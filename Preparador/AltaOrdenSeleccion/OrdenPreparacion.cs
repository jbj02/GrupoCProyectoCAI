﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoCProyectoCAI.Preparador.AltaOrdenSeleccion
{
    public class OrdenPreparacion
    {
        public int NumOrdenP {  get; set; }
        public string ClienteP { get; set; }
        public DateTime FechaDespacho { get; set; }
        public string PrioridadP { get; set; }
    }
}