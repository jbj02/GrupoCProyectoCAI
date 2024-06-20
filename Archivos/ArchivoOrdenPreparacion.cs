using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoCProyectoCAI.Archivos
{
    public static class ArchivoOrdenPreparacion
    {
        private static List<OrdenPreparacion> ordenesPreparacion;

        static ArchivoOrdenPreparacion()
        {
            if (File.Exists(@"Data\ordenPreparacion.json"))
            {
                var contenido = File.ReadAllText(@"Data\ordenPreparacion.json");
                ordenesPreparacion = JsonConvert.DeserializeObject<List<OrdenPreparacion>>(contenido);
            }
            else
            {
                ordenesPreparacion = new List<OrdenPreparacion>();
            }
        }

        public static ReadOnlyCollection<OrdenPreparacion> OrdenesPreparacion => ordenesPreparacion.AsReadOnly();

        public static void AgregarOrdenPreparacion(OrdenPreparacion orden)
        {
            ordenesPreparacion.Add(orden);
        }

        public static void GrabarDatos()
        {
            var contenido = JsonConvert.SerializeObject(ordenesPreparacion);
            File.WriteAllText(@"Data\ordenesPreparacion.json", contenido);
        }
    }
}
