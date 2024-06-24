using GrupoCProyectoCAI.Archivos;
using GrupoCProyectoCAI.Preparador.PrepararOrden;
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
                        FechaDespacho = ordenEntidad.FechaDespacho,
                    };

                    OrdenesPreparadas.Add(ordenPreparacion);
                }
            }
        }
        public void Confirmar()
        {
            // Utilizaremos un diccionario para almacenar remitos por cliente (utilizando CUIT como clave única)
            Dictionary<string, RemitoEnt> remitosPorCliente = new Dictionary<string, RemitoEnt>();

            foreach (var ordenDespachada in OrdenesSeleccionadas)
            {
                // Verificar si ya existe un remito para este cliente
                if (!remitosPorCliente.ContainsKey(ordenDespachada.ClienteCUIT))
                {
                    // Si no existe, creamos un nuevo remito para este cliente
                    var remitoEnt = new RemitoEnt
                    {
                        NroRemito = GenerarNumero(),
                        clienteCUIT = ordenDespachada.ClienteCUIT,
                        transportistaCUIT = ordenDespachada.TransportistaCUIT,
                        FechaDespacho = ordenDespachada.FechaDespacho,
                        NroOrdenes = new List<int> { ordenDespachada.NumOrden }
                    };

                    // Agregamos este remito al diccionario de remitos por cliente
                    remitosPorCliente.Add(ordenDespachada.ClienteCUIT, remitoEnt);
                }
                else
                {
                    // Si ya existe un remito para este cliente, simplemente agregamos la orden despachada al remito existente
                    remitosPorCliente[ordenDespachada.ClienteCUIT].NroOrdenes.Add(ordenDespachada.NumOrden);
                }

                // Eliminar el stock provisorio asociado a esta orden despachada
                ArchivoStockProvisorio.EliminarStockProvisorio(ordenDespachada.NumOrden);
            }

            // Ahora guardamos todos los remitos creados en el archivo de remitos
            foreach (var remito in remitosPorCliente.Values)
            {
                ArchivoRemito.AgregarRemito(remito);
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
