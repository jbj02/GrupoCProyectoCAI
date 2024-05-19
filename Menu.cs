using GrupoCProyectoCAI.Despachador;
using GrupoCProyectoCAI.Estibador;
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
            // Abre el Formulario EstibadorForm
            EstibadorMenuForm estibadorMenuForm = new();
            estibadorMenuForm.ShowDialog();
        }

        private void PreparadorBtn_Click(object sender, EventArgs e)
        {
            // Abre el Formulario PreparadorForm
            PreparadorMenuForm peparadorMenuForm = new();
            peparadorMenuForm.ShowDialog();
        }

        private void DespachadorBtn_Click(object sender, EventArgs e)
        {
            // Abre el Formulario DespachadorForm
            DespachadorMenuForm despachadorMenuForm = new();
            despachadorMenuForm.ShowDialog();
        }
    }
}
