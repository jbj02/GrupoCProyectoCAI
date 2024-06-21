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
    private static List<Stock> stock;
    static ArchivoStock()
    {
        if (File.Exists(@"Data\stock.json"))
        {
            var contenido = File.ReadAllText(@"Data\stock.json");
            stock = JsonConvert.DeserializeObject<List<Stock>>(contenido);
        }
        else
        {
            stock = new List<Stock>();
        }
    }

    public static ReadOnlyCollection<Stock> Stock => new ReadOnlyCollection<Stock>(stock);

    public static void RestarStock(List<Stock> productos)
    {
        foreach (Stock producto in productos)
        {
            //no se valida si el producto existe ya que en este caso siempre va a existir
            // Busca el producto en la lista stock
            Stock productoEnStock = stock.FirstOrDefault(p => p.ProductoCliente == producto.ProductoCliente);
            
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
