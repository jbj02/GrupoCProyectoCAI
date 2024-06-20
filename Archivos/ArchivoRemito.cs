using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoCProyectoCAI.Archivos
{
    public static class ArchivoRemito
    {
        private static List<Remito> remitos;
        static ArchivoRemito()
        {
            if (File.Exists(@"Data\remitos.json"))
            {
                var contenido = File.ReadAllText(@"Data\remitos.json");
                remitos = JsonConvert.DeserializeObject<List<Remito>>(contenido);
            }
            else
            {
                remitos = new List<Remito>();
            }
        }

        public static ReadOnlyCollection<Remito> Remitos => new ReadOnlyCollection<Remito>(remitos);

        public static void GrabarDatos()
        {
            var contenido = JsonConvert.SerializeObject(remitos);
            File.WriteAllText(@"Data\remitos.json", contenido);
        }
    }
}
