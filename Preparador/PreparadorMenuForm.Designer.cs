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
            AltaOrdenSeleccionBtn = new Button();
            PrepararOrdenBtn = new Button();
            SuspendLayout();
            // 
            // AltaOrdenSeleccionBtn
            // 
            AltaOrdenSeleccionBtn.Location = new Point(44, 25);
            AltaOrdenSeleccionBtn.Name = "AltaOrdenSeleccionBtn";
            AltaOrdenSeleccionBtn.Size = new Size(144, 48);
            AltaOrdenSeleccionBtn.TabIndex = 0;
            AltaOrdenSeleccionBtn.Text = "Alta Orden Seleccion";
            AltaOrdenSeleccionBtn.UseVisualStyleBackColor = true;
            AltaOrdenSeleccionBtn.Click += AltaOrdenSeleccionBtn_Click;
            // 
            // PrepararOrdenBtn
            // 
            PrepararOrdenBtn.Location = new Point(44, 79);
            PrepararOrdenBtn.Name = "PrepararOrdenBtn";
            PrepararOrdenBtn.Size = new Size(144, 49);
            PrepararOrdenBtn.TabIndex = 1;
            PrepararOrdenBtn.Text = "Preparar Orden";
            PrepararOrdenBtn.UseVisualStyleBackColor = true;
            PrepararOrdenBtn.Click += PrepararOrdenBtn_Click;
            // 
            // PreparadorMenuForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(222, 151);
            Controls.Add(PrepararOrdenBtn);
            Controls.Add(AltaOrdenSeleccionBtn);
            Name = "PreparadorMenuForm";
            Text = "PreparadorMenuForm";
            ResumeLayout(false);
        }

        #endregion

        private Button AltaOrdenSeleccionBtn;
        private Button PrepararOrdenBtn;
    }
}