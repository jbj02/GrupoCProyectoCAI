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
            DatosAltaOrdenSeleccionGroup = new GroupBox();
            dateTimePicker1 = new DateTimePicker();
            OrdenExt_List = new ListView();
            Producto = new ColumnHeader();
            Cantidad = new ColumnHeader();
            button1 = new Button();
            label6 = new Label();
            textBox1 = new TextBox();
            TipoDeProductoText = new TextBox();
            label2 = new Label();
            label1 = new Label();
            NumOrdenIntText = new TextBox();
            SeleccionarBtn = new Button();
            FechaCreacionDT = new DateTimePicker();
            label5 = new Label();
            label3 = new Label();
            label8 = new Label();
            label4 = new Label();
            ClienteText = new TextBox();
            CantidadText = new TextBox();
            label9 = new Label();
            CancelarDatosNuevaOrdenInternaBtn = new Button();
            AceptarDatosNuevaOrdenInternaBtn = new Button();
            button2 = new Button();
            DatosAltaOrdenSeleccionGroup.SuspendLayout();
            SuspendLayout();
            // 
            // DatosAltaOrdenSeleccionGroup
            // 
            DatosAltaOrdenSeleccionGroup.Controls.Add(dateTimePicker1);
            DatosAltaOrdenSeleccionGroup.Controls.Add(OrdenExt_List);
            DatosAltaOrdenSeleccionGroup.Controls.Add(button1);
            DatosAltaOrdenSeleccionGroup.Controls.Add(label6);
            DatosAltaOrdenSeleccionGroup.Controls.Add(textBox1);
            DatosAltaOrdenSeleccionGroup.Controls.Add(TipoDeProductoText);
            DatosAltaOrdenSeleccionGroup.Controls.Add(label2);
            DatosAltaOrdenSeleccionGroup.Controls.Add(label1);
            DatosAltaOrdenSeleccionGroup.Controls.Add(NumOrdenIntText);
            DatosAltaOrdenSeleccionGroup.Controls.Add(SeleccionarBtn);
            DatosAltaOrdenSeleccionGroup.Controls.Add(FechaCreacionDT);
            DatosAltaOrdenSeleccionGroup.Controls.Add(label5);
            DatosAltaOrdenSeleccionGroup.Controls.Add(label3);
            DatosAltaOrdenSeleccionGroup.Controls.Add(label8);
            DatosAltaOrdenSeleccionGroup.Controls.Add(label4);
            DatosAltaOrdenSeleccionGroup.Controls.Add(ClienteText);
            DatosAltaOrdenSeleccionGroup.Controls.Add(CantidadText);
            DatosAltaOrdenSeleccionGroup.Enabled = false;
            DatosAltaOrdenSeleccionGroup.Location = new Point(68, 12);
            DatosAltaOrdenSeleccionGroup.Name = "DatosAltaOrdenSeleccionGroup";
            DatosAltaOrdenSeleccionGroup.Size = new Size(500, 474);
            DatosAltaOrdenSeleccionGroup.TabIndex = 134;
            DatosAltaOrdenSeleccionGroup.TabStop = false;
            DatosAltaOrdenSeleccionGroup.Text = "Datos para alta de orden selección";
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
            // OrdenExt_List
            // 
            OrdenExt_List.Columns.AddRange(new ColumnHeader[] { Producto, Cantidad });
            OrdenExt_List.FullRowSelect = true;
            OrdenExt_List.GridLines = true;
            OrdenExt_List.Location = new Point(6, 243);
            OrdenExt_List.MultiSelect = false;
            OrdenExt_List.Name = "OrdenExt_List";
            OrdenExt_List.Size = new Size(212, 190);
            OrdenExt_List.TabIndex = 132;
            OrdenExt_List.UseCompatibleStateImageBehavior = false;
            OrdenExt_List.View = View.Details;
            // 
            // Producto
            // 
            Producto.Text = "Producto";
            Producto.Width = 120;
            // 
            // Cantidad
            // 
            Cantidad.Text = "Cantidad";
            Cantidad.Width = 120;
            // 
            // button1
            // 
            button1.Location = new Point(36, 439);
            button1.Name = "button1";
            button1.Size = new Size(144, 32);
            button1.TabIndex = 135;
            button1.Text = "Borrar seleccionado";
            button1.UseVisualStyleBackColor = true;
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
            // TipoDeProductoText
            // 
            TipoDeProductoText.Location = new Point(247, 267);
            TipoDeProductoText.Name = "TipoDeProductoText";
            TipoDeProductoText.Size = new Size(245, 23);
            TipoDeProductoText.TabIndex = 110;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 135);
            label2.Name = "label2";
            label2.Size = new Size(110, 15);
            label2.TabIndex = 130;
            label2.Text = "Transportista (CUIT)";
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
            // SeleccionarBtn
            // 
            SeleccionarBtn.Location = new Point(300, 355);
            SeleccionarBtn.Name = "SeleccionarBtn";
            SeleccionarBtn.Size = new Size(138, 32);
            SeleccionarBtn.TabIndex = 131;
            SeleccionarBtn.Text = "Agregar a la lista";
            SeleccionarBtn.UseVisualStyleBackColor = true;
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
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(247, 295);
            label3.Name = "label3";
            label3.Size = new Size(55, 15);
            label3.TabIndex = 107;
            label3.Text = "Cantidad";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 88);
            label8.Name = "label8";
            label8.Size = new Size(80, 15);
            label8.TabIndex = 115;
            label8.Text = "Cliente (CUIT)";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(247, 248);
            label4.Name = "label4";
            label4.Size = new Size(56, 15);
            label4.TabIndex = 109;
            label4.Text = "Producto";
            // 
            // ClienteText
            // 
            ClienteText.Location = new Point(6, 108);
            ClienteText.Name = "ClienteText";
            ClienteText.Size = new Size(361, 23);
            ClienteText.TabIndex = 116;
            // 
            // CantidadText
            // 
            CantidadText.Location = new Point(247, 314);
            CantidadText.Name = "CantidadText";
            CantidadText.Size = new Size(245, 23);
            CantidadText.TabIndex = 108;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(858, 89);
            label9.Name = "label9";
            label9.Size = new Size(0, 15);
            label9.TabIndex = 133;
            // 
            // CancelarDatosNuevaOrdenInternaBtn
            // 
            CancelarDatosNuevaOrdenInternaBtn.Location = new Point(527, 528);
            CancelarDatosNuevaOrdenInternaBtn.Name = "CancelarDatosNuevaOrdenInternaBtn";
            CancelarDatosNuevaOrdenInternaBtn.Size = new Size(97, 32);
            CancelarDatosNuevaOrdenInternaBtn.TabIndex = 138;
            CancelarDatosNuevaOrdenInternaBtn.Text = "Cancelar";
            CancelarDatosNuevaOrdenInternaBtn.UseVisualStyleBackColor = true;
            // 
            // AceptarDatosNuevaOrdenInternaBtn
            // 
            AceptarDatosNuevaOrdenInternaBtn.Location = new Point(196, 492);
            AceptarDatosNuevaOrdenInternaBtn.Name = "AceptarDatosNuevaOrdenInternaBtn";
            AceptarDatosNuevaOrdenInternaBtn.Size = new Size(97, 32);
            AceptarDatosNuevaOrdenInternaBtn.TabIndex = 137;
            AceptarDatosNuevaOrdenInternaBtn.Text = "Confirmar";
            AceptarDatosNuevaOrdenInternaBtn.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(355, 492);
            button2.Name = "button2";
            button2.Size = new Size(97, 32);
            button2.TabIndex = 139;
            button2.Text = "Reestablecer";
            button2.UseVisualStyleBackColor = true;
            // 
            // AltaOrdenPreparacionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(636, 572);
            Controls.Add(button2);
            Controls.Add(CancelarDatosNuevaOrdenInternaBtn);
            Controls.Add(AceptarDatosNuevaOrdenInternaBtn);
            Controls.Add(DatosAltaOrdenSeleccionGroup);
            Controls.Add(label9);
            Margin = new Padding(3, 2, 3, 2);
            Name = "AltaOrdenPreparacionForm";
            Text = "AltaOrdenPreparacionForm";
            DatosAltaOrdenSeleccionGroup.ResumeLayout(false);
            DatosAltaOrdenSeleccionGroup.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox DatosAltaOrdenSeleccionGroup;
        private Label label1;
        private TextBox NumOrdenIntText;
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
        private ColumnHeader Producto;
        private ColumnHeader Cantidad;
        private DateTimePicker dateTimePicker1;
        private Label label6;
        private TextBox textBox1;
        private Label label2;
        private Button SeleccionarBtn;
        private Button button1;
        private Button CancelarDatosNuevaOrdenInternaBtn;
        private Button AceptarDatosNuevaOrdenInternaBtn;
        private Button button2;
    }
}