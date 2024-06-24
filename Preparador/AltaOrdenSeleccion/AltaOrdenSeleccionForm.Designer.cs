namespace GrupoCProyectoCAI.Preparador.AltaOrdenSeleccion
{
    partial class AltaOrdenSeleccionForm
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
            OrdenPreparacionList = new ListView();
            NumOrdenP = new ColumnHeader();
            ClienteCUITP = new ColumnHeader();
            FechaDespacho = new ColumnHeader();
            OrdenSeleccionList = new ListView();
            NumOrdenS = new ColumnHeader();
            CantidadOrdenesPreparacion = new ColumnHeader();
            SeleccionarBtn = new Button();
            ConfirmarBtn = new Button();
            DeseleccionarBtn = new Button();
            CancelarBtn = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // OrdenPreparacionList
            // 
            OrdenPreparacionList.Columns.AddRange(new ColumnHeader[] { NumOrdenP, ClienteCUITP, FechaDespacho });
            OrdenPreparacionList.FullRowSelect = true;
            OrdenPreparacionList.GridLines = true;
            OrdenPreparacionList.Location = new Point(24, 41);
            OrdenPreparacionList.Name = "OrdenPreparacionList";
            OrdenPreparacionList.Size = new Size(397, 276);
            OrdenPreparacionList.TabIndex = 81;
            OrdenPreparacionList.UseCompatibleStateImageBehavior = false;
            OrdenPreparacionList.View = View.Details;
            // 
            // NumOrdenP
            // 
            NumOrdenP.Text = "N° de orden";
            NumOrdenP.Width = 140;
            // 
            // ClienteCUITP
            // 
            ClienteCUITP.Text = "Cliente (CUIT)";
            ClienteCUITP.Width = 100;
            // 
            // FechaDespacho
            // 
            FechaDespacho.Text = "Fecha de Despacho";
            FechaDespacho.Width = 150;
            // 
            // OrdenSeleccionList
            // 
            OrdenSeleccionList.Columns.AddRange(new ColumnHeader[] { NumOrdenS, CantidadOrdenesPreparacion });
            OrdenSeleccionList.FullRowSelect = true;
            OrdenSeleccionList.GridLines = true;
            OrdenSeleccionList.Location = new Point(523, 41);
            OrdenSeleccionList.MultiSelect = false;
            OrdenSeleccionList.Name = "OrdenSeleccionList";
            OrdenSeleccionList.Size = new Size(266, 276);
            OrdenSeleccionList.TabIndex = 83;
            OrdenSeleccionList.UseCompatibleStateImageBehavior = false;
            OrdenSeleccionList.View = View.Details;
            // 
            // NumOrdenS
            // 
            NumOrdenS.Text = "N° de orden";
            NumOrdenS.Width = 140;
            // 
            // CantidadOrdenesPreparacion
            // 
            CantidadOrdenesPreparacion.Text = "Cant. Ord. Prep.";
            CantidadOrdenesPreparacion.Width = 120;
            // 
            // SeleccionarBtn
            // 
            SeleccionarBtn.Location = new Point(287, 322);
            SeleccionarBtn.Margin = new Padding(3, 2, 3, 2);
            SeleccionarBtn.Name = "SeleccionarBtn";
            SeleccionarBtn.Size = new Size(134, 32);
            SeleccionarBtn.TabIndex = 84;
            SeleccionarBtn.Text = "Seleccionar ordenes";
            SeleccionarBtn.UseVisualStyleBackColor = true;
            SeleccionarBtn.Click += SeleccionarBtn_Click;
            // 
            // ConfirmarBtn
            // 
            ConfirmarBtn.Location = new Point(577, 364);
            ConfirmarBtn.Margin = new Padding(3, 2, 3, 2);
            ConfirmarBtn.Name = "ConfirmarBtn";
            ConfirmarBtn.Size = new Size(95, 32);
            ConfirmarBtn.TabIndex = 85;
            ConfirmarBtn.Text = "Confirmar";
            ConfirmarBtn.UseVisualStyleBackColor = true;
            ConfirmarBtn.Click += ConfirmarBtn_Click;
            // 
            // DeseleccionarBtn
            // 
            DeseleccionarBtn.Location = new Point(683, 320);
            DeseleccionarBtn.Margin = new Padding(3, 2, 3, 2);
            DeseleccionarBtn.Name = "DeseleccionarBtn";
            DeseleccionarBtn.Size = new Size(106, 32);
            DeseleccionarBtn.TabIndex = 86;
            DeseleccionarBtn.Text = "Deseleccionar";
            DeseleccionarBtn.UseVisualStyleBackColor = true;
            DeseleccionarBtn.Click += DeseleccionarBtn_Click;
            // 
            // CancelarBtn
            // 
            CancelarBtn.Location = new Point(694, 364);
            CancelarBtn.Margin = new Padding(3, 2, 3, 2);
            CancelarBtn.Name = "CancelarBtn";
            CancelarBtn.Size = new Size(95, 32);
            CancelarBtn.TabIndex = 87;
            CancelarBtn.Text = "Cancelar";
            CancelarBtn.UseVisualStyleBackColor = true;
            CancelarBtn.Click += CancelarBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 23);
            label1.Name = "label1";
            label1.Size = new Size(365, 15);
            label1.TabIndex = 88;
            label1.Text = "Órdenes de Preparación (ctrl + click para seleccioanr varias ordenes)";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(523, 23);
            label2.Name = "label2";
            label2.Size = new Size(120, 15);
            label2.TabIndex = 89;
            label2.Text = "Órdenes de Selección";
            // 
            // AltaOrdenSeleccionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(798, 407);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(CancelarBtn);
            Controls.Add(DeseleccionarBtn);
            Controls.Add(ConfirmarBtn);
            Controls.Add(SeleccionarBtn);
            Controls.Add(OrdenSeleccionList);
            Controls.Add(OrdenPreparacionList);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            Name = "AltaOrdenSeleccionForm";
            Text = "Alta Orden Seleccion Pampazon S.A";
            Load += AltaOrdenSeleccionForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView OrdenPreparacionList;
        private ColumnHeader NumOrdenP;
        private ColumnHeader ClienteCUITP;
        private ColumnHeader FechaDespacho;
        private ListView OrdenSeleccionList;
        private ColumnHeader NumOrdenS;
        private Button SeleccionarBtn;
        private Button ConfirmarBtn;
        private Button DeseleccionarBtn;
        private Button CancelarBtn;
        private Label label1;
        private Label label2;
        private ColumnHeader CantidadOrdenesPreparacion;
    }
}