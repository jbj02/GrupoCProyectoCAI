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

namespace GrupoCProyectoCAI.Estibador
{
    public partial class EstibadorMenuForm : Form
    {
        public EstibadorMenuForm()
        {
            InitializeComponent();
        }

        private void modificarbtn_Click(object sender, EventArgs e)
        {
           ModificarForm modificarOrdenEstibador = new();
            modificarOrdenEstibador.ShowDialog();
        }
    }
}
