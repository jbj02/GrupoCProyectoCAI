using GrupoCProyectoCAI.Almacenaje.SelecciondeProductos;
using GrupoCProyectoCAI.Archivos;
using GrupoCProyectoCAI.Despachador;

using GrupoCProyectoCAI.Preparador.AltaOrdenSeleccion;
using GrupoCProyectoCAI.Preparador.PrepararOrden;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace GrupoCProyectoCAI.Almacenaje.SelecciondeProductos
{
    internal class SeleccionProductosModelo
    {

        public List<OrdenDeSeleccion> OrdenesSeleccion { get; set; }
        public List<int> numeroOrden { get; set; }
        public OrdenDeSeleccion orden { get; internal set; }
        public List<OrdenPreparacion> ordenesAsociadas { get; set; }

        public SeleccionProductosModelo()
        {
            OrdenesSeleccion = new List<OrdenDeSeleccion>();


            foreach (var ordenEnt in ArchivoOrdenSeleccion.OrdenSeleccions)
            {
                if (ordenEnt.Estado == EstadosOrdenSeleccion.Pendiente)
                {
                    var ordenSeleccion = new OrdenDeSeleccion
                    {
                        NumeroOrden = ordenEnt.NroOrden,
                        Estado = ordenEnt.Estado.ToString(),
                        ordenAsociada = new List<OrdenPreparacion>()

                        // ordenAsociada = ordenEnt.OrdenPreparacionAsociadas
                    };
                    foreach (var ordenA in ArchivoOrdenPreparacion.OrdenesPreparacion)
                    {
                        var ordenPrep = new OrdenPreparacion
                        {
                            NumOrdenP = ordenA.NroOrden,
                            productos = new List<Productos>()
                        };
                        foreach (var product in ArchivoStockProvisorio.StockProvisorio)
                        {
                            var x = ArchivoProductos.Productos.FirstOrDefault(p => p.Codigo == product.CodigoProducto);
                            var producto = new Productos
                            {

                                Producto = x.Producto,
                                Cantidades = product.Cantidad,
                                Ubicacion = product.Ubicacion,


                            };
                        }

                    }

                    OrdenesSeleccion.Add(ordenSeleccion);
                }
            }
        }
        public OrdenDeSeleccion Buscar(int orden)
        {
            //int numero = Convert.ToInt32(orden);
            OrdenDeSeleccion ord = OrdenesSeleccion.Find(o => o.NumeroOrden == orden);
            return ord;
        }
        public void ActualizarOrden(string orden)
        {
            int numero = Convert.ToInt32(orden);
            foreach (var ord in OrdenesSeleccion)
            {
                // if(numero == (NumeroOrden).ordenSeleccion){}
            }
        }
        public void Confirmar()
        {
            ArchivoOrdenSeleccion.CambiarEstado(orden.NumeroOrden);

            // Cambiar estado de las órdenes de preparación asociadas
            foreach (var ordenPreparacion in orden.ordenAsociada)
            {
                // ArchivoOrdenPreparacion.SeleccionarOrden(ordenPreparacion.NroOrden, "Seleccionada");
                ArchivoOrdenPreparacion.SeleccionarOrden(ordenPreparacion.NumOrdenP, EstadosOrdenPreparacion.Seleccionada); 

            }
        }
    }
}
