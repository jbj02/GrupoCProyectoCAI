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
            Tipo_Producto = new ColumnHeader();
            Cantidad = new ColumnHeader();
            groupBox2 = new GroupBox();
            label9 = new Label();
            NumeroOrdenInternaBuscarText = new TextBox();
            BuscarBtn = new Button();
            button1 = new Button();
            Deposito = new ColumnHeader();
            button2 = new Button();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // OrdenExt_List
            // 
            OrdenExt_List.Columns.AddRange(new ColumnHeader[] { Tipo_Producto, Cantidad, Deposito });
            OrdenExt_List.FullRowSelect = true;
            OrdenExt_List.GridLines = true;
            OrdenExt_List.Location = new Point(58, 118);
            OrdenExt_List.Margin = new Padding(3, 4, 3, 4);
            OrdenExt_List.MultiSelect = false;
            OrdenExt_List.Name = "OrdenExt_List";
            OrdenExt_List.Size = new Size(350, 252);
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
            // groupBox2
            // 
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(NumeroOrdenInternaBuscarText);
            groupBox2.Controls.Add(BuscarBtn);
            groupBox2.Location = new Point(12, 13);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(479, 87);
            groupBox2.TabIndex = 134;
            groupBox2.TabStop = false;
            groupBox2.Text = "Busqueda";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(10, 36);
            label9.Name = "label9";
            label9.Size = new Size(129, 20);
            label9.TabIndex = 105;
            label9.Text = "Número de Orden";
            // 
            // NumeroOrdenInternaBuscarText
            // 
            NumeroOrdenInternaBuscarText.Location = new Point(145, 33);
            NumeroOrdenInternaBuscarText.Margin = new Padding(3, 4, 3, 4);
            NumeroOrdenInternaBuscarText.Name = "NumeroOrdenInternaBuscarText";
            NumeroOrdenInternaBuscarText.Size = new Size(223, 27);
            NumeroOrdenInternaBuscarText.TabIndex = 104;
            // 
            // BuscarBtn
            // 
            BuscarBtn.Location = new Point(374, 26);
            BuscarBtn.Margin = new Padding(3, 4, 3, 4);
            BuscarBtn.Name = "BuscarBtn";
            BuscarBtn.Size = new Size(98, 41);
            BuscarBtn.TabIndex = 106;
            BuscarBtn.Text = "Buscar";
            BuscarBtn.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(126, 389);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 135;
            button1.Text = "Confirmar";
            button1.UseVisualStyleBackColor = true;
            // 
            // Deposito
            // 
            Deposito.Text = "Deposito";
            Deposito.Width = 100;
            // 
            // button2
            // 
            button2.Location = new Point(261, 389);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 137;
            button2.Text = "Vaciar";
            button2.UseVisualStyleBackColor = true;
            // 
            // SeleccionProductosForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(544, 521);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(groupBox2);
            Controls.Add(OrdenExt_List);
            Name = "SeleccionProductosForm";
            Text = "SeleccionProductosForm";
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ListView OrdenExt_List;
        private ColumnHeader Tipo_Producto;
        private ColumnHeader Cantidad;
        private ColumnHeader Deposito;
        private GroupBox groupBox2;
        private Label label9;
        private TextBox NumeroOrdenInternaBuscarText;
        private Button BuscarBtn;
        private Button button1;
        private Button button2;
    }
}