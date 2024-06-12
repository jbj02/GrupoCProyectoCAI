using GrupoCProyectoCAI.Almacenaje.SelecciondeProductos;
using GrupoCProyectoCAI.Despachador;
using GrupoCProyectoCAI.Despachador.DespacharOrden;
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

        private void AlmacenajeBtn_Click(object sender, EventArgs e)
        {
            // Abre el Formulario SeleccionProductosForm
            SeleccionProductosForm seleccionProductosForm = new();
            seleccionProductosForm.ShowDialog();
        }
    }
}
