using GrupoCProyectoCAI.Almacenaje.SelecciondeProductos;
using GrupoCProyectoCAI.Archivos;
using GrupoCProyectoCAI.Preparador.AltaOrdenSeleccion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace GrupoCProyectoCAI.Almacenaje.SelecciondeProductos
{
    internal class SeleccionProductosModelo
    {

        public List<OrdenSeleccion> ordenSeleccion { get; set; }
        public List<int> numeroOrden { get; set; }
        public SeleccionProductosModelo()
        {

            ordenSeleccion = new List<OrdenSeleccion> ();
            CargarOrden();

        }
        public void CargarOrden()
        {
            foreach (var orden in ArchivoOrdenSeleccion.OrdenSeleccions)
            {
                ordenSeleccion.Add(orden);
            }
        }
        public OrdenSeleccion Buscar(int orden)
        {
            //int numero = Convert.ToInt32(orden);
            OrdenSeleccion ord = ordenSeleccion.Find(o => o.NroOrden == orden);
            return ord;
        }
        public void CambiarEstadoOrdenEstado(OrdenSeleccion orden)
        {
            // Buscar la orden en la lista y actualizar su estado
            var ordenExistente = ArchivoOrdenSeleccion.OrdenSeleccions.FirstOrDefault(o => o.NroOrden == orden.NroOrden);
            if (ordenExistente != null)
            {
                ordenExistente.Estado = orden.Estado;
                //ArchivoOrdenPreparacion.GrabarDatos(); // Guardar los cambios
                
            }
            else
            {
                MessageBox.Show($"La orden {orden.NroOrden} no existe en la lista");
            }
        }

    }
}
