﻿namespace GrupoCProyectoCAI.Estibador.SelecciondeProductos
{
    partial class SeleccionProductosForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            OrdenExt_List = new ListView();
            Tipo_Producto = new ColumnHeader();
            Cantidad = new ColumnHeader();
            Ubicacion = new ColumnHeader();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // OrdenExt_List
            // 
            OrdenExt_List.Columns.AddRange(new ColumnHeader[] { Tipo_Producto, Cantidad, Ubicacion });
            OrdenExt_List.FullRowSelect = true;
            OrdenExt_List.GridLines = true;
            OrdenExt_List.Location = new Point(51, 12);
            OrdenExt_List.MultiSelect = false;
            OrdenExt_List.Name = "OrdenExt_List";
            OrdenExt_List.Size = new Size(345, 266);
            OrdenExt_List.TabIndex = 133;
            OrdenExt_List.UseCompatibleStateImageBehavior = false;
            OrdenExt_List.View = View.Details;
            // 
            // Tipo_Producto
            // 
            Tipo_Producto.Text = "Tipo Producto";
            Tipo_Producto.Width = 120;
            // 
            // Cantidad
            // 
            Cantidad.Text = "Cantidad";
            Cantidad.Width = 120;
            // 
            // Ubicacion
            // 
            Ubicacion.Text = "Ubicación";
            Ubicacion.Width = 100;
            // 
            // button1
            // 
            button1.Location = new Point(87, 283);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(128, 31);
            button1.TabIndex = 135;
            button1.Text = "Confirmar Producto";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(251, 283);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(116, 31);
            button2.TabIndex = 136;
            button2.Text = "Confirmar Todo";
            button2.UseVisualStyleBackColor = true;
            // 
            // SeleccionProductosForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(476, 391);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(OrdenExt_List);
            Margin = new Padding(3, 2, 3, 2);
            Name = "SeleccionProductosForm";
            Text = "SeleccionProductosForm";
            ResumeLayout(false);
        }

        #endregion

        private ListView OrdenExt_List;
        private ColumnHeader Tipo_Producto;
        private ColumnHeader Cantidad;
        private ColumnHeader Ubicacion;
        private Button button1;
        private Button button2;
    }
}