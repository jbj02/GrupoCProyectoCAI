﻿namespace GrupoCProyectoCAI.Despachador
{
    partial class DespachadorMenuForm
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
            ModificarOrdenBtn = new Button();
            GenerarRemitoBtn = new Button();
            SuspendLayout();
            // 
            // ModificarOrdenBtn
            // 
            ModificarOrdenBtn.Location = new Point(12, 32);
            ModificarOrdenBtn.Name = "ModificarOrdenBtn";
            ModificarOrdenBtn.Size = new Size(244, 27);
            ModificarOrdenBtn.TabIndex = 0;
            ModificarOrdenBtn.Text = "Modificar órden";
            ModificarOrdenBtn.UseVisualStyleBackColor = true;
            ModificarOrdenBtn.Click += ModificarOrdenBtn_Click;
            // 
            // GenerarRemitoBtn
            // 
            GenerarRemitoBtn.Location = new Point(12, 65);
            GenerarRemitoBtn.Name = "GenerarRemitoBtn";
            GenerarRemitoBtn.Size = new Size(244, 27);
            GenerarRemitoBtn.TabIndex = 1;
            GenerarRemitoBtn.Text = "Generar remito";
            GenerarRemitoBtn.UseVisualStyleBackColor = true;
            // 
            // DespachadorMenuForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(268, 135);
            Controls.Add(GenerarRemitoBtn);
            Controls.Add(ModificarOrdenBtn);
            Name = "DespachadorMenuForm";
            Text = "DespachadorMenuForm";
            ResumeLayout(false);
        }

        #endregion

        private Button ModificarOrdenBtn;
        private Button GenerarRemitoBtn;
    }
}