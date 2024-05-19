using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoCProyectoCAI.Preparador.NuevaOrden
{
    internal class NuevaOrdenPreparadorModelo
    {
        public List<OrdenExt> OrdenesExternas { get; set; }

        // Creamos un constructor para cargarle datos y probar el prototipo de forma aislada
        public NuevaOrdenPreparadorModelo()
        {
            OrdenesExternas = new List<OrdenExt>()
            {
                new OrdenExt
                {
                    NumOrdenExt = 25462357,
                    TipoProducto = "Producto A",
                    Cantidad = 2,
                    Cliente = "Mercado Libre",
                    Prioridad = "Alta",
                    FechaCreacion = new DateTime(2024,5,15)
                },
                new OrdenExt
                {
                    NumOrdenExt = 98765432,
                    TipoProducto = "Producto B",
                    Cantidad = 5,
                    Cliente = "Amazon",
                    Prioridad = "Media",
                    FechaCreacion = new DateTime(2024, 5, 16)
                },
                new OrdenExt
                {
                    NumOrdenExt = 12345678,
                    TipoProducto = "Producto C",
                    Cantidad = 3,
                    Cliente = "Walmart",
                    Prioridad = "Baja",
                    FechaCreacion = new DateTime(2024, 5, 17)
                }
            };
        }
    }
}
