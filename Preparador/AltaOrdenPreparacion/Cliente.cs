namespace GrupoCProyectoCAI.Preparador.AltaOrdenPreparacion
{
    public class Cliente
    {
        public string CUIT { get; set; }
        public string Nombre { get; set; }
        public List<Producto> ProductosAsociados { get; set; }

    }
}
