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
