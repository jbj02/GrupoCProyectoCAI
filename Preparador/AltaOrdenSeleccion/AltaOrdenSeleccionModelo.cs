using GrupoCProyectoCAI.Archivos;
using GrupoCProyectoCAI.Despachador;
using GrupoCProyectoCAI.Preparador.PrepararOrden;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoCProyectoCAI.Preparador.AltaOrdenSeleccion
{
    internal class AltaOrdenSeleccionModelo
    {
        public List<OrdenPreparacion> OrdenesPreparacion { get; set; }

        private List<OrdenSeleccion> ordenesSeleccion = new List<OrdenSeleccion>();

        // Lista para almacenar los Números De Orden de Seleccion generados previamente
        public static int UltimoNumeroOrdenSeleccion { get; private set; }

        // Creamos un constructor para cargarle datos
        public AltaOrdenSeleccionModelo()
        {
            OrdenesPreparacion = new List<OrdenPreparacion>();

            foreach (var ordenEntidad in ArchivoOrdenPreparacion.OrdenesPreparacion)
            {
                if (ordenEntidad.Estado == EstadosOrdenPreparacion.Pendiente)
                {
                    var ordenPreparacion = new OrdenPreparacion
                    {
                        NumOrdenP = ordenEntidad.NroOrden,
                        ClienteCUIT = ordenEntidad.ClienteCUIT,
                        FechaDespacho = ordenEntidad.FechaDespacho,
                    };             

                    OrdenesPreparacion.Add(ordenPreparacion);
                }
            }

            UltimoNumeroOrdenSeleccion = BuscarUltimaOrdenSeleccion();
        }

        public void AgregarOrdenesSeleccion(OrdenSeleccion orden)
        {
            // Crear un nuevo objeto OrdenSeleccionEnt y asignar los valores del objeto OrdenSeleccion
            var ordenSeleccionEnt = new OrdenSeleccionEnt
            {
                NroOrden = orden.NumOrden,
                Estado = EstadosOrdenSeleccion.Pendiente,
                OrdenPreparacionAsociadas = orden.OrdenesPreparacionAsociadas.Select(op => op.NumOrdenP).ToList()
            };

            foreach (var ordenP in orden.OrdenesPreparacionAsociadas)
            {
                var ordenPreparacionEnt = ArchivoOrdenPreparacion.ObtenerOrdenPreparacionPorNumero(ordenP.NumOrdenP);
                if (ordenPreparacionEnt != null)
                {
                    ordenPreparacionEnt.Estado = EstadosOrdenPreparacion.EnSeleccion;
                    //ArchivoOrdenPreparacion.ActualizarOrdenPreparacion(ordenPreparacionEnt);
                }
                else
                {
                    throw new Exception($"No se encontró la orden de preparación con el número {ordenP.NumOrdenP}.");
                }
            }

            // Agregar la ordenSeleccionEnt a la lista de órdenes de selección en el archivo
            ArchivoOrdenSeleccion.AgregarOrdenesSeleccion(ordenSeleccionEnt);
        }        

        public int BuscarUltimaOrdenSeleccion()
        {
            if (ArchivoOrdenSeleccion.OrdenSeleccions.Count != 0)
            {
                return ArchivoOrdenSeleccion.OrdenSeleccions.Max(o => o.NroOrden);
            }
            else
            {
                return 0;
            }
        }

        public void CrearOrdenSeleccion(List<OrdenPreparacion> ordenesSeleccionadas)
        {
            int nuevoNumeroOrden = ++UltimoNumeroOrdenSeleccion;
            var nuevaOrdenSeleccion = new OrdenSeleccion(nuevoNumeroOrden);
            nuevaOrdenSeleccion.OrdenesPreparacionAsociadas.AddRange(ordenesSeleccionadas);
            ordenesSeleccion.Add(nuevaOrdenSeleccion);
        }

        public void EliminarOrdenSeleccion(OrdenSeleccion orden)
        {
            orden.NumOrden = --UltimoNumeroOrdenSeleccion;
            ordenesSeleccion.Remove(orden);
        }

        public List<OrdenSeleccion> ObtenerOrdenesSeleccion()
        {
            return ordenesSeleccion;
        }
    }    
}

