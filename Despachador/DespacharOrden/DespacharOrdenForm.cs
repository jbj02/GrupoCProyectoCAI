using GrupoCProyectoCAI.Almacenaje.SelecciondeProductos;
using GrupoCProyectoCAI.Archivos;
using GrupoCProyectoCAI.Preparador.AltaOrdenSeleccion;
using GrupoCProyectoCAI.Preparador.PrepararOrden;
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

namespace GrupoCProyectoCAI.Despachador.DespacharOrden
{
    public partial class DespacharOrdenForm : Form
    {

        DespacharOrdenModelo despacharOrdenModelo = new();

        public DespacharOrdenForm()
        {
            InitializeComponent();
        }

        private void DespacharOrdenForm_Load(object sender, EventArgs e)
        {
            CargarComboBoxTranportista();
            CargarComboBoxFechaDespacho();
            CargarListaOrdenesPreparadas();
        }

        private void CargarListaOrdenesPreparadas()
        {
            OrdenesPreparadasList.Items.Clear();

            foreach (var ordenpreparada in despacharOrdenModelo.OrdenesPreparadas)
            {
                // Verifica si la orden no está en la lista de despachadas
                bool noEstaEnDespachadas = !OrdenesDespachadasList.Items.Cast<ListViewItem>()
                    .Any(item => ((OrdenPreparacion)item.Tag).NroOrden == ordenpreparada.NroOrden);

                if (noEstaEnDespachadas)
                {
                    
                    var fila = new ListViewItem();
                    // Cargamos los datos a la fila
                    fila.Text = ordenpreparada.NroOrden.ToString();
                    fila.SubItems.Add(ordenpreparada.ClienteCUIT);
                    fila.SubItems.Add(ordenpreparada.TransportistaCUIT);
                    fila.SubItems.Add(ordenpreparada.FechaDespacho.ToString("dd/MM/yyyy"));
                    fila.Tag = ordenpreparada; // Permite identificar cuál objeto se está utilizando
                                                // Agregamos la fila a la lista
                    OrdenesPreparadasList.Items.Add(fila);
                 
                }
            }
        }

        private void CargarComboBoxTranportista()
        {
            HashSet<string> transportistasUnicos = new HashSet<string>();
            TransportistaCB.Items.Clear();
            TransportistaCB.Items.Add("");
            foreach (var orden in despacharOrdenModelo.OrdenesPreparadas)
            {
                if (transportistasUnicos.Add(orden.TransportistaCUIT))
                {
                    TransportistaCB.Items.Add(orden.TransportistaCUIT);
                }
            }
        }

        private void CargarComboBoxFechaDespacho()
        {
            HashSet<string> fechasDespachoUnicos = new HashSet<string>();
            FechaDespachoCB.Items.Clear();
            FechaDespachoCB.Items.Add("");
            foreach (var orden in despacharOrdenModelo.OrdenesPreparadas)
            {
                if (fechasDespachoUnicos.Add(orden.FechaDespacho.ToString("dd/MM/yyyy")))
                {
                    FechaDespachoCB.Items.Add(orden.FechaDespacho.ToString("dd/MM/yyyy"));
                }                
            }
        }

        private void FiltrarBtn_Click(object sender, EventArgs e)
        {
            string transportistaFiltro = TransportistaCB.Text.Trim();
            DateTime fechaDespachoFiltro = DateTime.Parse(FechaDespachoCB.Text);
            bool fechaDespachoValida = false;

            // Verificar si ambos campos están vacíos
            if (string.IsNullOrEmpty(transportistaFiltro) && string.IsNullOrWhiteSpace(FechaDespachoCB.Text))
            {
                MessageBox.Show("Debe seleccionar al menos un filtro en Transportista o Fecha de Despacho.");
                return;
            }

            // Filtra las órdenes según los valores ingresados
            var ordenesFiltradas = despacharOrdenModelo.OrdenesPreparadas.Where(o => (string.IsNullOrWhiteSpace(transportistaFiltro) || o.TransportistaCUIT.Contains(transportistaFiltro)) &&
                            (string.IsNullOrWhiteSpace(FechaDespachoCB.Text) || o.FechaDespacho.Date == fechaDespachoFiltro.Date)).ToList();

            // Actualiza la ListView con las órdenes filtradas
            OrdenesPreparadasList.Items.Clear();

            foreach (var orden in ordenesFiltradas)
            {
                // Verifica si la orden ya está en la lista de despachadas
                bool existeEnDespachadas = OrdenesDespachadasList.Items.Cast<ListViewItem>()
                    .Any(item => ((OrdenPreparacion)item.Tag).NroOrden == orden.NroOrden);

                if (!existeEnDespachadas)
                {
                    var item = new ListViewItem(new[]
                    {
                orden.NroOrden.ToString(),
                orden.ClienteCUIT,
                orden.TransportistaCUIT,
                orden.FechaDespacho.ToString("dd/MM/yyyy"),
            });

                    item.Tag = orden; // Asignar el objeto OrdenPreparacion al Tag
                    OrdenesPreparadasList.Items.Add(item);
                }
            }

            if (OrdenesPreparadasList.Items.Count == 0)
            {
                MessageBox.Show("No se encontró ninguna órden.");
            }
        }

