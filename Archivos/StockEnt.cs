using GrupoCProyectoCAI.Preparador.AltaOrdenPreparacion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoCProyectoCAI.Archivos
{
    public class StockEnt
    {       
        public string CodigoProducto { get; set; }
        public string ClienteCUIT { get; set; }
        public string Ubicacion { get; set; }
        public int Cantidad { get; set; }

        public string ProductoCliente
        {
            get
            {
                return $"{CodigoProducto}{ClienteCUIT}";
            }
        }
    }
}
