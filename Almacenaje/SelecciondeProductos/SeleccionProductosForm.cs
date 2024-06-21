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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CancelarBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SeleccionProductosForm_Load(object sender, EventArgs e)
        {
            foreach (var orden in modelo.ordenSeleccion)
            {
                OrdenSeleccionCmb.Items.Add(orden.NroOrden);
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
                foreach (var detalle in orden.OrdenPreparacionAsociadas)
                {
                    foreach(var producto in detalle.ProductosList)
                    {
                        var fila = new ListViewItem();
                        fila.Text = producto.Producto;
                        fila.SubItems.Add(producto.Cantidad.ToString());
                        fila.SubItems.Add(producto.Ubicacion);
                        OrdenExt_List.Items.Add(fila);
                    }
                    
                }
            }
        }

        private void ConfirmarBtn_Click(object sender, EventArgs e)
        {
            //bool flag = OrdenExt_List.CheckBoxes;
            
            MessageBox.Show("Desea confirmar la orden?", "Mensaje de confirmación", MessageBoxButtons.YesNo); // falta if de si selecciona yes 
            OrdenExt_List.Items.Clear();
            
            modelo.ActualizarOrden(OrdenSeleccionCmb.SelectedItem.ToString());
            OrdenSeleccionCmb.SelectedIndex = -1;
        }
    }
}
