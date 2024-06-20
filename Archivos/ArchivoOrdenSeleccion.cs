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
        private static List<OrdenSeleccion> ordenesSeleccion;
        static ArchivoOrdenSeleccion()
        {
            if (File.Exists(@"Data\ordenesSeleccion.json"))
            {
                var contenido = File.ReadAllText(@"Data\ordenSeleccion.json");
                ordenesSeleccion = JsonConvert.DeserializeObject<List<OrdenSeleccion>>(contenido);
            }
            else
            {
                ordenesSeleccion = new List<OrdenSeleccion>();
            }
        }

        public static ReadOnlyCollection<OrdenSeleccion> OrdenSeleccions => new ReadOnlyCollection<OrdenSeleccion>(ordenesSeleccion);

        public static void GrabarDatos()
        {
            var contenido = JsonConvert.SerializeObject(ordenesSeleccion);
            File.WriteAllText(@"Data\ordenSeleccion.json", contenido);
        }
    }
}
