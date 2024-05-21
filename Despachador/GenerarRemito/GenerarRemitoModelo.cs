using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoCProyectoCAI.Despachador.GenerarRemito
{
    internal class GenerarRemitoModelo
    {

           public List<OrdenInt> OrdenesInternas { get; set; }

        // Creamos un constructor para cargarle datos y probar el prototipo de forma aislada
        public GenerarRemitoModelo() 
        {
            OrdenesInternas = new List<OrdenInt>()
            {
                new OrdenInt
                {
                    NumOrdenInt = 65839573,
                    NumOrdenExt = 25462357,
                    TipoProducto = "Producto A",
                    Cantidad = 2,
                    Deposito = "Buenos Aires" , 
                    FechaCreacion = new DateTime(2024,5,15),
                   
                    
                },
                new OrdenInt
                {
                    NumOrdenInt = 74949275,
                    NumOrdenExt = 98765432,
                    TipoProducto = "Producto B",
                    Cantidad = 5,
                    Deposito = "Rosario" ,
                    FechaCreacion = new DateTime(2024, 5, 16),
                    
                },
                new OrdenInt
                {
                    NumOrdenInt = 67594852,
                    NumOrdenExt = 12345678,
                    TipoProducto = "Producto C",
                    Cantidad = 3,
                    Deposito = "Buenos Aires" ,
                    FechaCreacion = new DateTime(2024, 5, 17),
                    
                }
            };
        }






    }



}
