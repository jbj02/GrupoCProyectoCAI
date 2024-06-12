namespace GrupoCProyectoCAI.Almacenaje.SelecciondeProductos
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
            Producto = new ColumnHeader();
            Cantidad = new ColumnHeader();
            Ubicacion = new ColumnHeader();
            ConfirmarBtn = new Button();
            CancelarBtn = new Button();
            OrdenSeleccionCmb = new ComboBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // OrdenExt_List
            // 
            OrdenExt_List.CheckBoxes = true;
            OrdenExt_List.Columns.AddRange(new ColumnHeader[] { Producto, Cantidad, Ubicacion });
            OrdenExt_List.FullRowSelect = true;
            OrdenExt_List.GridLines = true;
            OrdenExt_List.Location = new Point(47, 86);
            OrdenExt_List.MultiSelect = false;
            OrdenExt_List.Name = "OrdenExt_List";
            OrdenExt_List.Size = new Size(396, 266);
            OrdenExt_List.TabIndex = 133;
            OrdenExt_List.UseCompatibleStateImageBehavior = false;
            OrdenExt_List.View = View.Details;
            // 
            // Producto
            // 
            Producto.Text = "Producto";
            Producto.Width = 120;
            // 
            // Cantidad
            // 
            Cantidad.Text = "Cantidad";
            Cantidad.Width = 120;
            // 
            // Ubicacion
            // 
            Ubicacion.Text = "Ubicación";
            Ubicacion.Width = 150;
            // 
            // ConfirmarBtn
            // 
            ConfirmarBtn.Location = new Point(327, 357);
            ConfirmarBtn.Margin = new Padding(3, 2, 3, 2);
            ConfirmarBtn.Name = "ConfirmarBtn";
            ConfirmarBtn.Size = new Size(116, 31);
            ConfirmarBtn.TabIndex = 136;
            ConfirmarBtn.Text = "Confirmar Todo";
            ConfirmarBtn.UseVisualStyleBackColor = true;
            ConfirmarBtn.Click += ConfirmarBtn_Click;
            // 
            // CancelarBtn
            // 
            CancelarBtn.Location = new Point(348, 414);
            CancelarBtn.Margin = new Padding(3, 2, 3, 2);
            CancelarBtn.Name = "CancelarBtn";
            CancelarBtn.Size = new Size(95, 32);
            CancelarBtn.TabIndex = 137;
            CancelarBtn.Text = "Cancelar";
            CancelarBtn.UseVisualStyleBackColor = true;
            CancelarBtn.Click += CancelarBtn_Click;
            // 
            // OrdenSeleccionCmb
            // 
            OrdenSeleccionCmb.FormattingEnabled = true;
            OrdenSeleccionCmb.Location = new Point(49, 38);
            OrdenSeleccionCmb.Name = "OrdenSeleccionCmb";
            OrdenSeleccionCmb.Size = new Size(394, 23);
            OrdenSeleccionCmb.TabIndex = 138;
            OrdenSeleccionCmb.SelectedIndexChanged += OrdenSeleccionCmb_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(51, 18);
            label1.Name = "label1";
            label1.Size = new Size(108, 15);
            label1.TabIndex = 139;
            label1.Text = "Orden de seleccion";
            // 
            // SeleccionProductosForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(500, 467);
            Controls.Add(label1);
            Controls.Add(OrdenSeleccionCmb);
            Controls.Add(CancelarBtn);
            Controls.Add(ConfirmarBtn);
            Controls.Add(OrdenExt_List);
            Margin = new Padding(3, 2, 3, 2);
            Name = "SeleccionProductosForm";
            Text = "SeleccionProductosForm";
            Load += SeleccionProductosForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView OrdenExt_List;
        private ColumnHeader Producto;
        private ColumnHeader Cantidad;
        private ColumnHeader Ubicacion;
        private Button ConfirmarBtn;
        private Button CancelarBtn;
        private ComboBox OrdenSeleccionCmb;
        private Label label1;
    }
}