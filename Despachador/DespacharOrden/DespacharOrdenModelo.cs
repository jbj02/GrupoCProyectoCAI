using GrupoCProyectoCAI.Archivos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoCProyectoCAI.Despachador.DespacharOrden
{
    internal class DespacharOrdenModelo
    {
        public List<OrdenPreparacionD> OrdenesPreparadas { get; set; }
        public List<OrdenPreparacionD> OrdenesSeleccionadas { get; set; } = new List<OrdenPreparacionD>();

        // Lista para almacenar los Números De Orden de Seleccion generados previamente
        public static List<int> numeroOrdenIntGenerados = new List<int>();

        // Creamos un constructor para cargarle datos y probar el prototipo de forma aislada
        public DespacharOrdenModelo()
        {
            OrdenesPreparadas = new List<OrdenPreparacionD>();

            foreach (var ordenEntidad in ArchivoOrdenPreparacion.OrdenesPreparacion)
            {
                if (ordenEntidad.Estado == EstadosOrdenPreparacion.Preparada)
                {
                    var ordenPreparacion = new OrdenPreparacionD
                    {
                        NumOrden = ordenEntidad.NroOrden,
                        ClienteCUIT = ordenEntidad.ClienteCUIT,
                        TransportistaCUIT = ordenEntidad.TransportistaCUIT,
                        FechaDespacho = ordenEntidad.FechaDespacho
                    };

                    OrdenesPreparadas.Add(ordenPreparacion);
                }
            }
        }
        public void Confirmar()
        {
            foreach (var ordenDespachada in OrdenesSeleccionadas)
            {
                // Obtener la orden de preparación completa (incluidos los productos)
                var ordenPreparacion = ArchivoOrdenPreparacion.ObtenerOrdenPreparacionPorNumero(ordenDespachada.NumOrden);

                ArchivoOrdenPreparacion.SeleccionarOrden(ordenDespachada.NumOrden, "Despachada");

                // Crear un nuevo objeto Remito y asignar los valores requeridos
                var remitoEnt = new RemitoEnt
                {
                    NroRemito = GenerarNumero(),
                    clienteCUIT = ordenDespachada.ClienteCUIT,
                    transportistaCUIT = ordenDespachada.TransportistaCUIT,
                    FechaDespacho = ordenDespachada.FechaDespacho,
                    ProductosList = new List<StockEnt>()
                };

                // Agregar los productos de la orden de preparación al remito
                foreach (var producto in ordenPreparacion.ProductosList)
                {
                    remitoEnt.ProductosList.Add(new StockEnt
                    {
                        Producto = producto.Producto,
                        ClienteCUIT = ordenDespachada.ClienteCUIT,
                        Cantidad = producto.Cantidad,
                        Ubicacion = producto.Ubicacion,
                        Peso = producto.Peso,
                        TipoProducto = producto.TipoProducto
                    });
                }
                // Agregar la ordenSeleccionEnt a la lista de órdenes de selección en el archivo
                ArchivoRemito.AgregarRemito(remitoEnt);
            }
        }

        internal int GenerarNumero()
        {
            // Crear una instancia de la clase Random
            Random random = new Random();

            // Generar un nuevo N° de Orden hasta que sea único
            int NumOrden;
            do
            {
                // Generar 8 dígitos aleatorios
                int numeros = GenerarNumeros(8);
                NumOrden = numeros;
            } while (numeroOrdenIntGenerados.Contains(NumOrden));

            // Agregar el N° de orden interna generado a la lista
            numeroOrdenIntGenerados.Add(NumOrden);

            // Devolver el N° de orden interna generado
            return NumOrden;
        }

        // Método para generar números aleatorios
        public static int GenerarNumeros(int cantidad)
        {
            // Crear una instancia de la clase Random
            Random random = new Random();
            return random.Next((int)Math.Pow(10, cantidad));
        }

        public void SeleccionarOrden(OrdenPreparacionD orden)
        {
            orden.Estado = "Despachada";
            OrdenesSeleccionadas.Add(orden);
        }

        public void DeseleccionarOrden(OrdenPreparacionD orden)
        {
            orden.Estado = "Preparada";
            OrdenesSeleccionadas.Remove(orden);
        }
    }
}
