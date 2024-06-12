using GrupoCProyectoCAI.Despachador;
using GrupoCProyectoCAI.Preparador.AltaOrdenSeleccion;
using GrupoCProyectoCAI.Preparador.PrepararOrden;
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
            // Abre el Formulario altaOrdenSeleccionForm
            AltaOrdenSeleccionForm altaOrdenSeleccionForm = new();
            altaOrdenSeleccionForm.ShowDialog();
        }

        private void PrepararOrdenBtn_Click(object sender, EventArgs e)
        {
            // Abre el Formulario PrepararOrdenForm
            PrepararOrdenForm prepararOrdenForm = new();
            prepararOrdenForm.ShowDialog();
        }

        private void AltaOrdenPreparacion_Click(object sender, EventArgs e)
        {
            // Abre el Formulario AltaOrdenPreparacion
            AltaOrdenPreparacionForm altaOrdenPreparacionForm = new();
            altaOrdenPreparacionForm.ShowDialog();
        }

        private void VolverMenuBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
