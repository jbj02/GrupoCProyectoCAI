using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoCProyectoCAI.Despachador.DespacharOrden
{
    internal class DespacharOrdenModelo
    {
        public List<OrdenPreparacion> OrdenesPreparadas { get; set; }

        // Creamos un constructor para cargarle datos y probar el prototipo de forma aislada
        public DespacharOrdenModelo()
        {
            OrdenesPreparadas = new List<OrdenPreparacion>()
            {
                new OrdenPreparacion
                {
                    NumOrden = 65839573,
                    Cliente = "Mercado Libre",
                    Transportista = "Andreani",
                    Estado = "Preparada",
                    FechaDespacho = new DateTime(2024,6,18)
                },
                new OrdenPreparacion
                {
                    NumOrden = 35673863,
                    Cliente = "Amazon",
                    Transportista = "CorreoArgentino",
                    Estado = "Preparada",
                    FechaDespacho = new DateTime(2024,6,20)
                },
                new OrdenPreparacion
                {
                    NumOrden = 257843,
                    Cliente = "Coto",
                    Transportista = "Andreani",
                    Estado = "Preparada",
                    FechaDespacho = new DateTime(2024,6,20)
                },
                new OrdenPreparacion
                {
                    NumOrden = 12345678,
                    Cliente = "Walmart",
                    Transportista = "OCA",
                    Estado = "Preparada",
                    FechaDespacho = new DateTime(2024, 6, 21)
                },
                new OrdenPreparacion
                {
                    NumOrden = 87654321,
                    Cliente = "Falabella",
                    Transportista = "CorreoArgentino",
                    Estado = "Preparada",
                    FechaDespacho = new DateTime(2024, 6, 22)
                },
                new OrdenPreparacion
                {
                    NumOrden = 23456789,
                    Cliente = "Garbarino",
                    Transportista = "Andreani",
                    Estado = "Preparada",
                    FechaDespacho = new DateTime(2024, 6, 23)
                },
                new OrdenPreparacion
                {
                    NumOrden = 98765432,
                    Cliente = "Frávega",
                    Transportista = "OCA",
                    Estado = "Preparada",
                    FechaDespacho = new DateTime(2024, 6, 24)
                },
                new OrdenPreparacion
                {
                    NumOrden = 34567890,
                    Cliente = "Musimundo",
                    Transportista = "CorreoArgentino",
                    Estado = "Preparada",
                    FechaDespacho = new DateTime(2024, 6, 25)
                },
                new OrdenPreparacion
                {
                    NumOrden = 98765431,
                    Cliente = "Ribeiro",
                    Transportista = "Andreani",
                    Estado = "Preparada",
                    FechaDespacho = new DateTime(2024, 6, 26)
                },
                new OrdenPreparacion
                {
                    NumOrden = 45678901,
                    Cliente = "Compumundo",
                    Transportista = "OCA",
                    Estado = "Preparada",
                    FechaDespacho = new DateTime(2024, 6, 27)
                }
            };
        }

        public bool ValidarRangoFecha(DateTime fecha)
        {
            if(fecha < DateTime.Now)
            {
                return false;
            }else
            {
                return true;
            }
        }
    }
}
