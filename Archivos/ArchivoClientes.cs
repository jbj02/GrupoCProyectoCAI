using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoCProyectoCAI.Archivos;

public static class ArchivoClientes
{
    private static List<ClienteEnt> clientes;

    static ArchivoClientes()
    {
        if (File.Exists(@"Data\clientes.json"))
        {
            var contenido = File.ReadAllText(@"Data\clientes.json");
            clientes = JsonConvert.DeserializeObject<List<ClienteEnt>>(contenido);
        }
        else
        {
            clientes = new List<ClienteEnt>();
        }
    }

    public static ReadOnlyCollection<ClienteEnt> Clientes => new ReadOnlyCollection<ClienteEnt>(clientes);
}
