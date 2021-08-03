using System;
using System.Collections.Generic;
using System.Text;

namespace Inmobiliaria
{
  public  class Alquileres
    {
        public string direccion { get; set; }
        public string localidad { get; set; }
        public int codPostal { get; set; }
        public string provincia { get; set; }
        public decimal precio { get; set; }
        public decimal precio_metro { get; set; }
        public decimal valorTotal { get; set; }
        public decimal valorIRPF { get; set; }
       
    }
}
