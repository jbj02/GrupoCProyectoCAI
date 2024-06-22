using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoCProyectoCAI.Archivos;
public static class ArchivoStockProvisorio
{
    //este archivo usa la clase Stock que ya existía, no se crea una nueva porque son las dos iguales
    private static List<StockProvisrorioEnt> stockProvisorio;
    static ArchivoStockProvisorio()
    {
        if (File.Exists(@"Data\stockProvisorio.json"))
        {
            var contenido = File.ReadAllText(@"Data\stockProvisorio.json");
            stockProvisorio = JsonConvert.DeserializeObject<List<StockProvisrorioEnt>>(contenido);
        }
        else
        {
            stockProvisorio = new List<StockProvisrorioEnt>();
        }
    }

    public static ReadOnlyCollection<StockProvisrorioEnt> StockProvisorio => new ReadOnlyCollection<StockProvisrorioEnt>(stockProvisorio);

    public static void SumarStockProvisorio(List<StockProvisrorioEnt> productos)
    {
        foreach (StockProvisrorioEnt producto in productos)
        {
            int indiceExistente = stockProvisorio.FindIndex(p => p.ProductoCliente == producto.ProductoCliente);
            //si el producto ya existe dentro del stock provisorio
            if (indiceExistente != -1)
            {
                //se le suman las cantidades de la órden nueva
                stockProvisorio[indiceExistente].Cantidad += producto.Cantidad;
            }
            else
            {
                //sino, simplemente se agrega todo el producto proveniente de la órden
                stockProvisorio.Add(producto);
            }
        }
    }

    public static void GrabarDatos()
    {
        var contenido = JsonConvert.SerializeObject(stockProvisorio);
        File.WriteAllText(@"Data\stockProvisorio.json", contenido);
    }
}
