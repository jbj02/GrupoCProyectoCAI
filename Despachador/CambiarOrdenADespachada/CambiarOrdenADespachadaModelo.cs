using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoCProyectoCAI.Despachador.Modificar
{
    internal class CambiarOrdenADespachadaModelo
    {
        public List<OrdenInt> OrdenesInternas { get; set; }

        // Creamos un constructor para cargarle datos y probar el prototipo de forma aislada
        public CambiarOrdenADespachadaModelo()
        {
            OrdenesInternas = new List<OrdenInt>()
            {
                new OrdenInt
                {
                    NumOrdenInt = 65839573,
                    NumOrdenExt = 25462357,
                    TipoProducto = "Producto A",
                    Cantidad = 2,
                    Cliente = "Mercado Libre",
                    Prioridad = "Alta",
                    FechaCreacion = new DateTime(2024,5,15),
                    FechaModificacion = new DateTime(2024,5,16),
                    Estado = "Preparada"
                },
                new OrdenInt
                {
                    NumOrdenInt = 74949275,
                    NumOrdenExt = 98765432,
                    TipoProducto = "Producto B",
                    Cantidad = 5,
                    Cliente = "Amazon",
                    Prioridad = "Media",
                    FechaCreacion = new DateTime(2024, 5, 16),
                    FechaModificacion = new DateTime(2024,5,17),
                    Estado = "Preparada"
                },
                new OrdenInt
                {
                    NumOrdenInt = 67594852,
                    NumOrdenExt = 12345678,
                    TipoProducto = "Producto C",
                    Cantidad = 3,
                    Cliente = "Walmart",
                    Prioridad = "Baja",
                    FechaCreacion = new DateTime(2024, 5, 17),
                    FechaModificacion = new DateTime(2024,5,17),
                    Estado = "Preparada"
                }
            };
        }
    }
}
