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
            OrdenInt_List = new ListView();
            NumOrden = new ColumnHeader();
            FechaEntrega = new ColumnHeader();
            Prioridad = new ColumnHeader();
            Cliente = new ColumnHeader();
            button1 = new Button();
            listView1 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            SuspendLayout();
            // 
            // OrdenInt_List
            // 
            OrdenInt_List.Columns.AddRange(new ColumnHeader[] { NumOrden, Cliente, FechaEntrega, Prioridad });
            OrdenInt_List.FullRowSelect = true;
            OrdenInt_List.GridLines = true;
            OrdenInt_List.Location = new Point(27, 24);
            OrdenInt_List.Margin = new Padding(3, 4, 3, 4);
            OrdenInt_List.MultiSelect = false;
            OrdenInt_List.Name = "OrdenInt_List";
            OrdenInt_List.Size = new Size(441, 367);
            OrdenInt_List.TabIndex = 81;
            OrdenInt_List.UseCompatibleStateImageBehavior = false;
            OrdenInt_List.View = View.Details;
            // 
            // NumOrden
            // 
            NumOrden.Text = "N° de orden";
            NumOrden.Width = 140;
            // 
            // FechaEntrega
            // 
            FechaEntrega.Text = "Fecha de entrega";
            FechaEntrega.Width = 150;
            // 
            // Prioridad
            // 
            Prioridad.Text = "Prioridad";
            Prioridad.Width = 80;
            // 
            // Cliente
            // 
            Cliente.Text = "Cliente";
            // 
            // button1
            // 
            button1.Location = new Point(224, 398);
            button1.Name = "button1";
            button1.Size = new Size(109, 42);
            button1.TabIndex = 82;
            button1.Text = "Ordenar";
            button1.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            listView1.FullRowSelect = true;
            listView1.GridLines = true;
            listView1.Location = new Point(598, 24);
            listView1.Margin = new Padding(3, 4, 3, 4);
            listView1.MultiSelect = false;
            listView1.Name = "listView1";
            listView1.Size = new Size(441, 367);
            listView1.TabIndex = 83;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "N° de orden";
            columnHeader1.Width = 140;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Cliente";
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Fecha de entrega";
            columnHeader3.Width = 150;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Prioridad";
            columnHeader4.Width = 80;
            // 
            // button2
            // 
            button2.Location = new Point(359, 398);
            button2.Name = "button2";
            button2.Size = new Size(109, 42);
            button2.TabIndex = 84;
            button2.Text = "Seleccionar";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(930, 460);
            button3.Name = "button3";
            button3.Size = new Size(109, 42);
            button3.TabIndex = 85;
            button3.Text = "Confirmar";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(918, 398);
            button4.Name = "button4";
            button4.Size = new Size(121, 42);
            button4.TabIndex = 86;
            button4.Text = "Desseleccionar";
            button4.UseVisualStyleBackColor = true;
            // 
            // AltaOrdenSeleccionForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1056, 524);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(listView1);
            Controls.Add(button1);
            Controls.Add(OrdenInt_List);
            Name = "AltaOrdenSeleccionForm";
            Text = "AltaOrdenSeleccion";
            ResumeLayout(false);
        }

        #endregion

        private ListView OrdenInt_List;
        private ColumnHeader NumOrden;
        private ColumnHeader Cliente;
        private ColumnHeader FechaEntrega;
        private ColumnHeader Prioridad;
        private Button button1;
        private ListView listView1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}