using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoCProyectoCAI.Archivos
{
    public class RemitoEnt
    {
        public int NroRemito { get; set; }
        public string clienteCUIT { get; set; }
        public string transportistaCUIT { get; set; }
        public DateTime FechaDespacho { get; set; }
        public List<StockEnt> ProductosList { get; set; }
    }
}
