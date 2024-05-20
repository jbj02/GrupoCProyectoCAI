namespace GrupoCProyectoCAI.Preparador.NuevaOrden
{
    partial class NuevaOrdenPreparadorForm
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
            SeleccionarBtn = new Button();
            FechaCreacionDT = new DateTimePicker();
            VovlerBoton = new Button();
            AceptarDatosNuevaOrdenInternaBtn = new Button();
            ClienteText = new TextBox();
            label8 = new Label();
            label5 = new Label();
            TipoDeProductoText = new TextBox();
            label4 = new Label();
            CantidadText = new TextBox();
            label3 = new Label();
            NumOrdExtText = new TextBox();
            label2 = new Label();
            NumOrdenIntText = new TextBox();
            label1 = new Label();
            OrdenExt_List = new ListView();
            Num_Orden_Ext = new ColumnHeader();
            Tipo_Producto = new ColumnHeader();
            Cantidad = new ColumnHeader();
            Cliente = new ColumnHeader();
            Prioridad = new ColumnHeader();
            Fecha_Creacion = new ColumnHeader();
            label9 = new Label();
            PrioridadText = new TextBox();
            label6 = new Label();
            DatosNuevaOrdenInternaGroup = new GroupBox();
            CancelarDatosNuevaOrdenInternaBtn = new Button();
            groupBox1 = new GroupBox();
            label10 = new Label();
            NumeroOrdenExternaBuscarText = new TextBox();
            BuscarBtn = new Button();
            DatosNuevaOrdenInternaGroup.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // SeleccionarBtn
            // 
            SeleccionarBtn.Location = new Point(478, 508);
            SeleccionarBtn.Name = "SeleccionarBtn";
            SeleccionarBtn.Size = new Size(97, 32);
            SeleccionarBtn.TabIndex = 122;
            SeleccionarBtn.Text = "Seleccionar";
            SeleccionarBtn.UseVisualStyleBackColor = true;
            SeleccionarBtn.Click += SeleccionarBtn_Click;
            // 
            // FechaCreacionDT
            // 
            FechaCreacionDT.Enabled = false;
            FechaCreacionDT.Format = DateTimePickerFormat.Short;
            FechaCreacionDT.Location = new Point(6, 344);
            FechaCreacionDT.Name = "FechaCreacionDT";
            FechaCreacionDT.Size = new Size(82, 23);
            FechaCreacionDT.TabIndex = 120;
            FechaCreacionDT.Value = new DateTime(2024, 5, 15, 0, 0, 0, 0);
            // 
            // VovlerBoton
            // 
            VovlerBoton.Location = new Point(610, 508);
            VovlerBoton.Name = "VovlerBoton";
            VovlerBoton.Size = new Size(97, 32);
            VovlerBoton.TabIndex = 118;
            VovlerBoton.Text = "Volver";
            VovlerBoton.UseVisualStyleBackColor = true;
            VovlerBoton.Click += VolverBoton_Click;
            // 
            // AceptarDatosNuevaOrdenInternaBtn
            // 
            AceptarDatosNuevaOrdenInternaBtn.Location = new Point(80, 372);
            AceptarDatosNuevaOrdenInternaBtn.Name = "AceptarDatosNuevaOrdenInternaBtn";
            AceptarDatosNuevaOrdenInternaBtn.Size = new Size(97, 32);
            AceptarDatosNuevaOrdenInternaBtn.TabIndex = 117;
            AceptarDatosNuevaOrdenInternaBtn.Text = "Aceptar";
            AceptarDatosNuevaOrdenInternaBtn.UseVisualStyleBackColor = true;
            AceptarDatosNuevaOrdenInternaBtn.Click += AceptarDatosNuevaOrdenInternaBtn_Click;
            // 
            // ClienteText
            // 
            ClienteText.Location = new Point(6, 248);
            ClienteText.Name = "ClienteText";
            ClienteText.ReadOnly = true;
            ClienteText.Size = new Size(361, 23);
            ClienteText.TabIndex = 116;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 228);
            label8.Name = "label8";
            label8.Size = new Size(44, 15);
            label8.TabIndex = 115;
            label8.Text = "Cliente";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 324);
            label5.Name = "label5";
            label5.Size = new Size(104, 15);
            label5.TabIndex = 111;
            label5.Text = "Fecha de Creación";
            // 
            // TipoDeProductoText
            // 
            TipoDeProductoText.Location = new Point(6, 152);
            TipoDeProductoText.Name = "TipoDeProductoText";
            TipoDeProductoText.ReadOnly = true;
            TipoDeProductoText.Size = new Size(361, 23);
            TipoDeProductoText.TabIndex = 110;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 132);
            label4.Name = "label4";
            label4.Size = new Size(98, 15);
            label4.TabIndex = 109;
            label4.Text = "Tipo de Producto";
            // 
            // CantidadText
            // 
            CantidadText.Location = new Point(6, 200);
            CantidadText.Name = "CantidadText";
            CantidadText.Size = new Size(361, 23);
            CantidadText.TabIndex = 108;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 180);
            label3.Name = "label3";
            label3.Size = new Size(55, 15);
            label3.TabIndex = 107;
            label3.Text = "Cantidad";
            // 
            // NumOrdExtText
            // 
            NumOrdExtText.Location = new Point(6, 104);
            NumOrdExtText.Name = "NumOrdExtText";
            NumOrdExtText.ReadOnly = true;
            NumOrdExtText.Size = new Size(361, 23);
            NumOrdExtText.TabIndex = 106;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 84);
            label2.Name = "label2";
            label2.Size = new Size(115, 15);
            label2.TabIndex = 105;
            label2.Text = "N° de Orden Externa";
            // 
            // NumOrdenIntText
            // 
            NumOrdenIntText.Location = new Point(6, 56);
            NumOrdenIntText.Name = "NumOrdenIntText";
            NumOrdenIntText.ReadOnly = true;
            NumOrdenIntText.Size = new Size(361, 23);
            NumOrdenIntText.TabIndex = 104;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 36);
            label1.Name = "label1";
            label1.Size = new Size(113, 15);
            label1.TabIndex = 103;
            label1.Text = "N° de Orden Interna";
            // 
            // OrdenExt_List
            // 
            OrdenExt_List.Columns.AddRange(new ColumnHeader[] { Num_Orden_Ext, Tipo_Producto, Cantidad, Cliente, Prioridad, Fecha_Creacion });
            OrdenExt_List.FullRowSelect = true;
            OrdenExt_List.GridLines = true;
            OrdenExt_List.Location = new Point(38, 83);
            OrdenExt_List.MultiSelect = false;
            OrdenExt_List.Name = "OrdenExt_List";
            OrdenExt_List.Size = new Size(669, 419);
            OrdenExt_List.TabIndex = 123;
            OrdenExt_List.UseCompatibleStateImageBehavior = false;
            OrdenExt_List.View = View.Details;
            // 
            // Num_Orden_Ext
            // 
            Num_Orden_Ext.Text = "N° Orden Ext";
            Num_Orden_Ext.Width = 120;
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
            // Cliente
            // 
            Cliente.Text = "Cliente";
            Cliente.Width = 120;
            // 
            // Prioridad
            // 
            Prioridad.Text = "Prioridad";
            // 
            // Fecha_Creacion
            // 
            Fecha_Creacion.Text = "Fecha de Creación";
            Fecha_Creacion.Width = 120;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(783, 42);
            label9.Name = "label9";
            label9.Size = new Size(0, 15);
            label9.TabIndex = 124;
            // 
            // PrioridadText
            // 
            PrioridadText.Location = new Point(6, 296);
            PrioridadText.Name = "PrioridadText";
            PrioridadText.ReadOnly = true;
            PrioridadText.Size = new Size(120, 23);
            PrioridadText.TabIndex = 126;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 276);
            label6.Name = "label6";
            label6.Size = new Size(55, 15);
            label6.TabIndex = 125;
            label6.Text = "Prioridad";
            // 
            // DatosNuevaOrdenInternaGroup
            // 
            DatosNuevaOrdenInternaGroup.Controls.Add(CancelarDatosNuevaOrdenInternaBtn);
            DatosNuevaOrdenInternaGroup.Controls.Add(TipoDeProductoText);
            DatosNuevaOrdenInternaGroup.Controls.Add(label1);
            DatosNuevaOrdenInternaGroup.Controls.Add(PrioridadText);
            DatosNuevaOrdenInternaGroup.Controls.Add(NumOrdenIntText);
            DatosNuevaOrdenInternaGroup.Controls.Add(label6);
            DatosNuevaOrdenInternaGroup.Controls.Add(AceptarDatosNuevaOrdenInternaBtn);
            DatosNuevaOrdenInternaGroup.Controls.Add(label2);
            DatosNuevaOrdenInternaGroup.Controls.Add(NumOrdExtText);
            DatosNuevaOrdenInternaGroup.Controls.Add(label3);
            DatosNuevaOrdenInternaGroup.Controls.Add(CantidadText);
            DatosNuevaOrdenInternaGroup.Controls.Add(FechaCreacionDT);
            DatosNuevaOrdenInternaGroup.Controls.Add(label4);
            DatosNuevaOrdenInternaGroup.Controls.Add(label5);
            DatosNuevaOrdenInternaGroup.Controls.Add(label8);
            DatosNuevaOrdenInternaGroup.Controls.Add(ClienteText);
            DatosNuevaOrdenInternaGroup.Enabled = false;
            DatosNuevaOrdenInternaGroup.Location = new Point(754, 83);
            DatosNuevaOrdenInternaGroup.Name = "DatosNuevaOrdenInternaGroup";
            DatosNuevaOrdenInternaGroup.Size = new Size(380, 416);
            DatosNuevaOrdenInternaGroup.TabIndex = 128;
            DatosNuevaOrdenInternaGroup.TabStop = false;
            DatosNuevaOrdenInternaGroup.Text = "Datos de nueva orden interna";
            // 
            // CancelarDatosNuevaOrdenInternaBtn
            // 
            CancelarDatosNuevaOrdenInternaBtn.Location = new Point(206, 372);
            CancelarDatosNuevaOrdenInternaBtn.Name = "CancelarDatosNuevaOrdenInternaBtn";
            CancelarDatosNuevaOrdenInternaBtn.Size = new Size(97, 32);
            CancelarDatosNuevaOrdenInternaBtn.TabIndex = 129;
            CancelarDatosNuevaOrdenInternaBtn.Text = "Cancelar";
            CancelarDatosNuevaOrdenInternaBtn.UseVisualStyleBackColor = true;
            CancelarDatosNuevaOrdenInternaBtn.Click += CancelarDatosNuevaOrdenInternaBtn_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(NumeroOrdenExternaBuscarText);
            groupBox1.Controls.Add(BuscarBtn);
            groupBox1.Location = new Point(38, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(464, 65);
            groupBox1.TabIndex = 129;
            groupBox1.TabStop = false;
            groupBox1.Text = "Busqueda";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(22, 30);
            label10.Name = "label10";
            label10.Size = new Size(145, 15);
            label10.TabIndex = 105;
            label10.Text = "Número de Orden Externa";
            // 
            // NumeroOrdenExternaBuscarText
            // 
            NumeroOrdenExternaBuscarText.Location = new Point(171, 27);
            NumeroOrdenExternaBuscarText.Name = "NumeroOrdenExternaBuscarText";
            NumeroOrdenExternaBuscarText.Size = new Size(196, 23);
            NumeroOrdenExternaBuscarText.TabIndex = 104;
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
            // NuevaOrdenPreparadorForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1172, 548);
            Controls.Add(groupBox1);
            Controls.Add(DatosNuevaOrdenInternaGroup);
            Controls.Add(label9);
            Controls.Add(OrdenExt_List);
            Controls.Add(SeleccionarBtn);
            Controls.Add(VovlerBoton);
            Name = "NuevaOrdenPreparadorForm";
            Text = "NuevaOrdenPreparadorForm";
            Load += NuevaOrdenPreparadorForm_Load;
            DatosNuevaOrdenInternaGroup.ResumeLayout(false);
            DatosNuevaOrdenInternaGroup.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button SeleccionarBtn;
        private DateTimePicker FechaCreacionDT;
        private Button VovlerBoton;
        private Button AceptarDatosNuevaOrdenInternaBtn;
        private TextBox ClienteText;
        private Label label8;
        private Label label5;
        private TextBox TipoDeProductoText;
        private Label label4;
        private TextBox CantidadText;
        private Label label3;
        private TextBox NumOrdExtText;
        private Label label2;
        private TextBox NumOrdenIntText;
        private Label label1;
        private ListView OrdenExt_List;
        private ColumnHeader Num_Orden_Ext;
        private ColumnHeader Tipo_Producto;
        private ColumnHeader Cantidad;
        private ColumnHeader Cliente;
        private ColumnHeader Prioridad;
        private ColumnHeader Fecha_Creacion;
        private Label label9;
        private TextBox PrioridadText;
        private Label label6;
        private GroupBox DatosNuevaOrdenInternaGroup;
        private Button CancelarDatosNuevaOrdenInternaBtn;
        private GroupBox groupBox1;
        private Label label10;
        private TextBox NumeroOrdenExternaBuscarText;
        private Button BuscarBtn;
    }
}