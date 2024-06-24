using GrupoCProyectoCAI.Archivos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoCProyectoCAI.Almacenaje.SelecciondeProductos
{
    internal class OrdenDeSeleccion
    {
        public int NumeroOrden { get; set; }
        public List<OrdenPreparacion> ordenAsociada { get; set; }
        public string Estado { get; set; }
    }
}
