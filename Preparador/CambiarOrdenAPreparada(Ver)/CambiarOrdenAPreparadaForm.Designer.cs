namespace GrupoCProyectoCAI.Preparador.Modificar
{
    partial class CambiarOrdenAPreparadaForm
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
            FechaModificacionDT = new DateTimePicker();
            FechaCreacionDT = new DateTimePicker();
            EstadoCB = new ComboBox();
            ConfirmarDatosOrdenBtn = new Button();
            ClienteText = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            NumOrdenText = new TextBox();
            label1 = new Label();
            OrdenInt_List = new ListView();
            N_Orden = new ColumnHeader();
            Estado = new ColumnHeader();
            Cliente = new ColumnHeader();
            Prioridad = new ColumnHeader();
            Fecha_Creacion = new ColumnHeader();
            Fecha_Entrega = new ColumnHeader();
            SeleccionarBtn = new Button();
            DatosOrdenGroup = new GroupBox();
            listView1 = new ListView();
            TipoProducto = new ColumnHeader();
            Cantidad = new ColumnHeader();
            PrioridadText = new TextBox();
            label10 = new Label();
            CancelarDatosOrdenBtn = new Button();
            groupBox2 = new GroupBox();
            label9 = new Label();
            NumeroOrdenInternaBuscarText = new TextBox();
            BuscarBtn = new Button();
            DatosOrdenGroup.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // FechaModificacionDT
            // 
            FechaModificacionDT.Enabled = false;
            FechaModificacionDT.Format = DateTimePickerFormat.Short;
            FechaModificacionDT.Location = new Point(283, 96);
            FechaModificacionDT.Name = "FechaModificacionDT";
            FechaModificacionDT.Size = new Size(82, 23);
            FechaModificacionDT.TabIndex = 99;
            FechaModificacionDT.Value = new DateTime(2024, 5, 16, 0, 0, 0, 0);
            // 
            // FechaCreacionDT
            // 
            FechaCreacionDT.Enabled = false;
            FechaCreacionDT.Format = DateTimePickerFormat.Short;
            FechaCreacionDT.Location = new Point(283, 48);
            FechaCreacionDT.Name = "FechaCreacionDT";
            FechaCreacionDT.Size = new Size(82, 23);
            FechaCreacionDT.TabIndex = 98;
            FechaCreacionDT.Value = new DateTime(2024, 5, 15, 0, 0, 0, 0);
            // 
            // EstadoCB
            // 
            EstadoCB.FormattingEnabled = true;
            EstadoCB.Items.AddRange(new object[] { "EnSeleccion", "Seleccionada", "Preparada", "Despachada" });
            EstadoCB.Location = new Point(147, 50);
            EstadoCB.Name = "EstadoCB";
            EstadoCB.Size = new Size(121, 23);
            EstadoCB.TabIndex = 97;
            // 
            // ConfirmarDatosOrdenBtn
            // 
            ConfirmarDatosOrdenBtn.Location = new Point(76, 170);
            ConfirmarDatosOrdenBtn.Name = "ConfirmarDatosOrdenBtn";
            ConfirmarDatosOrdenBtn.Size = new Size(86, 31);
            ConfirmarDatosOrdenBtn.TabIndex = 95;
            ConfirmarDatosOrdenBtn.Text = "Confirmar";
            ConfirmarDatosOrdenBtn.UseVisualStyleBackColor = true;
            ConfirmarDatosOrdenBtn.Click += AceptarDatosOrdenBtn_Click;
            // 
            // ClienteText
            // 
            ClienteText.Location = new Point(6, 99);
            ClienteText.Name = "ClienteText";
            ClienteText.ReadOnly = true;
            ClienteText.Size = new Size(121, 23);
            ClienteText.TabIndex = 94;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 79);
            label8.Name = "label8";
            label8.Size = new Size(44, 15);
            label8.TabIndex = 93;
            label8.Text = "Cliente";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(147, 30);
            label7.Name = "label7";
            label7.Size = new Size(42, 15);
            label7.TabIndex = 91;
            label7.Text = "Estado";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(283, 76);
            label6.Name = "label6";
            label6.Size = new Size(97, 15);
            label6.TabIndex = 90;
            label6.Text = "Fecha de Entrega";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(283, 30);
            label5.Name = "label5";
            label5.Size = new Size(104, 15);
            label5.TabIndex = 89;
            label5.Text = "Fecha de Creación";
            // 
            // NumOrdenText
            // 
            NumOrdenText.Location = new Point(6, 50);
            NumOrdenText.Name = "NumOrdenText";
            NumOrdenText.ReadOnly = true;
            NumOrdenText.Size = new Size(121, 23);
            NumOrdenText.TabIndex = 82;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 30);
            label1.Name = "label1";
            label1.Size = new Size(73, 15);
            label1.TabIndex = 81;
            label1.Text = "N° de Orden";
            // 
            // OrdenInt_List
            // 
            OrdenInt_List.Columns.AddRange(new ColumnHeader[] { N_Orden, Estado, Cliente, Prioridad, Fecha_Creacion, Fecha_Entrega });
            OrdenInt_List.FullRowSelect = true;
            OrdenInt_List.GridLines = true;
            OrdenInt_List.Location = new Point(26, 83);
            OrdenInt_List.MultiSelect = false;
            OrdenInt_List.Name = "OrdenInt_List";
            OrdenInt_List.Size = new Size(738, 202);
            OrdenInt_List.TabIndex = 80;
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
            // Fecha_Entrega
            // 
            Fecha_Entrega.Text = " Fecha de Entrega";
            Fecha_Entrega.Width = 140;
            // 
            // SeleccionarBtn
            // 
            SeleccionarBtn.Location = new Point(678, 291);
            SeleccionarBtn.Name = "SeleccionarBtn";
            SeleccionarBtn.Size = new Size(86, 31);
            SeleccionarBtn.TabIndex = 101;
            SeleccionarBtn.Text = "Seleccionar";
            SeleccionarBtn.UseVisualStyleBackColor = true;
            SeleccionarBtn.Click += SeleccionarBtn_Click;
            // 
            // DatosOrdenGroup
            // 
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
            DatosOrdenGroup.Location = new Point(26, 328);
            DatosOrdenGroup.Name = "DatosOrdenGroup";
            DatosOrdenGroup.Size = new Size(738, 227);
            DatosOrdenGroup.TabIndex = 102;
            DatosOrdenGroup.TabStop = false;
            DatosOrdenGroup.Text = "Datos de la Orden";
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { TipoProducto, Cantidad });
            listView1.FullRowSelect = true;
            listView1.GridLines = true;
            listView1.Location = new Point(438, 30);
            listView1.MultiSelect = false;
            listView1.Name = "listView1";
            listView1.Size = new Size(237, 171);
            listView1.TabIndex = 104;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // TipoProducto
            // 
            TipoProducto.Text = "Tipo de Producto";
            TipoProducto.Width = 110;
            // 
            // Cantidad
            // 
            Cantidad.Text = "Cantidad";
            Cantidad.Width = 140;
            // 
            // PrioridadText
            // 
            PrioridadText.Location = new Point(147, 99);
            PrioridadText.Name = "PrioridadText";
            PrioridadText.ReadOnly = true;
            PrioridadText.Size = new Size(120, 23);
            PrioridadText.TabIndex = 128;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(146, 81);
            label10.Name = "label10";
            label10.Size = new Size(55, 15);
            label10.TabIndex = 127;
            label10.Text = "Prioridad";
            // 
            // CancelarDatosOrdenBtn
            // 
            CancelarDatosOrdenBtn.Location = new Point(219, 170);
            CancelarDatosOrdenBtn.Name = "CancelarDatosOrdenBtn";
            CancelarDatosOrdenBtn.Size = new Size(86, 31);
            CancelarDatosOrdenBtn.TabIndex = 108;
            CancelarDatosOrdenBtn.Text = "Cancelar";
            CancelarDatosOrdenBtn.UseVisualStyleBackColor = true;
            CancelarDatosOrdenBtn.Click += CancelarDatosOrdenBtn_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(NumeroOrdenInternaBuscarText);
            groupBox2.Controls.Add(BuscarBtn);
            groupBox2.Location = new Point(26, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(428, 65);
            groupBox2.TabIndex = 103;
            groupBox2.TabStop = false;
            groupBox2.Text = "Busqueda";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(22, 30);
            label9.Name = "label9";
            label9.Size = new Size(103, 15);
            label9.TabIndex = 105;
            label9.Text = "Número de Orden";
            // 
            // NumeroOrdenInternaBuscarText
            // 
            NumeroOrdenInternaBuscarText.Location = new Point(131, 27);
            NumeroOrdenInternaBuscarText.Name = "NumeroOrdenInternaBuscarText";
            NumeroOrdenInternaBuscarText.Size = new Size(196, 23);
            NumeroOrdenInternaBuscarText.TabIndex = 104;
            // 
            // BuscarBtn
            // 
            BuscarBtn.Location = new Point(333, 22);
            BuscarBtn.Name = "BuscarBtn";
            BuscarBtn.Size = new Size(86, 31);
            BuscarBtn.TabIndex = 106;
            BuscarBtn.Text = "Buscar";
            BuscarBtn.UseVisualStyleBackColor = true;
            BuscarBtn.Click += BuscarBtn_Click;
            // 
            // CambiarOrdenAPreparadaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(773, 567);
            Controls.Add(groupBox2);
            Controls.Add(DatosOrdenGroup);
            Controls.Add(SeleccionarBtn);
            Controls.Add(OrdenInt_List);
            Name = "CambiarOrdenAPreparadaForm";
            Text = "CambiarOrdenAPreparadaForm";
            Load += ModificarPreparadorForm_Load;
            DatosOrdenGroup.ResumeLayout(false);
            DatosOrdenGroup.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DateTimePicker FechaModificacionDT;
        private DateTimePicker FechaCreacionDT;
        private ComboBox EstadoCB;
        private Button ConfirmarDatosOrdenBtn;
        private TextBox ClienteText;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private TextBox NumOrdenText;
        private Label label1;
        private ListView OrdenInt_List;
        private ColumnHeader N_Orden_Ext;
        private ColumnHeader N_Orden;
        private ColumnHeader Cliente;
        private ColumnHeader Prioridad;
        private ColumnHeader Estado;
        private ColumnHeader Fecha_Creacion;
        private Button SeleccionarBtn;
        private GroupBox DatosOrdenGroup;
        private GroupBox groupBox2;
        private Label label9;
        private Button CancelarBusquedaBtn;
        private TextBox NumeroOrdenInternaBuscarText;
        private Button BuscarBtn;
        private Button CancelarDatosOrdenBtn;
        private TextBox PrioridadText;
        private Label label10;
        private ColumnHeader Fecha_Entrega;
        private ListView listView1;
        private ColumnHeader TipoProducto;
        private ColumnHeader Cantidad;
    }
}