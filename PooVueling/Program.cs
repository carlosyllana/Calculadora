using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PooVueling
{
    class Program
    {


        static void Main(string[] args)
        {
        string[] acciones = { "1.Suma", "2.Rest", "3.Multiplicacion", "4.Division", "5.Division"};
            ICalculadora iCalculadora = new Calculadora();
            
            int opc = 0;
            while (opc <5)
            {
                Console.WriteLine("////////MENU////////");
                for( int i =0; i< acciones.Length; i++)
                {
                    Console.WriteLine(acciones[i].ToString());

                }
                Console.WriteLine("--------------------");
                Console.WriteLine("Escoge opcion:");
                 opc = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Introduce el primer entero");

                int num1 = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Introduce el segundo entero");
                int num2 = Int32.Parse(Console.ReadLine());
      
                switch (opc)
                 {
                     case 1:
                        Console.WriteLine("Ha escogido la opcion " + acciones[opc - 1].ToString() + ". El resultado es = " + iCalculadora.Suma(num1, num2).ToString());
                         break;
                     case 2:
                        Console.WriteLine("Ha escogido la opcion " + acciones[opc - 1].ToString() + ". El resultado es = " + iCalculadora.Resta(num1, num2).ToString());
                        break;
                    case 3:
                        Console.WriteLine("Ha escogido la opcion " + acciones[opc - 1].ToString() + ". El resultado es = " + iCalculadora.Multiplicacion(num1, num2).ToString());
                        break;
                    case 4:
                        Console.WriteLine("Ha escogido la opcion " + acciones[opc - 1].ToString() + ". El resultado es = " + iCalculadora.Division(num1, num2).ToString());
                        break;
                    case 5:
                        Console.WriteLine("Adios");
                        break;

                }

            }

        }
    }
}
