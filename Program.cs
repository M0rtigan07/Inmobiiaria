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

                Console.WriteLine("*******************************");
                Console.WriteLine("Seleccione tipo de alquiler : ");
                Console.WriteLine("Pulse 1 para Casas ");
                Console.WriteLine("Pulse 2 para Pisos");
                Console.WriteLine("Pulse 3 para Terrenos");
                  
                
                tipoAlquiler = Convert.ToInt32(Console.ReadLine());

                switch (tipoAlquiler)
                {
                    case 1:
                        Console.WriteLine("Seleccionado tipo Casa");
                        Casas unaCasa = new Casas();
                        Console.WriteLine("Ingrese los metros cuadrados de las habitaciones :");
                        unaCasa.habitacionesMetros = Convert.ToDecimal(Console.ReadLine());
                        Console.WriteLine("Ingrese los metros cuadrados de los baños :");
                        unaCasa.banosMetros = Convert.ToDecimal(Console.ReadLine());
                        Console.WriteLine("Ingrese los metros cuadrados de la sala de estar :");
                        unaCasa.salaMetros = Convert.ToDecimal(Console.ReadLine());
                        Console.WriteLine("Ingrese los metros cuadrados de la cocina :");
                        unaCasa.cocinaMetros = Convert.ToDecimal(Console.ReadLine());
                        Console.WriteLine("Ingrese los metros cuadrados del parking :");
                        unaCasa.parkingMetros = Convert.ToDecimal(Console.ReadLine());
                        Console.WriteLine("Ingrese los metros cuadrados de otras zonas :");
                        unaCasa.zonasMetros = Convert.ToDecimal(Console.ReadLine());
                        Console.WriteLine("Ingrese los metros cuadrados del jardin :");
                        unaCasa.jardinMetros = Convert.ToDecimal(Console.ReadLine());

                       
                       
                        unAlquiler.precio_metro = unaCasa.habitacionesMetros + unaCasa.banosMetros + unaCasa.salaMetros + unaCasa.cocinaMetros + unaCasa.parkingMetros + unaCasa.zonasMetros + unaCasa.jardinMetros;
                        unAlquiler.precio_metro = unAlquiler.precio_metro * unAlquiler.precio;

                        Console.WriteLine(" Calculado precio X metros : {0}", unAlquiler.precio_metro);

                        unaListaAlquiles.Add(unAlquiler);
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

                    Console.WriteLine("  Introduce el valor de las comisiones :  ");
                    comision = Convert.ToInt32(Console.ReadLine());
                    decimal valorComision;

                   // List <Alquileres>  listaValor = (from x  in unaListaAlquiles select x  ).ToList();
                    
                    valorTotal = unaListaAlquiles.Sum(x => x.precio_metro )  ;
                    Console.WriteLine("Calculado  valor Total de Alquileres : {0}", valorTotal);

                    valorComision = valorTotal + comision / 100;

                    
                    decimal irpf = valorTotal + 15 / 100;
                    decimal todo = valorTotal + valorComision;
                    

                    if( valorComision > irpf )
                    {
                        Console.WriteLine("Debe pagar {0}  de IVA", irpf);
                    
                        

                    }
                    else
                    {
                        Console.WriteLine("Valor Total + Comisiones : {0}",todo );
                        unaListaAlquiles.Add(unAlquiler);
                    }

                }



            }
           
            Console.WriteLine("***********************************");
            Console.WriteLine("    FIN DE PROGRAMA   ");
        }
    }

}
    

