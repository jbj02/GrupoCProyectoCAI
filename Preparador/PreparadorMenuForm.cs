using GrupoCProyectoCAI.Despachador;
using GrupoCProyectoCAI.Preparador.AltaOrdenSeleccion;
using GrupoCProyectoCAI.Preparador.Modificar;
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

        private void AltaOrdenSeleccionBtn_Click(object sender, EventArgs e)
        {
            // Abre el Formulario ModificarPreparadorForm
            AltaOrdenSeleccionForm altaOrdenSeleccionForm = new();
            altaOrdenSeleccionForm.ShowDialog();
        }

        private void PrepararOrdenBtn_Click(object sender, EventArgs e)
        {
            // Abre el Formulario ModificarPreparadorForm
            PrepararOrdenForm prepararOrdenForm = new();
            prepararOrdenForm.ShowDialog();
        }
    }
}
