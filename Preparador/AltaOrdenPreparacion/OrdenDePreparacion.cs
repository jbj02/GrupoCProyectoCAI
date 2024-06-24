using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoCProyectoCAI.Preparador.AltaOrdenPreparacion
{
    internal class OrdenDePreparacion
    {
        public int NumeroDeOrden { get; set; }
        public string Cliente { get; set; }
        public string Transportista { get; set; }
        //public string Estado { get; set; }
        public DateTime FechaDeDespacho { get; set; }
        //public DateTime FechaDeAlta { get; set; }
        //public string Prioridad { get; set; }
        public List<Producto> Productos { get; set; }
    }
}
