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

        // Creamos un constructor para cargarle datos y probar el prototipo de forma aislada
        public AltaOrdenSeleccionModelo()
        {
            OrdenesPreparacion = new List<OrdenPreparacion>()
            {
                new OrdenPreparacion
                {
                    NumOrdenP = 25462357,
                    ClienteP = "Mercado Libre",
                    PrioridadP = "Alta",
                    FechaDespacho = new DateTime(2024,5,15)
                },
                new OrdenPreparacion
                {
                    NumOrdenP = 98765432,
                    ClienteP = "Amazon",
                    PrioridadP = "Media",
                    FechaDespacho = new DateTime(2024, 5, 16)
                },
                new OrdenPreparacion
                {
                    NumOrdenP = 12345678,
                    ClienteP = "Walmart",
                    PrioridadP = "Baja",
                    FechaDespacho = new DateTime(2024, 5, 17)
                },
                new OrdenPreparacion
                {
                    NumOrdenP = 77778888,
                    ClienteP = "Librería",
                    PrioridadP = "Alta",
                    FechaDespacho = new DateTime(2024, 5, 28)
                },
                new OrdenPreparacion
                {
                    NumOrdenP = 99990000,
                    ClienteP = "Joyería",
                    PrioridadP = "Media",
                    FechaDespacho = new DateTime(2024, 5, 30)
                },
                new OrdenPreparacion
                {
                    NumOrdenP = 24681357,
                    ClienteP = "Zapatería",
                    PrioridadP = "Baja",
                    FechaDespacho = new DateTime(2024, 6, 2)
                },
                new OrdenPreparacion
                {
                    NumOrdenP = 13579246,
                    ClienteP = "Electrohogar",
                    PrioridadP = "Alta",
                    FechaDespacho = new DateTime(2024, 6, 5)
                },
                new OrdenPreparacion
                {
                    NumOrdenP = 12348765,
                    ClienteP = "Mueblería ModernaP",
                    PrioridadP = "MediaP",
                    FechaDespacho = new DateTime(2024, 6, 10)
                }
            };
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

        public string ElegirPrioridad(List<string> Prioridades)
        {
            int prioridadesAltas = 0;
            int prioridadesMedias = 0;
            int prioridadesBajas = 0;

            // Este método elige la prioridad más alta en base a las ordenes de preparación seleccionadas
            foreach (var prioridad in Prioridades)
            {
                if (prioridad == "Alta")
                {
                    prioridadesAltas += 3;
                }
                else if (prioridad == "Media")
                {
                    prioridadesMedias += 2;
                }
                else if (prioridad == "Baja")
                {
                    prioridadesBajas++;
                }
            }

            if (prioridadesAltas >= prioridadesMedias && prioridadesAltas >= prioridadesBajas)
            {
                return "Alta";
            } else if (prioridadesMedias > prioridadesAltas && prioridadesMedias >= prioridadesBajas)
            {
                return "Media";
            } else if (prioridadesBajas > prioridadesAltas && prioridadesBajas > prioridadesMedias)
            {
                return "Baja";
            } else
            {
                return "";
            }
        }          
    }
}
