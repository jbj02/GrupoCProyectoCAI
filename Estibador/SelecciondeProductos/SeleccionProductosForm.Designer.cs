namespace GrupoCProyectoCAI.Estibador.SelecciondeProductos
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
            button2 = new Button();
            button5 = new Button();
            comboBox1 = new ComboBox();
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
            OrdenExt_List.Size = new Size(345, 266);
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
            Ubicacion.Width = 100;
            // 
            // button2
            // 
            button2.Location = new Point(276, 357);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(116, 31);
            button2.TabIndex = 136;
            button2.Text = "Confirmar Todo";
            button2.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(369, 425);
            button5.Margin = new Padding(3, 2, 3, 2);
            button5.Name = "button5";
            button5.Size = new Size(95, 32);
            button5.TabIndex = 137;
            button5.Text = "Cancelar";
            button5.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(49, 38);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(343, 23);
            comboBox1.TabIndex = 138;
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
            ClientSize = new Size(476, 468);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Controls.Add(button5);
            Controls.Add(button2);
            Controls.Add(OrdenExt_List);
            Margin = new Padding(3, 2, 3, 2);
            Name = "SeleccionProductosForm";
            Text = "SeleccionProductosForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView OrdenExt_List;
        private ColumnHeader Producto;
        private ColumnHeader Cantidad;
        private ColumnHeader Ubicacion;
        private Button button2;
        private Button button5;
        private ComboBox comboBox1;
        private Label label1;
    }
}