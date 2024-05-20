namespace GrupoCProyectoCAI.Preparador
{
    partial class PreparadorMenuForm
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
            ModificarBtn = new Button();
            NuevaOrdenBtn = new Button();
            SuspendLayout();
            // 
            // ModificarBtn
            // 
            ModificarBtn.Location = new Point(44, 25);
            ModificarBtn.Name = "ModificarBtn";
            ModificarBtn.Size = new Size(144, 48);
            ModificarBtn.TabIndex = 0;
            ModificarBtn.Text = "Modificar";
            ModificarBtn.UseVisualStyleBackColor = true;
            ModificarBtn.Click += ModificarBtn_Click;
            // 
            // NuevaOrdenBtn
            // 
            NuevaOrdenBtn.Location = new Point(44, 79);
            NuevaOrdenBtn.Name = "NuevaOrdenBtn";
            NuevaOrdenBtn.Size = new Size(144, 49);
            NuevaOrdenBtn.TabIndex = 1;
            NuevaOrdenBtn.Text = "Nueva Orden Int";
            NuevaOrdenBtn.UseVisualStyleBackColor = true;
            NuevaOrdenBtn.Click += NuevaOrdenBtn_Click;
            // 
            // PreparadorMenuForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(222, 151);
            Controls.Add(NuevaOrdenBtn);
            Controls.Add(ModificarBtn);
            Name = "PreparadorMenuForm";
            Text = "PreparadorMenuForm";
            ResumeLayout(false);
        }

        #endregion

        private Button ModificarBtn;
        private Button NuevaOrdenBtn;
    }
}