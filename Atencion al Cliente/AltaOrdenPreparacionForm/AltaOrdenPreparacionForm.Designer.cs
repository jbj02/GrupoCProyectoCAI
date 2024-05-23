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
            button2 = new Button();
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
            DatosNuevaOrdenInternaGroup.Location = new Point(113, 21);
            DatosNuevaOrdenInternaGroup.Name = "DatosNuevaOrdenInternaGroup";
            DatosNuevaOrdenInternaGroup.Size = new Size(394, 244);
            DatosNuevaOrdenInternaGroup.TabIndex = 134;
            DatosNuevaOrdenInternaGroup.TabStop = false;
            DatosNuevaOrdenInternaGroup.Text = "Datos para alta de orden";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Enabled = false;
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(143, 205);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(82, 23);
            dateTimePicker1.TabIndex = 133;
            dateTimePicker1.Value = new DateTime(2024, 5, 15, 0, 0, 0, 0);
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(143, 185);
            label6.Name = "label6";
            label6.Size = new Size(97, 15);
            label6.TabIndex = 132;
            label6.Text = "Fecha de entrega";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(6, 155);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(120, 23);
            textBox1.TabIndex = 131;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 135);
            label2.Name = "label2";
            label2.Size = new Size(74, 15);
            label2.TabIndex = 130;
            label2.Text = "Transportista";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 37);
            label1.Name = "label1";
            label1.Size = new Size(73, 15);
            label1.TabIndex = 103;
            label1.Text = "N° de Orden";
            // 
            // NumOrdenIntText
            // 
            NumOrdenIntText.Location = new Point(6, 56);
            NumOrdenIntText.Name = "NumOrdenIntText";
            NumOrdenIntText.Size = new Size(361, 23);
            NumOrdenIntText.TabIndex = 104;
            // 
            // FechaCreacionDT
            // 
            FechaCreacionDT.Enabled = false;
            FechaCreacionDT.Format = DateTimePickerFormat.Short;
            FechaCreacionDT.Location = new Point(6, 205);
            FechaCreacionDT.Name = "FechaCreacionDT";
            FechaCreacionDT.Size = new Size(82, 23);
            FechaCreacionDT.TabIndex = 120;
            FechaCreacionDT.Value = new DateTime(2024, 5, 15, 0, 0, 0, 0);
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(5, 185);
            label5.Name = "label5";
            label5.Size = new Size(104, 15);
            label5.TabIndex = 111;
            label5.Text = "Fecha de Creación";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 88);
            label8.Name = "label8";
            label8.Size = new Size(44, 15);
            label8.TabIndex = 115;
            label8.Text = "Cliente";
            // 
            // ClienteText
            // 
            ClienteText.Location = new Point(6, 108);
            ClienteText.Name = "ClienteText";
            ClienteText.Size = new Size(361, 23);
            ClienteText.TabIndex = 116;
            // 
            // CancelarDatosNuevaOrdenInternaBtn
            // 
            CancelarDatosNuevaOrdenInternaBtn.Location = new Point(548, 572);
            CancelarDatosNuevaOrdenInternaBtn.Name = "CancelarDatosNuevaOrdenInternaBtn";
            CancelarDatosNuevaOrdenInternaBtn.Size = new Size(97, 32);
            CancelarDatosNuevaOrdenInternaBtn.TabIndex = 129;
            CancelarDatosNuevaOrdenInternaBtn.Text = "Cancelar";
            CancelarDatosNuevaOrdenInternaBtn.UseVisualStyleBackColor = true;
            // 
            // AceptarDatosNuevaOrdenInternaBtn
            // 
            AceptarDatosNuevaOrdenInternaBtn.Location = new Point(234, 572);
            AceptarDatosNuevaOrdenInternaBtn.Name = "AceptarDatosNuevaOrdenInternaBtn";
            AceptarDatosNuevaOrdenInternaBtn.Size = new Size(97, 32);
            AceptarDatosNuevaOrdenInternaBtn.TabIndex = 117;
            AceptarDatosNuevaOrdenInternaBtn.Text = "Confirmar";
            AceptarDatosNuevaOrdenInternaBtn.UseVisualStyleBackColor = true;
            // 
            // TipoDeProductoText
            // 
            TipoDeProductoText.Location = new Point(360, 328);
            TipoDeProductoText.Name = "TipoDeProductoText";
            TipoDeProductoText.Size = new Size(245, 23);
            TipoDeProductoText.TabIndex = 110;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(360, 356);
            label3.Name = "label3";
            label3.Size = new Size(55, 15);
            label3.TabIndex = 107;
            label3.Text = "Cantidad";
            // 
            // CantidadText
            // 
            CantidadText.Location = new Point(360, 375);
            CantidadText.Name = "CantidadText";
            CantidadText.Size = new Size(245, 23);
            CantidadText.TabIndex = 108;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(360, 309);
            label4.Name = "label4";
            label4.Size = new Size(98, 15);
            label4.TabIndex = 109;
            label4.Text = "Tipo de Producto";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(858, 89);
            label9.Name = "label9";
            label9.Size = new Size(0, 15);
            label9.TabIndex = 133;
            // 
            // OrdenExt_List
            // 
            OrdenExt_List.Columns.AddRange(new ColumnHeader[] { Tipo_Producto, Cantidad });
            OrdenExt_List.FullRowSelect = true;
            OrdenExt_List.GridLines = true;
            OrdenExt_List.Location = new Point(119, 304);
            OrdenExt_List.MultiSelect = false;
            OrdenExt_List.Name = "OrdenExt_List";
            OrdenExt_List.Size = new Size(212, 190);
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
            SeleccionarBtn.Location = new Point(413, 416);
            SeleccionarBtn.Name = "SeleccionarBtn";
            SeleccionarBtn.Size = new Size(138, 32);
            SeleccionarBtn.TabIndex = 131;
            SeleccionarBtn.Text = "Agregar a la lista";
            SeleccionarBtn.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(149, 500);
            button1.Name = "button1";
            button1.Size = new Size(144, 32);
            button1.TabIndex = 135;
            button1.Text = "Borrar seleccionado";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(383, 572);
            button2.Name = "button2";
            button2.Size = new Size(97, 32);
            button2.TabIndex = 136;
            button2.Text = "Reestablecer";
            button2.UseVisualStyleBackColor = true;
            // 
            // AltaOrdenPreparacionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(673, 616);
            Controls.Add(button2);
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
            Margin = new Padding(3, 2, 3, 2);
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
        private Button button2;
    }
}