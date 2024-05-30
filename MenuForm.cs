using GrupoCProyectoCAI.Despachador;
using GrupoCProyectoCAI.Despachador.Modificar;
using GrupoCProyectoCAI.Estibador;
using GrupoCProyectoCAI.Estibador.SelecciondeProductos;
using GrupoCProyectoCAI.Preparador;
using System.Reflection;

namespace GrupoCProyectoCAI
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void EstibadorBtn_Click(object sender, EventArgs e)
        {
            // Abre el Formulario SeleccionProductosForm
            SeleccionProductosForm seleccionProductosForm = new();
            seleccionProductosForm.ShowDialog();
        }

        private void PreparadorBtn_Click(object sender, EventArgs e)
        {
            // Abre el Formulario PreparadorMenuForm
            PreparadorMenuForm peparadorMenuForm = new();
            peparadorMenuForm.ShowDialog();
        }

        private void DespachadorBtn_Click(object sender, EventArgs e)
        {
            // Abre el Formulario DespacharOrdenForm
            DespacharOrdenForm despacharOrdenForm = new();
            despacharOrdenForm.ShowDialog();
        }

        private void AtencionCliente_Click(object sender, EventArgs e)
        {
            // Abre el Formulario AltaOrdenPreparacionForm
            AltaOrdenPreparacionForm altaOrdenPreparacionForm = new();
            altaOrdenPreparacionForm.ShowDialog();
        }
    }
}
