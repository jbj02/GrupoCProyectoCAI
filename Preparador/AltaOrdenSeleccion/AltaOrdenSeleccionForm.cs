using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GrupoCProyectoCAI.Preparador.AltaOrdenSeleccion
{
    public partial class AltaOrdenSeleccionForm : Form
    {
        AltaOrdenSeleccionModelo modelo = new();
        public AltaOrdenSeleccionForm()
        {
            InitializeComponent();
        }

        private void AltaOrdenSeleccionForm_Load(object sender, EventArgs e)
        {
            CargarListaOrdenesPrepracion();
        }

        private void CargarListaOrdenesPrepracion()
        {
            OrdenPreparacionList.Items.Clear();

            foreach (var ordenPreparacion in modelo.OrdenesPreparacion)
            {
                var fila = new ListViewItem();
                // le cargamos los datos a la fila
                fila.Text = ordenPreparacion.NumOrdenP.ToString();
                fila.SubItems.Add(ordenPreparacion.ClienteCUIT);
                fila.SubItems.Add(ordenPreparacion.FechaDespacho.ToString("dd/MM/yyyy"));

                // agregamops fila a la lista
                OrdenPreparacionList.Items.Add(fila);
            }
        }

        private void SeleccionarBtn_Click(object sender, EventArgs e)
        {
            var cantidadOrdenesPreparacion = OrdenPreparacionList.SelectedItems.Count;

            // Mensaje en caso de que no seleccione ninguna fila
            if (OrdenPreparacionList.SelectedItems.Count == 0)
            {
                MessageBox.Show("Seleccione un item de la lista primero.");
                return;
            }

            var ordenesSeleccionadas = OrdenPreparacionList.SelectedItems
            .Cast<ListViewItem>()
            .Select(item => new OrdenPreparacion
            {
                NumOrdenP = int.Parse(item.SubItems[0].Text),
                ClienteCUIT = item.SubItems[1].Text,
                FechaDespacho = DateTime.Parse(item.SubItems[2].Text)
            }).ToList();

            modelo.CrearOrdenSeleccion(ordenesSeleccionadas);

            foreach (ListViewItem item in OrdenPreparacionList.SelectedItems)
            {
                OrdenPreparacionList.Items.Remove(item);
            }

            CargarListaOrdenesSeleccion();
        }

        private void CargarListaOrdenesSeleccion()
        {
            OrdenSeleccionList.Items.Clear();
            foreach (var ordenSeleccion in modelo.ObtenerOrdenesSeleccion())
            {
                var fila = new ListViewItem
                {
                    Text = ordenSeleccion.NumOrden.ToString()
                };
                fila.SubItems.Add(ordenSeleccion.OrdenesPreparacionAsociadas.Count.ToString());
                OrdenSeleccionList.Items.Add(fila);
            }
        }

        private void CancelarBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }        

        private void DeseleccionarBtn_Click(Object sender, EventArgs e)
        {
            // Mensaje en caso de que no seleccione ninguna fila
            if (OrdenSeleccionList.SelectedItems.Count == 0)
            {
                MessageBox.Show("Seleccione un item de la lista primero.");
                return;
            }

            // Obtenemos el item seleccionado en OrdenSeleccionList
            ListViewItem itemSeleccionado = OrdenSeleccionList.SelectedItems[0];

            // Recuperar el NumeroOrdenSeleccion del item seleccionado
            int numeroOrdenSeleccionado = int.Parse(itemSeleccionado.Text);

            // Buscar la orden de selección correspondiente
            OrdenSeleccion ordenSeleccion = modelo.ObtenerOrdenesSeleccion().FirstOrDefault(o => o.NumOrden == numeroOrdenSeleccionado);

            if (ordenSeleccion != null)
            {
                // Agregar las órdenes de preparación asociadas de vuelta a OrdenPreparacionList
                foreach (var ordenPreparacion in ordenSeleccion.OrdenesPreparacionAsociadas)
                {
                    // Crear un nuevo ListViewItem para OrdenPreparacionList
                    ListViewItem nuevoItem = new ListViewItem(ordenPreparacion.NumOrdenP.ToString());
                    nuevoItem.SubItems.Add(ordenPreparacion.ClienteCUIT);
                    nuevoItem.SubItems.Add(ordenPreparacion.FechaDespacho.ToString("d")); // Formato de fecha corto

                    // Agregar el nuevo item a OrdenPreparacionList
                    OrdenPreparacionList.Items.Add(nuevoItem);
                }

                modelo.EliminarOrdenSeleccion(ordenSeleccion);

                CargarListaOrdenesSeleccion();
            }
            else
            {
                MessageBox.Show("No se encontró la orden de preparación correspondiente.");
            }
        }

        private void ConfirmarBtn_Click(Object sender, EventArgs e)
        {
            if (OrdenSeleccionList.Items.Count == 0)
            {
                MessageBox.Show("Debe haber por lo menos una orden selección para crearla.");
            }
            else
            {
                DialogResult respuesta = MessageBox.Show("¿Estás seguro que desea dar de alta la/s orden/es de selección?", "Pampazon S.A", MessageBoxButtons.YesNo);

                if (respuesta == DialogResult.Yes)
                {
                    foreach (OrdenSeleccion ordenSeleccion in modelo.ObtenerOrdenesSeleccion())
                    {
                        // Agregar la nueva orden de selección al modelo
                        modelo.AgregarOrdenesSeleccion(ordenSeleccion);
                    }

                    MessageBox.Show($"Se crearon las órdenes de selección", "Pampazon S.A");
                    this.Close();
                }
            }
        }
    }
}
