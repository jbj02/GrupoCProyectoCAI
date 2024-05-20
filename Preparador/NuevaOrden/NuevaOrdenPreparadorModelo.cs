using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoCProyectoCAI.Preparador.NuevaOrden
{
    public class NuevaOrdenPreparadorModelo
    {
        public List<OrdenExt> OrdenesExternas { get; set; }
        // Lista para almacenar los Números De Orden Interna generados previamente
        public static List<int> numeroOrdenIntGenerados = new List<int>();

        // Creamos un constructor para cargarle datos y probar el prototipo de forma aislada
        public NuevaOrdenPreparadorModelo()
        {
            OrdenesExternas = new List<OrdenExt>()
            {
                new OrdenExt
                {
                    NumOrdenExt = 25462357,
                    TipoProducto = "Producto A",
                    Cantidad = 2,
                    Cliente = "Mercado Libre",
                    Prioridad = "Alta",
                    FechaCreacion = new DateTime(2024,5,15)
                },
                new OrdenExt
                {
                    NumOrdenExt = 98765432,
                    TipoProducto = "Producto B",
                    Cantidad = 5,
                    Cliente = "Amazon",
                    Prioridad = "Media",
                    FechaCreacion = new DateTime(2024, 5, 16)
                },
                new OrdenExt
                {
                    NumOrdenExt = 12345678,
                    TipoProducto = "Producto C",
                    Cantidad = 3,
                    Cliente = "Walmart",
                    Prioridad = "Baja",
                    FechaCreacion = new DateTime(2024, 5, 17)
                }
            };
        }

        // Método para generar el Npumero de Orden Interna
        public static int GenerarNumeroOrdenInt()
        {
            // Crear una instancia de la clase Random
            Random random = new Random();

            // Generar un nuevo N° de Orden Interna hasta que sea único
            int NumOrdenInt;
            do
            {
                // Generar 8 dígitos aleatorios
                int numeros = GenerarNumeros(8);
                NumOrdenInt = numeros;
            } while (numeroOrdenIntGenerados.Contains(NumOrdenInt));

            // Agregar el N° de orden interna generado a la lista
            numeroOrdenIntGenerados.Add(NumOrdenInt);

            // Devolver el N° de orden interna generado
            return NumOrdenInt;
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
