using GrupoCProyectoCAI.Preparador.PrepararOrden;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoCProyectoCAI.Preparador.PrepararOrden
{
    internal class PrepararOrdenModelo
    {
        public List<OrdenPrepara> OrdenesPreparacion { get; set; }
        public OrdenPrepara ordenPrepara { get; set; }
        // Creamos un constructor para cargarle datos y probar el prototipo de forma aislada
        public PrepararOrdenModelo()
        {
            OrdenesPreparacion = new List<OrdenPrepara>()
            {
                new OrdenPrepara
                {
                    NumOrden = 65839573,
                    Estado = "Seleccionada",
                    Cliente = "Mercado Libre",
                    Prioridad = "Alta",
                    FechaAlta = new DateTime(2024,5,15),
                    FechaDespacho = new DateTime(2024,5,16),

                    Productos = new List<Productos>()
                    {
                        new Productos
                        {
                            NombreProducto = "Producto A",
                            Cantidad = 4,
                        },
                        new Productos
                        {
                            NombreProducto = "Producto H",

                            Cantidad = 2,
                        },
                        new Productos
                        {
                            NombreProducto = "Producto F",

                            Cantidad = 12,
                        },
                        new Productos
                        {
                            NombreProducto = "Producto R",

                            Cantidad = 8,
                        },
                        new Productos
                        {
                            NombreProducto = "Producto T",

                            Cantidad = 3,
                        }
                    }         
                },
                new OrdenPrepara
                {
                    NumOrden = 65839373,
                    Estado = "Seleccionada",
                    Cliente = "Walmart",
                    Prioridad = "Media",
                    FechaAlta = new DateTime(2024,5,15),
                    FechaDespacho = new DateTime(2024,5,23),

                    Productos = new List<Productos>()
                    {
                        new Productos
                        {
                            NombreProducto = "Producto A",
                            Cantidad = 4,
                        },
                        new Productos
                        {
                            NombreProducto = "Producto H",

                            Cantidad = 6,
                        }
                    }
                },
                 new OrdenPrepara
                {
                    NumOrden = 65839373,
                    Estado = "Seleccionada",
                    Cliente = "Amazon",
                    Prioridad = "Alta",
                    FechaAlta = new DateTime(2024,5,15),
                    FechaDespacho = new DateTime(2024,5,18),

                    Productos = new List<Productos>()
                    {
                        new Productos
                        {
                            NombreProducto = "Producto A",
                            Cantidad = 4,
                        },
                        new Productos
                        {
                            NombreProducto = "Producto H",

                            Cantidad = 12,
                        }
                    }
                },
                  new OrdenPrepara
                {
                    NumOrden = 65839373,
                    Estado = "Seleccionada",
                    Cliente = "Walmart",
                    Prioridad = "Media",
                    FechaAlta = new DateTime(2024,5,15),
                    FechaDespacho = new DateTime(2024,5,25),

                    Productos = new List<Productos>()
                    {
                        new Productos
                        {
                            NombreProducto = "Producto A",
                            Cantidad = 4,
                        }
                    }
                },
                new OrdenPrepara
                {
                    NumOrden = 65839563,
                    Estado = "Seleccionada",
                    Cliente = "Mercado Libre",
                    Prioridad = "Alta",
                    FechaAlta = new DateTime(2024,5,12),
                    FechaDespacho = new DateTime(2024,5,16),

                    Productos = new List<Productos>()
                    {
                        new Productos
                        {
                            NombreProducto = "Producto A",
                            Cantidad = 4,
                        }
                    }
                },
                new OrdenPrepara
                {
                    NumOrden = 65829573,
                    Estado = "Seleccionada",
                    Cliente = "Amazon",
                    Prioridad = "Alta",
                    FechaAlta = new DateTime(2024,5,13),
                    FechaDespacho = new DateTime(2024,5,18),

                    Productos = new List<Productos>()
                    {
                        new Productos
                        {
                            NombreProducto = "Producto C",
                            Cantidad = 12,
                        },
                        new Productos
                        {
                            NombreProducto = "Producto A",
                            Cantidad = 4,
                        }
                    }
                },
                new OrdenPrepara
                {
                    NumOrden = 67839573,
                    Estado = "Seleccionada",
                    Cliente = "Amazon",
                    Prioridad = "Alta",
                    FechaAlta = new DateTime(2024,5,15),
                    FechaDespacho = new DateTime(2024,5,16),

                    Productos = new List<Productos>()
                    {
                        new Productos
                        {
                            NombreProducto = "Producto E",
                            Cantidad = 9,
                        },
                        new Productos
                        {
                            NombreProducto = "Producto A",
                            Cantidad = 4,
                        }
                    }
                },
                new OrdenPrepara
                {
                    NumOrden = 65830573,
                    Estado = "Seleccionada",
                    Cliente = "Tienda Mia",
                    Prioridad = "Alta",
                    FechaAlta = new DateTime(2024,5,15),
                    FechaDespacho = new DateTime(2024,5,16),

                    Productos = new List<Productos>()
                    {
                        new Productos
                        {
                            NombreProducto = "Producto R",
                            Cantidad = 32,
                        }
                    }
                },
                new OrdenPrepara
                {
                    NumOrden = 65830073,
                    Estado = "Seleccionada",
                    Cliente = "Mercado Libre",
                    Prioridad = "Media",
                    FechaAlta = new DateTime(2024,5,15),
                    FechaDespacho = new DateTime(2024,5,21),

                    Productos = new List<Productos>()
                    {
                        new Productos
                        {
                            NombreProducto = "Producto F",
                            Cantidad = 14,
                        }
                    }
                },
                new OrdenPrepara
                {
                    NumOrden = 74949275,
                    Estado = "Seleccionada",
                    Cliente = "Amazon",
                    Prioridad = "Media",
                    FechaAlta = new DateTime(2024, 5, 15),
                    FechaDespacho = new DateTime(2024,5,29),
                    Productos = new List<Productos>()
                    {
                        new Productos
                        {
                            NombreProducto = "Producto C",
                            Cantidad = 8,
                        },
                        new Productos
                        {
                            NombreProducto = "Producto H",

                            Cantidad = 6,
                        }
                    }

                },
                new OrdenPrepara
                {
                    NumOrden = 67594852,
                    Estado = "Seleccionada",
                    Cliente = "Walmart",
                    Prioridad = "Baja",
                    FechaAlta = new DateTime(2024, 5, 16),
                    FechaDespacho = new DateTime(2024,6,10),
                    Productos = new List<Productos>()
                    {
                        new Productos
                        {
                            NombreProducto = "Producto C",
                            Cantidad = 8,
                        },
                        new Productos
                        {
                            NombreProducto = "Producto H",

                            Cantidad = 6,
                        }
                    }
                }
            };
        }
        
    }
}
