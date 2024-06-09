namespace GrupoCProyectoCAI.Preparador.PrepararOrden
{
    partial class PrepararOrdenForm
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
            ConfirmarDatosOrdenBtn = new Button();
            OrdenesPreparacion_List = new ListView();
            N_Orden = new ColumnHeader();
            Estado = new ColumnHeader();
            Cliente = new ColumnHeader();
            Prioridad = new ColumnHeader();
            Fecha_Creacion = new ColumnHeader();
            Fecha_Entrega = new ColumnHeader();
            SeleccionarBtn = new Button();
            ProductoList = new ListView();
            Producto = new ColumnHeader();
            Cantidad = new ColumnHeader();
            CancelarBtn = new Button();
            NumeroOrdenInternaBuscarText = new TextBox();
            label1 = new Label();
            button1 = new Button();
            label2 = new Label();
            SuspendLayout();
            // 
            // ConfirmarDatosOrdenBtn
            // 
            ConfirmarDatosOrdenBtn.BackColor = Color.PaleGreen;
            ConfirmarDatosOrdenBtn.FlatStyle = FlatStyle.Popup;
            ConfirmarDatosOrdenBtn.Font = new Font("Arial", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            ConfirmarDatosOrdenBtn.Location = new Point(938, 260);
            ConfirmarDatosOrdenBtn.Name = "ConfirmarDatosOrdenBtn";
            ConfirmarDatosOrdenBtn.Size = new Size(86, 31);
            ConfirmarDatosOrdenBtn.TabIndex = 95;
            ConfirmarDatosOrdenBtn.Text = "Confirmar";
            ConfirmarDatosOrdenBtn.UseVisualStyleBackColor = false;
            ConfirmarDatosOrdenBtn.UseWaitCursor = true;
            ConfirmarDatosOrdenBtn.Click += ConfirmarDatosOrdenBtn_Click;
            // 
            // OrdenesPreparacion_List
            // 
            OrdenesPreparacion_List.BackColor = SystemColors.GradientActiveCaption;
            OrdenesPreparacion_List.Columns.AddRange(new ColumnHeader[] { N_Orden, Estado, Cliente, Prioridad, Fecha_Creacion, Fecha_Entrega });
            OrdenesPreparacion_List.Font = new Font("Arial Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            OrdenesPreparacion_List.FullRowSelect = true;
            OrdenesPreparacion_List.GridLines = true;
            OrdenesPreparacion_List.Location = new Point(26, 52);
            OrdenesPreparacion_List.MultiSelect = false;
            OrdenesPreparacion_List.Name = "OrdenesPreparacion_List";
            OrdenesPreparacion_List.Size = new Size(836, 202);
            OrdenesPreparacion_List.TabIndex = 80;
            OrdenesPreparacion_List.UseCompatibleStateImageBehavior = false;
            OrdenesPreparacion_List.UseWaitCursor = true;
            OrdenesPreparacion_List.View = View.Details;
            // 
            // N_Orden
            // 
            N_Orden.Text = "N° Orden";
            N_Orden.Width = 90;
            // 
            // Estado
            // 
            Estado.Text = "Estado";
            Estado.TextAlign = HorizontalAlignment.Center;
            Estado.Width = 140;
            // 
            // Cliente
            // 
            Cliente.Text = "Cliente";
            Cliente.TextAlign = HorizontalAlignment.Center;
            Cliente.Width = 180;
            // 
            // Prioridad
            // 
            Prioridad.Text = "Prioridad";
            Prioridad.TextAlign = HorizontalAlignment.Center;
            Prioridad.Width = 100;
            // 
            // Fecha_Creacion
            // 
            Fecha_Creacion.Text = "Fecha de Alta";
            Fecha_Creacion.TextAlign = HorizontalAlignment.Center;
            Fecha_Creacion.Width = 140;
            // 
            // Fecha_Entrega
            // 
            Fecha_Entrega.Text = " Fecha de Despacho";
            Fecha_Entrega.TextAlign = HorizontalAlignment.Center;
            Fecha_Entrega.Width = 180;
            // 
            // SeleccionarBtn
            // 
            SeleccionarBtn.BackColor = Color.LightGray;
            SeleccionarBtn.FlatStyle = FlatStyle.Popup;
            SeleccionarBtn.Font = new Font("Arial", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            SeleccionarBtn.ForeColor = SystemColors.ControlText;
            SeleccionarBtn.Location = new Point(776, 260);
            SeleccionarBtn.Name = "SeleccionarBtn";
            SeleccionarBtn.Size = new Size(86, 31);
            SeleccionarBtn.TabIndex = 101;
            SeleccionarBtn.Text = "Seleccionar";
            SeleccionarBtn.UseVisualStyleBackColor = false;
            SeleccionarBtn.UseWaitCursor = true;
            SeleccionarBtn.Click += SeleccionarBtn_Click;
            // 
            // ProductoList
            // 
            ProductoList.BackColor = SystemColors.GradientActiveCaption;
            ProductoList.Columns.AddRange(new ColumnHeader[] { Producto, Cantidad });
            ProductoList.Font = new Font("Arial Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ProductoList.FullRowSelect = true;
            ProductoList.GridLines = true;
            ProductoList.Location = new Point(938, 52);
            ProductoList.MultiSelect = false;
            ProductoList.Name = "ProductoList";
            ProductoList.Size = new Size(260, 202);
            ProductoList.TabIndex = 104;
            ProductoList.UseCompatibleStateImageBehavior = false;
            ProductoList.UseWaitCursor = true;
            ProductoList.View = View.Details;
            // 
            // Producto
            // 
            Producto.Text = "Producto";
            Producto.Width = 140;
            // 
            // Cantidad
            // 
            Cantidad.Text = "Cantidad";
            Cantidad.TextAlign = HorizontalAlignment.Center;
            Cantidad.Width = 150;
            // 
            // CancelarBtn
            // 
            CancelarBtn.BackColor = Color.IndianRed;
            CancelarBtn.FlatStyle = FlatStyle.Popup;
            CancelarBtn.Font = new Font("Arial", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            CancelarBtn.ForeColor = SystemColors.ButtonHighlight;
            CancelarBtn.Location = new Point(1111, 260);
            CancelarBtn.Name = "CancelarBtn";
            CancelarBtn.Size = new Size(86, 31);
            CancelarBtn.TabIndex = 108;
            CancelarBtn.Text = "Cancelar";
            CancelarBtn.UseVisualStyleBackColor = false;
            CancelarBtn.UseWaitCursor = true;
            CancelarBtn.Click += CancelarBtn_Click;
            // 
            // NumeroOrdenInternaBuscarText
            // 
            NumeroOrdenInternaBuscarText.Location = new Point(661, 392);
            NumeroOrdenInternaBuscarText.Name = "NumeroOrdenInternaBuscarText";
            NumeroOrdenInternaBuscarText.Size = new Size(157, 23);
            NumeroOrdenInternaBuscarText.TabIndex = 104;
            NumeroOrdenInternaBuscarText.UseWaitCursor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(661, 374);
            label1.Name = "label1";
            label1.Size = new Size(57, 15);
            label1.TabIndex = 109;
            label1.Text = "N° Orden";
            label1.UseWaitCursor = true;
            // 
            // button1
            // 
            button1.Location = new Point(834, 389);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 110;
            button1.Text = "Buscar";
            button1.UseVisualStyleBackColor = true;
            button1.UseWaitCursor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.LightBlue;
            label2.Font = new Font("Arial", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(26, 31);
            label2.Name = "label2";
            label2.Size = new Size(178, 17);
            label2.TabIndex = 111;
            label2.Text = "Ordenes de Preparación";
            label2.UseWaitCursor = true;
            // 
            // PrepararOrdenForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Linen;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(1210, 304);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(NumeroOrdenInternaBuscarText);
            Controls.Add(CancelarBtn);
            Controls.Add(ProductoList);
            Controls.Add(ConfirmarDatosOrdenBtn);
            Controls.Add(SeleccionarBtn);
            Controls.Add(OrdenesPreparacion_List);
            Name = "PrepararOrdenForm";
            Text = "PrepararOrdenForm";
            UseWaitCursor = true;
            Load += PrepararOrdenForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button ConfirmarDatosOrdenBtn;
        private ListView OrdenesPreparacion_List;
        private ColumnHeader N_Orden_Ext;
        private ColumnHeader N_Orden;
        private ColumnHeader Cliente;
        private ColumnHeader Prioridad;
        private ColumnHeader Estado;
        private ColumnHeader Fecha_Creacion;
        private Button SeleccionarBtn;
        private Button CancelarBusquedaBtn;
        private TextBox NumeroOrdenInternaBuscarText;
        private Button CancelarBtn;
        private ColumnHeader Fecha_Entrega;
        private ListView ProductoList;
        private ColumnHeader Producto;
        private ColumnHeader Cantidad;
        private Label label1;
        private Button button1;
        private Label label2;
    }
}