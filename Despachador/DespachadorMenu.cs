using GrupoCProyectoCAI.Despachador.GenerarRemito;
using GrupoCProyectoCAI.Despachador.Modificar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GrupoCProyectoCAI.Despachador
{
    public partial class DespachadorMenuForm : Form
    {
        public DespachadorMenuForm()
        {
            InitializeComponent();
        }

        private void ModificarOrdenBtn_Click(object sender, EventArgs e)
        {
            ModificarDespachadorForm modificarDespachadorForm = new();
            modificarDespachadorForm.ShowDialog();
        }

        private void GenerarRemitoBtn_Click(object sender, EventArgs e)
        {
            GenerarRemitoForm generarRemitoForm = new GenerarRemitoForm();
            generarRemitoForm.ShowDialog();
        }
    }
}
