using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoCProyectoCAI.Archivos;
internal static class ArchivoProductos
{
    private static List<ProductoEnt> productos;
    static ArchivoProductos()
    {
        if (File.Exists(@"Data\productos.json"))
        {
            var contenido = File.ReadAllText(@"Data\productos.json");
            productos = JsonConvert.DeserializeObject<List<ProductoEnt>>(contenido);
        }
        else
        {
            productos = new List<ProductoEnt>();
        }
    }
    public static ReadOnlyCollection<ProductoEnt> Productos => new ReadOnlyCollection<ProductoEnt>(productos);
}
