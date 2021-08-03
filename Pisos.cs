using System;
using System.Collections.Generic;
using System.Text;

namespace Inmobiliaria
{
  public  class Pisos : Alquileres
    {
        public decimal habitacionesMetros { get; set; }
        public decimal banosMetros { get; set; }
        public decimal salaMetros { get; set; }
        public decimal cocinaMetros { get; set; }
        public decimal parkingMetros { get; set; }
        public decimal zonasMetros { get; set; }
        public decimal trasteroMetros { get; set; }
    }
}
