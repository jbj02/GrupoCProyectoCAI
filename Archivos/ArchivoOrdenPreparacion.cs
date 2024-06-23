using GrupoCProyectoCAI.Despachador;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoCProyectoCAI.Archivos
{
    public static class ArchivoOrdenPreparacion
    {
        // Expone el archivo con una lista de solo lectura
        public static ReadOnlyCollection<OrdenPreparacionEnt> OrdenesPreparacion => ordenesPreparacion.AsReadOnly();

        private static List<OrdenPreparacionEnt> ordenesPreparacion;

        static ArchivoOrdenPreparacion()
        {

            if (File.Exists(@"DatosPrueba\ordenPreparacionP.json"))
            {
                var contenido = File.ReadAllText(@"DatosPrueba\ordenPreparacionP.json");
                ordenesPreparacion = JsonConvert.DeserializeObject<List<OrdenPreparacionEnt>>(contenido);
            }
            else
            {
                ordenesPreparacion = new List<OrdenPreparacionEnt>();
            }
        }

        public static void AgregarOrdenPreparacion(OrdenPreparacionEnt orden)
        {
            ordenesPreparacion.Add(orden);
        }

        public static void GrabarDatos()
        {
            var contenido = JsonConvert.SerializeObject(ordenesPreparacion);
            File.WriteAllText(@"Data\ordenPreparacion.json", contenido);
        }

        public static void SeleccionarOrden(int numeroOrden, EstadosOrdenPreparacion estado)
        {
            foreach(var orden in ordenesPreparacion)
            {
                if(orden.NroOrden == numeroOrden)
                {
                    orden.Estado = estado;
                }
            }
        }

        public static OrdenPreparacionEnt ObtenerOrdenPreparacionPorNumero(int numOrdenP)
        {
            return ordenesPreparacion.FirstOrDefault(op => op.NroOrden == numOrdenP);
        }

        public static void ActualizarOrdenPreparacion(OrdenPreparacionEnt ordenActualizada)
        {
            var ordenExistente = ObtenerOrdenPreparacionPorNumero(ordenActualizada.NroOrden);
            if (ordenExistente != null)
            {
                ordenExistente.ClienteCUIT = ordenActualizada.ClienteCUIT;
                ordenExistente.TransportistaCUIT = ordenActualizada.TransportistaCUIT;
                ordenExistente.FechaDespacho = ordenActualizada.FechaDespacho;
                ordenExistente.FechaAlta = ordenActualizada.FechaAlta;
                ordenExistente.Estado = ordenActualizada.Estado;
            }
        }
    }

}
