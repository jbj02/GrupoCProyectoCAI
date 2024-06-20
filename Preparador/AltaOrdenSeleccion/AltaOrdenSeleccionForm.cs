using GrupoCProyectoCAI.Archivos;
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
            // Asegúrate de que la lista esté inicializada
            if (modelo.OrdenesPreparacion == null)
            {
                modelo.OrdenesPreparacion = new List<OrdenPreparacion>();
            }

            OrdenPreparacionList.Items.Clear();

            foreach (var ordenPreparacion in modelo.OrdenesPreparacion)
            {
                var fila = new ListViewItem();
                // le cargamos los datos a la fila
                fila.Text = ordenPreparacion.NroOrden.ToString();
                fila.SubItems.Add(ordenPreparacion.ClienteCUIT);
                fila.SubItems.Add(ordenPreparacion.FechaDespacho.ToString("dd/MM/yyyy"));

                // agregamops fila a la lista
                OrdenPreparacionList.Items.Add(fila);
            }
        }

        // Lista que contendrá las órdenes de selección
        List<OrdenSeleccion> ordenesSeleccion = new List<OrdenSeleccion>();

        private void SeleccionarBtn_Click(object sender, EventArgs e)
        {
            List<string> Prioridades = new();
            var cantidadOrdenesPreparacion = OrdenPreparacionList.SelectedItems.Count;

            // Mensaje en caso de que no seleccione ninguna fila
            if (OrdenPreparacionList.SelectedItems.Count == 0)
            {
                MessageBox.Show("Seleccione un item de la lista primero.");
                return;
            }


            // Crear una nueva orden de selección
            OrdenSeleccion nuevaOrdenSeleccion = new OrdenSeleccion();
            nuevaOrdenSeleccion.DevolverNumeroOrdenSeleccion(modelo.GenerarNumeroOrdenSeleccion());

            foreach (ListViewItem orden in OrdenPreparacionList.SelectedItems)
            {
                // Crear un objeto OrdenPreparacion
                OrdenPreparacion ordenPreparacion = new OrdenPreparacion
                {
                    NroOrden = int.Parse(orden.SubItems[0].Text),
                    ClienteCUIT = orden.SubItems[1].Text,
                    FechaDespacho = DateTime.Parse(orden.SubItems[2].Text)
                };

                // Añadir la orden de preparación a la lista de órdenes asociadas con la orden de selección
                nuevaOrdenSeleccion.OrdenPreparacionAsociadas.Add(ordenPreparacion);

                // Se eliminan de la lista OrdenesPreparacionList las que fueron seleccionadas
                OrdenPreparacionList.Items.Remove(orden);
            }

            // Agregar la nueva orden de selección a la lista de órdenes de selección
            ordenesSeleccion.Add(nuevaOrdenSeleccion);

            // Crear y agregar la fila a OrdenSeleccionList
            var fila = new ListViewItem();
            fila.Text = nuevaOrdenSeleccion.NroOrden.ToString();
            fila.SubItems.Add(cantidadOrdenesPreparacion.ToString());

            // Agregamos fila a la lista
            OrdenSeleccionList.Items.Add(fila);
        }
        private void CancelarBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ConfirmarBtn_Click(Object sender, EventArgs e)
        {
            if (OrdenSeleccionList.Items.Count == 0)
            {
                MessageBox.Show("Debe haber por lo menos una orden selección para crearla.");
            }else
            {
                MessageBox.Show("¿Estás seguro que desea dar de alta la/s orden/es de selección?", "Confirmación creación", MessageBoxButtons.YesNo);
            }            
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
            OrdenSeleccion ordenSeleccion = ordenesSeleccion.FirstOrDefault(o => o.NroOrden == numeroOrdenSeleccionado);

            if (ordenSeleccion != null)
            {
                // Agregar las órdenes de preparación asociadas de vuelta a OrdenPreparacionList
                foreach (var ordenPreparacion in ordenSeleccion.OrdenPreparacionAsociadas)
                {
                    // Crear un nuevo ListViewItem para OrdenPreparacionList
                    ListViewItem nuevoItem = new ListViewItem(ordenPreparacion.NroOrden.ToString());
                    nuevoItem.SubItems.Add(ordenPreparacion.ClienteCUIT);
                    nuevoItem.SubItems.Add(ordenPreparacion.FechaDespacho.ToString("d")); // Formato de fecha corto

                    // Agregar el nuevo item a OrdenPreparacionList
                    OrdenPreparacionList.Items.Add(nuevoItem);
                }

                // Remover la orden de selección de la lista de órdenes de selección
                ordenesSeleccion.Remove(ordenSeleccion);

                // Remover el item seleccionado de OrdenSeleccionList
                OrdenSeleccionList.Items.Remove(itemSeleccionado);
            }
            else
            {
                MessageBox.Show("No se encontró la orden de preparación correspondiente.");
            }
        }
    }
}
