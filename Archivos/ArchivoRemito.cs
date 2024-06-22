using GrupoCProyectoCAI.Almacenaje.SelecciondeProductos;
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
        private static List<RemitoEnt> remitos;
        static ArchivoRemito()
        {
            if (File.Exists(@"Data\remitos.json"))
            {
                var contenido = File.ReadAllText(@"Data\remitos.json");
                remitos = JsonConvert.DeserializeObject<List<RemitoEnt>>(contenido);
            }
            else
            {
                remitos = new List<RemitoEnt>();
            }
        }

        public static ReadOnlyCollection<RemitoEnt> Remitos => new ReadOnlyCollection<RemitoEnt>(remitos);

        public static void GrabarDatos()
        {
            var contenido = JsonConvert.SerializeObject(remitos);
            File.WriteAllText(@"Data\remitos.json", contenido);
        }

        public static void AgregarRemito(RemitoEnt remito)
        {
            remitos.Add(remito);
        }
    }
}
