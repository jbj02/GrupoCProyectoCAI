using GrupoCProyectoCAI.Despachador;
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
        // Expone el archivo con una lista de solo lectura
        public static ReadOnlyCollection<OrdenPreparacion> OrdenesPreparacion => ordenesPreparacion.AsReadOnly();

        private static List<OrdenPreparacion> ordenesPreparacion;

        static ArchivoOrdenPreparacion()
        {

            if (File.Exists(@"DatosPrueba\ordenPreparacionP.json"))
            {
                var contenido = File.ReadAllText(@"DatosPrueba\ordenPreparacionP.json");
                ordenesPreparacion = JsonConvert.DeserializeObject<List<OrdenPreparacion>>(contenido);
            }
            else
            {
                ordenesPreparacion = new List<OrdenPreparacion>();
            }
        }

        public static void AgregarOrdenPreparacion(OrdenPreparacion orden)
        {
            ordenesPreparacion.Add(orden);
        }

        public static void GrabarDatos()
        {
            var contenido = JsonConvert.SerializeObject(ordenesPreparacion);
            File.WriteAllText(@"DatosPrueba\ordenPreparacionP.json", contenido);
        }
    }

}
