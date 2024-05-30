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
            ClienteP = new ColumnHeader();
            FechaDespacho = new ColumnHeader();
            PrioridadP = new ColumnHeader();
            OrdenSeleccionList = new ListView();
            NumOrdenS = new ColumnHeader();
            PrioridadS = new ColumnHeader();
            CantidadOrdenesPreparacion = new ColumnHeader();
            SeleccionarBtn = new Button();
            ConfirmarBtn = new Button();
            DesseleccionarBtn = new Button();
            CancelarBtn = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // OrdenPreparacionList
            // 
            OrdenPreparacionList.Columns.AddRange(new ColumnHeader[] { NumOrdenP, ClienteP, FechaDespacho, PrioridadP });
            OrdenPreparacionList.FullRowSelect = true;
            OrdenPreparacionList.GridLines = true;
            OrdenPreparacionList.Location = new Point(24, 30);
            OrdenPreparacionList.Name = "OrdenPreparacionList";
            OrdenPreparacionList.Size = new Size(435, 276);
            OrdenPreparacionList.TabIndex = 81;
            OrdenPreparacionList.UseCompatibleStateImageBehavior = false;
            OrdenPreparacionList.View = View.Details;
            // 
            // NumOrdenP
            // 
            NumOrdenP.Text = "N° de orden";
            NumOrdenP.Width = 140;
            // 
            // ClienteP
            // 
            ClienteP.Text = "Cliente";
            // 
            // FechaDespacho
            // 
            FechaDespacho.Text = "Fecha de despacho";
            FechaDespacho.Width = 150;
            // 
            // PrioridadP
            // 
            PrioridadP.Text = "Prioridad";
            PrioridadP.Width = 80;
            // 
            // OrdenSeleccionList
            // 
            OrdenSeleccionList.Columns.AddRange(new ColumnHeader[] { NumOrdenS, PrioridadS, CantidadOrdenesPreparacion });
            OrdenSeleccionList.FullRowSelect = true;
            OrdenSeleccionList.GridLines = true;
            OrdenSeleccionList.Location = new Point(523, 30);
            OrdenSeleccionList.MultiSelect = false;
            OrdenSeleccionList.Name = "OrdenSeleccionList";
            OrdenSeleccionList.Size = new Size(347, 276);
            OrdenSeleccionList.TabIndex = 83;
            OrdenSeleccionList.UseCompatibleStateImageBehavior = false;
            OrdenSeleccionList.View = View.Details;
            // 
            // NumOrdenS
            // 
            NumOrdenS.Text = "N° de orden";
            NumOrdenS.Width = 140;
            // 
            // PrioridadS
            // 
            PrioridadS.Text = "Prioridad";
            PrioridadS.Width = 80;
            // 
            // CantidadOrdenesPreparacion
            // 
            CantidadOrdenesPreparacion.Text = "Cant. Ord. Prep.";
            CantidadOrdenesPreparacion.Width = 120;
            // 
            // SeleccionarBtn
            // 
            SeleccionarBtn.Location = new Point(364, 310);
            SeleccionarBtn.Margin = new Padding(3, 2, 3, 2);
            SeleccionarBtn.Name = "SeleccionarBtn";
            SeleccionarBtn.Size = new Size(95, 32);
            SeleccionarBtn.TabIndex = 84;
            SeleccionarBtn.Text = "Seleccionar";
            SeleccionarBtn.UseVisualStyleBackColor = true;
            SeleccionarBtn.Click += SeleccionarBtn_Click;
            // 
            // ConfirmarBtn
            // 
            ConfirmarBtn.Location = new Point(658, 355);
            ConfirmarBtn.Margin = new Padding(3, 2, 3, 2);
            ConfirmarBtn.Name = "ConfirmarBtn";
            ConfirmarBtn.Size = new Size(95, 32);
            ConfirmarBtn.TabIndex = 85;
            ConfirmarBtn.Text = "Confirmar";
            ConfirmarBtn.UseVisualStyleBackColor = true;
            ConfirmarBtn.Click += ConfirmarBtn_Click;
            // 
            // DesseleccionarBtn
            // 
            DesseleccionarBtn.Location = new Point(764, 311);
            DesseleccionarBtn.Margin = new Padding(3, 2, 3, 2);
            DesseleccionarBtn.Name = "DesseleccionarBtn";
            DesseleccionarBtn.Size = new Size(106, 32);
            DesseleccionarBtn.TabIndex = 86;
            DesseleccionarBtn.Text = "Desseleccionar";
            DesseleccionarBtn.UseVisualStyleBackColor = true;
            DesseleccionarBtn.Click += DesseleccionarBtn_Click;
            // 
            // CancelarBtn
            // 
            CancelarBtn.Location = new Point(775, 355);
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
            label1.Location = new Point(24, 9);
            label1.Name = "label1";
            label1.Size = new Size(133, 15);
            label1.TabIndex = 88;
            label1.Text = "Ordenes de Preparación";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(523, 9);
            label2.Name = "label2";
            label2.Size = new Size(120, 15);
            label2.TabIndex = 89;
            label2.Text = "Ordenes de Selección";
            // 
            // AltaOrdenSeleccionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(957, 398);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(CancelarBtn);
            Controls.Add(DesseleccionarBtn);
            Controls.Add(ConfirmarBtn);
            Controls.Add(SeleccionarBtn);
            Controls.Add(OrdenSeleccionList);
            Controls.Add(OrdenPreparacionList);
            Margin = new Padding(3, 2, 3, 2);
            Name = "AltaOrdenSeleccionForm";
            Text = "AltaOrdenSeleccion";
            Load += AltaOrdenSeleccionForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView OrdenPreparacionList;
        private ColumnHeader NumOrdenP;
        private ColumnHeader ClienteP;
        private ColumnHeader FechaDespacho;
        private ColumnHeader PrioridadP;
        private ListView OrdenSeleccionList;
        private ColumnHeader NumOrdenS;
        private ColumnHeader PrioridadS;
        private Button SeleccionarBtn;
        private Button ConfirmarBtn;
        private Button DesseleccionarBtn;
        private Button CancelarBtn;
        private Label label1;
        private Label label2;
        private ColumnHeader CantidadOrdenesPreparacion;
    }
}