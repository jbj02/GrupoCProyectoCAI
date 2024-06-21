using GrupoCProyectoCAI.Almacenaje.SelecciondeProductos;
using GrupoCProyectoCAI.Archivos;
using GrupoCProyectoCAI.Preparador.AltaOrdenSeleccion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace GrupoCProyectoCAI.Almacenaje.SelecciondeProductos
{
    internal class SeleccionProductosModelo
    {

        public List<OrdenSeleccion> ordenSeleccion { get; set; }
        public List<int> numeroOrden { get; set; }
        public SeleccionProductosModelo()
        {

            ordenSeleccion = new List<OrdenSeleccion> ();
            CargarOrden();

        }
        public void CargarOrden()
        {
            foreach (var orden in ArchivoOrdenSeleccion.OrdenSeleccions)
            {
                ordenSeleccion.Add(orden);
            }
        }
        public OrdenSeleccion Buscar(int orden)
        {
            //int numero = Convert.ToInt32(orden);
            OrdenSeleccion ord = ordenSeleccion.Find(o => o.NroOrden == orden);
            return ord;
        }
        public void ActualizarOrden(string orden)
        {
            int numero = Convert.ToInt32(orden);
            foreach (var ord in ordenSeleccion)
            {
                // if(numero == (NumeroOrden).ordenSeleccion){}
            }
        }
    }
}
