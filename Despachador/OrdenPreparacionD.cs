using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoCProyectoCAI.Despachador
{
    internal class OrdenPreparacionD
    {
        public int NumOrden { get; set; }
        public string ClienteCUIT { get; set; }
        public string Estado { get; set; }
        public string TransportistaCUIT {  get; set; }
        public DateTime FechaDespacho { get; set; }
    }
}
