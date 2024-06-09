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
            CargarListaOrdenesPreparadas();
        }

        private void CargarListaOrdenesPreparadas()
        {
            OrdenesPreparadasList.Items.Clear();

            foreach (var ordenpreparada in despacharOrdenModelo.OrdenesPreparadas)
            {
                var fila = new ListViewItem();
                // le cargamos los datos a la fila
                fila.Text = ordenpreparada.NumOrden.ToString();
                fila.SubItems.Add(ordenpreparada.Cliente);
                fila.SubItems.Add(ordenpreparada.Transportista);
                fila.SubItems.Add(ordenpreparada.FechaDespacho.ToString("dd/MM/yyyy"));
                fila.Tag = ordenpreparada; // Permite identificar cuál objeto se está utilizando
                // agregamops fila a la lista
                OrdenesPreparadasList.Items.Add(fila);
            }
        }

        private void FiltrarBtn_Click(object sender, EventArgs e)
        {
            string transportistaFiltro = TransportistaTxt.Text.Trim();
            DateTime fechaDespachoFiltro = DateTime.MinValue;
            bool fechaDespachoValida = false;

            // Verificar si ambos campos están vacíos
            if (string.IsNullOrEmpty(transportistaFiltro) && string.IsNullOrWhiteSpace(FechaDespachoTxt.Text))
            {
                MessageBox.Show("Debe ingresar al menos uno de los campos: Transportista o Fecha de Despacho.");
                return;
            }

            // Validar y convertir el campo de fecha
            if (!string.IsNullOrWhiteSpace(FechaDespachoTxt.Text))
            {
                if (!DateTime.TryParse(FechaDespachoTxt.Text, out fechaDespachoFiltro))
                {
                    MessageBox.Show("Fecha de despacho inválida. Ingrese una fecha válida (ejemplo: 01/01/2024).");
                    return;
                }

                bool flagRangoFecha = despacharOrdenModelo.ValidarRangoFecha(fechaDespachoFiltro);

                if (!flagRangoFecha)
                {
                    MessageBox.Show("La fecha no puede ser menor a hoy.");
                    return;
                }
            }        

            // Filtra las órdenes según los valores ingresados
            var ordenesFiltradas = despacharOrdenModelo.OrdenesPreparadas.Where(o => (string.IsNullOrWhiteSpace(transportistaFiltro) || o.Transportista.Contains(transportistaFiltro)) &&
                            (string.IsNullOrWhiteSpace(FechaDespachoTxt.Text) || o.FechaDespacho.Date == fechaDespachoFiltro.Date)).ToList();

            // Actualiza la ListView con las órdenes filtradas
            OrdenesPreparadasList.Items.Clear();

            foreach (var orden in ordenesFiltradas)
            {
                var item = new ListViewItem(new[]
                {
                    orden.NumOrden.ToString(),
                    orden.Cliente,
                    orden.Transportista,
                    orden.FechaDespacho.ToString("dd/MM/yyyy"),
                });

                item.Tag = orden; // Asignar el objeto OrdenPreparacion al Tag
                OrdenesPreparadasList.Items.Add(item);
            }

            if(OrdenesPreparadasList.Items.Count == 0)
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
            }
            else
            {
                MessageBox.Show("¿Estás seguro que deseas confirmar la orden y generar el/los remito/s?", "Confirmación de orden", MessageBoxButtons.YesNo);
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
                NumOrden = ordenSeleccionada.NumOrden,
                Cliente = ordenSeleccionada.Cliente,
                Transportista = ordenSeleccionada.Transportista,
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
                    NumOrden = int.Parse(orden.SubItems[0].Text),
                    Cliente = orden.SubItems[1].Text,
                    Transportista = orden.SubItems[2].Text,
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
                NumOrden = ordenSeleccionada.NumOrden,
                Cliente = ordenSeleccionada.Cliente,
                Transportista = ordenSeleccionada.Transportista,
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
            
            TransportistaTxt.Clear();
            FechaDespachoTxt.Clear();
        }        
    }
}
