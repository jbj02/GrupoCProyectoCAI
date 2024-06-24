using GrupoCProyectoCAI.Archivos;
using GrupoCProyectoCAI.Preparador.AltaOrdenPreparacion;
using GrupoCProyectoCAI.Preparador.AltaOrdenSeleccion;
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
    public partial class AltaOrdenPreparacionForm : Form
    {

        AltaOrdenPreparacionModelo modelo = new();

        public AltaOrdenPreparacionForm()
        {
            InitializeComponent();
        }

        private void CancelarBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AltaOrdenPreparacionForm_Load(object sender, EventArgs e)
        {
            CargarClientesCMB();
            ConfigurarFechaDeDespachoDTP();
        }

        public void ConfigurarFechaDeDespachoDTP()
        {
            FechaDeDespachoDtp.MinDate = DateTime.Now;
        }

        string dataSplitter = " ; ";
        //no usar "-" porque hay adentro del cuit

        public void CargarClientesCMB()
        {
            foreach (var cliente in modelo.Clientes)
            {
                string ClienteNombreCUIT = cliente.Nombre + dataSplitter + cliente.CUIT;
                ClienteCmb.Items.Add(ClienteNombreCUIT);
            }
        }

        public Cliente clienteActivo;
        public Producto productoActivo;
        public List<Producto> productosSeleccionados;

        private void ClienteCmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            ProductoCmb.Items.Clear();
            ProductoCmb.Text = "";
            CantidadNum.Minimum = 0;
            CantidadNum.Maximum = 0;
            productosSeleccionados = null;
            ActualizarListView();

            if (ClienteCmb.SelectedIndex != -1)
            {
                //se extrae el cuit del string de cliente ("Cliente1;20-11111111-5" ==> "20-11111111-5")
                string ClienteCompleto = ClienteCmb.SelectedItem.ToString();
                string[] ClienteSplit = ClienteCompleto.Split(new string[] { dataSplitter }, StringSplitOptions.None);
                string ClienteCUIT = ClienteSplit[1];

                clienteActivo = modelo.BuscarCliente(ClienteCUIT);
                if (clienteActivo != null && clienteActivo.ProductosAsociados.Count == 0)
                {
                    MessageBox.Show("El cliente no tiene productos almacenados actualmente", "Error");
                }
                else
                {
                    foreach (var producto in clienteActivo.ProductosAsociados)
                    {
                        ProductoCmb.Items.Add(producto.Nombre);
                    }
                }
            }
        }

        private void AgregarProductosBtn_Click(object sender, EventArgs e)
        {
            if (ProductoCmb.Text == "")
            {
                MessageBox.Show("Debe seleccionar un producto de la lista", "Error");
            }
            else if
            (
            productosSeleccionados != null &&
            productosSeleccionados.Find(p => p.CodigoDeProducto == productoActivo.CodigoDeProducto) != null
            )
            {
                MessageBox.Show("El producto ya se encuentra seleccionado", "Error");
            }
            else
            {
                //agregar producto
                if (productosSeleccionados == null)
                {
                    productosSeleccionados = new List<Producto>();
                }
                Producto producto = new Producto
                {
                    CodigoDeProducto = productoActivo.CodigoDeProducto,
                    Nombre = productoActivo.Nombre,
                    Cantidad = Convert.ToInt32(CantidadNum.Value)
                };
                productosSeleccionados.Add(producto);

                ActualizarListView();
            }
        }

        public void ActualizarListView()
        {
            ProductosList.Items.Clear();

            if (productosSeleccionados != null)
            {
                foreach (var producto in productosSeleccionados)
                {
                    var item = new ListViewItem(producto.CodigoDeProducto);
                    item.SubItems.Add(producto.Nombre);
                    item.SubItems.Add(producto.Cantidad.ToString());
                    ProductosList.Items.Add(item);
                }
            }
        }

        private void ProductoCmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ProductoCmb.SelectedIndex != -1)
            {
                int indexActivo = ProductoCmb.SelectedIndex;
                productoActivo = clienteActivo.ProductosAsociados[indexActivo];
                CantidadNum.Minimum = 1;
                CantidadNum.Maximum = productoActivo.Cantidad;
            }
            else
            {
                productoActivo = null;
            }
        }

        private void BorrarSeleccionadoBtn_Click(object sender, EventArgs e)
        {
            if (productosSeleccionados != null && ProductosList.SelectedItems.Count > 0)
            {
                string codigoDeProductoSeleccionado = ProductosList.SelectedItems[0].Text;
                Producto productoAEliminar = productosSeleccionados.Find(p => p.CodigoDeProducto == codigoDeProductoSeleccionado);
                productosSeleccionados.Remove(productoAEliminar);

                ActualizarListView();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un producto de la lista", "Error");
            }
        }

        private void ConfirmarBtn_Click(object sender, EventArgs e)
        {
            //hay que validar que el CUIT tenga un formato válido
            if (modelo.ValidarCUIT(TransportistaTxt.Text) == false)
            {
                MessageBox.Show("El CUIT no es válido. Debe ser de la siguiente manera: NN-NNNNNNNN-NN", "Error");
            }
            //hay que verificar que todos los campos estén completos
            else if
            (
                ClienteCmb.SelectedIndex == -1 ||
                TransportistaTxt.Text.Length == 0 ||
                productosSeleccionados.Count < 1
            )
            {
                MessageBox.Show("Debe completar todos los campos y agregar productos a la lista", "Error");
            }
            //si está todo bien...
            else
            {
                DialogResult respuesta = MessageBox.Show("¿Estás seguro que desea dar de alta la órden de preparación?", "Confirmar creación", MessageBoxButtons.YesNo);
                if (respuesta == DialogResult.Yes)
                {
                    OrdenDePreparacion NuevaOrden = new OrdenDePreparacion();
                    NuevaOrden.NumeroDeOrden = modelo.BuscarUltimaOrenPreparacion() + 1;
                    NuevaOrden.Cliente = clienteActivo.CUIT;
                    NuevaOrden.Transportista = TransportistaTxt.Text;
                    //NuevaOrden.Estado = "Pendiente";
                    NuevaOrden.FechaDeDespacho = FechaDeDespachoDtp.Value;
                    //NuevaOrden.FechaDeAlta = DateTime.Now;
                    NuevaOrden.Productos = productosSeleccionados;

                    modelo.AgregarOrdenPreparacion(NuevaOrden);

                    //se modifican los stocks
                    modelo.ModificarStocks(NuevaOrden.Productos, NuevaOrden.Cliente, NuevaOrden.NumeroDeOrden);

                    MessageBox.Show("Se creó la orden número " + NuevaOrden.NumeroDeOrden);
                    this.Close();
                }
            }
        }
    }
}
