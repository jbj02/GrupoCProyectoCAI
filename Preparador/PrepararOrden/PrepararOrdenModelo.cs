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
                OrdenesPreparacion.Add(ordenPreparacion);
            }
        }
    }
}
