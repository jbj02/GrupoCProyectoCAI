using GrupoCProyectoCAI.Archivos;
using GrupoCProyectoCAI.Despachador;
using GrupoCProyectoCAI.Preparador.PrepararOrden;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoCProyectoCAI.Preparador.AltaOrdenSeleccion
{
    internal class AltaOrdenSeleccionModelo
    {
        public List<OrdenPreparacion> OrdenesPreparacion { get; set; }

        // Lista para almacenar los Números De Orden de Seleccion generados previamente
        public static List<int> numeroOrdenIntGenerados = new List<int>();

        // Creamos un constructor para cargarle datos
        public AltaOrdenSeleccionModelo()
        {
            OrdenesPreparacion = new List<OrdenPreparacion>();

            foreach (var ordenEntidad in ArchivoOrdenPreparacion.OrdenesPreparacion)
            {
                if (ordenEntidad.Estado == "PendienteDeSeleccion")
                {
                    var ordenPreparacion = new OrdenPreparacion
                    {
                        NumOrdenP = ordenEntidad.NroOrden,
                        ClienteCUIT = ordenEntidad.ClienteCUIT,
                        FechaDespacho = ordenEntidad.FechaDespacho
                    };

                    OrdenesPreparacion.Add(ordenPreparacion);
                }                   
            }          
        }

        public void AgregarOrdenesSeleccion(OrdenSeleccion orden)
        {
            // Crear un nuevo objeto OrdenSeleccionEnt y asignar los valores del objeto OrdenSeleccion
            var ordenSeleccionEnt = new OrdenSeleccionEnt
            {
                NroOrden = orden.NumOrden,
                Estado = orden.Estado,
                OrdenPreparacionAsociadas = new List<OrdenPreparacionEnt>()
            };

            foreach (var ordenPreparacion in orden.OrdenesPreparacionAsociadas)
            {
                var ordenPreparacionEnt = ArchivoOrdenPreparacion.ObtenerOrdenPreparacionPorNumero(ordenPreparacion.NumOrdenP);
                if (ordenPreparacionEnt != null)
                {
                    ordenSeleccionEnt.OrdenPreparacionAsociadas.Add(ordenPreparacionEnt);

                    ArchivoOrdenPreparacion.SeleccionarOrden(ordenPreparacion.NumOrdenP, "EnSeleccion");
                }
                else
                {
                    throw new Exception($"No se encontró la orden de preparación con el número {ordenPreparacion.NumOrdenP}.");
                }
            }

            // Agregar la ordenSeleccionEnt a la lista de órdenes de selección en el archivo
            ArchivoOrdenSeleccion.AgregarOrdenesSeleccion(ordenSeleccionEnt);
        }

        internal int GenerarNumeroOrdenSeleccion()
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
    }    
}

