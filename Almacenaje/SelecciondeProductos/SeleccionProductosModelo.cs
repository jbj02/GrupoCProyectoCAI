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

        public List<OrdenDeSeleccion> ordenSeleccion { get; set; }
        public List<int> numeroOrden { get; set; }
        public OrdenDeSeleccion orden { get; internal set; }

        public SeleccionProductosModelo()
        {
            ordenSeleccion = new List<OrdenDeSeleccion>();

            
            foreach (var ordenEnt in ArchivoOrdenSeleccion.OrdenSeleccions) 
            { 
                var orden = new OrdenDeSeleccion();
                orden.NumeroOrden = ordenEnt.NroOrden;
                orden.Estado = ordenEnt.Estado;
                orden.ordenAsociada = ordenEnt.OrdenPreparacionAsociadas;
               ordenSeleccion.Add(orden);
            }
                


        }
        public OrdenDeSeleccion Buscar(int orden)
        {
            //int numero = Convert.ToInt32(orden);
            OrdenDeSeleccion ord = ordenSeleccion.Find(o => o.NumeroOrden == orden);
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
        public void Confirmar()
        {
            ArchivoOrdenSeleccion.CambiarEstado(orden.NumeroOrden);
        }
    }
}
