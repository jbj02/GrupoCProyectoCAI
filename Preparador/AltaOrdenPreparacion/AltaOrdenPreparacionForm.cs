using GrupoCProyectoCAI.Archivos;
using GrupoCProyectoCAI.Preparador.AltaOrdenPreparacion;
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
            //fija fecha mínima para el día de hoy
            FechaDeDespachoDtp.MinDate = DateTime.Now;
        }

        string dataSplitter = " ; ";
        //no usar "-" porque hay adentro del cuit

        public void CargarClientesCMB()
        {
            foreach (var cliente in modelo.clientes)
            {
                //se cargan los clientes de la siguiente manera: "Juan Perez ; 20-11111111-5"
                string ClienteNombreCUIT = cliente.Nombre + dataSplitter + cliente.CUIT;
                ClienteCmb.Items.Add(ClienteNombreCUIT);
            }
        }

        //cliente seleccionado en ClienteCmb
        public Cliente clienteActivo;
        //producto seleccionado en ProductosCmb
        public Stock productoActivo;
        //productos que corresponden a clienteActivo
        public List<Stock> productosDelCliente = new List<Stock>();
        //productos que aparecen en el listView
        public List<Stock> productosSeleccionados = new List<Stock>();

        //cuando cambia el cliente seleccionado...
        private void ClienteCmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            //hay que limpiar todo lo de abajo por si habia datos cargados
            ProductoCmb.Items.Clear();
            ProductoCmb.Text = "";
            CantidadNum.Minimum = 0;
            CantidadNum.Maximum = 0;
            productosSeleccionados = new List<Stock>();
            //hay que actualizar el listView, que va a quedar vacío
            ActualizarListView();

            if (ClienteCmb.SelectedIndex != -1)
            {
                //hay que extraer el cuit del string de cliente ("Juan Perez ; 20-11111111-5" ==> "20-11111111-5")
                string ClienteCompleto = ClienteCmb.SelectedItem.ToString();
                string[] ClienteSplit = ClienteCompleto.Split(dataSplitter);
                string ClienteCUIT = ClienteSplit[1];

                //hay que volver a setear clienteActivo
                clienteActivo = modelo.BuscarCliente(ClienteCUIT);
                productosDelCliente = modelo.BuscarProductosDelCliente(ClienteCUIT);

                //si el cliente seleccionado no tiene productos en el archivo Stock...
                if (clienteActivo != null && productosDelCliente.Count == 0)
                {
                    //hay que avisar que no tiene productos almacenados
                    MessageBox.Show("El cliente no tiene productos almacenados actualmente", "Error");
                }
                else
                {
                    //sino, hay que agregarlos al combobox ProductoCmb
                    foreach (var producto in productosDelCliente)
                    {
                        ProductoCmb.Items.Add(producto.Producto);
                    }
                }
            }
        }

        //cuando se hace click en agregar producto...
        private void AgregarProductosBtn_Click(object sender, EventArgs e)
        {
            //hay que verificar que se haya seleccionado uno primero
            if (ProductoCmb.Text == "")
            {
                MessageBox.Show("Debe seleccionar un producto de la lista", "Error");
            }
            //hay que verificar que el producto no se encuentre ya presente en el listView
            else if
            (
            productosSeleccionados.Count != 0 &&
            productosSeleccionados.Find(p => p.ProductoCliente == productoActivo.ProductoCliente) != null
            )
            {
                MessageBox.Show("El producto ya se encuentra seleccionado", "Error");
            }
            //si pasa las verificaciones, se agrega el producto activo a la lista de productos seleccionados y se actualiza el listView
            else
            {
                //primero se le modifica la cantidad al producto activo
                //cantidad original: la que proviene del stock
                //cantidad nueva: la seleccionada por el usuario en CantidadNum
                productoActivo.Cantidad = Convert.ToInt32(CantidadNum.Value);
                productosSeleccionados.Add(productoActivo);

                ActualizarListView();
            }
        }

        //esta función actualiza el listView iterando sobre productosSeleccionados
        public void ActualizarListView()
        {
            ProductosList.Items.Clear();

            if (productosSeleccionados.Count > 0)
            {
                foreach (var producto in productosSeleccionados)
                {
                    var item = new ListViewItem(producto.ProductoCliente);
                    item.SubItems.Add(producto.Producto);
                    item.SubItems.Add(producto.Cantidad.ToString());
                    ProductosList.Items.Add(item);
                }
            }
        }

        //cada vez que se cambia el combobox ProductoCmb...
        private void ProductoCmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ProductoCmb.SelectedIndex != -1)
            {
                int indexActivo = ProductoCmb.SelectedIndex;
                //hay que actualizar productoActivo
                productoActivo = productosDelCliente[indexActivo];
                //hay que setear las nuevas cantidades mínimas y máximas de CantidadNum
                CantidadNum.Minimum = 1;
                CantidadNum.Maximum = productoActivo.Cantidad;
            }
            else
            {
                productoActivo = null;
            }
        }

        //cada vez que se presiona borrar seleccionado...
        private void BorrarSeleccionadoBtn_Click(object sender, EventArgs e)
        {
            //se borra el producto del listView
            if (productosSeleccionados.Count != 0 && ProductosList.SelectedItems.Count > 0)
            {
                string codigoDeProductoSeleccionado = ProductosList.SelectedItems[0].Text;
                Stock productoAEliminar = productosSeleccionados.Find(p => p.ProductoCliente == codigoDeProductoSeleccionado);
                productosSeleccionados.Remove(productoAEliminar);

                ActualizarListView();
            }
            //hay que verificar que primero se haya seleccionado un producto del listView
            else
            {
                MessageBox.Show("Debe seleccionar un producto de la lista", "Error");
            }
        }

        //cuando se presiona el botón confirmar...
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
                //se abre un diálogo si/no
                DialogResult respuesta = MessageBox.Show("¿Estás seguro que desea dar de alta la órden de preparación?", "Confirmar creación", MessageBoxButtons.YesNo);
                if (respuesta == DialogResult.Yes)
                {
                    //se crea un nuevo objeto de órden de preparación
                    OrdenPreparacion NuevaOrden = new OrdenPreparacion();
                    NuevaOrden.NroOrden = modelo.BuscarUltimaOrenPreparacion() + 1;
                    NuevaOrden.ClienteCUIT = clienteActivo.CUIT;
                    NuevaOrden.TransportistaCUIT = TransportistaTxt.Text;
                    NuevaOrden.Estado = "Pendiente de selección";
                    NuevaOrden.FechaDespacho = FechaDeDespachoDtp.Value;
                    NuevaOrden.FechaAlta = DateTime.Now;
                    NuevaOrden.ProductosList = productosSeleccionados;
                    //se agrega el objeto a la lista
                    modelo.AgregarOrdenPreparacion(NuevaOrden);
                    //se modifican los stocks
                    modelo.ModificarStocks(NuevaOrden.ProductosList);
                    //ERROR A CORREGIR: tanto la órden de preparación como los stocks se escriben en los JSON con "Cantidad: 0"
                    //IMPORTANTE: debido al error, cada vez que se quiera probar el código y crear una nueva orden, se deberá entrar a stock.json y reestablecer las cantidades que quedaron en 0. En el caso de stockProvisorio.json y ordenPreparacion.json, se pueden borrar directamente los objetos y dejar una lista vacía.
                    MessageBox.Show("Se creó la orden");
                    this.Close();
                }
            }
        }
    }
}
