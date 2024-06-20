using GrupoCProyectoCAI.Archivos;
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
                fila.Text = ordenPrepara.NroOrden.ToString();
                //fila.SubItems.Add(ordenPrepara.NumOrden.ToString());
                //fila.SubItems.Add(ordenPrepara.TipoProducto);
                //fila.SubItems.Add(ordenPrepara.Cantidad.ToString());
                fila.SubItems.Add(ordenPrepara.Estado);
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
            var ordenSeleccionada = (OrdenPreparacion)OrdenesPreparacion_List.SelectedItems[0].Tag;


            //Borra la lista anterior seleccionada
            ProductoList.Items.Clear();

            foreach (var producto in ordenSeleccionada.ProductosList)
            {
                ListViewItem item = new ListViewItem(producto.Producto);
                item.SubItems.Add(producto.Cantidad.ToString());

                ProductoList.Items.Add(item);

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
             
            MessageBox.Show("¿Estás seguro que deseas confirmar?", "Confirmación", MessageBoxButtons.YesNo);
        }
    }
}
