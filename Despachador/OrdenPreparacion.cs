using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoCProyectoCAI.Despachador
{
    internal class OrdenPreparacion
    {
        public int NumOrden { get; set; }
        public string Cliente { get; set; }
        public string Estado { get; set; }
        public string Transportista {  get; set; }
        public DateTime FechaDespacho { get; set; }
    }
}
