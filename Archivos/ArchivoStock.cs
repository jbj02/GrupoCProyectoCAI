using GrupoCProyectoCAI.Preparador.AltaOrdenPreparacion;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoCProyectoCAI.Archivos;

public static class ArchivoStock
{
    private static List<StockEnt> stock;
    static ArchivoStock()
    {
        if (File.Exists(@"Data\stock.json"))
        {
            var contenido = File.ReadAllText(@"Data\stock.json");
            stock = JsonConvert.DeserializeObject<List<StockEnt>>(contenido);
        }
        else
        {
            stock = new List<StockEnt>();
        }
    }

    public static ReadOnlyCollection<StockEnt> Stock => new ReadOnlyCollection<StockEnt>(stock);

    public static void GrabarDatos()
    {
        var contenido = JsonConvert.SerializeObject(stock);
        File.WriteAllText(@"Data\stock.json", contenido);
    }

    // Método para restar stock
    public static void RestarStock(List<StockEnt> productosAfectados)
    {
        foreach (var producto in productosAfectados)
        {
            var stockProducto = Stock.FirstOrDefault(p => p.ProductoCliente == producto.ProductoCliente);
            stockProducto.Cantidad -= producto.Cantidad;
        }

    }
}
