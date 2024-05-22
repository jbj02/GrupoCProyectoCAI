using GrupoCProyectoCAI.Despachador;
using GrupoCProyectoCAI.Preparador.Modificar;
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

namespace GrupoCProyectoCAI.Preparador
{
    public partial class PreparadorMenuForm : Form
    {
        public PreparadorMenuForm()
        {
            InitializeComponent();
        }

        private void ModificarBtn_Click(object sender, EventArgs e)
        {
            // Abre el Formulario ModificarPreparadorForm
            CambiarOrdenAPreparadaForm modificarPreparadorForm = new();
            modificarPreparadorForm.ShowDialog();
        }

        private void NuevaOrdenBtn_Click(object sender, EventArgs e)
        {
            // Abre el Formulario ModificarPreparadorForm
            NuevaOrdenPreparadorForm nuevaOrdenPreparadorForm = new();
            nuevaOrdenPreparadorForm.ShowDialog();
        }
    }
}
