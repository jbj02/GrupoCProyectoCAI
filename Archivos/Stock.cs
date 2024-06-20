using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoCProyectoCAI.Archivos
{
    public class Stock
    {
        public string ProductoCliente
        {
            get
            {
                return $"{Producto}{ClienteCUIT}";
            }
        }
        public string Producto { get; set; }
        public string ClienteCUIT { get; set; }
        public int Cantidad { get; set; }
        public string Ubicacion { get; set; }
        public double Peso { get; set; }
        public string TipoProducto { get; set; }
    }
}
