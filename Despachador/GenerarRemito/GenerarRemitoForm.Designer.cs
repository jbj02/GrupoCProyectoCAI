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
            label2 = new Label();
            label5 = new Label();
            label6 = new Label();
            GenerarRemitoBtn = new Button();
            FechaDT = new TextBox();
            BuscarBtn = new Button();
            label7 = new Label();
            NumeroOrdenInternaBuscarText = new TextBox();
            DatosOrdenGroup = new GroupBox();
            textBox2 = new TextBox();
            label3 = new Label();
            Deposito = new TextBox();
            BorrarBtn = new Button();
            label8 = new Label();
            textBox1 = new TextBox();
            OrdenInt_List = new ListView();
            ID = new ColumnHeader();
            Transportistaa = new ColumnHeader();
            CantidadOrdenes = new ColumnHeader();
            FechaDespacho = new ColumnHeader();
            DatosOrdenGroup.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(4, 79);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(0, 15);
            label2.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(4, 80);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(54, 15);
            label5.TabIndex = 4;
            label5.Text = "Deposito";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 109);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(38, 15);
            label6.TabIndex = 8;
            label6.Text = "Fecha";
            // 
            // GenerarRemitoBtn
            // 
            GenerarRemitoBtn.Location = new Point(430, 242);
            GenerarRemitoBtn.Margin = new Padding(2);
            GenerarRemitoBtn.Name = "GenerarRemitoBtn";
            GenerarRemitoBtn.Size = new Size(129, 28);
            GenerarRemitoBtn.TabIndex = 9;
            GenerarRemitoBtn.Text = "Generar remito";
            GenerarRemitoBtn.UseVisualStyleBackColor = true;
            GenerarRemitoBtn.Click += GenerarRemitoBtn_Click;
            // 
            // FechaDT
            // 
            FechaDT.Location = new Point(121, 109);
            FechaDT.Margin = new Padding(2);
            FechaDT.Name = "FechaDT";
            FechaDT.ReadOnly = true;
            FechaDT.Size = new Size(107, 23);
            FechaDT.TabIndex = 12;
            // 
            // BuscarBtn
            // 
            BuscarBtn.Location = new Point(592, 67);
            BuscarBtn.Margin = new Padding(2);
            BuscarBtn.Name = "BuscarBtn";
            BuscarBtn.Size = new Size(66, 23);
            BuscarBtn.TabIndex = 2;
            BuscarBtn.Text = "Buscar";
            BuscarBtn.UseVisualStyleBackColor = true;
            BuscarBtn.Click += BuscarBtn_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(430, 50);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(74, 15);
            label7.TabIndex = 1;
            label7.Text = "Transportista";
            // 
            // NumeroOrdenInternaBuscarText
            // 
            NumeroOrdenInternaBuscarText.Location = new Point(430, 67);
            NumeroOrdenInternaBuscarText.Margin = new Padding(2);
            NumeroOrdenInternaBuscarText.Name = "NumeroOrdenInternaBuscarText";
            NumeroOrdenInternaBuscarText.Size = new Size(118, 23);
            NumeroOrdenInternaBuscarText.TabIndex = 0;
            // 
            // DatosOrdenGroup
            // 
            DatosOrdenGroup.Controls.Add(textBox2);
            DatosOrdenGroup.Controls.Add(label3);
            DatosOrdenGroup.Controls.Add(label8);
            DatosOrdenGroup.Controls.Add(textBox1);
            DatosOrdenGroup.Controls.Add(Deposito);
            DatosOrdenGroup.Controls.Add(label2);
            DatosOrdenGroup.Controls.Add(label5);
            DatosOrdenGroup.Controls.Add(FechaDT);
            DatosOrdenGroup.Controls.Add(label6);
            DatosOrdenGroup.Location = new Point(430, 93);
            DatosOrdenGroup.Margin = new Padding(2);
            DatosOrdenGroup.Name = "DatosOrdenGroup";
            DatosOrdenGroup.Padding = new Padding(2);
            DatosOrdenGroup.Size = new Size(234, 144);
            DatosOrdenGroup.TabIndex = 17;
            DatosOrdenGroup.TabStop = false;
            DatosOrdenGroup.Text = "Datos";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(121, 19);
            textBox2.Margin = new Padding(2);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(107, 23);
            textBox2.TabIndex = 107;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(4, 21);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(44, 15);
            label3.TabIndex = 107;
            label3.Text = "Cliente";
            // 
            // Deposito
            // 
            Deposito.Location = new Point(121, 80);
            Deposito.Margin = new Padding(3, 2, 3, 2);
            Deposito.Name = "Deposito";
            Deposito.ReadOnly = true;
            Deposito.Size = new Size(107, 23);
            Deposito.TabIndex = 16;
            // 
            // BorrarBtn
            // 
            BorrarBtn.Location = new Point(598, 239);
            BorrarBtn.Margin = new Padding(3, 2, 3, 2);
            BorrarBtn.Name = "BorrarBtn";
            BorrarBtn.Size = new Size(66, 31);
            BorrarBtn.TabIndex = 106;
            BorrarBtn.Text = "Borrar";
            BorrarBtn.UseVisualStyleBackColor = true;
            BorrarBtn.Click += BorrarBtn_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(4, 49);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(74, 15);
            label8.TabIndex = 108;
            label8.Text = "Transportista";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(121, 46);
            textBox1.Margin = new Padding(2);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(107, 23);
            textBox1.TabIndex = 109;
            // 
            // OrdenInt_List
            // 
            OrdenInt_List.Columns.AddRange(new ColumnHeader[] { ID, Transportistaa, CantidadOrdenes, FechaDespacho });
            OrdenInt_List.FullRowSelect = true;
            OrdenInt_List.GridLines = true;
            OrdenInt_List.Location = new Point(12, 68);
            OrdenInt_List.MultiSelect = false;
            OrdenInt_List.Name = "OrdenInt_List";
            OrdenInt_List.Size = new Size(413, 202);
            OrdenInt_List.TabIndex = 107;
            OrdenInt_List.UseCompatibleStateImageBehavior = false;
            OrdenInt_List.View = View.Details;
            // 
            // ID
            // 
            ID.Text = "ID";
            ID.Width = 40;
            // 
            // Transportistaa
            // 
            Transportistaa.Text = "Transportista";
            Transportistaa.Width = 120;
            // 
            // CantidadOrdenes
            // 
            CantidadOrdenes.Text = "Cantidad de Ordenes";
            CantidadOrdenes.Width = 120;
            // 
            // FechaDespacho
            // 
            FechaDespacho.Text = "Fecha de Despacho";
            FechaDespacho.Width = 120;
            // 
            // GenerarRemitoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(692, 322);
            Controls.Add(OrdenInt_List);
            Controls.Add(BuscarBtn);
            Controls.Add(NumeroOrdenInternaBuscarText);
            Controls.Add(label7);
            Controls.Add(BorrarBtn);
            Controls.Add(DatosOrdenGroup);
            Controls.Add(GenerarRemitoBtn);
            Margin = new Padding(2);
            Name = "GenerarRemitoForm";
            Text = "GenerarRemitoForm";
            Load += GenerarRemitoForm_Load;
            DatosOrdenGroup.ResumeLayout(false);
            DatosOrdenGroup.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Label label5;
        private Label label6;
        private Button GenerarRemitoBtn;
        private TextBox FechaDT;
        private TextBox NumeroOrdenInternaBuscarText;
        private Label label7;
        private GroupBox DatosOrdenGroup;
        private Button BuscarBtn;
        private Button BorrarBtn;
        private TextBox Deposito;
        private TextBox textBox2;
        private Label label3;
        private Label label8;
        private TextBox textBox1;
        private ListView OrdenInt_List;
        private ColumnHeader ID;
        private ColumnHeader Transportistaa;
        private ColumnHeader CantidadOrdenes;
        private ColumnHeader FechaDespacho;
    }
}