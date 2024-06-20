using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Text.Json;
using Newtonsoft.Json;
using GrupoCProyectoCAI.Archivos;
using System.Text.RegularExpressions;

namespace GrupoCProyectoCAI.Preparador.AltaOrdenPreparacion
{
    internal class AltaOrdenPreparacionModelo
    {
        public List<Cliente> clientes { get; set; }
        public List<Stock> stock { get; set; }
        public AltaOrdenPreparacionModelo()
        {
            clientes = new List<Cliente>();
            stock = new List<Stock>();
            CargarClientes();
            CargarProductos();
        }

        public void CargarClientes()
        {
            foreach (var c in ArchivoClientes.Clientes)
            {
               clientes.Add(c);
            }
        }

        public void CargarProductos()
        {
            foreach (var c in ArchivoStock.Stock)
            {
                Stock productoACargar = new Stock();
                productoACargar.Cantidad = c.Cantidad;
                productoACargar.ClienteCUIT = c.ClienteCUIT;
                productoACargar.Peso = c.Peso;
                productoACargar.TipoProducto = c.TipoProducto;
                productoACargar.Ubicacion = c.Ubicacion;
                productoACargar.Producto = c.Producto;

                stock.Add(productoACargar);
            }
        }

        public Cliente BuscarCliente(string cuit)
        {
            Cliente cliente = clientes.Find(id => id.CUIT == cuit);
            return cliente;
        }

        public List<Stock> BuscarProductosDelCliente(string cuit)
        {
            List<Stock> productosDelCliente = new List<Stock>();
            foreach (var p in ArchivoStock.Stock)
            {
                if (p.ClienteCUIT == cuit)
                {
                    productosDelCliente.Add(p);
                }
            }
            return productosDelCliente;
        }

        public bool ValidarCUIT(string cuit)
        {
            string pattern = @"^\d{2}-\d{8}-\d{1}$";
            Regex regex = new Regex(pattern);

            string pattern2 = @"^\d{2}-\d{8}-\d{2}$";
            Regex regex2 = new Regex(pattern);

            if (regex2.IsMatch(cuit) == true || regex.IsMatch(cuit) == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void ModificarStocks (List<Stock> productosAfectados)
        {
            ArchivoStockProvisorio.SumarStockProvisorio(productosAfectados);
            ArchivoStock.RestarStock(productosAfectados);
        }

        public void AgregarOrdenPreparacion (OrdenPreparacion orden)
        {
            ArchivoOrdenPreparacion.AgregarOrdenPreparacion(orden);
        }

        public int BuscarUltimaOrenPreparacion ()
        {
            if (ArchivoOrdenPreparacion.OrdenesPreparacion.Count != 0)
            {
                int ultimoNumero = ArchivoOrdenPreparacion.OrdenesPreparacion[ArchivoOrdenPreparacion.OrdenesPreparacion.Count - 1].NroOrden;
                return ultimoNumero;
            }
            else
            {
                return 0;
            }
        }
    }
}
