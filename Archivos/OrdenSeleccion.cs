using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoCProyectoCAI.Archivos
{
    public class OrdenSeleccion
    {
        public int NroOrden { get; set; }
        public string Estado { get; set; }
        public List<OrdenPreparacion> OrdenPreparacionAsociadas { get; set; } = new();

        public void DevolverNumeroOrdenSeleccion(int numeroOrdenSeleccion)
        {
            NroOrden = numeroOrdenSeleccion;
            OrdenPreparacionAsociadas = new List<OrdenPreparacion>();
        }
    }

    
}
