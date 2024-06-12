using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoCProyectoCAI.Preparador.AltaOrdenPreparacion
{
    internal class AltaOrdenPreparacionModelo
    {
        public List<Cliente> clientes { get; set; }
        public List<Transportista> transportistas { get; set; }
        public AltaOrdenPreparacionModelo()
        {
            clientes = new List<Cliente>()
            {
                new Cliente
                {
                    CUIT = "20-11111111-5",
                    Nombre = "Juan Pérez",
                    ProductosAsociados = new List<Producto>()
                    {
                        new Producto
                        {
                            CodigoDeProducto = "0001",
                            Nombre = "Mochila",
                            //Peso = 2,
                            Cantidad = 10,
                            //Ubicacion = new Ubicacion { X = "pasillo 1", Y = "almacen 1", Z = "sector 1" }
                        },
                        new Producto
                        {
                            CodigoDeProducto = "0002",
                            Nombre = "Bolso",
                            //Peso = 4,
                            Cantidad = 5,
                            //Ubicacion = new Ubicacion { X = "pasillo 2", Y = "almacen 2", Z = "sector 2" }
                        },
                        new Producto
                        {
                            CodigoDeProducto = "0003",
                            Nombre = "Valija",
                            //Peso = 8,
                            Cantidad = 2,
                            //Ubicacion = new Ubicacion { X = "pasillo 3", Y = "almacen 3", Z = "sector 3" }
                        }
                    }
                },
                new Cliente
                {
                    CUIT = "20-22222222-5",
                    Nombre = "Mercado Libre LLC",
                    ProductosAsociados = new List<Producto>()
                    {
                        new Producto
                        {
                            CodigoDeProducto = "0004",
                            Nombre = "Computadora",
                            //Peso = 12,
                            Cantidad = 45,
                            //Ubicacion = new Ubicacion { X = "pasillo 1", Y = "almacen 1", Z = "sector 1" }
                        },
                        new Producto
                        {
                            CodigoDeProducto = "0005",
                            Nombre = "Silla",
                            //Peso = 12,
                            Cantidad = 60,
                            //Ubicacion = new Ubicacion { X = "pasillo 2", Y = "almacen 2", Z = "sector 2" }
                        }
                    }
                },
            };

            transportistas = new List<Transportista>()
            {
                new Transportista
                {
                    CUIT = "20-33333333-5",
                    Nombre = "Juan Carlos Gonzalez",
                },
                new Transportista
                {
                    CUIT = "20-44444444-5",
                    Nombre = "Fernando Justo",
                },
                new Transportista
                {
                    CUIT = "20-55555555-5",
                    Nombre = "Luis Fernandez",
                }
            };
        }

        public Cliente BuscarCliente(string cuit)
        {
            Cliente cliente = clientes.Find(id => id.CUIT == cuit);
            return cliente;
        }

        public Transportista BuscarTransportista(string cuit)
        {
            Transportista transportista = transportistas.Find(id => id.CUIT == cuit);
            return transportista;
        }
    }
}
