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

    public static void RestarStock(List<StockEnt> productos)
    {
        foreach (StockEnt producto in productos)
        {
            //no se valida si el producto existe ya que en este caso siempre va a existir
            // Busca el producto en la lista stock
            StockEnt productoEnStock = stock.FirstOrDefault(p => p.ProductoCliente == producto.ProductoCliente);
            
            // Resta la cantidad del producto existente en stock
            productoEnStock.Cantidad -= producto.Cantidad;
        }
    }

    public static void GrabarDatos()
    {
        var contenido = JsonConvert.SerializeObject(stock);
        File.WriteAllText(@"Data\stock.json", contenido);
    }


}
