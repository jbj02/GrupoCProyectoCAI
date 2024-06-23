using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoCProyectoCAI.Archivos
{
    public class OrdenSeleccionEnt
    {
        public int NroOrden { get; set; }
        public EstadosOrdenSeleccion Estado { get; set; }
        public List<int> OrdenPreparacionAsociadas { get; set; } = new();

        /*
        public void DevolverNumeroOrdenSeleccion(int numeroOrdenSeleccion)
        {
            NroOrden = numeroOrdenSeleccion;
            OrdenPreparacionAsociadas = new List<OrdenPreparacionEnt>();
        }
        */
    }

    
}
