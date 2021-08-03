using System;
using System.Collections.Generic;
using System.Text;

namespace Inmobiliaria
{
  public  class Casas : Alquileres
    {
        public decimal habitacionesMetros { get; set; }
        public decimal banosMetros { get; set; }
        public decimal salaMetros { get; set; }
        public decimal cocinaMetros { get; set; }
        public decimal parkingMetros { get; set; }
        public decimal zonasMetros { get; set; }
        public decimal jardinMetros { get; set; }
        public decimal totalMetrosCasa { get; set; }
    }
}
