namespace GrupoCProyectoCAI
{
    partial class ModificarForm
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
            ordenesInternas_lst = new ListView();
            numero_orden_interna = new ColumnHeader();
            numero_orden_externa = new ColumnHeader();
            tipo_producto = new ColumnHeader();
            Cantidades = new ColumnHeader();
            Prioridad = new ColumnHeader();
            Estado = new ColumnHeader();
            fecha_creacion = new ColumnHeader();
            fecha_modificacion = new ColumnHeader();
            groupBox1 = new GroupBox();
            Cancelarbtn = new Button();
            Aceptarbtn = new Button();
            label10 = new Label();
            Estadocmb = new ComboBox();
            label9 = new Label();
            FechaDeModificartxt = new TextBox();
            label8 = new Label();
            FechaDeCreaciontxt = new TextBox();
            label7 = new Label();
            label6 = new Label();
            Prioridadtxt = new TextBox();
            label5 = new Label();
            Clientetxt = new TextBox();
            label4 = new Label();
            Cantidadtxt = new TextBox();
            label3 = new Label();
            TipoDeProductotxt = new TextBox();
            label2 = new Label();
            OrdenExternatxt = new TextBox();
            label1 = new Label();
            OrdenInternatxt = new TextBox();
            FormCancelarbtn = new Button();
            groupBox2 = new GroupBox();
            Buscarbtn = new Button();
            BuscarOrdentxt = new TextBox();
            label11 = new Label();
            seleccionarbtn = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // ordenesInternas_lst
            // 
            ordenesInternas_lst.Columns.AddRange(new ColumnHeader[] { numero_orden_interna, numero_orden_externa, tipo_producto, Cantidades, Prioridad, Estado, fecha_creacion, fecha_modificacion });
            ordenesInternas_lst.Location = new Point(11, 12);
            ordenesInternas_lst.MultiSelect = false;
            ordenesInternas_lst.Name = "ordenesInternas_lst";
            ordenesInternas_lst.Size = new Size(806, 294);
            ordenesInternas_lst.TabIndex = 0;
            ordenesInternas_lst.UseCompatibleStateImageBehavior = false;
            ordenesInternas_lst.View = View.Details;
            // 
            // numero_orden_interna
            // 
            numero_orden_interna.DisplayIndex = 1;
            numero_orden_interna.Text = "N° Orden Int";
            numero_orden_interna.Width = 150;
            // 
            // numero_orden_externa
            // 
            numero_orden_externa.DisplayIndex = 0;
            numero_orden_externa.Text = "N° Orden Ext";
            numero_orden_externa.Width = 150;
            // 
            // tipo_producto
            // 
            tipo_producto.Text = "Tipo de Producto";
            tipo_producto.Width = 150;
            // 
            // Cantidades
            // 
            Cantidades.Text = "Cantidades";
            Cantidades.Width = 100;
            // 
            // Prioridad
            // 
            Prioridad.Text = "Prioridad";
            Prioridad.Width = 100;
            // 
            // Estado
            // 
            Estado.Text = "Estado";
            Estado.Width = 90;
            // 
            // fecha_creacion
            // 
            fecha_creacion.Text = "Fecha de creación";
            fecha_creacion.Width = 180;
            // 
            // fecha_modificacion
            // 
            fecha_modificacion.Text = "Fecha de Modificación";
            fecha_modificacion.Width = 190;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(Cancelarbtn);
            groupBox1.Controls.Add(Aceptarbtn);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(Estadocmb);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(FechaDeModificartxt);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(FechaDeCreaciontxt);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(Prioridadtxt);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(Clientetxt);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(Cantidadtxt);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(TipoDeProductotxt);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(OrdenExternatxt);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(OrdenInternatxt);
            groupBox1.Location = new Point(818, 8);
            groupBox1.Margin = new Padding(2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2);
            groupBox1.Size = new Size(279, 454);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // Cancelarbtn
            // 
            Cancelarbtn.Location = new Point(122, 422);
            Cancelarbtn.Margin = new Padding(2);
            Cancelarbtn.Name = "Cancelarbtn";
            Cancelarbtn.Size = new Size(78, 20);
            Cancelarbtn.TabIndex = 20;
            Cancelarbtn.Text = "Cancelar";
            Cancelarbtn.UseVisualStyleBackColor = true;
            Cancelarbtn.Click += Cancelarbtn_Click;
            // 
            // Aceptarbtn
            // 
            Aceptarbtn.Location = new Point(8, 422);
            Aceptarbtn.Margin = new Padding(2);
            Aceptarbtn.Name = "Aceptarbtn";
            Aceptarbtn.Size = new Size(78, 20);
            Aceptarbtn.TabIndex = 19;
            Aceptarbtn.Text = "Aceptar";
            Aceptarbtn.UseVisualStyleBackColor = true;
            Aceptarbtn.Click += Aceptarbtn_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(4, 410);
            label10.Margin = new Padding(2, 0, 2, 0);
            label10.Name = "label10";
            label10.Size = new Size(0, 15);
            label10.TabIndex = 18;
            // 
            // Estadocmb
            // 
            Estadocmb.FormattingEnabled = true;
            Estadocmb.Location = new Point(4, 382);
            Estadocmb.Margin = new Padding(2);
            Estadocmb.Name = "Estadocmb";
            Estadocmb.Size = new Size(129, 23);
            Estadocmb.TabIndex = 17;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(4, 365);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(42, 15);
            label9.TabIndex = 16;
            label9.Text = "Estado";
            label9.Click += label9_Click;
            // 
            // FechaDeModificartxt
            // 
            FechaDeModificartxt.Location = new Point(4, 338);
            FechaDeModificartxt.Margin = new Padding(2);
            FechaDeModificartxt.Name = "FechaDeModificartxt";
            FechaDeModificartxt.ReadOnly = true;
            FechaDeModificartxt.Size = new Size(148, 23);
            FechaDeModificartxt.TabIndex = 15;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(4, 321);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(108, 15);
            label8.TabIndex = 14;
            label8.Text = "Fecha de Modificar";
            // 
            // FechaDeCreaciontxt
            // 
            FechaDeCreaciontxt.Location = new Point(4, 295);
            FechaDeCreaciontxt.Margin = new Padding(2);
            FechaDeCreaciontxt.Name = "FechaDeCreaciontxt";
            FechaDeCreaciontxt.ReadOnly = true;
            FechaDeCreaciontxt.Size = new Size(148, 23);
            FechaDeCreaciontxt.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(4, 278);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(102, 15);
            label7.TabIndex = 12;
            label7.Text = "Fecha de creacion";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(4, 228);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(55, 15);
            label6.TabIndex = 11;
            label6.Text = "Prioridad";
            // 
            // Prioridadtxt
            // 
            Prioridadtxt.Location = new Point(4, 252);
            Prioridadtxt.Margin = new Padding(2);
            Prioridadtxt.Name = "Prioridadtxt";
            Prioridadtxt.ReadOnly = true;
            Prioridadtxt.Size = new Size(148, 23);
            Prioridadtxt.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(4, 178);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(44, 15);
            label5.TabIndex = 9;
            label5.Text = "Cliente";
            // 
            // Clientetxt
            // 
            Clientetxt.Location = new Point(4, 202);
            Clientetxt.Margin = new Padding(2);
            Clientetxt.Name = "Clientetxt";
            Clientetxt.ReadOnly = true;
            Clientetxt.Size = new Size(148, 23);
            Clientetxt.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(4, 134);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(55, 15);
            label4.TabIndex = 7;
            label4.Text = "Cantidad";
            // 
            // Cantidadtxt
            // 
            Cantidadtxt.Location = new Point(4, 157);
            Cantidadtxt.Margin = new Padding(2);
            Cantidadtxt.Name = "Cantidadtxt";
            Cantidadtxt.Size = new Size(148, 23);
            Cantidadtxt.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(4, 97);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(98, 15);
            label3.TabIndex = 5;
            label3.Text = "Tipo de producto";
            // 
            // TipoDeProductotxt
            // 
            TipoDeProductotxt.Location = new Point(4, 114);
            TipoDeProductotxt.Margin = new Padding(2);
            TipoDeProductotxt.Name = "TipoDeProductotxt";
            TipoDeProductotxt.ReadOnly = true;
            TipoDeProductotxt.Size = new Size(148, 23);
            TipoDeProductotxt.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(4, 60);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(113, 15);
            label2.TabIndex = 3;
            label2.Text = "N° de orden externa";
            label2.Click += label2_Click;
            // 
            // OrdenExternatxt
            // 
            OrdenExternatxt.Location = new Point(4, 77);
            OrdenExternatxt.Margin = new Padding(2);
            OrdenExternatxt.Name = "OrdenExternatxt";
            OrdenExternatxt.ReadOnly = true;
            OrdenExternatxt.Size = new Size(148, 23);
            OrdenExternatxt.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(4, 23);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(111, 15);
            label1.TabIndex = 1;
            label1.Text = "N° de orden interna";
            // 
            // OrdenInternatxt
            // 
            OrdenInternatxt.Location = new Point(4, 40);
            OrdenInternatxt.Margin = new Padding(2);
            OrdenInternatxt.Name = "OrdenInternatxt";
            OrdenInternatxt.ReadOnly = true;
            OrdenInternatxt.Size = new Size(148, 23);
            OrdenInternatxt.TabIndex = 0;
            // 
            // FormCancelarbtn
            // 
            FormCancelarbtn.Location = new Point(1014, 472);
            FormCancelarbtn.Margin = new Padding(2);
            FormCancelarbtn.Name = "FormCancelarbtn";
            FormCancelarbtn.Size = new Size(78, 20);
            FormCancelarbtn.TabIndex = 21;
            FormCancelarbtn.Text = "Cancelar";
            FormCancelarbtn.UseVisualStyleBackColor = true;
            FormCancelarbtn.Click += FormCancelarbtn_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(Buscarbtn);
            groupBox2.Controls.Add(BuscarOrdentxt);
            groupBox2.Controls.Add(label11);
            groupBox2.Location = new Point(20, 326);
            groupBox2.Margin = new Padding(2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(2);
            groupBox2.Size = new Size(774, 145);
            groupBox2.TabIndex = 22;
            groupBox2.TabStop = false;
            groupBox2.Text = "groupBox2";
            // 
            // Buscarbtn
            // 
            Buscarbtn.Location = new Point(325, 35);
            Buscarbtn.Margin = new Padding(2);
            Buscarbtn.Name = "Buscarbtn";
            Buscarbtn.Size = new Size(78, 20);
            Buscarbtn.TabIndex = 23;
            Buscarbtn.Text = "Buscar";
            Buscarbtn.UseVisualStyleBackColor = true;
            Buscarbtn.Click += Buscarbtn_Click;
            // 
            // BuscarOrdentxt
            // 
            BuscarOrdentxt.Location = new Point(150, 35);
            BuscarOrdentxt.Margin = new Padding(2);
            BuscarOrdentxt.Name = "BuscarOrdentxt";
            BuscarOrdentxt.Size = new Size(148, 23);
            BuscarOrdentxt.TabIndex = 22;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(13, 35);
            label11.Margin = new Padding(2, 0, 2, 0);
            label11.Name = "label11";
            label11.Size = new Size(111, 15);
            label11.TabIndex = 21;
            label11.Text = "N° de orden interna";
            // 
            // seleccionarbtn
            // 
            seleccionarbtn.Location = new Point(696, 310);
            seleccionarbtn.Name = "seleccionarbtn";
            seleccionarbtn.Size = new Size(122, 21);
            seleccionarbtn.TabIndex = 23;
            seleccionarbtn.Text = "Seleccionar";
            seleccionarbtn.UseVisualStyleBackColor = true;
            seleccionarbtn.Click += seleccionarbtn_Click;
            // 
            // ModificarForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1102, 496);
            Controls.Add(seleccionarbtn);
            Controls.Add(groupBox2);
            Controls.Add(FormCancelarbtn);
            Controls.Add(groupBox1);
            Controls.Add(ordenesInternas_lst);
            Name = "ModificarForm";
            Text = "ModificarForm";
            Load += ModificarForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ListView ordenesInternas_lst;
        private ColumnHeader numero_orden_externa;
        private ColumnHeader numero_orden_interna;
        private ColumnHeader tipo_producto;
        private ColumnHeader Cantidades;
        private ColumnHeader Prioridad;
        private ColumnHeader Estado;
        private ColumnHeader fecha_creacion;
        private ColumnHeader fecha_modificacion;
        private GroupBox groupBox1;
        private TextBox OrdenInternatxt;
        private Label label2;
        private TextBox OrdenExternatxt;
        private Label label1;
        private Label label4;
        private TextBox Cantidadtxt;
        private Label label3;
        private TextBox TipoDeProductotxt;
        private Label label7;
        private Label label6;
        private TextBox Prioridadtxt;
        private Label label5;
        private TextBox Clientetxt;
        private TextBox FechaDeCreaciontxt;
        private TextBox FechaDeModificartxt;
        private Label label8;
        private Label label9;
        private Button Aceptarbtn;
        private Label label10;
        private ComboBox Estadocmb;
        private Button Cancelarbtn;
        private Button FormCancelarbtn;
        private GroupBox groupBox2;
        private Button Buscarbtn;
        private TextBox BuscarOrdentxt;
        private Label label11;
        private Button seleccionarbtn;
    }
}