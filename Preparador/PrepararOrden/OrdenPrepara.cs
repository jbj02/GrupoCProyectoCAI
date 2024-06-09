using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoCProyectoCAI.Preparador.PrepararOrden
{
    internal class OrdenPrepara
    {
        public int NumOrden { get; set; }
        public string Cliente { get; set; }
        public string Prioridad { get; set; }
        public DateTime FechaAlta { get; set; }
        public DateTime FechaDespacho { get; set; }
        public string Estado { get; set; }

        public List<Productos> Productos { get; set; }
    }
    
}
