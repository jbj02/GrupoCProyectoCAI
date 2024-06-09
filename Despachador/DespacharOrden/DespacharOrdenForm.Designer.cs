namespace GrupoCProyectoCAI.Despachador.DespacharOrden
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
            label9 = new Label();
            TransportistaTxt = new TextBox();
            label1 = new Label();
            FiltrarBtn = new Button();
            FechaDespachoTxt = new TextBox();
            SelecionarBtn = new Button();
            ConfirmarYRemitoBtn = new Button();
            OrdenesPreparadasList = new ListView();
            N_Orden = new ColumnHeader();
            Cliente = new ColumnHeader();
            Transportista = new ColumnHeader();
            FechaDespacho = new ColumnHeader();
            CancelarBtn = new Button();
            label2 = new Label();
            label5 = new Label();
            OrdenesDespachadasList = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            DesseleccionarBtn = new Button();
            SeleccionarTodasBtn = new Button();
            ReestablecerBtn = new Button();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(TransportistaTxt);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(FiltrarBtn);
            groupBox2.Controls.Add(FechaDespachoTxt);
            groupBox2.Location = new Point(12, 18);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(305, 129);
            groupBox2.TabIndex = 107;
            groupBox2.TabStop = false;
            groupBox2.Text = "Filtrar";
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
            // TransportistaTxt
            // 
            TransportistaTxt.Location = new Point(22, 37);
            TransportistaTxt.Name = "TransportistaTxt";
            TransportistaTxt.Size = new Size(132, 23);
            TransportistaTxt.TabIndex = 104;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 64);
            label1.Name = "label1";
            label1.Size = new Size(109, 15);
            label1.TabIndex = 108;
            label1.Text = "Fecha de Despacho";
            // 
            // FiltrarBtn
            // 
            FiltrarBtn.Location = new Point(174, 57);
            FiltrarBtn.Name = "FiltrarBtn";
            FiltrarBtn.Size = new Size(80, 28);
            FiltrarBtn.TabIndex = 106;
            FiltrarBtn.Text = "Filtrar";
            FiltrarBtn.UseVisualStyleBackColor = true;
            FiltrarBtn.Click += FiltrarBtn_Click;
            // 
            // FechaDespachoTxt
            // 
            FechaDespachoTxt.Location = new Point(22, 82);
            FechaDespachoTxt.Name = "FechaDespachoTxt";
            FechaDespachoTxt.Size = new Size(132, 23);
            FechaDespachoTxt.TabIndex = 107;
            // 
            // SelecionarBtn
            // 
            SelecionarBtn.Location = new Point(350, 404);
            SelecionarBtn.Name = "SelecionarBtn";
            SelecionarBtn.Size = new Size(80, 28);
            SelecionarBtn.TabIndex = 109;
            SelecionarBtn.Text = "Seleccionar";
            SelecionarBtn.UseVisualStyleBackColor = true;
            SelecionarBtn.Click += SeleccionarBtn_Click;
            // 
            // ConfirmarYRemitoBtn
            // 
            ConfirmarYRemitoBtn.Location = new Point(585, 463);
            ConfirmarYRemitoBtn.Name = "ConfirmarYRemitoBtn";
            ConfirmarYRemitoBtn.Size = new Size(308, 31);
            ConfirmarYRemitoBtn.TabIndex = 105;
            ConfirmarYRemitoBtn.Text = "Confirmar + Generar remito (en archivo)";
            ConfirmarYRemitoBtn.UseVisualStyleBackColor = true;
            ConfirmarYRemitoBtn.Click += ConfirmarYRemitoBtn_Click;
            // 
            // OrdenesPreparadasList
            // 
            OrdenesPreparadasList.Columns.AddRange(new ColumnHeader[] { N_Orden, Cliente, Transportista, FechaDespacho });
            OrdenesPreparadasList.FullRowSelect = true;
            OrdenesPreparadasList.GridLines = true;
            OrdenesPreparadasList.Location = new Point(12, 196);
            OrdenesPreparadasList.MultiSelect = false;
            OrdenesPreparadasList.Name = "OrdenesPreparadasList";
            OrdenesPreparadasList.Size = new Size(418, 202);
            OrdenesPreparadasList.TabIndex = 104;
            OrdenesPreparadasList.UseCompatibleStateImageBehavior = false;
            OrdenesPreparadasList.View = View.Details;
            // 
            // N_Orden
            // 
            N_Orden.Text = "N° Orden";
            N_Orden.Width = 90;
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
            // FechaDespacho
            // 
            FechaDespacho.Text = "Fecha de Despacho";
            FechaDespacho.Width = 140;
            // 
            // CancelarBtn
            // 
            CancelarBtn.Location = new Point(669, 510);
            CancelarBtn.Name = "CancelarBtn";
            CancelarBtn.Size = new Size(224, 31);
            CancelarBtn.TabIndex = 108;
            CancelarBtn.Text = "Cancelar";
            CancelarBtn.UseVisualStyleBackColor = true;
            CancelarBtn.Click += CancelarBtn_Click;
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
            label5.Location = new Point(473, 166);
            label5.Name = "label5";
            label5.Size = new Size(123, 15);
            label5.TabIndex = 111;
            label5.Text = "Ordenes Despachadas";
            // 
            // OrdenesDespachadasList
            // 
            OrdenesDespachadasList.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader3, columnHeader4, columnHeader5 });
            OrdenesDespachadasList.FullRowSelect = true;
            OrdenesDespachadasList.GridLines = true;
            OrdenesDespachadasList.Location = new Point(473, 196);
            OrdenesDespachadasList.MultiSelect = false;
            OrdenesDespachadasList.Name = "OrdenesDespachadasList";
            OrdenesDespachadasList.Size = new Size(420, 202);
            OrdenesDespachadasList.TabIndex = 110;
            OrdenesDespachadasList.UseCompatibleStateImageBehavior = false;
            OrdenesDespachadasList.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "N° Orden";
            columnHeader1.Width = 90;
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
            columnHeader5.Text = "Fecha de Despacho";
            columnHeader5.Width = 140;
            // 
            // DesseleccionarBtn
            // 
            DesseleccionarBtn.Location = new Point(791, 404);
            DesseleccionarBtn.Name = "DesseleccionarBtn";
            DesseleccionarBtn.Size = new Size(102, 28);
            DesseleccionarBtn.TabIndex = 112;
            DesseleccionarBtn.Text = "Deseleccionar";
            DesseleccionarBtn.UseVisualStyleBackColor = true;
            DesseleccionarBtn.Click += DesseleccionarBtn_Click;
            // 
            // SeleccionarTodasBtn
            // 
            SeleccionarTodasBtn.Location = new Point(216, 404);
            SeleccionarTodasBtn.Name = "SeleccionarTodasBtn";
            SeleccionarTodasBtn.Size = new Size(128, 28);
            SeleccionarTodasBtn.TabIndex = 113;
            SeleccionarTodasBtn.Text = "Seleccionar todas";
            SeleccionarTodasBtn.UseVisualStyleBackColor = true;
            SeleccionarTodasBtn.Click += SeleccionarTodasBtn_Click;
            // 
            // ReestablecerBtn
            // 
            ReestablecerBtn.Location = new Point(118, 404);
            ReestablecerBtn.Name = "ReestablecerBtn";
            ReestablecerBtn.Size = new Size(92, 28);
            ReestablecerBtn.TabIndex = 114;
            ReestablecerBtn.Text = "Reestablecer";
            ReestablecerBtn.UseVisualStyleBackColor = true;
            ReestablecerBtn.Click += ReestablecerBtn_Click;
            // 
            // DespacharOrdenForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(915, 574);
            Controls.Add(ReestablecerBtn);
            Controls.Add(SeleccionarTodasBtn);
            Controls.Add(DesseleccionarBtn);
            Controls.Add(label5);
            Controls.Add(SelecionarBtn);
            Controls.Add(OrdenesDespachadasList);
            Controls.Add(label2);
            Controls.Add(CancelarBtn);
            Controls.Add(groupBox2);
            Controls.Add(ConfirmarYRemitoBtn);
            Controls.Add(OrdenesPreparadasList);
            Name = "DespacharOrdenForm";
            Text = "DespacharOrdenForm";
            Load += DespacharOrdenForm_Load;
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox2;
        private Label label9;
        private TextBox TransportistaTxt;
        private Button FiltrarBtn;
        private TextBox NumOrdenIntText;
        private TextBox NumOrdExtText;
        private Label label3;
        private TextBox CantidadText;
        private Button AceptarDatosOrdenBtn;
        private Label label4;
        private TextBox TipoDeProductoText;
        private CheckBox checkBox1;
        private Button ConfirmarYRemitoBtn;
        private ListView OrdenesPreparadasList;
        private ColumnHeader N_Orden;
        private ColumnHeader N_Orden_Ext;
        private ColumnHeader N_Orden_In;
        private ColumnHeader Tipo_Producto;
        private ColumnHeader Cantidades;
        private ColumnHeader Cliente;
        private ColumnHeader Estado;
        private ColumnHeader FechaDespacho;

        public ColumnHeader Fecha_Entrega { get; private set; }

        private ColumnHeader Fecha_Modificacion;
        private Button CancelarBoton;
        private ColumnHeader Transportista;
        private Label label1;
        private TextBox FechaDespachoTxt;
        private Button SelecionarBtn;
        private Label label2;
        private Label label5;
        private ListView OrdenesDespachadasList;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private Button DesseleccionarBtn;
        private Button SeleccionarTodasBtn;
        private Button CancelarBtn;
        private Button ReestablecerBtn;
    }
}