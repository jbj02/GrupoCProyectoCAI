using GrupoCProyectoCAI.Almacenaje.SelecciondeProductos;
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
        public SeleccionProductosModelo()
        {
            ordenSeleccion = new List<OrdenDeSeleccion>()

            {
                new OrdenDeSeleccion
                {
                    NumeroOrden = 25462357,
                    Estado = "Pendiente",
                    productosAsociados = new List<Productos>()
                    {
                        new Productos
                        {
                            Producto = "Mochila",
                            Cantidades = 10,
                            Ubicacion = new Ubicacion { X = "pasillo", Y = "almacen", Z = "sector" }
                        },
                        new Productos
                        {
                            Producto = "Bolso",
                            Cantidades = 5,
                            Ubicacion = new Ubicacion { X = "pasillo", Y = "almacen", Z = "sector" }
                        }
                    }
                    //Ubicacion = new Ubicacion { X = "pasillo", Y = "almacen", Z = "sector" }
                } ,
                new OrdenDeSeleccion
                {
                    NumeroOrden = 25462359,
                    Estado = "Pendiente",
                    productosAsociados= new List<Productos>()
                    {
                        new Productos
                        {
                            Producto = "Silla",
                            Cantidades = 4,
                            Ubicacion = new Ubicacion { X = "pasillo", Y = "almacen", Z = "sector" }
                        }
                    }
                }
            };


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
    }
}
