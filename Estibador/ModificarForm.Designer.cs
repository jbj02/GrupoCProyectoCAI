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
            numero_orden_externa = new ColumnHeader();
            numero_orden_interna = new ColumnHeader();
            tipo_producto = new ColumnHeader();
            Cantidades = new ColumnHeader();
            Prioridad = new ColumnHeader();
            Estado = new ColumnHeader();
            fecha_creacion = new ColumnHeader();
            fecha_modificacion = new ColumnHeader();
            groupBox1 = new GroupBox();
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
            Estadocmb = new ComboBox();
            label10 = new Label();
            Aceptarbtn = new Button();
            Cancelarbtn = new Button();
            FormCancelarbtn = new Button();
            groupBox2 = new GroupBox();
            label11 = new Label();
            BuscarOrdentxt = new TextBox();
            Buscarbtn = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // ordenesInternas_lst
            // 
            ordenesInternas_lst.Columns.AddRange(new ColumnHeader[] { numero_orden_externa, numero_orden_interna, tipo_producto, Cantidades, Prioridad, Estado, fecha_creacion, fecha_modificacion });
            ordenesInternas_lst.Location = new Point(13, 14);
            ordenesInternas_lst.Margin = new Padding(4, 5, 4, 5);
            ordenesInternas_lst.MultiSelect = false;
            ordenesInternas_lst.Name = "ordenesInternas_lst";
            ordenesInternas_lst.Size = new Size(1149, 488);
            ordenesInternas_lst.TabIndex = 0;
            ordenesInternas_lst.UseCompatibleStateImageBehavior = false;
            ordenesInternas_lst.View = View.Details;
            // 
            // numero_orden_externa
            // 
            numero_orden_externa.Text = "N° Orden Ext";
            numero_orden_externa.Width = 150;
            // 
            // numero_orden_interna
            // 
            numero_orden_interna.Text = "N° Orden Int";
            numero_orden_interna.Width = 150;
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
            groupBox1.Location = new Point(1169, 14);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(399, 757);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(6, 609);
            label9.Name = "label9";
            label9.Size = new Size(66, 25);
            label9.TabIndex = 16;
            label9.Text = "Estado";
            label9.Click += label9_Click;
            // 
            // FechaDeModificartxt
            // 
            FechaDeModificartxt.Location = new Point(6, 563);
            FechaDeModificartxt.Name = "FechaDeModificartxt";
            FechaDeModificartxt.ReadOnly = true;
            FechaDeModificartxt.Size = new Size(210, 31);
            FechaDeModificartxt.TabIndex = 15;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 535);
            label8.Name = "label8";
            label8.Size = new Size(162, 25);
            label8.TabIndex = 14;
            label8.Text = "Fecha de Modificar";
            // 
            // FechaDeCreaciontxt
            // 
            FechaDeCreaciontxt.Location = new Point(6, 491);
            FechaDeCreaciontxt.Name = "FechaDeCreaciontxt";
            FechaDeCreaciontxt.ReadOnly = true;
            FechaDeCreaciontxt.Size = new Size(210, 31);
            FechaDeCreaciontxt.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 463);
            label7.Name = "label7";
            label7.Size = new Size(152, 25);
            label7.TabIndex = 12;
            label7.Text = "Fecha de creacion";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 380);
            label6.Name = "label6";
            label6.Size = new Size(84, 25);
            label6.TabIndex = 11;
            label6.Text = "Prioridad";
            // 
            // Prioridadtxt
            // 
            Prioridadtxt.Location = new Point(6, 420);
            Prioridadtxt.Name = "Prioridadtxt";
            Prioridadtxt.ReadOnly = true;
            Prioridadtxt.Size = new Size(210, 31);
            Prioridadtxt.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 296);
            label5.Name = "label5";
            label5.Size = new Size(65, 25);
            label5.TabIndex = 9;
            label5.Text = "Cliente";
            // 
            // Clientetxt
            // 
            Clientetxt.Location = new Point(6, 337);
            Clientetxt.Name = "Clientetxt";
            Clientetxt.ReadOnly = true;
            Clientetxt.Size = new Size(210, 31);
            Clientetxt.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 224);
            label4.Name = "label4";
            label4.Size = new Size(83, 25);
            label4.TabIndex = 7;
            label4.Text = "Cantidad";
            // 
            // Cantidadtxt
            // 
            Cantidadtxt.Location = new Point(6, 262);
            Cantidadtxt.Name = "Cantidadtxt";
            Cantidadtxt.Size = new Size(210, 31);
            Cantidadtxt.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 162);
            label3.Name = "label3";
            label3.Size = new Size(151, 25);
            label3.TabIndex = 5;
            label3.Text = "Tipo de producto";
            // 
            // TipoDeProductotxt
            // 
            TipoDeProductotxt.Location = new Point(6, 190);
            TipoDeProductotxt.Name = "TipoDeProductotxt";
            TipoDeProductotxt.ReadOnly = true;
            TipoDeProductotxt.Size = new Size(210, 31);
            TipoDeProductotxt.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 100);
            label2.Name = "label2";
            label2.Size = new Size(171, 25);
            label2.TabIndex = 3;
            label2.Text = "N° de orden externa";
            label2.Click += label2_Click;
            // 
            // OrdenExternatxt
            // 
            OrdenExternatxt.Location = new Point(6, 128);
            OrdenExternatxt.Name = "OrdenExternatxt";
            OrdenExternatxt.ReadOnly = true;
            OrdenExternatxt.Size = new Size(210, 31);
            OrdenExternatxt.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 38);
            label1.Name = "label1";
            label1.Size = new Size(168, 25);
            label1.TabIndex = 1;
            label1.Text = "N° de orden interna";
            // 
            // OrdenInternatxt
            // 
            OrdenInternatxt.Location = new Point(6, 66);
            OrdenInternatxt.Name = "OrdenInternatxt";
            OrdenInternatxt.ReadOnly = true;
            OrdenInternatxt.Size = new Size(210, 31);
            OrdenInternatxt.TabIndex = 0;
            // 
            // Estadocmb
            // 
            Estadocmb.FormattingEnabled = true;
            Estadocmb.Location = new Point(6, 637);
            Estadocmb.Name = "Estadocmb";
            Estadocmb.Size = new Size(182, 33);
            Estadocmb.TabIndex = 17;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(6, 683);
            label10.Name = "label10";
            label10.Size = new Size(0, 25);
            label10.TabIndex = 18;
            // 
            // Aceptarbtn
            // 
            Aceptarbtn.Location = new Point(12, 704);
            Aceptarbtn.Name = "Aceptarbtn";
            Aceptarbtn.Size = new Size(112, 34);
            Aceptarbtn.TabIndex = 19;
            Aceptarbtn.Text = "Aceptar";
            Aceptarbtn.UseVisualStyleBackColor = true;
            // 
            // Cancelarbtn
            // 
            Cancelarbtn.Location = new Point(174, 704);
            Cancelarbtn.Name = "Cancelarbtn";
            Cancelarbtn.Size = new Size(112, 34);
            Cancelarbtn.TabIndex = 20;
            Cancelarbtn.Text = "Cancelar";
            Cancelarbtn.UseVisualStyleBackColor = true;
            // 
            // FormCancelarbtn
            // 
            FormCancelarbtn.Location = new Point(1449, 786);
            FormCancelarbtn.Name = "FormCancelarbtn";
            FormCancelarbtn.Size = new Size(112, 34);
            FormCancelarbtn.TabIndex = 21;
            FormCancelarbtn.Text = "Cancelar";
            FormCancelarbtn.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(Buscarbtn);
            groupBox2.Controls.Add(BuscarOrdentxt);
            groupBox2.Controls.Add(label11);
            groupBox2.Location = new Point(28, 543);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1105, 242);
            groupBox2.TabIndex = 22;
            groupBox2.TabStop = false;
            groupBox2.Text = "groupBox2";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(18, 58);
            label11.Name = "label11";
            label11.Size = new Size(168, 25);
            label11.TabIndex = 21;
            label11.Text = "N° de orden interna";
            // 
            // BuscarOrdentxt
            // 
            BuscarOrdentxt.Location = new Point(214, 58);
            BuscarOrdentxt.Name = "BuscarOrdentxt";
            BuscarOrdentxt.Size = new Size(210, 31);
            BuscarOrdentxt.TabIndex = 22;
            // 
            // Buscarbtn
            // 
            Buscarbtn.Location = new Point(464, 58);
            Buscarbtn.Name = "Buscarbtn";
            Buscarbtn.Size = new Size(112, 34);
            Buscarbtn.TabIndex = 23;
            Buscarbtn.Text = "Buscar";
            Buscarbtn.UseVisualStyleBackColor = true;
            // 
            // ModificarForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1574, 827);
            Controls.Add(groupBox2);
            Controls.Add(FormCancelarbtn);
            Controls.Add(groupBox1);
            Controls.Add(ordenesInternas_lst);
            Margin = new Padding(4, 5, 4, 5);
            Name = "ModificarForm";
            Text = "ModificarForm";
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
    }
}