﻿namespace GrupoCProyectoCAI.Atencion_al_Cliente.AltaOrdenPreparacionForm
{
    public class Ubicacion
    {
        public string X { get; set; }
        public string Y { get; set; }
        public string Z { get; set; }
        public string Ubi()
        {
            return $" {X};{Y};{Z}";
        }
    }
}
