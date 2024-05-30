namespace GrupoCProyectoCAI
{
    partial class MenuForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            EstibadorBtn = new Button();
            PreparadorBtn = new Button();
            DespachadorBtn = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // EstibadorBtn
            // 
            EstibadorBtn.Location = new Point(307, 159);
            EstibadorBtn.Name = "EstibadorBtn";
            EstibadorBtn.Size = new Size(152, 23);
            EstibadorBtn.TabIndex = 0;
            EstibadorBtn.Text = "Estibador";
            EstibadorBtn.UseVisualStyleBackColor = true;
            EstibadorBtn.Click += EstibadorBtn_Click;
            // 
            // PreparadorBtn
            // 
            PreparadorBtn.Location = new Point(307, 188);
            PreparadorBtn.Name = "PreparadorBtn";
            PreparadorBtn.Size = new Size(152, 23);
            PreparadorBtn.TabIndex = 3;
            PreparadorBtn.Text = "Preparador";
            PreparadorBtn.UseVisualStyleBackColor = true;
            PreparadorBtn.Click += PreparadorBtn_Click;
            // 
            // DespachadorBtn
            // 
            DespachadorBtn.Location = new Point(307, 217);
            DespachadorBtn.Name = "DespachadorBtn";
            DespachadorBtn.Size = new Size(152, 23);
            DespachadorBtn.TabIndex = 4;
            DespachadorBtn.Text = "Despachador";
            DespachadorBtn.UseVisualStyleBackColor = true;
            DespachadorBtn.Click += DespachadorBtn_Click;
            // 
            // button1
            // 
            button1.Location = new Point(307, 246);
            button1.Name = "button1";
            button1.Size = new Size(152, 23);
            button1.TabIndex = 5;
            button1.Text = "Atención al Cliente";
            button1.UseVisualStyleBackColor = true;
            button1.Click += AtencionCliente_Click;
            // 
            // MenuForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(DespachadorBtn);
            Controls.Add(PreparadorBtn);
            Controls.Add(EstibadorBtn);
            Name = "MenuForm";
            Text = "MenuForm";
            ResumeLayout(false);
        }

        #endregion
        private Button EstibadorBtn;
        private Button PreparadorBtn;
        private Button DespachadorBtn;
        private Button button1;
    }
}
