using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoCProyectoCAI.Archivos
{
    public class OrdenPreparacionEnt
    {
        public int NroOrden { get; set; }
        public string ClienteCUIT { get; set; }
        public string Estado { get; set; }
        public string TransportistaCUIT { get; set; }
        public DateTime FechaDespacho { get; set; }
        public DateTime FechaAlta { get; set; }
        public List<StockEnt> ProductosList { get; set; }

    }
}
