using GrupoCProyectoCAI.Archivos;
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
            OrdenesPreparadas = new List<OrdenPreparacion>();
            // Cargar Lista
            CargarListaOrdenPreparadas();
        }

        public void CargarListaOrdenPreparadas()
        {            
            // Agregar código que solo cargue las que tiene el estado "Seleccionada"
            foreach (var ordenPreparacion in ArchivoOrdenPreparacion.OrdenesPreparacion)
            {
                // Agregarlas solamente si tiene el Estado "Preparada"
                if (ordenPreparacion.Estado == "Preparada")
                {
                    OrdenesPreparadas.Add(ordenPreparacion);
                }                
            }            
        }

        public void CambiarEstadoOrdenPreparacionYGenerarRemito(OrdenPreparacion ordenPreparada)
        {
            // Buscar la orden en la lista y actualizar su estado
            var ordenExistente = ArchivoOrdenPreparacion.OrdenesPreparacion.FirstOrDefault(o => o.NroOrden == ordenPreparada.NroOrden);

            // Cambiar el estado a "Despachada"
            ordenPreparada.Estado = "Despachada";

            // Crear un remito
            var remito = new Remito
            {
                NroRemito = BuscarUltimoRemito(),
                clienteCUIT = ordenPreparada.ClienteCUIT,
                transportistaCUIT = ordenPreparada.TransportistaCUIT,
                FechaDespacho = ordenPreparada.FechaDespacho,
                ProductosList = ordenExistente.ProductosList // Es Nulo CORREGIR    
            };
            ArchivoRemito.AgregarRemito(remito);
            
            if (ordenExistente != null)
            {
                ordenExistente.Estado = ordenPreparada.Estado;
                //ArchivoOrdenPreparacion.GrabarDatos(); // Guardar los cambios
            }
            else
            {
                MessageBox.Show($"La orden {ordenPreparada.NroOrden} no existe en la lista");
            }
        }

        public int BuscarUltimoRemito()
        {
            if (ArchivoRemito.Remitos.Count != 0)
            {
                int ultimoNumero = ArchivoRemito.Remitos[ArchivoRemito.Remitos.Count - 1].NroRemito;
                return (ultimoNumero + 1);
            }
            else
            {
                return 0;
            }
        }
    }
}
