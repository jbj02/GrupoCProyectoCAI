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
            label5 = new Label();
            listView1 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            button3 = new Button();
            button4 = new Button();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(NumeroOrdenInternaBuscarText);
            groupBox2.Controls.Add(BuscarBtn);
            groupBox2.Location = new Point(12, 18);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(317, 132);
            groupBox2.TabIndex = 107;
            groupBox2.TabStop = false;
            groupBox2.Text = "Filtrar";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 72);
            label1.Name = "label1";
            label1.Size = new Size(97, 15);
            label1.TabIndex = 108;
            label1.Text = "Fecha de Entrega";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(34, 90);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(132, 23);
            textBox1.TabIndex = 107;
            // 
            // button1
            // 
            button1.Location = new Point(237, 404);
            button1.Name = "button1";
            button1.Size = new Size(80, 28);
            button1.TabIndex = 109;
            button1.Text = "Seleccionar";
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
            SeleccionarBtn.Location = new Point(355, 471);
            SeleccionarBtn.Name = "SeleccionarBtn";
            SeleccionarBtn.Size = new Size(308, 31);
            SeleccionarBtn.TabIndex = 105;
            SeleccionarBtn.Text = "Confirmar + Generar remito (en archivo)";
            SeleccionarBtn.UseVisualStyleBackColor = true;
            // 
            // OrdenInt_List
            // 
            OrdenInt_List.Columns.AddRange(new ColumnHeader[] { N_Orden, Estado, Cliente, Transportista, FechaEntrega });
            OrdenInt_List.FullRowSelect = true;
            OrdenInt_List.GridLines = true;
            OrdenInt_List.Location = new Point(12, 185);
            OrdenInt_List.MultiSelect = false;
            OrdenInt_List.Name = "OrdenInt_List";
            OrdenInt_List.Size = new Size(317, 202);
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
            button2.Location = new Point(439, 518);
            button2.Name = "button2";
            button2.Size = new Size(224, 31);
            button2.TabIndex = 108;
            button2.Text = "Cancelar";
            button2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 166);
            label2.Name = "label2";
            label2.Size = new Size(112, 15);
            label2.TabIndex = 109;
            label2.Text = "Ordenes Preparadas";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(355, 166);
            label5.Name = "label5";
            label5.Size = new Size(122, 15);
            label5.TabIndex = 111;
            label5.Text = "Ordenes despachadas";
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5 });
            listView1.FullRowSelect = true;
            listView1.GridLines = true;
            listView1.Location = new Point(355, 185);
            listView1.MultiSelect = false;
            listView1.Name = "listView1";
            listView1.Size = new Size(317, 202);
            listView1.TabIndex = 110;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "N° Orden";
            columnHeader1.Width = 90;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Estado";
            columnHeader2.Width = 140;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Cliente";
            columnHeader3.Width = 120;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Transportista";
            columnHeader4.Width = 90;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Fecha de Entrega";
            columnHeader5.Width = 140;
            // 
            // button3
            // 
            button3.Location = new Point(570, 404);
            button3.Name = "button3";
            button3.Size = new Size(102, 28);
            button3.TabIndex = 112;
            button3.Text = "Deseleccionar";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(103, 404);
            button4.Name = "button4";
            button4.Size = new Size(128, 28);
            button4.TabIndex = 113;
            button4.Text = "Seleccionar todas";
            button4.UseVisualStyleBackColor = true;
            // 
            // DespacharOrdenForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(704, 574);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(label1);
            Controls.Add(label5);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(listView1);
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
        private Label label5;
        private ListView listView1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private Button button3;
        private Button button4;
    }
}