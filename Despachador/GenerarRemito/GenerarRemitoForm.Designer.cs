namespace GrupoCProyectoCAI.Despachador.GenerarRemito
{
    partial class GenerarRemitoForm
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
            label1 = new Label();
            label2 = new Label();
            label5 = new Label();
            NumOrdenIntText = new TextBox();
            label6 = new Label();
            GenerarRemitoBtn = new Button();
            FechaDT = new TextBox();
            groupBox1 = new GroupBox();
            BuscarBtn = new Button();
            label7 = new Label();
            NumeroOrdenInternaBuscarText = new TextBox();
            DatosOrdenGroup = new GroupBox();
            Deposito = new TextBox();
            BorrarBtn = new Button();
            label8 = new Label();
            textBox1 = new TextBox();
            label3 = new Label();
            textBox2 = new TextBox();
            groupBox1.SuspendLayout();
            DatosOrdenGroup.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(5, 35);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 0;
            label1.Text = "Orden";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(5, 105);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(0, 20);
            label2.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(5, 146);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(70, 20);
            label5.TabIndex = 4;
            label5.Text = "Deposito";
            // 
            // NumOrdenIntText
            // 
            NumOrdenIntText.Location = new Point(138, 32);
            NumOrdenIntText.Margin = new Padding(2);
            NumOrdenIntText.Name = "NumOrdenIntText";
            NumOrdenIntText.ReadOnly = true;
            NumOrdenIntText.Size = new Size(122, 27);
            NumOrdenIntText.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(14, 185);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(47, 20);
            label6.TabIndex = 8;
            label6.Text = "Fecha";
            // 
            // GenerarRemitoBtn
            // 
            GenerarRemitoBtn.Location = new Point(66, 387);
            GenerarRemitoBtn.Margin = new Padding(2);
            GenerarRemitoBtn.Name = "GenerarRemitoBtn";
            GenerarRemitoBtn.Size = new Size(147, 37);
            GenerarRemitoBtn.TabIndex = 9;
            GenerarRemitoBtn.Text = "Generar remito";
            GenerarRemitoBtn.UseVisualStyleBackColor = true;
            GenerarRemitoBtn.Click += GenerarRemitoBtn_Click;
            // 
            // FechaDT
            // 
            FechaDT.Location = new Point(138, 185);
            FechaDT.Margin = new Padding(2);
            FechaDT.Name = "FechaDT";
            FechaDT.ReadOnly = true;
            FechaDT.Size = new Size(122, 27);
            FechaDT.TabIndex = 12;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(BuscarBtn);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(NumeroOrdenInternaBuscarText);
            groupBox1.Location = new Point(61, 71);
            groupBox1.Margin = new Padding(2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2);
            groupBox1.Size = new Size(365, 76);
            groupBox1.TabIndex = 16;
            groupBox1.TabStop = false;
            groupBox1.Text = "Busqueda";
            // 
            // BuscarBtn
            // 
            BuscarBtn.Location = new Point(286, 32);
            BuscarBtn.Margin = new Padding(2);
            BuscarBtn.Name = "BuscarBtn";
            BuscarBtn.Size = new Size(75, 27);
            BuscarBtn.TabIndex = 2;
            BuscarBtn.Text = "Buscar";
            BuscarBtn.UseVisualStyleBackColor = true;
            BuscarBtn.Click += BuscarBtn_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(14, 32);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(94, 20);
            label7.TabIndex = 1;
            label7.Text = "Transportista";
            // 
            // NumeroOrdenInternaBuscarText
            // 
            NumeroOrdenInternaBuscarText.Location = new Point(132, 32);
            NumeroOrdenInternaBuscarText.Margin = new Padding(2);
            NumeroOrdenInternaBuscarText.Name = "NumeroOrdenInternaBuscarText";
            NumeroOrdenInternaBuscarText.Size = new Size(134, 27);
            NumeroOrdenInternaBuscarText.TabIndex = 0;
            // 
            // DatosOrdenGroup
            // 
            DatosOrdenGroup.Controls.Add(textBox2);
            DatosOrdenGroup.Controls.Add(label3);
            DatosOrdenGroup.Controls.Add(label8);
            DatosOrdenGroup.Controls.Add(textBox1);
            DatosOrdenGroup.Controls.Add(Deposito);
            DatosOrdenGroup.Controls.Add(label1);
            DatosOrdenGroup.Controls.Add(label2);
            DatosOrdenGroup.Controls.Add(label5);
            DatosOrdenGroup.Controls.Add(FechaDT);
            DatosOrdenGroup.Controls.Add(NumOrdenIntText);
            DatosOrdenGroup.Controls.Add(label6);
            DatosOrdenGroup.Location = new Point(61, 151);
            DatosOrdenGroup.Margin = new Padding(2);
            DatosOrdenGroup.Name = "DatosOrdenGroup";
            DatosOrdenGroup.Padding = new Padding(2);
            DatosOrdenGroup.Size = new Size(272, 231);
            DatosOrdenGroup.TabIndex = 17;
            DatosOrdenGroup.TabStop = false;
            DatosOrdenGroup.Text = "Datos";
            // 
            // Deposito
            // 
            Deposito.Location = new Point(138, 146);
            Deposito.Name = "Deposito";
            Deposito.ReadOnly = true;
            Deposito.Size = new Size(122, 27);
            Deposito.TabIndex = 16;
            // 
            // BorrarBtn
            // 
            BorrarBtn.Location = new Point(246, 387);
            BorrarBtn.Name = "BorrarBtn";
            BorrarBtn.Size = new Size(75, 41);
            BorrarBtn.TabIndex = 106;
            BorrarBtn.Text = "Borrar";
            BorrarBtn.UseVisualStyleBackColor = true;
            BorrarBtn.Click += BorrarBtn_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(5, 101);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(94, 20);
            label8.TabIndex = 108;
            label8.Text = "Transportista";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(138, 101);
            textBox1.Margin = new Padding(2);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(122, 27);
            textBox1.TabIndex = 109;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(5, 68);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(55, 20);
            label3.TabIndex = 107;
            label3.Text = "Cliente";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(138, 65);
            textBox2.Margin = new Padding(2);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(122, 27);
            textBox2.TabIndex = 107;
            // 
            // GenerarRemitoForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(454, 474);
            Controls.Add(BorrarBtn);
            Controls.Add(DatosOrdenGroup);
            Controls.Add(groupBox1);
            Controls.Add(GenerarRemitoBtn);
            Margin = new Padding(2);
            Name = "GenerarRemitoForm";
            Text = "GenerarRemitoForm";
            Load += GenerarRemitoForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            DatosOrdenGroup.ResumeLayout(false);
            DatosOrdenGroup.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label5;
        private TextBox NumOrdenIntText;
        private Label label6;
        private Button GenerarRemitoBtn;
        private TextBox FechaDT;
        private GroupBox groupBox1;
        private TextBox NumeroOrdenInternaBuscarText;
        private Label label7;
        private GroupBox DatosOrdenGroup;
        private Button BuscarBtn;
        private Button BorrarBtn;
        private TextBox Deposito;
        private Label label8;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label3;
    }
}