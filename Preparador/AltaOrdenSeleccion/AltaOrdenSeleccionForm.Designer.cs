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
            Cliente = new ColumnHeader();
            FechaEntrega = new ColumnHeader();
            Prioridad = new ColumnHeader();
            button1 = new Button();
            listView1 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // OrdenInt_List
            // 
            OrdenInt_List.Columns.AddRange(new ColumnHeader[] { NumOrden, Cliente, FechaEntrega, Prioridad });
            OrdenInt_List.FullRowSelect = true;
            OrdenInt_List.GridLines = true;
            OrdenInt_List.Location = new Point(24, 30);
            OrdenInt_List.MultiSelect = false;
            OrdenInt_List.Name = "OrdenInt_List";
            OrdenInt_List.Size = new Size(435, 276);
            OrdenInt_List.TabIndex = 81;
            OrdenInt_List.UseCompatibleStateImageBehavior = false;
            OrdenInt_List.View = View.Details;
            // 
            // NumOrden
            // 
            NumOrden.Text = "N° de orden";
            NumOrden.Width = 140;
            // 
            // Cliente
            // 
            Cliente.Text = "Cliente";
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
            // button1
            // 
            button1.Location = new Point(243, 310);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(95, 32);
            button1.TabIndex = 82;
            button1.Text = "Ordenar";
            button1.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            listView1.FullRowSelect = true;
            listView1.GridLines = true;
            listView1.Location = new Point(523, 30);
            listView1.MultiSelect = false;
            listView1.Name = "listView1";
            listView1.Size = new Size(439, 276);
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
            button2.Location = new Point(364, 310);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(95, 32);
            button2.TabIndex = 84;
            button2.Text = "Seleccionar";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(750, 355);
            button3.Margin = new Padding(3, 2, 3, 2);
            button3.Name = "button3";
            button3.Size = new Size(95, 32);
            button3.TabIndex = 85;
            button3.Text = "Confirmar";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(856, 311);
            button4.Margin = new Padding(3, 2, 3, 2);
            button4.Name = "button4";
            button4.Size = new Size(106, 32);
            button4.TabIndex = 86;
            button4.Text = "Desseleccionar";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(867, 355);
            button5.Margin = new Padding(3, 2, 3, 2);
            button5.Name = "button5";
            button5.Size = new Size(95, 32);
            button5.TabIndex = 87;
            button5.Text = "Cancelar";
            button5.UseVisualStyleBackColor = true;
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
            ClientSize = new Size(1002, 398);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(listView1);
            Controls.Add(button1);
            Controls.Add(OrdenInt_List);
            Margin = new Padding(3, 2, 3, 2);
            Name = "AltaOrdenSeleccionForm";
            Text = "AltaOrdenSeleccion";
            ResumeLayout(false);
            PerformLayout();
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
        private Button button5;
        private Label label1;
        private Label label2;
    }
}