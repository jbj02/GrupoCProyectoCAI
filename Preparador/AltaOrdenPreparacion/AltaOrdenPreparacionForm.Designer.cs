namespace GrupoCProyectoCAI
{
    partial class AltaOrdenPreparacionForm
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
            CancelarBtn = new Button();
            ClienteCmb = new ComboBox();
            ClienteLbl = new Label();
            TransportistaLbl = new Label();
            TransportistaCmb = new ComboBox();
            FechaDeDespachoDtp = new DateTimePicker();
            FechaDespachoLbl = new Label();
            ProductosList = new ListView();
            CodigoDeProducto = new ColumnHeader();
            Nombre = new ColumnHeader();
            Cantidad = new ColumnHeader();
            AgregarProductosBtn = new Button();
            label7 = new Label();
            label10 = new Label();
            BorrarSeleccionadoBtn = new Button();
            ConfirmarBtn = new Button();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            CantidadNum = new NumericUpDown();
            ProductoCmb = new ComboBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)CantidadNum).BeginInit();
            SuspendLayout();
            // 
            // CancelarBtn
            // 
            CancelarBtn.Location = new Point(358, 568);
            CancelarBtn.Name = "CancelarBtn";
            CancelarBtn.Size = new Size(108, 32);
            CancelarBtn.TabIndex = 138;
            CancelarBtn.Text = "Cancelar";
            CancelarBtn.UseVisualStyleBackColor = true;
            CancelarBtn.Click += CancelarBtn_Click;
            // 
            // ClienteCmb
            // 
            ClienteCmb.DropDownStyle = ComboBoxStyle.DropDownList;
            ClienteCmb.FormattingEnabled = true;
            ClienteCmb.Location = new Point(15, 48);
            ClienteCmb.Name = "ClienteCmb";
            ClienteCmb.Size = new Size(424, 23);
            ClienteCmb.TabIndex = 140;
            ClienteCmb.SelectedIndexChanged += ClienteCmb_SelectedIndexChanged;
            // 
            // ClienteLbl
            // 
            ClienteLbl.AutoSize = true;
            ClienteLbl.Location = new Point(14, 27);
            ClienteLbl.Name = "ClienteLbl";
            ClienteLbl.Size = new Size(44, 15);
            ClienteLbl.TabIndex = 141;
            ClienteLbl.Text = "Cliente";
            // 
            // TransportistaLbl
            // 
            TransportistaLbl.AutoSize = true;
            TransportistaLbl.Location = new Point(15, 81);
            TransportistaLbl.Name = "TransportistaLbl";
            TransportistaLbl.Size = new Size(74, 15);
            TransportistaLbl.TabIndex = 143;
            TransportistaLbl.Text = "Transportista";
            // 
            // TransportistaCmb
            // 
            TransportistaCmb.DropDownStyle = ComboBoxStyle.DropDownList;
            TransportistaCmb.FormattingEnabled = true;
            TransportistaCmb.Location = new Point(15, 99);
            TransportistaCmb.Name = "TransportistaCmb";
            TransportistaCmb.Size = new Size(424, 23);
            TransportistaCmb.TabIndex = 142;
            TransportistaCmb.SelectedIndexChanged += TransportistaCmb_SelectedIndexChanged;
            // 
            // FechaDeDespachoDtp
            // 
            FechaDeDespachoDtp.Format = DateTimePickerFormat.Short;
            FechaDeDespachoDtp.Location = new Point(15, 152);
            FechaDeDespachoDtp.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            FechaDeDespachoDtp.Name = "FechaDeDespachoDtp";
            FechaDeDespachoDtp.Size = new Size(158, 23);
            FechaDeDespachoDtp.TabIndex = 137;
            FechaDeDespachoDtp.Value = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            // 
            // FechaDespachoLbl
            // 
            FechaDespachoLbl.AutoSize = true;
            FechaDespachoLbl.Location = new Point(15, 134);
            FechaDespachoLbl.Name = "FechaDespachoLbl";
            FechaDespachoLbl.Size = new Size(108, 15);
            FechaDespachoLbl.TabIndex = 136;
            FechaDespachoLbl.Text = "Fecha de despacho";
            // 
            // ProductosList
            // 
            ProductosList.Columns.AddRange(new ColumnHeader[] { CodigoDeProducto, Nombre, Cantidad });
            ProductosList.FullRowSelect = true;
            ProductosList.GridLines = true;
            ProductosList.Location = new Point(15, 109);
            ProductosList.MultiSelect = false;
            ProductosList.Name = "ProductosList";
            ProductosList.Size = new Size(425, 190);
            ProductosList.TabIndex = 141;
            ProductosList.UseCompatibleStateImageBehavior = false;
            ProductosList.View = View.Details;
            // 
            // CodigoDeProducto
            // 
            CodigoDeProducto.Text = "Código";
            CodigoDeProducto.Width = 100;
            // 
            // Nombre
            // 
            Nombre.Text = "Producto";
            Nombre.Width = 220;
            // 
            // Cantidad
            // 
            Cantidad.Text = "Cantidad";
            Cantidad.Width = 100;
            // 
            // AgregarProductosBtn
            // 
            AgregarProductosBtn.Location = new Point(325, 76);
            AgregarProductosBtn.Name = "AgregarProductosBtn";
            AgregarProductosBtn.Size = new Size(115, 24);
            AgregarProductosBtn.TabIndex = 140;
            AgregarProductosBtn.Text = "Agregar";
            AgregarProductosBtn.UseVisualStyleBackColor = true;
            AgregarProductosBtn.Click += AgregarProductosBtn_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(329, 26);
            label7.Name = "label7";
            label7.Size = new Size(55, 15);
            label7.TabIndex = 136;
            label7.Text = "Cantidad";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(15, 26);
            label10.Name = "label10";
            label10.Size = new Size(56, 15);
            label10.TabIndex = 138;
            label10.Text = "Producto";
            // 
            // BorrarSeleccionadoBtn
            // 
            BorrarSeleccionadoBtn.Location = new Point(293, 305);
            BorrarSeleccionadoBtn.Name = "BorrarSeleccionadoBtn";
            BorrarSeleccionadoBtn.Size = new Size(147, 24);
            BorrarSeleccionadoBtn.TabIndex = 144;
            BorrarSeleccionadoBtn.Text = "Borrar seleccionado";
            BorrarSeleccionadoBtn.UseVisualStyleBackColor = true;
            BorrarSeleccionadoBtn.Click += BorrarSeleccionadoBtn_Click;
            // 
            // ConfirmarBtn
            // 
            ConfirmarBtn.Location = new Point(244, 568);
            ConfirmarBtn.Name = "ConfirmarBtn";
            ConfirmarBtn.Size = new Size(108, 32);
            ConfirmarBtn.TabIndex = 145;
            ConfirmarBtn.Text = "Confirmar";
            ConfirmarBtn.UseVisualStyleBackColor = true;
            ConfirmarBtn.Click += ConfirmarBtn_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(FechaDeDespachoDtp);
            groupBox1.Controls.Add(TransportistaLbl);
            groupBox1.Controls.Add(FechaDespachoLbl);
            groupBox1.Controls.Add(TransportistaCmb);
            groupBox1.Controls.Add(ClienteLbl);
            groupBox1.Controls.Add(ClienteCmb);
            groupBox1.Location = new Point(15, 11);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(454, 189);
            groupBox1.TabIndex = 147;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos de la órden";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(CantidadNum);
            groupBox2.Controls.Add(ProductoCmb);
            groupBox2.Controls.Add(BorrarSeleccionadoBtn);
            groupBox2.Controls.Add(ProductosList);
            groupBox2.Controls.Add(AgregarProductosBtn);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label10);
            groupBox2.Location = new Point(15, 206);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(454, 347);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Productos a preparar";
            // 
            // CantidadNum
            // 
            CantidadNum.Location = new Point(325, 47);
            CantidadNum.Maximum = new decimal(new int[] { 0, 0, 0, 0 });
            CantidadNum.Name = "CantidadNum";
            CantidadNum.ReadOnly = true;
            CantidadNum.Size = new Size(114, 23);
            CantidadNum.TabIndex = 145;
            // 
            // ProductoCmb
            // 
            ProductoCmb.DropDownStyle = ComboBoxStyle.DropDownList;
            ProductoCmb.FormattingEnabled = true;
            ProductoCmb.Location = new Point(15, 47);
            ProductoCmb.Name = "ProductoCmb";
            ProductoCmb.Size = new Size(304, 23);
            ProductoCmb.TabIndex = 144;
            ProductoCmb.SelectedIndexChanged += ProductoCmb_SelectedIndexChanged;
            // 
            // AltaOrdenPreparacionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 615);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(ConfirmarBtn);
            Controls.Add(CancelarBtn);
            Margin = new Padding(3, 2, 3, 2);
            Name = "AltaOrdenPreparacionForm";
            Text = "AltaOrdenPreparacionForm";
            Load += AltaOrdenPreparacionForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)CantidadNum).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button CancelarBtn;
        private ComboBox ClienteCmb;
        private Label ClienteLbl;
        private Label TransportistaLbl;
        private ComboBox TransportistaCmb;
        private DateTimePicker FechaDeDespachoDtp;
        private Label FechaDespachoLbl;
        private ListView ProductosList;
        private ColumnHeader Nombre;
        private ColumnHeader Cantidad;
        private Button AgregarProductosBtn;
        private Label label7;
        private Label label10;
        private Button BorrarSeleccionadoBtn;
        private Button ConfirmarBtn;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private ComboBox ProductoCmb;
        private NumericUpDown CantidadNum;
        private ColumnHeader CodigoDeProducto;
    }
}