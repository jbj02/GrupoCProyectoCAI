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
            DatosNuevaOrdenInternaGroup = new GroupBox();
            dateTimePicker1 = new DateTimePicker();
            label6 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            label1 = new Label();
            NumOrdenIntText = new TextBox();
            FechaCreacionDT = new DateTimePicker();
            label5 = new Label();
            label8 = new Label();
            ClienteText = new TextBox();
            CancelarDatosNuevaOrdenInternaBtn = new Button();
            AceptarDatosNuevaOrdenInternaBtn = new Button();
            TipoDeProductoText = new TextBox();
            label3 = new Label();
            CantidadText = new TextBox();
            label4 = new Label();
            label9 = new Label();
            OrdenExt_List = new ListView();
            Tipo_Producto = new ColumnHeader();
            Cantidad = new ColumnHeader();
            SeleccionarBtn = new Button();
            button1 = new Button();
            DatosNuevaOrdenInternaGroup.SuspendLayout();
            SuspendLayout();
            // 
            // DatosNuevaOrdenInternaGroup
            // 
            DatosNuevaOrdenInternaGroup.Controls.Add(dateTimePicker1);
            DatosNuevaOrdenInternaGroup.Controls.Add(label6);
            DatosNuevaOrdenInternaGroup.Controls.Add(textBox1);
            DatosNuevaOrdenInternaGroup.Controls.Add(label2);
            DatosNuevaOrdenInternaGroup.Controls.Add(label1);
            DatosNuevaOrdenInternaGroup.Controls.Add(NumOrdenIntText);
            DatosNuevaOrdenInternaGroup.Controls.Add(FechaCreacionDT);
            DatosNuevaOrdenInternaGroup.Controls.Add(label5);
            DatosNuevaOrdenInternaGroup.Controls.Add(label8);
            DatosNuevaOrdenInternaGroup.Controls.Add(ClienteText);
            DatosNuevaOrdenInternaGroup.Enabled = false;
            DatosNuevaOrdenInternaGroup.Location = new Point(129, 28);
            DatosNuevaOrdenInternaGroup.Margin = new Padding(3, 4, 3, 4);
            DatosNuevaOrdenInternaGroup.Name = "DatosNuevaOrdenInternaGroup";
            DatosNuevaOrdenInternaGroup.Padding = new Padding(3, 4, 3, 4);
            DatosNuevaOrdenInternaGroup.Size = new Size(450, 361);
            DatosNuevaOrdenInternaGroup.TabIndex = 134;
            DatosNuevaOrdenInternaGroup.TabStop = false;
            DatosNuevaOrdenInternaGroup.Text = "Datos para alta de orden";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Enabled = false;
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(163, 273);
            dateTimePicker1.Margin = new Padding(3, 4, 3, 4);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(93, 27);
            dateTimePicker1.TabIndex = 133;
            dateTimePicker1.Value = new DateTime(2024, 5, 15, 0, 0, 0, 0);
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(163, 247);
            label6.Name = "label6";
            label6.Size = new Size(123, 20);
            label6.TabIndex = 132;
            label6.Text = "Fecha de entrega";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(7, 207);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(137, 27);
            textBox1.TabIndex = 131;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(7, 180);
            label2.Name = "label2";
            label2.Size = new Size(94, 20);
            label2.TabIndex = 130;
            label2.Text = "Transportista";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(7, 49);
            label1.Name = "label1";
            label1.Size = new Size(92, 20);
            label1.TabIndex = 103;
            label1.Text = "N° de Orden";
            // 
            // NumOrdenIntText
            // 
            NumOrdenIntText.Location = new Point(7, 75);
            NumOrdenIntText.Margin = new Padding(3, 4, 3, 4);
            NumOrdenIntText.Name = "NumOrdenIntText";
            NumOrdenIntText.Size = new Size(412, 27);
            NumOrdenIntText.TabIndex = 104;
            // 
            // FechaCreacionDT
            // 
            FechaCreacionDT.Enabled = false;
            FechaCreacionDT.Format = DateTimePickerFormat.Short;
            FechaCreacionDT.Location = new Point(7, 273);
            FechaCreacionDT.Margin = new Padding(3, 4, 3, 4);
            FechaCreacionDT.Name = "FechaCreacionDT";
            FechaCreacionDT.Size = new Size(93, 27);
            FechaCreacionDT.TabIndex = 120;
            FechaCreacionDT.Value = new DateTime(2024, 5, 15, 0, 0, 0, 0);
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 247);
            label5.Name = "label5";
            label5.Size = new Size(130, 20);
            label5.TabIndex = 111;
            label5.Text = "Fecha de Creación";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(7, 118);
            label8.Name = "label8";
            label8.Size = new Size(55, 20);
            label8.TabIndex = 115;
            label8.Text = "Cliente";
            // 
            // ClienteText
            // 
            ClienteText.Location = new Point(7, 144);
            ClienteText.Margin = new Padding(3, 4, 3, 4);
            ClienteText.Name = "ClienteText";
            ClienteText.Size = new Size(412, 27);
            ClienteText.TabIndex = 116;
            // 
            // CancelarDatosNuevaOrdenInternaBtn
            // 
            CancelarDatosNuevaOrdenInternaBtn.Location = new Point(579, 766);
            CancelarDatosNuevaOrdenInternaBtn.Margin = new Padding(3, 4, 3, 4);
            CancelarDatosNuevaOrdenInternaBtn.Name = "CancelarDatosNuevaOrdenInternaBtn";
            CancelarDatosNuevaOrdenInternaBtn.Size = new Size(111, 43);
            CancelarDatosNuevaOrdenInternaBtn.TabIndex = 129;
            CancelarDatosNuevaOrdenInternaBtn.Text = "Cancelar";
            CancelarDatosNuevaOrdenInternaBtn.UseVisualStyleBackColor = true;
            // 
            // AceptarDatosNuevaOrdenInternaBtn
            // 
            AceptarDatosNuevaOrdenInternaBtn.Location = new Point(439, 766);
            AceptarDatosNuevaOrdenInternaBtn.Margin = new Padding(3, 4, 3, 4);
            AceptarDatosNuevaOrdenInternaBtn.Name = "AceptarDatosNuevaOrdenInternaBtn";
            AceptarDatosNuevaOrdenInternaBtn.Size = new Size(111, 43);
            AceptarDatosNuevaOrdenInternaBtn.TabIndex = 117;
            AceptarDatosNuevaOrdenInternaBtn.Text = "Confirmar";
            AceptarDatosNuevaOrdenInternaBtn.UseVisualStyleBackColor = true;
            // 
            // TipoDeProductoText
            // 
            TipoDeProductoText.Location = new Point(411, 438);
            TipoDeProductoText.Margin = new Padding(3, 4, 3, 4);
            TipoDeProductoText.Name = "TipoDeProductoText";
            TipoDeProductoText.Size = new Size(279, 27);
            TipoDeProductoText.TabIndex = 110;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(411, 474);
            label3.Name = "label3";
            label3.Size = new Size(69, 20);
            label3.TabIndex = 107;
            label3.Text = "Cantidad";
            // 
            // CantidadText
            // 
            CantidadText.Location = new Point(411, 500);
            CantidadText.Margin = new Padding(3, 4, 3, 4);
            CantidadText.Name = "CantidadText";
            CantidadText.Size = new Size(279, 27);
            CantidadText.TabIndex = 108;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(411, 412);
            label4.Name = "label4";
            label4.Size = new Size(124, 20);
            label4.TabIndex = 109;
            label4.Text = "Tipo de Producto";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(981, 119);
            label9.Name = "label9";
            label9.Size = new Size(0, 20);
            label9.TabIndex = 133;
            // 
            // OrdenExt_List
            // 
            OrdenExt_List.Columns.AddRange(new ColumnHeader[] { Tipo_Producto, Cantidad });
            OrdenExt_List.FullRowSelect = true;
            OrdenExt_List.GridLines = true;
            OrdenExt_List.Location = new Point(136, 406);
            OrdenExt_List.Margin = new Padding(3, 4, 3, 4);
            OrdenExt_List.MultiSelect = false;
            OrdenExt_List.Name = "OrdenExt_List";
            OrdenExt_List.Size = new Size(242, 252);
            OrdenExt_List.TabIndex = 132;
            OrdenExt_List.UseCompatibleStateImageBehavior = false;
            OrdenExt_List.View = View.Details;
            // 
            // Tipo_Producto
            // 
            Tipo_Producto.Text = "Tipo Producto";
            Tipo_Producto.Width = 120;
            // 
            // Cantidad
            // 
            Cantidad.Text = "Cantidad";
            Cantidad.Width = 120;
            // 
            // SeleccionarBtn
            // 
            SeleccionarBtn.Location = new Point(472, 555);
            SeleccionarBtn.Margin = new Padding(3, 4, 3, 4);
            SeleccionarBtn.Name = "SeleccionarBtn";
            SeleccionarBtn.Size = new Size(158, 43);
            SeleccionarBtn.TabIndex = 131;
            SeleccionarBtn.Text = "Agregar a la lista";
            SeleccionarBtn.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(179, 666);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(164, 43);
            button1.TabIndex = 135;
            button1.Text = "Borrar seleccionado";
            button1.UseVisualStyleBackColor = true;
            // 
            // AltaOrdenPreparacionForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(808, 822);
            Controls.Add(OrdenExt_List);
            Controls.Add(button1);
            Controls.Add(DatosNuevaOrdenInternaGroup);
            Controls.Add(TipoDeProductoText);
            Controls.Add(label9);
            Controls.Add(CancelarDatosNuevaOrdenInternaBtn);
            Controls.Add(SeleccionarBtn);
            Controls.Add(AceptarDatosNuevaOrdenInternaBtn);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(CantidadText);
            Name = "AltaOrdenPreparacionForm";
            Text = "AltaOrdenPreparacionForm";
            DatosNuevaOrdenInternaGroup.ResumeLayout(false);
            DatosNuevaOrdenInternaGroup.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox DatosNuevaOrdenInternaGroup;
        private Button CancelarDatosNuevaOrdenInternaBtn;
        private Label label1;
        private TextBox NumOrdenIntText;
        private Button AceptarDatosNuevaOrdenInternaBtn;
        private Label label3;
        private TextBox CantidadText;
        private DateTimePicker FechaCreacionDT;
        private Label label5;
        private Label label8;
        private TextBox ClienteText;
        private TextBox TipoDeProductoText;
        private Label label4;
        private Label label9;
        private ListView OrdenExt_List;
        private ColumnHeader Tipo_Producto;
        private ColumnHeader Cantidad;
        private DateTimePicker dateTimePicker1;
        private Label label6;
        private TextBox textBox1;
        private Label label2;
        private Button SeleccionarBtn;
        private Button button1;
    }
}