        private void CancelarBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ConfirmarYRemitoBtn_Click(object sender, EventArgs e)
        {
            if (OrdenesDespachadasList.Items.Count == 0)
            {
                MessageBox.Show("Debe haber por lo menos una órden despachada para confirmarla y generar su remito.");
                return;
            }
            else
            {                
                DialogResult respuesta = MessageBox.Show("¿Estás seguro que deseas confirmar la/S ordenes y generar el/los remito/s?", "Confirmación de orden", MessageBoxButtons.YesNo);

                if (respuesta == DialogResult.Yes)
                {
                    foreach (ListViewItem ordenDespacharItem in OrdenesDespachadasList.Items)
                    {
                        // Obtener la orden preparada
                        var ordenPreparada = (OrdenPreparacion)ordenDespacharItem.Tag;                        

                        despacharOrdenModelo.CambiarEstadoOrdenPreparacionYGenerarRemito(ordenPreparada);
                    }

                    MessageBox.Show("Se modificó el estado de las órdenes a Despachadas y se generaron los remitos.");
                    this.Close();
                }
            }
        }

        private void SeleccionarBtn_Click(object sender, EventArgs e)
        {
            // Mensaje en caso de que no seleccione ninguna fila a editar
            if (OrdenesPreparadasList.SelectedItems.Count == 0)
            {
                MessageBox.Show("Seleccione un item de la lista primero.");
                return;
            }

            // Creamos variable que apunte a la orden de la fila seleccionada
            var ordenSeleccionada = (OrdenPreparacion)OrdenesPreparadasList.SelectedItems[0].Tag;

            OrdenPreparacion orden = new OrdenPreparacion
            {
                NroOrden = ordenSeleccionada.NroOrden,
                ClienteCUIT = ordenSeleccionada.ClienteCUIT,
                TransportistaCUIT = ordenSeleccionada.TransportistaCUIT,
                Estado = "Despachada",
                FechaDespacho = ordenSeleccionada.FechaDespacho
            };

            ListViewItem ordenLV = OrdenesPreparadasList.SelectedItems[0];
            OrdenesPreparadasList.Items.Remove(ordenLV);

            // Asignar el objeto OrdenPreparacion actualizado al Tag
            ordenLV.Tag = orden;

            // agregamops fila a la lista
            OrdenesDespachadasList.Items.Add(ordenLV);
        }

        private void SeleccionarTodasBtn_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem orden in OrdenesPreparadasList.Items)
            {
                // Crear un objeto OrdenPreparada
                OrdenPreparacion ordenPreparada = new OrdenPreparacion
                {
                    NroOrden = int.Parse(orden.SubItems[0].Text),
                    ClienteCUIT = orden.SubItems[1].Text,
                    TransportistaCUIT = orden.SubItems[2].Text,
                    Estado = "Despachada",
                    FechaDespacho = DateTime.Parse(orden.SubItems[3].Text)
                };

                // Asignar el objeto OrdenPreparacion actualizado al Tag
                orden.Tag = ordenPreparada;

                // Se eliminan de la lista OrdenesPreparacionList
                OrdenesPreparadasList.Items.Remove(orden);

                // Se agrega a la lista OrdenesDespachadasList
                OrdenesDespachadasList.Items.Add(orden);
            }
        }

        private void DesseleccionarBtn_Click(Object sender, EventArgs e)
        {
            // Mensaje en caso de que no seleccione ninguna fila
            if (OrdenesDespachadasList.SelectedItems.Count == 0)
            {
                MessageBox.Show("Seleccione un item de la lista primero.");
                return;
            }

            // Creamos variable que apunte a la orden de la fila seleccionada
            var ordenSeleccionada = (OrdenPreparacion)OrdenesDespachadasList.SelectedItems[0].Tag;

            OrdenPreparacion orden = new OrdenPreparacion
            {
                NroOrden = ordenSeleccionada.NroOrden,
                ClienteCUIT = ordenSeleccionada.ClienteCUIT,
                TransportistaCUIT = ordenSeleccionada.TransportistaCUIT,
                Estado = "Preparada",
                FechaDespacho = ordenSeleccionada.FechaDespacho
            };

            ListViewItem ordenLV = OrdenesDespachadasList.SelectedItems[0];
            OrdenesDespachadasList.Items.Remove(ordenLV);

            // Asignar el objeto OrdenPreparacion actualizado al Tag
            ordenLV.Tag = orden;

            // agregamops fila a la lista
            OrdenesPreparadasList.Items.Add(ordenLV);
        }

        private void ReestablecerBtn_Click(object sender, EventArgs e)
        {
            CargarListaOrdenesPreparadas();

            TransportistaCB.SelectedIndex = -1;
            FechaDespachoCB.SelectedIndex = -1;
        }       
    }
}
