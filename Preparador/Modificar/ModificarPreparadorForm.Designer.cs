namespace GrupoCProyectoCAI.Preparador.Modificar
{
    partial class ModificarPreparadorForm
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
            CancelarBoton = new Button();
            AceptarDatosOrdenBtn = new Button();
            ClienteText = new TextBox();
            label8 = new Label();
            checkBox1 = new CheckBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            TipoDeProductoText = new TextBox();
            label4 = new Label();
            CantidadText = new TextBox();
            label3 = new Label();
            NumOrdExtText = new TextBox();
            label2 = new Label();
            NumOrdenIntText = new TextBox();
            label1 = new Label();
            OrdenInt_List = new ListView();
            N_Orden_Ext = new ColumnHeader();
            N_Orden_In = new ColumnHeader();
            Tipo_Producto = new ColumnHeader();
            Cantidades = new ColumnHeader();
            Cliente = new ColumnHeader();
            Prioridad = new ColumnHeader();
            Estado = new ColumnHeader();
            Fecha_Creacion = new ColumnHeader();
            Fecha_Modificacion = new ColumnHeader();
            SeleccionarBtn = new Button();
            DatosOrdenGroup = new GroupBox();
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
            FechaModificacionDT.Location = new Point(6, 380);
            FechaModificacionDT.Name = "FechaModificacionDT";
            FechaModificacionDT.Size = new Size(82, 23);
            FechaModificacionDT.TabIndex = 99;
            FechaModificacionDT.Value = new DateTime(2024, 5, 16, 0, 0, 0, 0);
            // 
            // FechaCreacionDT
            // 
            FechaCreacionDT.Enabled = false;
            FechaCreacionDT.Format = DateTimePickerFormat.Short;
            FechaCreacionDT.Location = new Point(6, 332);
            FechaCreacionDT.Name = "FechaCreacionDT";
            FechaCreacionDT.Size = new Size(82, 23);
            FechaCreacionDT.TabIndex = 98;
            FechaCreacionDT.Value = new DateTime(2024, 5, 15, 0, 0, 0, 0);
            // 
            // EstadoCB
            // 
            EstadoCB.FormattingEnabled = true;
            EstadoCB.Items.AddRange(new object[] { "EnSeleccion", "Seleccionada", "Preparada", "Despachada" });
            EstadoCB.Location = new Point(6, 428);
            EstadoCB.Name = "EstadoCB";
            EstadoCB.Size = new Size(121, 23);
            EstadoCB.TabIndex = 97;
            // 
            // CancelarBoton
            // 
            CancelarBoton.Location = new Point(1229, 547);
            CancelarBoton.Name = "CancelarBoton";
            CancelarBoton.Size = new Size(75, 23);
            CancelarBoton.TabIndex = 96;
            CancelarBoton.Text = "Cancelar";
            CancelarBoton.UseVisualStyleBackColor = true;
            CancelarBoton.Click += CancelarBoton_Click;
            // 
            // AceptarDatosOrdenBtn
            // 
            AceptarDatosOrdenBtn.Location = new Point(90, 480);
            AceptarDatosOrdenBtn.Name = "AceptarDatosOrdenBtn";
            AceptarDatosOrdenBtn.Size = new Size(75, 23);
            AceptarDatosOrdenBtn.TabIndex = 95;
            AceptarDatosOrdenBtn.Text = "Aceptar";
            AceptarDatosOrdenBtn.UseVisualStyleBackColor = true;
            AceptarDatosOrdenBtn.Click += AceptarDatosOrdenBtn_Click;
            // 
            // ClienteText
            // 
            ClienteText.Location = new Point(6, 242);
            ClienteText.Name = "ClienteText";
            ClienteText.ReadOnly = true;
            ClienteText.Size = new Size(361, 23);
            ClienteText.TabIndex = 94;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 222);
            label8.Name = "label8";
            label8.Size = new Size(44, 15);
            label8.TabIndex = 93;
            label8.Text = "Cliente";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(6, 456);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(120, 19);
            checkBox1.TabIndex = 92;
            checkBox1.Text = "Listo para Entrega";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 408);
            label7.Name = "label7";
            label7.Size = new Size(42, 15);
            label7.TabIndex = 91;
            label7.Text = "Estado";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 360);
            label6.Name = "label6";
            label6.Size = new Size(127, 15);
            label6.TabIndex = 90;
            label6.Text = "Fecha de Modificación";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 312);
            label5.Name = "label5";
            label5.Size = new Size(104, 15);
            label5.TabIndex = 89;
            label5.Text = "Fecha de Creación";
            // 
            // TipoDeProductoText
            // 
            TipoDeProductoText.Location = new Point(6, 146);
            TipoDeProductoText.Name = "TipoDeProductoText";
            TipoDeProductoText.ReadOnly = true;
            TipoDeProductoText.Size = new Size(361, 23);
            TipoDeProductoText.TabIndex = 88;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 126);
            label4.Name = "label4";
            label4.Size = new Size(98, 15);
            label4.TabIndex = 87;
            label4.Text = "Tipo de Producto";
            // 
            // CantidadText
            // 
            CantidadText.Location = new Point(6, 194);
            CantidadText.Name = "CantidadText";
            CantidadText.Size = new Size(361, 23);
            CantidadText.TabIndex = 86;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 174);
            label3.Name = "label3";
            label3.Size = new Size(55, 15);
            label3.TabIndex = 85;
            label3.Text = "Cantidad";
            // 
            // NumOrdExtText
            // 
            NumOrdExtText.Location = new Point(6, 98);
            NumOrdExtText.Name = "NumOrdExtText";
            NumOrdExtText.ReadOnly = true;
            NumOrdExtText.Size = new Size(361, 23);
            NumOrdExtText.TabIndex = 84;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 78);
            label2.Name = "label2";
            label2.Size = new Size(115, 15);
            label2.TabIndex = 83;
            label2.Text = "N° de Orden Externa";
            // 
            // NumOrdenIntText
            // 
            NumOrdenIntText.Location = new Point(6, 50);
            NumOrdenIntText.Name = "NumOrdenIntText";
            NumOrdenIntText.ReadOnly = true;
            NumOrdenIntText.Size = new Size(361, 23);
            NumOrdenIntText.TabIndex = 82;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 30);
            label1.Name = "label1";
            label1.Size = new Size(113, 15);
            label1.TabIndex = 81;
            label1.Text = "N° de Orden Interna";
            // 
            // OrdenInt_List
            // 
            OrdenInt_List.Columns.AddRange(new ColumnHeader[] { N_Orden_Ext, N_Orden_In, Tipo_Producto, Cantidades, Cliente, Prioridad, Estado, Fecha_Creacion, Fecha_Modificacion });
            OrdenInt_List.FullRowSelect = true;
            OrdenInt_List.GridLines = true;
            OrdenInt_List.Location = new Point(12, 12);
            OrdenInt_List.MultiSelect = false;
            OrdenInt_List.Name = "OrdenInt_List";
            OrdenInt_List.Size = new Size(997, 441);
            OrdenInt_List.TabIndex = 80;
            OrdenInt_List.UseCompatibleStateImageBehavior = false;
            OrdenInt_List.View = View.Details;
            // 
            // N_Orden_Ext
            // 
            N_Orden_Ext.Text = "N° Orden Ext";
            N_Orden_Ext.Width = 90;
            // 
            // N_Orden_In
            // 
            N_Orden_In.Text = "N° Orden Int";
            N_Orden_In.Width = 90;
            // 
            // Tipo_Producto
            // 
            Tipo_Producto.Text = "Tipo Producto";
            Tipo_Producto.Width = 90;
            // 
            // Cantidades
            // 
            Cantidades.Text = "Cantidades";
            Cantidades.Width = 80;
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
            // Estado
            // 
            Estado.Text = "Estado";
            Estado.Width = 140;
            // 
            // Fecha_Creacion
            // 
            Fecha_Creacion.Text = "Fecha de Creación";
            Fecha_Creacion.Width = 140;
            // 
            // Fecha_Modificacion
            // 
            Fecha_Modificacion.Text = " Fecha de Modificacion";
            Fecha_Modificacion.Width = 140;
            // 
            // SeleccionarBtn
            // 
            SeleccionarBtn.Location = new Point(934, 459);
            SeleccionarBtn.Name = "SeleccionarBtn";
            SeleccionarBtn.Size = new Size(75, 23);
            SeleccionarBtn.TabIndex = 101;
            SeleccionarBtn.Text = "Seleccionar";
            SeleccionarBtn.UseVisualStyleBackColor = true;
            SeleccionarBtn.Click += SeleccionarBtn_Click;
            // 
            // DatosOrdenGroup
            // 
            DatosOrdenGroup.Controls.Add(PrioridadText);
            DatosOrdenGroup.Controls.Add(label10);
            DatosOrdenGroup.Controls.Add(CancelarDatosOrdenBtn);
            DatosOrdenGroup.Controls.Add(label1);
            DatosOrdenGroup.Controls.Add(NumOrdenIntText);
            DatosOrdenGroup.Controls.Add(FechaModificacionDT);
            DatosOrdenGroup.Controls.Add(label2);
            DatosOrdenGroup.Controls.Add(FechaCreacionDT);
            DatosOrdenGroup.Controls.Add(NumOrdExtText);
            DatosOrdenGroup.Controls.Add(EstadoCB);
            DatosOrdenGroup.Controls.Add(label3);
            DatosOrdenGroup.Controls.Add(CantidadText);
            DatosOrdenGroup.Controls.Add(AceptarDatosOrdenBtn);
            DatosOrdenGroup.Controls.Add(label4);
            DatosOrdenGroup.Controls.Add(ClienteText);
            DatosOrdenGroup.Controls.Add(TipoDeProductoText);
            DatosOrdenGroup.Controls.Add(label8);
            DatosOrdenGroup.Controls.Add(label5);
            DatosOrdenGroup.Controls.Add(checkBox1);
            DatosOrdenGroup.Controls.Add(label6);
            DatosOrdenGroup.Controls.Add(label7);
            DatosOrdenGroup.Enabled = false;
            DatosOrdenGroup.Location = new Point(1041, 12);
            DatosOrdenGroup.Name = "DatosOrdenGroup";
            DatosOrdenGroup.Size = new Size(380, 515);
            DatosOrdenGroup.TabIndex = 102;
            DatosOrdenGroup.TabStop = false;
            DatosOrdenGroup.Text = "Datos de la Orden";
            // 
            // PrioridadText
            // 
            PrioridadText.Location = new Point(6, 286);
            PrioridadText.Name = "PrioridadText";
            PrioridadText.ReadOnly = true;
            PrioridadText.Size = new Size(120, 23);
            PrioridadText.TabIndex = 128;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(6, 266);
            label10.Name = "label10";
            label10.Size = new Size(55, 15);
            label10.TabIndex = 127;
            label10.Text = "Prioridad";
            // 
            // CancelarDatosOrdenBtn
            // 
            CancelarDatosOrdenBtn.Location = new Point(219, 480);
            CancelarDatosOrdenBtn.Name = "CancelarDatosOrdenBtn";
            CancelarDatosOrdenBtn.Size = new Size(75, 23);
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
            groupBox2.Location = new Point(12, 482);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(464, 65);
            groupBox2.TabIndex = 103;
            groupBox2.TabStop = false;
            groupBox2.Text = "Busqueda";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(22, 30);
            label9.Name = "label9";
            label9.Size = new Size(143, 15);
            label9.TabIndex = 105;
            label9.Text = "Número de Orden Interna";
            // 
            // NumeroOrdenInternaBuscarText
            // 
            NumeroOrdenInternaBuscarText.Location = new Point(171, 27);
            NumeroOrdenInternaBuscarText.Name = "NumeroOrdenInternaBuscarText";
            NumeroOrdenInternaBuscarText.Size = new Size(196, 23);
            NumeroOrdenInternaBuscarText.TabIndex = 104;
            // 
            // BuscarBtn
            // 
            BuscarBtn.Location = new Point(376, 27);
            BuscarBtn.Name = "BuscarBtn";
            BuscarBtn.Size = new Size(75, 23);
            BuscarBtn.TabIndex = 106;
            BuscarBtn.Text = "Buscar";
            BuscarBtn.UseVisualStyleBackColor = true;
            BuscarBtn.Click += BuscarBtn_Click;
            // 
            // ModificarPreparadorForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1456, 573);
            Controls.Add(groupBox2);
            Controls.Add(DatosOrdenGroup);
            Controls.Add(SeleccionarBtn);
            Controls.Add(OrdenInt_List);
            Controls.Add(CancelarBoton);
            Name = "ModificarPreparadorForm";
            Text = "ModificarPreparadorForm";
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
        private Button CancelarBoton;
        private Button AceptarDatosOrdenBtn;
        private TextBox ClienteText;
        private Label label8;
        private CheckBox checkBox1;
        private Label label7;
        private Label label6;
        private Label label5;
        private TextBox TipoDeProductoText;
        private Label label4;
        private TextBox CantidadText;
        private Label label3;
        private TextBox NumOrdExtText;
        private Label label2;
        private TextBox NumOrdenIntText;
        private Label label1;
        private ListView OrdenInt_List;
        private ColumnHeader N_Orden_Ext;
        private ColumnHeader N_Orden_In;
        private ColumnHeader Tipo_Producto;
        private ColumnHeader Cantidades;
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
        private ColumnHeader Fecha_Modificacion;
    }
}