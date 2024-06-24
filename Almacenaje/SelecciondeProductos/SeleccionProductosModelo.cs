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

                    // Filtrar las órdenes de preparación asociadas a la orden de selección actual
                    var ordenesPreparacionAsociadas = ArchivoOrdenPreparacion.OrdenesPreparacion
                        .Where(op => ordenEnt.OrdenPreparacionAsociadas.Contains(op.NroOrden))
                        .ToList();
                    foreach (var ordenA in ordenesPreparacionAsociadas)
                    {
                        var ordenPrep = new OrdenPreparacion
                        {
                            NumOrdenP = ordenA.NroOrden,
                            productos = new List<Productos>()
                        };

                        // Filtrar los productos del stock provisorio asociados a la orden de preparación actual
                        var productosAsociados = ArchivoStockProvisorio.StockProvisorio
                            .Where(sp => sp.NroOrden == ordenA.NroOrden)
                            .ToList();

                        foreach (var product in productosAsociados)
                        {
                            var x = ArchivoProductos.Productos.FirstOrDefault(p => p.Codigo == product.CodigoProducto);
                            if (x != null)
                            {
                                var producto = new Productos
                                {
                                    Producto = x.Producto,
                                    Cantidades = product.Cantidad,
                                    Ubicacion = product.Ubicacion
                                };
                                ordenPrep.productos.Add(producto);
                            }
                        }
                        ordenSeleccion.ordenAsociada.Add(ordenPrep);
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
