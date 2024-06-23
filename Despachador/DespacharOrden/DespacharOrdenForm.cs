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
                    .Any(item => ((OrdenPreparacionD)item.Tag).NumOrden == ordenpreparada.NumOrden);

                if (noEstaEnDespachadas)
                {
                    var fila = new ListViewItem();
                    // Cargamos los datos a la fila
                    fila.Text = ordenpreparada.NumOrden.ToString();
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
            DateTime fechaDespachoFiltro = DateTime.MinValue;

            // Verificar si ambos campos están vacíos
            if (string.IsNullOrEmpty(transportistaFiltro) && string.IsNullOrWhiteSpace(FechaDespachoCB.Text))
            {
                MessageBox.Show("Debe ingresar al menos uno de los campos: Transportista o Fecha de Despacho.");
                return;
            }

            // Validar y convertir el campo de fecha
            if (!string.IsNullOrWhiteSpace(FechaDespachoCB.Text))
            {
                if (!DateTime.TryParse(FechaDespachoCB.Text, out fechaDespachoFiltro))
                {
                    MessageBox.Show("Fecha de despacho inválida.");
                    return;
                }
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
                    .Any(item => ((OrdenPreparacionD)item.Tag).NumOrden == orden.NumOrden);

                if (!existeEnDespachadas)
                {
                    var item = new ListViewItem(new[]
                    {
                        orden.NumOrden.ToString(),
                        orden.ClienteCUIT,
                        orden.TransportistaCUIT,
                        orden.FechaDespacho.ToString("dd/MM/yyyy"),
                    })
                    {
                        Tag = orden
                    };

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

        private void SeleccionarBtn_Click(object sender, EventArgs e)
        {
            // Mensaje en caso de que no seleccione ninguna fila a editar
            if (OrdenesPreparadasList.SelectedItems.Count == 0)
            {
                MessageBox.Show("Seleccione un item de la lista primero.");
                return;
            }

            // Creamos variable que apunte a la orden de la fila seleccionada
            var ordenSeleccionada = (OrdenPreparacionD)OrdenesPreparadasList.SelectedItems[0].Tag;

            // Modificar el estado y mover la orden a la lista de despachadas
            despacharOrdenModelo.SeleccionarOrden(ordenSeleccionada);

            MoverOrdenAListaDespachadas(ordenSeleccionada);
        }

        private void SeleccionarTodasBtn_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem orden in OrdenesPreparadasList.Items)
            {
                var ordenDespachada = (OrdenPreparacionD)orden.Tag;

                despacharOrdenModelo.SeleccionarOrden(ordenDespachada);

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

            // Obtener la orden seleccionada y modificar su estado
            var ordenSeleccionada = (OrdenPreparacionD)OrdenesDespachadasList.SelectedItems[0].Tag;
            despacharOrdenModelo.DeseleccionarOrden(ordenSeleccionada);
            MoverOrdenAListaPreparadas(ordenSeleccionada);
        }

        private void MoverOrdenAListaDespachadas(OrdenPreparacionD orden)
        {
            var item = OrdenesPreparadasList.Items.Cast<ListViewItem>()
                .FirstOrDefault(i => ((OrdenPreparacionD)i.Tag).NumOrden == orden.NumOrden);

            if (item != null)
            {
                OrdenesPreparadasList.Items.Remove(item);
                OrdenesDespachadasList.Items.Add(item);
            }
        }

        private void MoverOrdenAListaPreparadas(OrdenPreparacionD orden)
        {
            var item = OrdenesDespachadasList.Items.Cast<ListViewItem>()
                .FirstOrDefault(i => ((OrdenPreparacionD)i.Tag).NumOrden == orden.NumOrden);

            if (item != null)
            {
                OrdenesDespachadasList.Items.Remove(item);
                OrdenesPreparadasList.Items.Add(item);
            }
        }

        private void ReestablecerBtn_Click(object sender, EventArgs e)
        {
            CargarListaOrdenesPreparadas();

            TransportistaCB.SelectedIndex = -1;
            FechaDespachoCB.SelectedIndex = -1;
        }

        private void ConfirmarYRemitoBtn_Click(object sender, EventArgs e)
        {
            if (OrdenesDespachadasList.Items.Count == 0)
            {
                MessageBox.Show("Debe haber por lo menos una órden despachada para confirmarla y generar su remito.");
            }
            else
            {
                DialogResult respuesta = MessageBox.Show("¿Estás seguro que deseas confirmar la/S ordenes y generar el/los remito/s?", "Confirmación de orden", MessageBoxButtons.YesNo);

                if (respuesta == DialogResult.Yes)
                {
                    despacharOrdenModelo.OrdenesSeleccionadas = OrdenesDespachadasList.Items.Cast<ListViewItem>()
                .Select(item => (OrdenPreparacionD)item.Tag).ToList();
                    despacharOrdenModelo.Confirmar();

                    MessageBox.Show("Se modificó el estado de las órdenes a Despachadas y se generaron los remitos.");
                    this.Close();
                }
                    
            }
        }

    }
}
