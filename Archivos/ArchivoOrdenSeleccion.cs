using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoCProyectoCAI.Archivos
{
    public static class ArchivoOrdenSeleccion
    {
        private static List<OrdenSeleccionEnt> ordenesSeleccion;
        static ArchivoOrdenSeleccion()
        {
            if (File.Exists(@"DatosPrueba\ordenSeleccionP.json"))
            {
                var contenido = File.ReadAllText(@"DatosPrueba\ordenSeleccionP.json");
                ordenesSeleccion = JsonConvert.DeserializeObject<List<OrdenSeleccionEnt>>(contenido);
            }
            else
            {
              ordenesSeleccion = new List<OrdenSeleccionEnt>();
            }
        }

        public static ReadOnlyCollection<OrdenSeleccionEnt> OrdenSeleccions => new ReadOnlyCollection<OrdenSeleccionEnt>(ordenesSeleccion);

        public static void GrabarDatos()
        {
            var contenido = JsonConvert.SerializeObject(ordenesSeleccion);
            File.WriteAllText(@"Data\ordenesSeleccion.json", contenido);
        }

        public static void AgregarOrdenesSeleccion(OrdenSeleccionEnt orden)
        {
            ordenesSeleccion.Add(orden);
        }
    }
}
