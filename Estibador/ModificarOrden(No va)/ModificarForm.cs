using GrupoCProyectoCAI.Preparador.NuevaOrden;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GrupoCProyectoCAI
{
    public partial class ModificarForm : Form
    {
        ModificarOrdenEstibadorModelo ModificarOrdenModelo = new();
        public ModificarForm()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            //hablar co bauti para eliminarlo

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            //Hablar con bauti para eliminarlo
        }

        private void label9_Click(object sender, EventArgs e)
        {
            //hablar con bauti
        }

        public void ModificarForm_Load(object sender, EventArgs e)
        {
            CargarListaOrdenesInternas();
        }
        public void CargarListaOrdenesInternas()
        {
            ordenesInternas_lst.Items.Clear();

            foreach (var ordenInterna in ModificarOrdenModelo.OrdenesInternas) //por cada orden interna en modelo (Lista del modelo)
            {
                var fila = new ListViewItem();
                // le cargamos los datos a la fila
                fila.Text = ordenInterna.NumOrdenExt.ToString();
                fila.SubItems.Add(ordenInterna.NumOrdenInt.ToString());
                fila.SubItems.Add(ordenInterna.TipoProducto);
                fila.SubItems.Add(ordenInterna.Cantidad.ToString());
                fila.SubItems.Add(ordenInterna.Cliente);
                fila.SubItems.Add(ordenInterna.Prioridad);
                fila.SubItems.Add(ordenInterna.Estado);
                fila.SubItems.Add(ordenInterna.FechaCreacion.ToString("dd/MM/yyyy"));
                fila.SubItems.Add(ordenInterna.FechaModificacion.ToString("dd/MM/yyyy"));
                fila.Tag = ordenInterna; // Permite identificar cuál objeto se está utilizando
                // agregamops fila a la lista
                ordenesInternas_lst.Items.Add(fila);
            }
        }

        private void FormCancelarbtn_Click(object sender, EventArgs e)
        {
            Close(); //this.Close
        }

        private void Buscarbtn_Click(object sender, EventArgs e)
        {
            bool validarOrden = false; //falta validar que la orden existe
            foreach (var ordenInterna in ModificarOrdenModelo.OrdenesInternas)
            {
                if (ordenInterna.NumOrdenInt == Convert.ToInt32(BuscarOrdentxt.Text))//falta validar que se haya ingresado una orden innerna numerica
                {
                    OrdenInternatxt.Text = ordenInterna.NumOrdenInt.ToString();
                    OrdenExternatxt.Text = ordenInterna.NumOrdenExt.ToString();
                    TipoDeProductotxt.Text = ordenInterna.TipoProducto;
                    Cantidadtxt.Text = ordenInterna.Cantidad.ToString();
                    Clientetxt.Text = ordenInterna.Cliente;
                    Prioridadtxt.Text = ordenInterna.Prioridad;
                    Estadocmb.SelectedItem = ordenInterna.Estado;
                    FechaDeModificartxt.Text = ordenInterna.FechaModificacion.ToString();
                    FechaDeCreaciontxt.Text = ordenInterna.FechaCreacion.ToString();
                }
            }
            if (!validarOrden)
            {
                MessageBox.Show("No se ha encontrado la orden ingresada");
            }
        }

        private void seleccionarbtn_Click(object sender, EventArgs e)
        {
            if (ordenesInternas_lst.SelectedItems.Count == 1)
            {
                var orden = (OrdenInt)ordenesInternas_lst.SelectedItems[0].Tag;
                OrdenInternatxt.Text = orden.NumOrdenInt.ToString();
                OrdenExternatxt.Text = orden.NumOrdenExt.ToString();
                TipoDeProductotxt.Text = orden.TipoProducto; 
                Cantidadtxt.Text = orden.Cantidad.ToString();
                Clientetxt.Text = orden.Cliente;
                Estadocmb.SelectedItem = orden.Estado;
                FechaDeCreaciontxt.Text =orden.FechaCreacion.ToString();
                FechaDeModificartxt.Text = orden.FechaModificacion.ToString();
                Prioridadtxt.Text = orden.Prioridad;
            }
            else
            {
                MessageBox.Show("No ha seleccionado ningun item de la lista");
            }
        }

        private void Aceptarbtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("¿Estás seguro que deseas modificar la orden?", "Confirmación modifiación", MessageBoxButtons.YesNo);
        }

        private void Cancelarbtn_Click(object sender, EventArgs e)
        {
            OrdenInternatxt.Clear();
            OrdenExternatxt.Clear();
            TipoDeProductotxt.Clear();
            Cantidadtxt.Clear();
            Prioridadtxt.Clear();
            Estadocmb.SelectedIndex = -1; //por ser cmb Estado.SelectedItem = "";
            FechaDeCreaciontxt.Clear();
            FechaDeModificartxt.Clear();
            Clientetxt.Clear();
        }
    }
}
