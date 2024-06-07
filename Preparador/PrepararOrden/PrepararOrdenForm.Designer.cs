namespace GrupoCProyectoCAI.Preparador.Modificar
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
            OrdenInt_List = new ListView();
            N_Orden = new ColumnHeader();
            Estado = new ColumnHeader();
            Cliente = new ColumnHeader();
            Prioridad = new ColumnHeader();
            FechaAlta = new ColumnHeader();
            FechaDespacho = new ColumnHeader();
            SeleccionarBtn = new Button();
            listView1 = new ListView();
            Producto = new ColumnHeader();
            Cantidad = new ColumnHeader();
            CancelarDatosOrdenBtn = new Button();
            label2 = new Label();
            button1 = new Button();
            label1 = new Label();
            NumeroOrdenInternaBuscarText = new TextBox();
            SuspendLayout();
            // 
            // ConfirmarDatosOrdenBtn
            // 
            ConfirmarDatosOrdenBtn.Location = new Point(823, 260);
            ConfirmarDatosOrdenBtn.Name = "ConfirmarDatosOrdenBtn";
            ConfirmarDatosOrdenBtn.Size = new Size(86, 31);
            ConfirmarDatosOrdenBtn.TabIndex = 95;
            ConfirmarDatosOrdenBtn.Text = "Confirmar";
            ConfirmarDatosOrdenBtn.UseVisualStyleBackColor = true;
            ConfirmarDatosOrdenBtn.Click += AceptarDatosOrdenBtn_Click;
            // 
            // OrdenInt_List
            // 
            OrdenInt_List.Columns.AddRange(new ColumnHeader[] { N_Orden, Estado, Cliente, Prioridad, FechaAlta, FechaDespacho });
            OrdenInt_List.FullRowSelect = true;
            OrdenInt_List.GridLines = true;
            OrdenInt_List.Location = new Point(26, 52);
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
            // FechaAlta
            // 
            FechaAlta.Text = "Fecha de Alta";
            FechaAlta.Width = 140;
            // 
            // FechaDespacho
            // 
            FechaDespacho.Text = " Fecha de Despacho";
            FechaDespacho.Width = 140;
            // 
            // SeleccionarBtn
            // 
            SeleccionarBtn.Location = new Point(678, 260);
            SeleccionarBtn.Name = "SeleccionarBtn";
            SeleccionarBtn.Size = new Size(86, 31);
            SeleccionarBtn.TabIndex = 101;
            SeleccionarBtn.Text = "Seleccionar";
            SeleccionarBtn.UseVisualStyleBackColor = true;
            SeleccionarBtn.Click += SeleccionarBtn_Click;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { Producto, Cantidad });
            listView1.FullRowSelect = true;
            listView1.GridLines = true;
            listView1.Location = new Point(823, 83);
            listView1.MultiSelect = false;
            listView1.Name = "listView1";
            listView1.Size = new Size(237, 171);
            listView1.TabIndex = 104;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // Producto
            // 
            Producto.Text = "Producto";
            Producto.Width = 110;
            // 
            // Cantidad
            // 
            Cantidad.Text = "Cantidad";
            Cantidad.Width = 140;
            // 
            // CancelarDatosOrdenBtn
            // 
            CancelarDatosOrdenBtn.Location = new Point(974, 260);
            CancelarDatosOrdenBtn.Name = "CancelarDatosOrdenBtn";
            CancelarDatosOrdenBtn.Size = new Size(86, 31);
            CancelarDatosOrdenBtn.TabIndex = 108;
            CancelarDatosOrdenBtn.Text = "Cancelar";
            CancelarDatosOrdenBtn.UseVisualStyleBackColor = true;
            CancelarDatosOrdenBtn.Click += CancelarDatosOrdenBtn_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 34);
            label2.Name = "label2";
            label2.Size = new Size(133, 15);
            label2.TabIndex = 111;
            label2.Text = "Ordenes de Preparación";
            // 
            // button1
            // 
            button1.Location = new Point(985, 53);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 110;
            button1.Text = "Buscar";
            button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(823, 36);
            label1.Name = "label1";
            label1.Size = new Size(57, 15);
            label1.TabIndex = 109;
            label1.Text = "N° Orden";
            // 
            // NumeroOrdenInternaBuscarText
            // 
            NumeroOrdenInternaBuscarText.Location = new Point(823, 54);
            NumeroOrdenInternaBuscarText.Name = "NumeroOrdenInternaBuscarText";
            NumeroOrdenInternaBuscarText.Size = new Size(157, 23);
            NumeroOrdenInternaBuscarText.TabIndex = 104;
            // 
            // PrepararOrdenForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1074, 299);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(NumeroOrdenInternaBuscarText);
            Controls.Add(CancelarDatosOrdenBtn);
            Controls.Add(listView1);
            Controls.Add(ConfirmarDatosOrdenBtn);
            Controls.Add(SeleccionarBtn);
            Controls.Add(OrdenInt_List);
            Name = "PrepararOrdenForm";
            Text = "PrepararOrdenForm";
            Load += ModificarPreparadorForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button ConfirmarDatosOrdenBtn;
        private ListView OrdenInt_List;
        private ColumnHeader N_Orden_Ext;
        private ColumnHeader N_Orden;
        private ColumnHeader Cliente;
        private ColumnHeader Prioridad;
        private ColumnHeader Estado;
        private ColumnHeader FechaAlta;
        private Button SeleccionarBtn;
        private Button CancelarBusquedaBtn;
        private Button CancelarDatosOrdenBtn;
        private ColumnHeader FechaDespacho;
        private ListView listView1;
        private ColumnHeader Producto;
        private ColumnHeader Cantidad;
        private Label label2;
        private Button button1;
        private Label label1;
        private TextBox NumeroOrdenInternaBuscarText;
    }
}