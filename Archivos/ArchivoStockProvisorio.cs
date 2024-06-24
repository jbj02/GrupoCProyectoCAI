using GrupoCProyectoCAI.Preparador.AltaOrdenPreparacion;
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
    private static List<StockProvisorioEnt> stockProvisorio;
    static ArchivoStockProvisorio()
    {
        if (File.Exists(@"Data\stockProvisorio.json"))
        {
            var contenido = File.ReadAllText(@"Data\stockProvisorio.json");
            stockProvisorio = JsonConvert.DeserializeObject<List<StockProvisorioEnt>>(contenido);
        }
        else
        {
            stockProvisorio = new List<StockProvisorioEnt>();
        }
    }

    public static ReadOnlyCollection<StockProvisorioEnt> StockProvisorio => new ReadOnlyCollection<StockProvisorioEnt>(stockProvisorio);

    public static void SumarStockProvisorio(List<StockProvisorioEnt> productosAfectados)
    {
        foreach (var producto in productosAfectados)
        {
            /*var stockProvisorioProducto = StockProvisorio.FirstOrDefault(p => p.ProductoCliente == producto.ProductoCliente);
            if (stockProvisorioProducto != null)
            {
                stockProvisorioProducto.Cantidad += producto.Cantidad;
            }
            else
            {
                stockProvisorio.Add(new StockProvisorioEnt
                {
                    Producto = producto.Producto,
                    ClienteCUIT = producto.ClienteCUIT,
                    Cantidad = producto.Cantidad,
                    Ubicacion = producto.Ubicacion,
                    Peso = producto.Peso,
                    TipoProducto = producto.TipoProducto
                });
            }*/
            stockProvisorio.Add(producto);
        }
    }

    // Método para eliminar el stock provisorio asociado a una orden despachada
    public static void EliminarStockProvisorio(int numeroOrden)
    {
        stockProvisorio.RemoveAll(sp => sp.NroOrden == numeroOrden);
    }

    public static void GrabarDatos()
    {
        var contenido = JsonConvert.SerializeObject(stockProvisorio);
        File.WriteAllText(@"Data\stockProvisorio.json", contenido);
    }
}
