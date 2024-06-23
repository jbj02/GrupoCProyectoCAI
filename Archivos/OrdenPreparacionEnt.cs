using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoCProyectoCAI.Archivos
{
    public class OrdenPreparacionEnt
    {
        public int NroOrden { get; set; }
        public string ClienteCUIT { get; set; }
        public EstadosOrdenPreparacion Estado { get; set; }        
        public string TransportistaCUIT { get; set; }
        public DateTime FechaDespacho { get; set; }
        public DateTime FechaAlta { get; set; }
    }
}


// { NroOrden:1, ClienteCuit:20-33123123-8, Estado="Pendiente", .... FechaAlta=2024-06-23 }
// { NroOrden:2, ClienteCuit:30-33123123-8, Estado="Pendiente", .... FechaAlta=2024-06-23 }