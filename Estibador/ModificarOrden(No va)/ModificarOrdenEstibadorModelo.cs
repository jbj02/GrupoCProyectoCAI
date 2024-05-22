namespace GrupoCProyectoCAI
{
    internal class ModificarOrdenEstibadorModelo
    {
        public List<OrdenInt> OrdenesInternas { get; set; } 

        public ModificarOrdenEstibadorModelo() 
        {
            OrdenesInternas = new List<OrdenInt>()
            {
                new OrdenInt //caso hardcodeado, despues levantamos archivo
                {
                    NumOrdenInt = 65839573,
                    NumOrdenExt = 25462357,
                    TipoProducto = "Producto A",
                    Cantidad = 2,
                    Cliente = "Mercado Libre",
                    Prioridad = "Alta",
                    FechaCreacion = new DateTime(2024,5,15),
                    FechaModificacion = new DateTime(2024,5,16),
                    Estado = "En Selección"
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
                    Estado = "En Selección"
                }
            };
        }

    }
}