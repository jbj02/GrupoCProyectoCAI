using GrupoCProyectoCAI.Archivos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoCProyectoCAI.Preparador.AltaOrdenSeleccion
{
    public class AltaOrdenSeleccionModelo
    {
        public List<OrdenPreparacion> OrdenesPreparacion { get; set; }

        // Lista para almacenar los Números De Orden de Seleccion generados previamente
        public static List<int> numeroOrdenIntGenerados = new List<int>();

        // Creamos un constructor para cargarle datos y probar el prototipo de forma aislada
        public AltaOrdenSeleccionModelo()
        {
            OrdenesPreparacion = new List<OrdenPreparacion>();
            CargarListaOrdenPreparacion();
        }

        public void CargarListaOrdenPreparacion()
        {
            foreach(var ordenPreparacion in ArchivoOrdenPreparacion.OrdenesPreparacion)
            {
                // Agregarlas solamente si tiene el Estado "Preparada"
                if (ordenPreparacion.Estado == "PendienteDeSeleccion")
                {
                    OrdenesPreparacion.Add(ordenPreparacion);
                }
            }
        }

        public void AgregarOrdenesSeleccion(OrdenSeleccion orden)
        {
            ArchivoOrdenSeleccion.AgregarOrdenesSeleccion(orden);
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
