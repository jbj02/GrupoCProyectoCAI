namespace GrupoCProyectoCAI.Despachador.Modificar
{
    partial class DespacharOrdenForm
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
            groupBox2 = new GroupBox();
            label1 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            label9 = new Label();
            NumeroOrdenInternaBuscarText = new TextBox();
            BuscarBtn = new Button();
            SeleccionarBtn = new Button();
            OrdenInt_List = new ListView();
            N_Orden = new ColumnHeader();
            Estado = new ColumnHeader();
            Cliente = new ColumnHeader();
            Transportista = new ColumnHeader();
            FechaEntrega = new ColumnHeader();
            button2 = new Button();
            label2 = new Label();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(textBox1);
            groupBox2.Controls.Add(button1);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(NumeroOrdenInternaBuscarText);
            groupBox2.Controls.Add(BuscarBtn);
            groupBox2.Location = new Point(12, 18);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(589, 79);
            groupBox2.TabIndex = 107;
            groupBox2.TabStop = false;
            groupBox2.Text = "Filtrar";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(341, 19);
            label1.Name = "label1";
            label1.Size = new Size(97, 15);
            label1.TabIndex = 108;
            label1.Text = "Fecha de Entrega";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(341, 37);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(132, 23);
            textBox1.TabIndex = 107;
            // 
            // button1
            // 
            button1.Location = new Point(492, 33);
            button1.Name = "button1";
            button1.Size = new Size(80, 28);
            button1.TabIndex = 109;
            button1.Text = "Buscar";
            button1.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(22, 19);
            label9.Name = "label9";
            label9.Size = new Size(74, 15);
            label9.TabIndex = 105;
            label9.Text = "Transportista";
            // 
            // NumeroOrdenInternaBuscarText
            // 
            NumeroOrdenInternaBuscarText.Location = new Point(22, 37);
            NumeroOrdenInternaBuscarText.Name = "NumeroOrdenInternaBuscarText";
            NumeroOrdenInternaBuscarText.Size = new Size(132, 23);
            NumeroOrdenInternaBuscarText.TabIndex = 104;
            // 
            // BuscarBtn
            // 
            BuscarBtn.Location = new Point(173, 33);
            BuscarBtn.Name = "BuscarBtn";
            BuscarBtn.Size = new Size(80, 28);
            BuscarBtn.TabIndex = 106;
            BuscarBtn.Text = "Buscar";
            BuscarBtn.UseVisualStyleBackColor = true;
            // 
            // SeleccionarBtn
            // 
            SeleccionarBtn.Location = new Point(515, 327);
            SeleccionarBtn.Name = "SeleccionarBtn";
            SeleccionarBtn.Size = new Size(86, 31);
            SeleccionarBtn.TabIndex = 105;
            SeleccionarBtn.Text = "Confirmar";
            SeleccionarBtn.UseVisualStyleBackColor = true;
            // 
            // OrdenInt_List
            // 
            OrdenInt_List.Columns.AddRange(new ColumnHeader[] { N_Orden, Estado, Cliente, Transportista, FechaEntrega });
            OrdenInt_List.FullRowSelect = true;
            OrdenInt_List.GridLines = true;
            OrdenInt_List.Location = new Point(12, 119);
            OrdenInt_List.MultiSelect = false;
            OrdenInt_List.Name = "OrdenInt_List";
            OrdenInt_List.Size = new Size(589, 202);
            OrdenInt_List.TabIndex = 104;
            OrdenInt_List.UseCompatibleStateImageBehavior = false;
            OrdenInt_List.View = View.Details;
            // 
            // N_Orden
            // 
            N_Orden.Text = "N° Orden";
            N_Orden.Width = 90;
            // 
            // Estado
            // 
            Estado.Text = "Estado";
            Estado.Width = 140;
            // 
            // Cliente
            // 
            Cliente.Text = "Cliente";
            Cliente.Width = 120;
            // 
            // Transportista
            // 
            Transportista.Text = "Transportista";
            Transportista.Width = 90;
            // 
            // FechaEntrega
            // 
            FechaEntrega.Text = "Fecha de Entrega";
            FechaEntrega.Width = 140;
            // 
            // button2
            // 
            button2.Location = new Point(515, 391);
            button2.Name = "button2";
            button2.Size = new Size(86, 31);
            button2.TabIndex = 108;
            button2.Text = "Cancelar";
            button2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 100);
            label2.Name = "label2";
            label2.Size = new Size(112, 15);
            label2.TabIndex = 109;
            label2.Text = "Ordenes Preparadas";
            // 
            // DespacharOrdenForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(622, 434);
            Controls.Add(label2);
            Controls.Add(button2);
            Controls.Add(groupBox2);
            Controls.Add(SeleccionarBtn);
            Controls.Add(OrdenInt_List);
            Name = "DespacharOrdenForm";
            Text = "DespacharOrdenForm";
            Load += ModificarDespachadorForm_Load;
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox2;
        private Label label9;
        private TextBox NumeroOrdenInternaBuscarText;
        private Button BuscarBtn;
        private TextBox NumOrdenIntText;
        private TextBox NumOrdExtText;
        private Label label3;
        private TextBox CantidadText;
        private Button AceptarDatosOrdenBtn;
        private Label label4;
        private TextBox TipoDeProductoText;
        private CheckBox checkBox1;
        private Button SeleccionarBtn;
        private ListView OrdenInt_List;
        private ColumnHeader N_Orden;
        private ColumnHeader N_Orden_Ext;
        private ColumnHeader N_Orden_In;
        private ColumnHeader Tipo_Producto;
        private ColumnHeader Cantidades;
        private ColumnHeader Cliente;
        private ColumnHeader Estado;
        private ColumnHeader FechaEntrega;

        public ColumnHeader Fecha_Entrega { get; private set; }

        private ColumnHeader Fecha_Modificacion;
        private Button CancelarBoton;
        private ColumnHeader Transportista;
        private Label label1;
        private TextBox textBox1;
        private Button button1;
        private Button button2;
        private Label label2;
    }
}