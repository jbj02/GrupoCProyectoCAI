using GrupoCProyectoCAI.Preparador.AltaOrdenPreparacion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoCProyectoCAI.Archivos
{
    public class StockProvisorioEnt
    {
        public int NroOrden { get; set; }
        public string CodigoProducto { get; set; }
        public int Cantidad { get; set; }
        public string Ubicacion { get; set; }
    }
}


//{ NroOrden:1, CodigoProducto: "REME-RAS", Cantidad:3, Ubicacion: "UBI01" }
//{ NroOrden:1, CodigoProducto: "REME-RAS", Cantidad:2, Ubicacion: "UBI02" }
//{ NroOrden:1, CodigoProducto: "TER-MO", Cantidad:4, Ubicacion: "UBI03" }
//{ NroOrden:1, CodigoProducto: "TER-MO", Cantidad:6, Ubicacion: "UBI10" }
//{ NroOrden:2, CodigoProducto: "DEST", Cantidad:1, Ubicacion: "UBI04" }