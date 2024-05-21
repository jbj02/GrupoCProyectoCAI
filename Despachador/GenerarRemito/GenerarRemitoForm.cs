using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GrupoCProyectoCAI.Despachador.GenerarRemito
{
    public partial class GenerarRemitoForm : Form
    {
        GenerarRemitoModelo generarRemitoModelo = new();
        public GenerarRemitoForm()
        {
            InitializeComponent();
        }

        private void GenerarRemitoForm_Load(object sender, EventArgs e)
        {
            CargarListaOrdenesInternas();
        }

        private void CargarListaOrdenesInternas()
        {
            OrdenInt_List.Items.Clear();

            foreach (var ordenInterna in generarRemitoModelo.OrdenesInternas)
            {
                var fila = new ListViewItem();
                // le cargamos los datos a la fila
                fila.Text = ordenInterna.NumOrdenExt.ToString();
                fila.SubItems.Add(ordenInterna.NumOrdenInt.ToString());
                fila.SubItems.Add(ordenInterna.TipoProducto);
                fila.SubItems.Add(ordenInterna.Cantidad.ToString());
                fila.SubItems.Add(ordenInterna.Deposito);
                fila.SubItems.Add(ordenInterna.FechaCreacion.ToString("dd/MM/yyyy"));
                fila.Tag = ordenInterna; // Permite identificar cuál objeto se está utilizando
                // agregamops fila a la lista
                OrdenInt_List.Items.Add(fila);
            }
        }

        private void BuscarBtn_Click(object sender, EventArgs e)
        {

            // Busca si se encuentran coincidencias con el número de orden interna ingresada, genera un mensaje si no encuentra coincidencias
            bool seEncontraronCoincidencias = false; // creamos una flag que verifique que se encuentre coincidencias

            foreach (var ordenInterna in generarRemitoModelo.OrdenesInternas)
            {
                if (NumeroOrdenInternaBuscarText.Text == ordenInterna.NumOrdenInt.ToString())
                {
                    NumOrdenIntText.Text = ordenInterna.NumOrdenInt.ToString();
                    NumOrdExtText.Text = ordenInterna.NumOrdenExt.ToString();
                    TipoDeProductoText.Text = ordenInterna.TipoProducto;
                    CantidadText.Text = ordenInterna.Cantidad.ToString();
                    FechaDT.Text = ordenInterna.FechaCreacion.ToString("dd/MM/yyyy");
                    Deposito.Text = ordenInterna.Deposito.ToString();
                    DatosOrdenGroup.Enabled = true;
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

        private void BorrarBtn_Click(object sender, EventArgs e)
        {
            NumOrdenIntText.Text = string.Empty;
            NumOrdExtText.Text = string.Empty;
            TipoDeProductoText.Text = string.Empty;
            CantidadText.Text = string.Empty;
            FechaDT.Text = string.Empty;
            Deposito.Text = string.Empty;
        }

        private void CancelarBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SeleccionarBtn_Click_1(object sender, EventArgs e)
        {
            // Mensaje en caso de que no seleccione ninguna fila a editar
            if (OrdenInt_List.SelectedItems.Count == 0)
            {
                MessageBox.Show("Seleccione un item de la lista primero.");
                return;
            }

            // Creamos variable que apunte a la orden interna de la fila seleccionada
            var ordenSeleccionada = (OrdenInt)OrdenInt_List.SelectedItems[0].Tag;

            // Cargamos los datos ingresados
            NumOrdenIntText.Text = ordenSeleccionada.NumOrdenInt.ToString();
            NumOrdExtText.Text = ordenSeleccionada.NumOrdenExt.ToString();
            TipoDeProductoText.Text = ordenSeleccionada.TipoProducto;
            CantidadText.Text = ordenSeleccionada.Cantidad.ToString();
            FechaDT.Text = ordenSeleccionada.FechaCreacion.ToString("dd/MM/yyyy");
            Deposito.Text = ordenSeleccionada.Deposito.ToString();


            DatosOrdenGroup.Enabled = true;
        }

        private void GenerarRemitoBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("¿Esta seguro que quiere generar un remito?", "Confirmación", MessageBoxButtons.YesNo);
        }
    }
}
