using GrupoCProyectoCAI.Archivos;
using GrupoCProyectoCAI.Preparador.AltaOrdenSeleccion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace GrupoCProyectoCAI.Preparador.AltaOrdenPreparacion
{
    internal class AltaOrdenPreparacionModelo
    {
        public List<Cliente> Clientes { get; set; }
        public AltaOrdenPreparacionModelo()
        {
            Clientes = new List<Cliente>();

            foreach (var clienteEntidad in ArchivoClientes.Clientes)
            {
                var nuevoCliente = new Cliente
                {
                    CUIT = clienteEntidad.CUIT,
                    Nombre = clienteEntidad.Nombre,
                    ProductosAsociados = new List<Producto>()
                };

                // Buscar productos asociados a este cliente en ArchivoStock
                var stockCliente = ArchivoStock.Stock.Where(p => p.ClienteCUIT == clienteEntidad.CUIT);
                foreach (var stockEntidad in stockCliente)
                {
                    string nombreABuscar = ArchivoProductos.Productos.First(p => p.Codigo == stockEntidad.CodigoProducto).Producto;
                    var nuevoProducto = new Producto
                    {
                        Nombre = nombreABuscar,
                        Cantidad = stockEntidad.Cantidad,
                        CodigoDeProducto = stockEntidad.CodigoProducto
                    };

                    nuevoCliente.ProductosAsociados.Add(nuevoProducto);
                }

                Clientes.Add(nuevoCliente);
            }
        }

        public Cliente BuscarCliente(string cuit)
        {
            return Clientes.Find(id => id.CUIT == cuit);
        }

        public bool ValidarCUIT(string cuit)
        {
            string pattern = @"^\d{2}-\d{8}-\d{1}$";
            Regex regex = new Regex(pattern);

            string pattern2 = @"^\d{2}-\d{8}-\d{2}$";
            Regex regex2 = new Regex(pattern);

            return regex.IsMatch(cuit) || regex2.IsMatch(cuit);
        }

        public int BuscarUltimaOrenPreparacion()
        {
            if (ArchivoOrdenPreparacion.OrdenesPreparacion.Count != 0)
            {
                int ultimoNumero = ArchivoOrdenPreparacion.OrdenesPreparacion[ArchivoOrdenPreparacion.OrdenesPreparacion.Count - 1].NroOrden;
                return ultimoNumero;
            }
            else
            {
                return 0;
            }
        }

        public void AgregarOrdenPreparacion(OrdenDePreparacion ordenPreparacion)
        {
            // Crear un nuevo objeto OrdenSeleccionEnt y asignar los valores del objeto OrdenSeleccion
            var ordenPreparacionEnt = new OrdenPreparacionEnt
            {
                NroOrden = ordenPreparacion.NumeroDeOrden,
                ClienteCUIT = ordenPreparacion.Cliente,
                TransportistaCUIT = ordenPreparacion.Transportista,
                FechaDespacho = ordenPreparacion.FechaDeDespacho,
                FechaAlta = DateTime.Now,
                Estado = EstadosOrdenPreparacion.Pendiente,
                //ProductosList = new List<StockEnt>()
            };

            // Buscar productos en ArchivoStock y agregar los detalles a la orden de preparación
            /*foreach (var producto in ordenPreparacion.Productos)
            {
                var productoStock = ArchivoStock.Stock.FirstOrDefault(p => p.Producto == producto.Nombre && p.ClienteCUIT == ordenPreparacion.Cliente);
                if (productoStock != null)
                {
                    ordenPreparacionEnt.ProductosList.Add(new StockEnt
                    {
                        Producto = productoStock.Producto,
                        ClienteCUIT = productoStock.ClienteCUIT,
                        Cantidad = producto.Cantidad,
                        Ubicacion = productoStock.Ubicacion,
                        Peso = productoStock.Peso,
                        TipoProducto = productoStock.TipoProducto
                    });
                }
                else
                {
                    // Manejo de error si el producto no se encuentra en el stock
                    throw new Exception($"Producto {producto.Nombre} no encontrado en el stock para el cliente {ordenPreparacion.Cliente}");
                }
            }*/


            // Agregar la ordenSeleccionEnt a la lista de órdenes de selección en el archivo
            ArchivoOrdenPreparacion.AgregarOrdenPreparacion(ordenPreparacionEnt);            
        }

        public void ModificarStocks(List<Producto> productosCliente, string clienteCUIT, int nroOrden)
        {
            List<StockEnt> stockARestar = new List<StockEnt>();

            foreach (var producto in productosCliente)
            {
                var stockProducto = ArchivoStock.Stock.FirstOrDefault(p => p.ProductoCliente == $"{producto.CodigoDeProducto}{clienteCUIT}");
                if (stockProducto != null)
                {
                    var productoCompleto = new StockEnt
                    {
                        ClienteCUIT = clienteCUIT,
                        Cantidad = producto.Cantidad,
                        Ubicacion = stockProducto.Ubicacion,
                        CodigoProducto = producto.CodigoDeProducto
                    };

                    stockARestar.Add(productoCompleto);
                }
            }
            
            ArchivoStock.RestarStock(stockARestar);


            List<StockProvisorioEnt> stockProvASumar = new List<StockProvisorioEnt>();

            foreach (var producto in productosCliente)
            {
                var stockProducto = ArchivoStock.Stock.FirstOrDefault(p => p.ProductoCliente == $"{producto.CodigoDeProducto}{clienteCUIT}");
                if (stockProducto != null)
                {
                    var productoCompleto = new StockProvisorioEnt
                    {
                        NroOrden = nroOrden,
                        Cantidad = producto.Cantidad,
                        Ubicacion = stockProducto.Ubicacion,
                        CodigoProducto = producto.CodigoDeProducto
                    };

                    stockProvASumar.Add(productoCompleto);
                }
            }

            ArchivoStockProvisorio.SumarStockProvisorio(stockProvASumar);
        }
    }
}