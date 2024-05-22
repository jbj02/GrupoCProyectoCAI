using GrupoCProyectoCAI.Preparador.Modificar;
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

namespace GrupoCProyectoCAI.Preparador.NuevaOrden
{
    public partial class NuevaOrdenPreparadorForm : Form
    {
        // Creamos el modelos del forms
        NuevaOrdenPreparadorModelo nuevaOrdenModelo = new();
        public NuevaOrdenPreparadorForm()
        {
            InitializeComponent();
        }

        private void VolverBoton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NuevaOrdenPreparadorForm_Load(object sender, EventArgs e)
        {
            CargarListaOrdenesExternas();
        }

        private void CargarListaOrdenesExternas()
        {
            OrdenExt_List.Items.Clear();

            foreach (var ordenExterna in nuevaOrdenModelo.OrdenesExternas)
            {
                var fila = new ListViewItem();
                // le cargamos los datos a la fila
                fila.Text = ordenExterna.NumOrdenExt.ToString();
                fila.SubItems.Add(ordenExterna.TipoProducto.ToString()); // Siguiente columna...
                fila.SubItems.Add(ordenExterna.Cantidad.ToString());
                fila.SubItems.Add(ordenExterna.Cliente);
                fila.SubItems.Add(ordenExterna.Prioridad);
                fila.SubItems.Add(ordenExterna.FechaCreacion.ToString("dd/MM/yyyy"));
                fila.Tag = ordenExterna; // Permite identificar cuál objeto se está utilizando
                // agregamops fila a la lista
                OrdenExt_List.Items.Add(fila);
            }
        }

        private void SeleccionarBtn_Click(object sender, EventArgs e)
        {
            // Mensaje en caso de que no seleccione ninguna fila a editar
            if (OrdenExt_List.SelectedItems.Count == 0)
            {
                MessageBox.Show("Seleccione un item de la lista primero.");
                return;
            }

            // Creamos variable que apunte a la orden interna de la fila seleccionada
            var ordenSeleccionada = (OrdenExt)OrdenExt_List.SelectedItems[0].Tag;

            // Cargamos los datos ingresados
            NumOrdenIntText.Text = NuevaOrdenPreparadorModelo.GenerarNumeroOrdenInt().ToString();
            NumOrdExtText.Text = ordenSeleccionada.NumOrdenExt.ToString();
            TipoDeProductoText.Text = ordenSeleccionada.TipoProducto;
            CantidadText.Text = ordenSeleccionada.Cantidad.ToString();
            ClienteText.Text = ordenSeleccionada.Cliente;
            PrioridadText.Text = ordenSeleccionada.Prioridad;
            FechaCreacionDT.Text = ordenSeleccionada.FechaCreacion.ToString("dd/MM/yyyy");

            DatosNuevaOrdenInternaGroup.Enabled = true;
        }

        private void BuscarBtn_Click(object sender, EventArgs e)
        {
            // Busca si se encuentran coincidencias con el número de orden externa ingresada, genera un mensaje si no encuentra coincidencias
            bool seEncontraronCoincidencias = false; // creamos una flag que verifique que se encuentre coincidencias

            foreach (var ordenExterna in nuevaOrdenModelo.OrdenesExternas)
            {
                if (NumeroOrdenExternaBuscarText.Text == ordenExterna.NumOrdenExt.ToString())
                {
                    NumOrdenIntText.Text = NuevaOrdenPreparadorModelo.GenerarNumeroOrdenInt().ToString();
                    NumOrdExtText.Text = ordenExterna.NumOrdenExt.ToString();
                    TipoDeProductoText.Text = ordenExterna.TipoProducto;
                    CantidadText.Text = ordenExterna.Cantidad.ToString();
                    ClienteText.Text = ordenExterna.Cliente;
                    PrioridadText.Text = ordenExterna.Prioridad;
                    FechaCreacionDT.Text = ordenExterna.FechaCreacion.ToString("dd/MM/yyyy");

                    DatosNuevaOrdenInternaGroup.Enabled = true;
                    seEncontraronCoincidencias = true;
                    break;
                }
            }

            if (!seEncontraronCoincidencias)
            {
                MessageBox.Show("No se encontró ninguna coincidencia");
                return;
            }
        }

        private void AceptarDatosNuevaOrdenInternaBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("¿Estás seguro que deseas crear una neuva orden interna?", "Confirmación de creación", MessageBoxButtons.YesNo);
        }

        private void CancelarDatosNuevaOrdenInternaBtn_Click(object sender, EventArgs e)
        {
            NumOrdenIntText.Text = string.Empty;
            NumOrdExtText.Text = string.Empty;
            TipoDeProductoText.Text = string.Empty;
            CantidadText.Text = string.Empty;
            ClienteText.Text = string.Empty;
            PrioridadText.Text = string.Empty;
            FechaCreacionDT.Text = string.Empty;

            DatosNuevaOrdenInternaGroup.Enabled = false;
        }
    }
}
