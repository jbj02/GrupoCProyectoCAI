namespace GrupoCProyectoCAI.Estibador
{
    partial class EstibadorMenuForm
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
            modificarbtn = new Button();
            SuspendLayout();
            // 
            // modificarbtn
            // 
            modificarbtn.Location = new Point(277, 82);
            modificarbtn.Name = "modificarbtn";
            modificarbtn.Size = new Size(216, 37);
            modificarbtn.TabIndex = 0;
            modificarbtn.Text = "Modificar";
            modificarbtn.UseVisualStyleBackColor = true;
            modificarbtn.Click += modificarbtn_Click;
            // 
            // EstibadorMenuForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(modificarbtn);
            Name = "EstibadorMenuForm";
            Text = "EstibadorMenuForm";
            ResumeLayout(false);
        }

        #endregion

        private Button modificarbtn;
    }
}