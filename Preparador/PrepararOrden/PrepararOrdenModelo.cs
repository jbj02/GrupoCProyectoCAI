using GrupoCProyectoCAI.Archivos;
using GrupoCProyectoCAI.Preparador.PrepararOrden;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoCProyectoCAI.Preparador.PrepararOrden
{
    internal class PrepararOrdenModelo
    {
        public List<OrdenPreparacion> OrdenesPreparacion { get; set; }

        public PrepararOrdenModelo()
        {
            OrdenesPreparacion = new List<OrdenPreparacion>();
            // Cargar Lista
            CargarListaOrdenPreparacion();
        }
         
        public void CargarListaOrdenPreparacion()
        {
            // Agregar código que solo cargue las que tiene el estado "Seleccionada"
            foreach (var ordenPreparacion in ArchivoOrdenPreparacion.OrdenesPreparacion)
            {
                if(ordenPreparacion.Estado == "Seleccionada")
                {
                    OrdenesPreparacion.Add(ordenPreparacion);
                }                
            }
        }

        public void CambiarEstadoOrdenPreparacion(OrdenPreparacion orden)
        {
            // Buscar la orden en la lista y actualizar su estado
            var ordenExistente = ArchivoOrdenPreparacion.OrdenesPreparacion.FirstOrDefault(o => o.NroOrden == orden.NroOrden);
            if (ordenExistente != null)
            {
                ordenExistente.Estado = orden.Estado;
                //ArchivoOrdenPreparacion.GrabarDatos(); // Guardar los cambios
            }
            else
            {
                MessageBox.Show($"La orden {orden.NroOrden} no existe en la lista");
            }
        }
    }
}
