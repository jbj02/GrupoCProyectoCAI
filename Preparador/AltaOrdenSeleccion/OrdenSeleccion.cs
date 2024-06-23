using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoCProyectoCAI.Preparador.AltaOrdenSeleccion
{
    public class OrdenSeleccion
    {
        public int NumOrden { get; set; }
        public string Estado { get; set; }
        public List<OrdenPreparacion> OrdenesPreparacionAsociadas { get; set; }

        public OrdenSeleccion(int numeroOrdenSeleccion)
        {
            NumOrden = numeroOrdenSeleccion;
            Estado = "Pendiente";
            OrdenesPreparacionAsociadas = new List<OrdenPreparacion>();
        }
    }
}
