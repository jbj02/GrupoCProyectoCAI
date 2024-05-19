using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoCProyectoCAI.Despachador
{
    internal class OrdenExt
    {
        public int NumOrdenExt { get; set; }
        public string TipoProducto { get; set; }
        public int Cantidad { get; set; }
        public string Cliente { get; set; }
        public string Prioridad { get; set; }
        public DateTime FechaCreacion { get; set; }
    }
}
