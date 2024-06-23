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
        public string ClienteCUIT { get; set; }
        public DateTime FechaAlta { get; set; }
        public DateTime FechaDespacho { get; set; }
        public List<Productos> Productos { get; set; }
    }
    
}
