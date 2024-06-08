using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoCProyectoCAI.Estibador.SelecciondeProductos
{
    internal class OrdenDeSeleccion
    {
        public int NumeroOrden {  get; set; }
        public string Producto { get; set; }
        public int Cantidades { get; set; }
        public string Estado { get; set; }
        public Ubicacion Ubicacion { get; set; }
    }
}
