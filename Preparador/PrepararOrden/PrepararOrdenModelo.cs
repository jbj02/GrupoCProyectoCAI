using GrupoCProyectoCAI.Archivos;
using GrupoCProyectoCAI.Preparador.PrepararOrden;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoCProyectoCAI.Preparador.PrepararOrden
{
    internal class PrepararOrdenModelo
    {
        public List<OrdenPrepara> OrdenesPreparacion { get; set; }

        public List<Productos> Productos { get; set; }

        public OrdenPrepara OrdenSeleccionada { get; set; }

        // Creamos un constructor para cargarle datos y probar el prototipo de forma aislada
        public PrepararOrdenModelo()
        {
            OrdenesPreparacion = new List<OrdenPrepara>();

            foreach (var ordenEntidad in ArchivoOrdenPreparacion.OrdenesPreparacion)
            {
                if (ordenEntidad.Estado == EstadosOrdenPreparacion.Seleccionada)
                {
                    var ordenPreparacion = new OrdenPrepara
                    {
                        NumOrden = ordenEntidad.NroOrden,
                        ClienteCUIT = ordenEntidad.ClienteCUIT,
                        FechaAlta = ordenEntidad.FechaAlta,
                        FechaDespacho = ordenEntidad.FechaDespacho,
                        Productos = new List<Productos>()
                    };

                    foreach (var stockProvisorio in ArchivoStockProvisorio.StockProvisorio)
                    {
                        if (stockProvisorio.NroOrden != ordenPreparacion.NumOrden)
                            continue;

                        foreach (var producto in ArchivoProductos.Productos)
                        {
                            if (producto.Codigo != stockProvisorio.CodigoProducto)
                                continue;

                            bool existe = false;
                            foreach (var productoYaCargados in ordenPreparacion.Productos)
                            {
                                if (productoYaCargados.NombreProducto != producto.Producto)
                                    continue;

                                productoYaCargados.Cantidad += stockProvisorio.Cantidad;
                                existe = true;
                            }

                            if (!existe)
                            {
                                var productosOrdenPreparacion = new Productos
                                {
                                    NombreProducto = producto.Producto,
                                    Cantidad = stockProvisorio.Cantidad
                                };

                                ordenPreparacion.Productos.Add(productosOrdenPreparacion);
                            }
                        }
                    }

                    OrdenesPreparacion.Add(ordenPreparacion);
                }
            }
        }

        public List<Productos> ObtenerProductosDeOrdenSeleccionada()
        {
            return OrdenSeleccionada?.Productos;
        }

        public void Confirmar()
        {
            ArchivoOrdenPreparacion.SeleccionarOrden(OrdenSeleccionada.NumOrden, EstadosOrdenPreparacion.Preparada);
        }

    }
}
