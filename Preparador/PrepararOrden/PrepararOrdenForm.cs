using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GrupoCProyectoCAI.Preparador.PrepararOrden
{
    public partial class PrepararOrdenForm : Form
    {
        // Creamos el modelos del forms
        PrepararOrdenModelo prepararOrdenModelo = new();

        public PrepararOrdenForm()
        {
            InitializeComponent();
        }

        private void PrepararOrdenForm_Load(object sender, EventArgs e)
        {
            CargarListaOrdenesPreparacion();
        }

        private void CargarListaOrdenesPreparacion()
        {
            OrdenesPreparacion_List.Items.Clear();

            foreach (var ordenPrepara in prepararOrdenModelo.OrdenesPreparacion)
            {
                var fila = new ListViewItem();
                // le cargamos los datos a la fila
                fila.Text = ordenPrepara.NumOrden.ToString();
                fila.SubItems.Add(ordenPrepara.ClienteCUIT);
                fila.SubItems.Add(ordenPrepara.FechaAlta.ToString("dd/MM/yyyy"));
                fila.SubItems.Add(ordenPrepara.FechaDespacho.ToString("dd/MM/yyyy"));
                fila.Tag = ordenPrepara; // Permite identificar cuál objeto se está utilizando
                // agregamops fila a la lista
                OrdenesPreparacion_List.Items.Add(fila);
            }
        }

        private void SeleccionarBtn_Click(object sender, EventArgs e)
        {
            // Mensaje en caso de que no seleccione ninguna fila
            if (OrdenesPreparacion_List.SelectedItems.Count == 0)
            {
                MessageBox.Show("Seleccione un item de la lista primero.");
                return;
            }

            // Creamos variable que apunte a la orden interna de la fila seleccionada
            var ordenSeleccionada = (OrdenPrepara)OrdenesPreparacion_List.SelectedItems[0].Tag;

            // Avisamos al modelo cuál fue la orden seleccionada por el usuario
            prepararOrdenModelo.OrdenSeleccionada = ordenSeleccionada;

            CargarProductosDeOrdenSeleccionada();
        }

        private void CargarProductosDeOrdenSeleccionada()
        {
            //Borra la lista anterior seleccionada
            ProductoList.Items.Clear();

            var productos = prepararOrdenModelo.ObtenerProductosDeOrdenSeleccionada();
            if (productos != null)
            {
                foreach (var producto in productos)
                {
                    ListViewItem item = new ListViewItem(producto.NombreProducto);
                    item.SubItems.Add(producto.Cantidad.ToString());
                    ProductoList.Items.Add(item);
                }
            }
        }

        private void CancelarBtn_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void ConfirmarDatosOrdenBtn_Click(object sender, EventArgs e)
        {
            if (ProductoList.Items.Count == 0)
            {
                MessageBox.Show("Primero debe seleccionar una orden de preparacion");
            
            }
            else
            {
                // Creamos variable que apunte a la orden de la fila seleccionada
                var ordenSeleccionada = (OrdenPrepara)OrdenesPreparacion_List.SelectedItems[0].Tag;

                DialogResult respuesta = MessageBox.Show($"¿Estás seguro que deseas confirmar el cambio del estado {ordenSeleccionada.NumOrden} a Preparada?", "Pampazon S.A", MessageBoxButtons.YesNo);

                if (respuesta == DialogResult.Yes)
                {
                    prepararOrdenModelo.Confirmar();

                    MessageBox.Show($"Se modificó el estado de la orden {ordenSeleccionada.NumOrden} a Preparada", "Pampazon S.A");

                    this.Close();

                }
            }            
        }
    }
}
