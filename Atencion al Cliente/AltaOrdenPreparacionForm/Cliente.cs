namespace GrupoCProyectoCAI.Atencion_al_Cliente.AltaOrdenPreparacionForm
{
    public class Cliente
    {
        public string CUIT { get; set; }
        public string Nombre { get; set; }
        public List<Producto> ProductosAsociados { get; set; }

    }
}
