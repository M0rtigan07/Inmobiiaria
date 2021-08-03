using System;
using System.Collections.Generic;
using System.Linq;

namespace Inmobiliaria
{
    class Program
    {
        static void Main(string[] args)
        {
            Alquileres unAlquiler = new Alquileres();

            List<Alquileres> unaListaAlquiles = new List<Alquileres>();
            List<Casas> unaListaCasas = new List<Casas>();
            List<Pisos> unaListaPisos = new List<Pisos>();
            List<Terrenos> unaListaTerrenos = new List<Terrenos>();


            int continuar = 1;
            int tipoAlquiler;
            int comision;
            decimal valorTotal;
            int IRPF = 15;
            int IVA = 10;


            while (continuar == 1)
            {
                Console.Clear();
                Console.WriteLine("*******************************");
                Console.WriteLine("**** *******  ALQUILERES ***************************");
                Console.WriteLine("*******************************");

                Console.WriteLine("Ingrese la dirección");
                unAlquiler.direccion = Console.ReadLine();
                Console.WriteLine("Ingrese su localidad");
                unAlquiler.localidad = Console.ReadLine();
                Console.WriteLine("Ingrese su codigo postal");
                unAlquiler.codPostal = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ingrese su  provincia");
                unAlquiler.provincia = Console.ReadLine();
                Console.WriteLine("Ingrese su  precio");
                unAlquiler.precio = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine("Ingrese su  precio por metro cuadrado");
                unAlquiler.precio_metro = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine("*******************************");
                Console.WriteLine("Seleccione tipo de alquiler : ");
                Console.WriteLine("Pulse 1 para Casas ");
                Console.WriteLine("Pulse 2 para Pisos");
                Console.WriteLine("Pulse 3 para Terrenos");
                unaListaAlquiles.Add(unAlquiler);

                tipoAlquiler = Convert.ToInt32(Console.ReadLine());

                switch (tipoAlquiler)
                {
                    case 1:
                        Console.WriteLine("Seleccionado tipo Casa");
                        Casas unaCasa = new Casas();
                        Console.WriteLine("Ingrese los metros cuadrados de las habitaciones");
                        unaCasa.habitacionesMetros = Convert.ToDecimal(Console.ReadLine());

                        unaListaCasas.Add(unaCasa);
                        break;
                    case 2:
                        Pisos unPiso = new Pisos();

                        unaListaPisos.Add(unPiso);
                        break;
                    case 3:
                        Console.WriteLine("Seleccionado tipo Terreno");
                        Terrenos unTerreno = new Terrenos();

                        unaListaTerrenos.Add(unTerreno);
                        break;
                }




                Console.WriteLine("Para continuar ingresando datos , pulse 1 ,  para  salir y calcular el  valor total de sus alquileres ,  pulse 0");
                continuar = Convert.ToInt32(Console.ReadLine());

                if (continuar == 0)
                {
                    Console.Clear();
                    Console.WriteLine("***********************************");
                    Console.WriteLine("******  CALCULAR EL VALOR TOTAL DE  SUS  ALQUILERES  *****************************");
                    Console.WriteLine("  Introduce el valor de las comisiones    ");
                    comision = Convert.ToInt32(Console.ReadLine());
                }



            }
            Console.Clear();
            Console.WriteLine("***********************************");
            Console.WriteLine("    FIN DE PROGRAMA   ");
        }
    }

}
    

