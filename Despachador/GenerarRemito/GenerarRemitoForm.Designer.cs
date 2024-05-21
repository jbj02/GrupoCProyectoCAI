namespace GrupoCProyectoCAI.Despachador.GenerarRemito
{
    partial class GenerarRemitoForm
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            NumOrdenIntText = new TextBox();
            label6 = new Label();
            GenerarRemitoBtn = new Button();
            CancelarBtn = new Button();
            FechaDT = new TextBox();
            CantidadText = new TextBox();
            TipoDeProductoText = new TextBox();
            NumOrdExtText = new TextBox();
            groupBox1 = new GroupBox();
            BuscarBtn = new Button();
            label7 = new Label();
            NumeroOrdenInternaBuscarText = new TextBox();
            DatosOrdenGroup = new GroupBox();
            Deposito = new TextBox();
            OrdenInt_List = new ListView();
            N_Orden_Ext = new ColumnHeader();
            N_Orden_In = new ColumnHeader();
            Tipo_Producto = new ColumnHeader();
            Cantidades = new ColumnHeader();
            Estado = new ColumnHeader();
            Fecha = new ColumnHeader();
            BorrarBtn = new Button();
            SeleccionarBtn = new Button();
            groupBox1.SuspendLayout();
            DatosOrdenGroup.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(5, 33);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(48, 19);
            label1.TabIndex = 0;
            label1.Text = "Orden";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(5, 61);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(97, 19);
            label2.TabIndex = 1;
            label2.Text = "Orden externa";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(5, 93);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(114, 19);
            label3.TabIndex = 2;
            label3.Text = "Tipo de producto";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(5, 121);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(77, 19);
            label4.TabIndex = 3;
            label4.Text = "Cantidades";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(5, 153);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(64, 19);
            label5.TabIndex = 4;
            label5.Text = "Deposito";
            // 
            // NumOrdenIntText
            // 
            NumOrdenIntText.Location = new Point(138, 33);
            NumOrdenIntText.Margin = new Padding(2);
            NumOrdenIntText.Name = "NumOrdenIntText";
            NumOrdenIntText.ReadOnly = true;
            NumOrdenIntText.Size = new Size(122, 26);
            NumOrdenIntText.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(9, 185);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(44, 19);
            label6.TabIndex = 8;
            label6.Text = "Fecha";
            // 
            // GenerarRemitoBtn
            // 
            GenerarRemitoBtn.Location = new Point(61, 382);
            GenerarRemitoBtn.Margin = new Padding(2);
            GenerarRemitoBtn.Name = "GenerarRemitoBtn";
            GenerarRemitoBtn.Size = new Size(147, 35);
            GenerarRemitoBtn.TabIndex = 9;
            GenerarRemitoBtn.Text = "Generar remito";
            GenerarRemitoBtn.UseVisualStyleBackColor = true;
            GenerarRemitoBtn.Click += GenerarRemitoBtn_Click;
            // 
            // CancelarBtn
            // 
            CancelarBtn.Location = new Point(956, 608);
            CancelarBtn.Margin = new Padding(2);
            CancelarBtn.Name = "CancelarBtn";
            CancelarBtn.Size = new Size(75, 29);
            CancelarBtn.TabIndex = 10;
            CancelarBtn.Text = "Cancelar";
            CancelarBtn.UseVisualStyleBackColor = true;
            CancelarBtn.Click += CancelarBtn_Click;
            // 
            // FechaDT
            // 
            FechaDT.Location = new Point(138, 185);
            FechaDT.Margin = new Padding(2);
            FechaDT.Name = "FechaDT";
            FechaDT.ReadOnly = true;
            FechaDT.Size = new Size(122, 26);
            FechaDT.TabIndex = 12;
            // 
            // CantidadText
            // 
            CantidadText.Location = new Point(138, 121);
            CantidadText.Margin = new Padding(2);
            CantidadText.Name = "CantidadText";
            CantidadText.ReadOnly = true;
            CantidadText.Size = new Size(122, 26);
            CantidadText.TabIndex = 13;
            // 
            // TipoDeProductoText
            // 
            TipoDeProductoText.Location = new Point(138, 89);
            TipoDeProductoText.Margin = new Padding(2);
            TipoDeProductoText.Name = "TipoDeProductoText";
            TipoDeProductoText.ReadOnly = true;
            TipoDeProductoText.Size = new Size(122, 26);
            TipoDeProductoText.TabIndex = 14;
            // 
            // NumOrdExtText
            // 
            NumOrdExtText.Location = new Point(138, 62);
            NumOrdExtText.Margin = new Padding(2);
            NumOrdExtText.Name = "NumOrdExtText";
            NumOrdExtText.ReadOnly = true;
            NumOrdExtText.Size = new Size(122, 26);
            NumOrdExtText.TabIndex = 15;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(BuscarBtn);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(NumeroOrdenInternaBuscarText);
            groupBox1.Location = new Point(61, 29);
            groupBox1.Margin = new Padding(2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2);
            groupBox1.Size = new Size(272, 110);
            groupBox1.TabIndex = 16;
            groupBox1.TabStop = false;
            groupBox1.Text = "Busqueda";
            // 
            // BuscarBtn
            // 
            BuscarBtn.Location = new Point(154, 60);
            BuscarBtn.Margin = new Padding(2);
            BuscarBtn.Name = "BuscarBtn";
            BuscarBtn.Size = new Size(75, 26);
            BuscarBtn.TabIndex = 2;
            BuscarBtn.Text = "Buscar";
            BuscarBtn.UseVisualStyleBackColor = true;
            BuscarBtn.Click += BuscarBtn_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(14, 30);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(95, 19);
            label7.TabIndex = 1;
            label7.Text = "Orden interna";
            // 
            // NumeroOrdenInternaBuscarText
            // 
            NumeroOrdenInternaBuscarText.Location = new Point(132, 30);
            NumeroOrdenInternaBuscarText.Margin = new Padding(2);
            NumeroOrdenInternaBuscarText.Name = "NumeroOrdenInternaBuscarText";
            NumeroOrdenInternaBuscarText.Size = new Size(134, 26);
            NumeroOrdenInternaBuscarText.TabIndex = 0;
            // 
            // DatosOrdenGroup
            // 
            DatosOrdenGroup.Controls.Add(Deposito);
            DatosOrdenGroup.Controls.Add(label1);
            DatosOrdenGroup.Controls.Add(label2);
            DatosOrdenGroup.Controls.Add(NumOrdExtText);
            DatosOrdenGroup.Controls.Add(label3);
            DatosOrdenGroup.Controls.Add(TipoDeProductoText);
            DatosOrdenGroup.Controls.Add(label4);
            DatosOrdenGroup.Controls.Add(CantidadText);
            DatosOrdenGroup.Controls.Add(label5);
            DatosOrdenGroup.Controls.Add(FechaDT);
            DatosOrdenGroup.Controls.Add(NumOrdenIntText);
            DatosOrdenGroup.Controls.Add(label6);
            DatosOrdenGroup.Location = new Point(61, 143);
            DatosOrdenGroup.Margin = new Padding(2);
            DatosOrdenGroup.Name = "DatosOrdenGroup";
            DatosOrdenGroup.Padding = new Padding(2);
            DatosOrdenGroup.Size = new Size(272, 234);
            DatosOrdenGroup.TabIndex = 17;
            DatosOrdenGroup.TabStop = false;
            DatosOrdenGroup.Text = "Datos";
            // 
            // Deposito
            // 
            Deposito.Location = new Point(138, 150);
            Deposito.Name = "Deposito";
            Deposito.ReadOnly = true;
            Deposito.Size = new Size(122, 26);
            Deposito.TabIndex = 16;
            // 
            // OrdenInt_List
            // 
            OrdenInt_List.Columns.AddRange(new ColumnHeader[] { N_Orden_Ext, N_Orden_In, Tipo_Producto, Cantidades, Estado, Fecha });
            OrdenInt_List.FullRowSelect = true;
            OrdenInt_List.GridLines = true;
            OrdenInt_List.Location = new Point(380, 29);
            OrdenInt_List.Margin = new Padding(3, 4, 3, 4);
            OrdenInt_List.MultiSelect = false;
            OrdenInt_List.Name = "OrdenInt_List";
            OrdenInt_List.Size = new Size(651, 557);
            OrdenInt_List.TabIndex = 105;
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
            // Estado
            // 
            Estado.Text = "Deposito";
            Estado.Width = 140;
            // 
            // Fecha
            // 
            Fecha.Text = "Fecha de Creación";
            Fecha.Width = 140;
            // 
            // BorrarBtn
            // 
            BorrarBtn.Location = new Point(244, 382);
            BorrarBtn.Name = "BorrarBtn";
            BorrarBtn.Size = new Size(75, 39);
            BorrarBtn.TabIndex = 106;
            BorrarBtn.Text = "Borrar";
            BorrarBtn.UseVisualStyleBackColor = true;
            BorrarBtn.Click += BorrarBtn_Click;
            // 
            // SeleccionarBtn
            // 
            SeleccionarBtn.Location = new Point(380, 608);
            SeleccionarBtn.Name = "SeleccionarBtn";
            SeleccionarBtn.Size = new Size(86, 29);
            SeleccionarBtn.TabIndex = 107;
            SeleccionarBtn.Text = "Seleccionar";
            SeleccionarBtn.UseVisualStyleBackColor = true;
            SeleccionarBtn.Click += SeleccionarBtn_Click_1;
            // 
            // GenerarRemitoForm
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1539, 683);
            Controls.Add(SeleccionarBtn);
            Controls.Add(BorrarBtn);
            Controls.Add(OrdenInt_List);
            Controls.Add(DatosOrdenGroup);
            Controls.Add(groupBox1);
            Controls.Add(CancelarBtn);
            Controls.Add(GenerarRemitoBtn);
            Margin = new Padding(2);
            Name = "GenerarRemitoForm";
            Text = "GenerarRemitoForm";
            Load += GenerarRemitoForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            DatosOrdenGroup.ResumeLayout(false);
            DatosOrdenGroup.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox NumOrdenIntText;
        private Label label6;
        private Button GenerarRemitoBtn;
        private Button CancelarBtn;
        private TextBox FechaDT;
        private TextBox CantidadText;
        private TextBox TipoDeProductoText;
        private TextBox NumOrdExtText;
        private GroupBox groupBox1;
        private TextBox NumeroOrdenInternaBuscarText;
        private Label label7;
        private GroupBox DatosOrdenGroup;
        private Button BuscarBtn;
        private ListView OrdenInt_List;
        private ColumnHeader N_Orden_Ext;
        private ColumnHeader N_Orden_In;
        private ColumnHeader Tipo_Producto;
        private ColumnHeader Cantidades;
        private ColumnHeader Estado;
        private ColumnHeader Fecha;
        private Button BorrarBtn;
        private Button SeleccionarBtn;
        private TextBox Deposito;
    }
}