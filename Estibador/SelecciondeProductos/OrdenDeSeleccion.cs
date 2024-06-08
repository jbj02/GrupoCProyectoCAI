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
        public List <Productos> productosAsociados { get; set; }
        public string Estado { get; set; }
        public OrdenDeSeleccion()
        {
           
            productosAsociados = new List<Productos>();
        }

    }
}
