using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoCProyectoCAI.Preparador.AltaOrdenSeleccion
{
    public class OrdenSeleccion
    {
        public int NumOrdenS { get; set; }
        public string PrioridadS { get; set; }
        public int CantidadOrdenPreparacion { get; set; }
        public List<OrdenPreparacion> OrdenesPreparacionAsociadas { get; set; }

        public OrdenSeleccion(int numeroOrdenSeleccion)
        {
            NumOrdenS = numeroOrdenSeleccion;
            OrdenesPreparacionAsociadas = new List<OrdenPreparacion>();
        }
    }
}
