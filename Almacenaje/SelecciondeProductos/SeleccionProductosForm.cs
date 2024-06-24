﻿using GrupoCProyectoCAI.Almacenaje.SelecciondeProductos;
using GrupoCProyectoCAI.Preparador.AltaOrdenSeleccion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GrupoCProyectoCAI.Almacenaje.SelecciondeProductos
{
    public partial class SeleccionProductosForm : Form
    {
        SeleccionProductosModelo modelo = new();
        public SeleccionProductosForm()
        {
            InitializeComponent();
        }

        private void CancelarBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SeleccionProductosForm_Load(object sender, EventArgs e)
        {
            foreach (var orden in modelo.OrdenesSeleccion)
            {
                OrdenSeleccionCmb.Items.Add(orden.NumeroOrden);
            }
        }

        private void OrdenSeleccionCmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            OrdenExt_List.Items.Clear();
            if (OrdenSeleccionCmb.SelectedIndex != -1)
            {
                string num = OrdenSeleccionCmb.SelectedItem.ToString();
                int numero = Convert.ToInt32(num);
                var orden = modelo.Buscar(numero);
                foreach (var detalle in orden.ordenAsociada)
                {
                    foreach (var producto in detalle.productos)
                    {
                        var fila = new ListViewItem();
                        fila.Text = producto.Producto;
                        fila.SubItems.Add(producto.Cantidades.ToString());
                        fila.SubItems.Add(producto.Ubicacion);
                        OrdenExt_List.Items.Add(fila);
                    }

                }
            }
        }

        private void ConfirmarBtn_Click(object sender, EventArgs e)
        {
            string error = "";
            bool flag;

            foreach (ListViewItem item in OrdenExt_List.Items)
            {
                flag = item.Checked;
                error = ValidarSeleccion(flag) + System.Environment.NewLine;
            }
            error += ValidarOrden(OrdenSeleccionCmb.SelectedIndex) + System.Environment.NewLine;
            error = error.Trim();
            if (!String.IsNullOrEmpty(error))
            {
                MessageBox.Show(error, "Error");
            }
            else
            {
                DialogResult respuesta = MessageBox.Show("Desea confirmar la orden?", "Pampazon S.A", MessageBoxButtons.YesNo); // falta if de si selecciona yes 
                if (respuesta == DialogResult.Yes)
                {
                    var orden = modelo.Buscar(Convert.ToInt32(OrdenSeleccionCmb.SelectedItem.ToString()));
                    modelo.orden = orden;
                    //orden.Estado = "cumplida";
                    modelo.Confirmar();
                    OrdenExt_List.Items.Clear();
                    //modelo.ActualizarOrden(OrdenSeleccionCmb.SelectedItem.ToString());
                    //modelo.CambiarEstadoOrdenEstado(orden);
                    OrdenSeleccionCmb.SelectedIndex = -1;
                    MessageBox.Show($"Se ha actualizado el estado de la orden {orden.NumeroOrden}", "Pampazon S.A");
                    this.Close();
                }
            }
        }
        public string ValidarOrden(int index)
        {
            string error = "";
            if (index == -1)
            {
                error = "No se ha seleccionado ninguna orden";
            }
            return error;
        }
        public string ValidarSeleccion(bool item)
        {
            string error = "";
            if (item == false)
            {
                error = "No ha seleccionado todos los productos asociados a la orden";
            }

            return error;
        }

        private void SeleccionarTodo_Click(object sender, EventArgs e)
        {
            foreach(ListViewItem item in OrdenExt_List.Items)
            {
                item.Checked = true;
            }
        }
    }
}
