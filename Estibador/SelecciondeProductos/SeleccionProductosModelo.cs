using GrupoCProyectoCAI.Preparador.AltaOrdenSeleccion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace GrupoCProyectoCAI.Estibador.SelecciondeProductos
{
    internal class SeleccionProductosModelo
    {
        
        public List<OrdenDeSeleccion> ordenSeleccion { get; set; }
        public List<int> numeroOrden { get; set; }
        public SeleccionProductosModelo()
        {
            ordenSeleccion = new List<OrdenDeSeleccion>()
            {
                new OrdenDeSeleccion
                {
                    NumeroOrden = 25462357,
                    Producto = "Mochilas",
                    Cantidades = 5,
                    Estado = "Pendiente",
                    Ubicacion = new Ubicacion { X = "pasillo", Y = "almacen", Z = "sector" }
                } ,
                new OrdenDeSeleccion
                {
                    NumeroOrden = 25462357,
                    Producto = "Bolso",
                    Cantidades = 10,
                    Estado = "Pendiente",
                    Ubicacion = new Ubicacion { X = "pasillo", Y = "almacen", Z = "sector" }
                },
                new OrdenDeSeleccion
                {
                    NumeroOrden = 25462359,
                    Producto = "Mesas",
                    Cantidades = 3,
                    Estado = "Pendiente",
                    Ubicacion = new Ubicacion { X = "pasillo2", Y = "almacen2", Z = "sector2" }
                }
            };

            
        }
        public void Buscar(string  orden)
        {
            int numero = Convert.ToInt32(orden);
            ordenSeleccion.Find(o => o.NumeroOrden == numero);
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
