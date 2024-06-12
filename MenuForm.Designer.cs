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
            AlmacenajeBtn = new Button();
            PreparadorBtn = new Button();
            DespachadorBtn = new Button();
            SuspendLayout();
            // 
            // AlmacenajeBtn
            // 
            AlmacenajeBtn.Location = new Point(307, 159);
            AlmacenajeBtn.Name = "AlmacenajeBtn";
            AlmacenajeBtn.Size = new Size(152, 23);
            AlmacenajeBtn.TabIndex = 0;
            AlmacenajeBtn.Text = "Almacenaje";
            AlmacenajeBtn.UseVisualStyleBackColor = true;
            AlmacenajeBtn.Click += AlmacenajeBtn_Click;
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
            // MenuForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(DespachadorBtn);
            Controls.Add(PreparadorBtn);
            Controls.Add(AlmacenajeBtn);
            Name = "MenuForm";
            Text = "MenuForm";
            ResumeLayout(false);
        }

        #endregion
        private Button AlmacenajeBtn;
        private Button PreparadorBtn;
        private Button DespachadorBtn;
    }
}
