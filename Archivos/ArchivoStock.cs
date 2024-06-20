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
            //se le resta al stock las cantidades provenientes de la órden
            //no se valida si el producto existe ya que en este caso siempre va a existir
            int indiceExistente = stock.FindIndex(p => p.ProductoCliente == producto.ProductoCliente);
            stock[indiceExistente].Cantidad = stock[indiceExistente].Cantidad - producto.Cantidad;
        }
    }

    public static void GrabarDatos()
    {
        var contenido = JsonConvert.SerializeObject(stock);
        File.WriteAllText(@"Data\stock.json", contenido);
    }
}
