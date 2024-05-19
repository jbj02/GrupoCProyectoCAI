namespace GrupoCProyectoCAI
{
    partial class ModificarForm
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
            ordenesInternas_lst = new ListView();
            numero_orden_externa = new ColumnHeader();
            numero_orden_interna = new ColumnHeader();
            tipo_producto = new ColumnHeader();
            Cantidades = new ColumnHeader();
            Prioridad = new ColumnHeader();
            Estado = new ColumnHeader();
            fecha_creacion = new ColumnHeader();
            fecha_modificacion = new ColumnHeader();
            SuspendLayout();
            // 
            // ordenesInternas_lst
            // 
            ordenesInternas_lst.Columns.AddRange(new ColumnHeader[] { numero_orden_externa, numero_orden_interna, tipo_producto, Cantidades, Prioridad, Estado, fecha_creacion, fecha_modificacion });
            ordenesInternas_lst.Location = new Point(25, 20);
            ordenesInternas_lst.Name = "ordenesInternas_lst";
            ordenesInternas_lst.Size = new Size(947, 396);
            ordenesInternas_lst.TabIndex = 0;
            ordenesInternas_lst.UseCompatibleStateImageBehavior = false;
            // 
            // numero_orden_externa
            // 
            numero_orden_externa.Text = "N° Orden Ext";
            // 
            // numero_orden_interna
            // 
            numero_orden_interna.Text = "N° Orden Int";
            // 
            // tipo_producto
            // 
            tipo_producto.Text = "Tipo de Producto";
            // 
            // Cantidades
            // 
            Cantidades.Text = "Cantidades";
            // 
            // Prioridad
            // 
            Prioridad.Text = "Prioridad";
            // 
            // Estado
            // 
            Estado.Text = "Estado";
            // 
            // fecha_creacion
            // 
            fecha_creacion.Text = "Fecha de creación";
            // 
            // fecha_modificacion
            // 
            fecha_modificacion.Text = "Fecha de Modificación";
            // 
            // ModificarForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1423, 625);
            Controls.Add(ordenesInternas_lst);
            Name = "ModificarForm";
            Text = "ModificarForm";
            ResumeLayout(false);
        }

        #endregion

        private ListView ordenesInternas_lst;
        private ColumnHeader numero_orden_externa;
        private ColumnHeader numero_orden_interna;
        private ColumnHeader tipo_producto;
        private ColumnHeader Cantidades;
        private ColumnHeader Prioridad;
        private ColumnHeader Estado;
        private ColumnHeader fecha_creacion;
        private ColumnHeader fecha_modificacion;
    }
}