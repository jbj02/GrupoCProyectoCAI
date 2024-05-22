namespace GrupoCProyectoCAI.Despachador.Modificar
{
    partial class CambiarOrdenADespachadaForm
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
            label9 = new Label();
            NumeroOrdenInternaBuscarText = new TextBox();
            BuscarBtn = new Button();
            DatosOrdenGroup = new GroupBox();
            textBox1 = new TextBox();
            label2 = new Label();
            listView1 = new ListView();
            TipoProducto = new ColumnHeader();
            Cantidad = new ColumnHeader();
            PrioridadText = new TextBox();
            label10 = new Label();
            CancelarDatosOrdenBtn = new Button();
            label1 = new Label();
            NumOrdenText = new TextBox();
            ConfirmarDatosOrdenBtn = new Button();
            FechaModificacionDT = new DateTimePicker();
            FechaCreacionDT = new DateTimePicker();
            EstadoCB = new ComboBox();
            ClienteText = new TextBox();
            label8 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            SeleccionarBtn = new Button();
            OrdenInt_List = new ListView();
            N_Orden = new ColumnHeader();
            Estado = new ColumnHeader();
            Cliente = new ColumnHeader();
            Prioridad = new ColumnHeader();
            Fecha_Creacion = new ColumnHeader();
            groupBox2.SuspendLayout();
            DatosOrdenGroup.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(NumeroOrdenInternaBuscarText);
            groupBox2.Controls.Add(BuscarBtn);
            groupBox2.Location = new Point(14, 24);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(489, 87);
            groupBox2.TabIndex = 107;
            groupBox2.TabStop = false;
            groupBox2.Text = "Busqueda";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(25, 40);
            label9.Name = "label9";
            label9.Size = new Size(129, 20);
            label9.TabIndex = 105;
            label9.Text = "Número de Orden";
            // 
            // NumeroOrdenInternaBuscarText
            // 
            NumeroOrdenInternaBuscarText.Location = new Point(150, 36);
            NumeroOrdenInternaBuscarText.Margin = new Padding(3, 4, 3, 4);
            NumeroOrdenInternaBuscarText.Name = "NumeroOrdenInternaBuscarText";
            NumeroOrdenInternaBuscarText.Size = new Size(223, 27);
            NumeroOrdenInternaBuscarText.TabIndex = 104;
            // 
            // BuscarBtn
            // 
            BuscarBtn.Location = new Point(381, 29);
            BuscarBtn.Margin = new Padding(3, 4, 3, 4);
            BuscarBtn.Name = "BuscarBtn";
            BuscarBtn.Size = new Size(98, 41);
            BuscarBtn.TabIndex = 106;
            BuscarBtn.Text = "Buscar";
            BuscarBtn.UseVisualStyleBackColor = true;
            // 
            // DatosOrdenGroup
            // 
            DatosOrdenGroup.Controls.Add(textBox1);
            DatosOrdenGroup.Controls.Add(label2);
            DatosOrdenGroup.Controls.Add(listView1);
            DatosOrdenGroup.Controls.Add(PrioridadText);
            DatosOrdenGroup.Controls.Add(label10);
            DatosOrdenGroup.Controls.Add(CancelarDatosOrdenBtn);
            DatosOrdenGroup.Controls.Add(label1);
            DatosOrdenGroup.Controls.Add(NumOrdenText);
            DatosOrdenGroup.Controls.Add(ConfirmarDatosOrdenBtn);
            DatosOrdenGroup.Controls.Add(FechaModificacionDT);
            DatosOrdenGroup.Controls.Add(FechaCreacionDT);
            DatosOrdenGroup.Controls.Add(EstadoCB);
            DatosOrdenGroup.Controls.Add(ClienteText);
            DatosOrdenGroup.Controls.Add(label8);
            DatosOrdenGroup.Controls.Add(label5);
            DatosOrdenGroup.Controls.Add(label6);
            DatosOrdenGroup.Controls.Add(label7);
            DatosOrdenGroup.Enabled = false;
            DatosOrdenGroup.Location = new Point(14, 445);
            DatosOrdenGroup.Margin = new Padding(3, 4, 3, 4);
            DatosOrdenGroup.Name = "DatosOrdenGroup";
            DatosOrdenGroup.Padding = new Padding(3, 4, 3, 4);
            DatosOrdenGroup.Size = new Size(843, 303);
            DatosOrdenGroup.TabIndex = 106;
            DatosOrdenGroup.TabStop = false;
            DatosOrdenGroup.Text = "Datos de la Orden";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(7, 201);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(138, 27);
            textBox1.TabIndex = 130;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(7, 175);
            label2.Name = "label2";
            label2.Size = new Size(94, 20);
            label2.TabIndex = 129;
            label2.Text = "Transportista";
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { TipoProducto, Cantidad });
            listView1.FullRowSelect = true;
            listView1.GridLines = true;
            listView1.Location = new Point(501, 40);
            listView1.Margin = new Padding(3, 4, 3, 4);
            listView1.MultiSelect = false;
            listView1.Name = "listView1";
            listView1.Size = new Size(270, 227);
            listView1.TabIndex = 104;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // TipoProducto
            // 
            TipoProducto.Text = "Tipo de Producto";
            TipoProducto.Width = 90;
            // 
            // Cantidad
            // 
            Cantidad.Text = "Cantidad";
            Cantidad.Width = 140;
            // 
            // PrioridadText
            // 
            PrioridadText.Location = new Point(168, 132);
            PrioridadText.Margin = new Padding(3, 4, 3, 4);
            PrioridadText.Name = "PrioridadText";
            PrioridadText.ReadOnly = true;
            PrioridadText.Size = new Size(137, 27);
            PrioridadText.TabIndex = 128;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(167, 108);
            label10.Name = "label10";
            label10.Size = new Size(70, 20);
            label10.TabIndex = 127;
            label10.Text = "Prioridad";
            // 
            // CancelarDatosOrdenBtn
            // 
            CancelarDatosOrdenBtn.Location = new Point(248, 240);
            CancelarDatosOrdenBtn.Margin = new Padding(3, 4, 3, 4);
            CancelarDatosOrdenBtn.Name = "CancelarDatosOrdenBtn";
            CancelarDatosOrdenBtn.Size = new Size(98, 41);
            CancelarDatosOrdenBtn.TabIndex = 108;
            CancelarDatosOrdenBtn.Text = "Cancelar";
            CancelarDatosOrdenBtn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(7, 40);
            label1.Name = "label1";
            label1.Size = new Size(92, 20);
            label1.TabIndex = 81;
            label1.Text = "N° de Orden";
            // 
            // NumOrdenText
            // 
            NumOrdenText.Location = new Point(7, 67);
            NumOrdenText.Margin = new Padding(3, 4, 3, 4);
            NumOrdenText.Name = "NumOrdenText";
            NumOrdenText.ReadOnly = true;
            NumOrdenText.Size = new Size(138, 27);
            NumOrdenText.TabIndex = 82;
            // 
            // ConfirmarDatosOrdenBtn
            // 
            ConfirmarDatosOrdenBtn.Location = new Point(85, 240);
            ConfirmarDatosOrdenBtn.Margin = new Padding(3, 4, 3, 4);
            ConfirmarDatosOrdenBtn.Name = "ConfirmarDatosOrdenBtn";
            ConfirmarDatosOrdenBtn.Size = new Size(98, 41);
            ConfirmarDatosOrdenBtn.TabIndex = 95;
            ConfirmarDatosOrdenBtn.Text = "Confirmar";
            ConfirmarDatosOrdenBtn.UseVisualStyleBackColor = true;
            // 
            // FechaModificacionDT
            // 
            FechaModificacionDT.Enabled = false;
            FechaModificacionDT.Format = DateTimePickerFormat.Short;
            FechaModificacionDT.Location = new Point(323, 128);
            FechaModificacionDT.Margin = new Padding(3, 4, 3, 4);
            FechaModificacionDT.Name = "FechaModificacionDT";
            FechaModificacionDT.Size = new Size(93, 27);
            FechaModificacionDT.TabIndex = 99;
            FechaModificacionDT.Value = new DateTime(2024, 5, 16, 0, 0, 0, 0);
            // 
            // FechaCreacionDT
            // 
            FechaCreacionDT.Enabled = false;
            FechaCreacionDT.Format = DateTimePickerFormat.Short;
            FechaCreacionDT.Location = new Point(323, 64);
            FechaCreacionDT.Margin = new Padding(3, 4, 3, 4);
            FechaCreacionDT.Name = "FechaCreacionDT";
            FechaCreacionDT.Size = new Size(93, 27);
            FechaCreacionDT.TabIndex = 98;
            FechaCreacionDT.Value = new DateTime(2024, 5, 15, 0, 0, 0, 0);
            // 
            // EstadoCB
            // 
            EstadoCB.FormattingEnabled = true;
            EstadoCB.Items.AddRange(new object[] { "EnSeleccion", "Seleccionada", "Preparada", "Despachada" });
            EstadoCB.Location = new Point(168, 67);
            EstadoCB.Margin = new Padding(3, 4, 3, 4);
            EstadoCB.Name = "EstadoCB";
            EstadoCB.Size = new Size(138, 28);
            EstadoCB.TabIndex = 97;
            // 
            // ClienteText
            // 
            ClienteText.Location = new Point(7, 132);
            ClienteText.Margin = new Padding(3, 4, 3, 4);
            ClienteText.Name = "ClienteText";
            ClienteText.ReadOnly = true;
            ClienteText.Size = new Size(138, 27);
            ClienteText.TabIndex = 94;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(7, 105);
            label8.Name = "label8";
            label8.Size = new Size(55, 20);
            label8.TabIndex = 93;
            label8.Text = "Cliente";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(323, 40);
            label5.Name = "label5";
            label5.Size = new Size(130, 20);
            label5.TabIndex = 89;
            label5.Text = "Fecha de Creación";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(323, 101);
            label6.Name = "label6";
            label6.Size = new Size(159, 20);
            label6.TabIndex = 90;
            label6.Text = "Fecha de Modificación";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(168, 40);
            label7.Name = "label7";
            label7.Size = new Size(54, 20);
            label7.TabIndex = 91;
            label7.Text = "Estado";
            // 
            // SeleccionarBtn
            // 
            SeleccionarBtn.Location = new Point(514, 396);
            SeleccionarBtn.Margin = new Padding(3, 4, 3, 4);
            SeleccionarBtn.Name = "SeleccionarBtn";
            SeleccionarBtn.Size = new Size(98, 41);
            SeleccionarBtn.TabIndex = 105;
            SeleccionarBtn.Text = "Seleccionar";
            SeleccionarBtn.UseVisualStyleBackColor = true;
            // 
            // OrdenInt_List
            // 
            OrdenInt_List.Columns.AddRange(new ColumnHeader[] { N_Orden, Estado, Cliente, Prioridad, Fecha_Creacion });
            OrdenInt_List.FullRowSelect = true;
            OrdenInt_List.GridLines = true;
            OrdenInt_List.Location = new Point(14, 119);
            OrdenInt_List.Margin = new Padding(3, 4, 3, 4);
            OrdenInt_List.MultiSelect = false;
            OrdenInt_List.Name = "OrdenInt_List";
            OrdenInt_List.Size = new Size(598, 268);
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
            // Prioridad
            // 
            Prioridad.Text = "Prioridad";
            Prioridad.Width = 100;
            // 
            // Fecha_Creacion
            // 
            Fecha_Creacion.Text = "Fecha de Creación";
            Fecha_Creacion.Width = 140;
            // 
            // CambiarOrdenADespachadaForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(881, 791);
            Controls.Add(groupBox2);
            Controls.Add(DatosOrdenGroup);
            Controls.Add(SeleccionarBtn);
            Controls.Add(OrdenInt_List);
            Margin = new Padding(3, 4, 3, 4);
            Name = "CambiarOrdenADespachadaForm";
            Text = "CambiarOrdenADespachadaForm";
            Load += ModificarDespachadorForm_Load;
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            DatosOrdenGroup.ResumeLayout(false);
            DatosOrdenGroup.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox2;
        private Label label9;
        private TextBox NumeroOrdenInternaBuscarText;
        private Button BuscarBtn;
        private GroupBox DatosOrdenGroup;
        private ListView listView1;
        private ColumnHeader TipoProducto;
        private ColumnHeader Cantidad;
        private TextBox PrioridadText;
        private Label label10;
        private Button CancelarDatosOrdenBtn;
        private Label label1;
        private TextBox NumOrdenText;
        private TextBox NumOrdenIntText;
        private Button ConfirmarDatosOrdenBtn;
        private DateTimePicker FechaModificacionDT;
        private Label label2;
        private DateTimePicker FechaCreacionDT;
        private TextBox NumOrdExtText;
        private ComboBox EstadoCB;
        private Label label3;
        private TextBox CantidadText;
        private Button AceptarDatosOrdenBtn;
        private Label label4;
        private TextBox ClienteText;
        private TextBox TipoDeProductoText;
        private Label label8;
        private Label label5;
        private CheckBox checkBox1;
        private Label label6;
        private Label label7;
        private Button SeleccionarBtn;
        private ListView OrdenInt_List;
        private ColumnHeader N_Orden;
        private ColumnHeader N_Orden_Ext;
        private ColumnHeader N_Orden_In;
        private ColumnHeader Tipo_Producto;
        private ColumnHeader Cantidades;
        private ColumnHeader Cliente;
        private ColumnHeader Prioridad;
        private ColumnHeader Estado;
        private ColumnHeader Fecha_Creacion;

        public ColumnHeader Fecha_Entrega { get; private set; }

        private ColumnHeader Fecha_Modificacion;
        private Button CancelarBoton;
        private TextBox textBox1;
    }
}