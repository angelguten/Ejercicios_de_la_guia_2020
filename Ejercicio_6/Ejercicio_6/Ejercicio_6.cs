using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace EjerciciosGuia_2020
{
    namespace Ejercicio_6
    {
        class Program
        {
            static void Main(string[] args)
            {
                int inicio = 0;
                int final = 0;

                string cadena = " ";

                Console.WriteLine("\nAÑOS BISIESTOS\n\n");

                Console.WriteLine("\n\nIngrese el año de inicio\n");
                cadena = Console.ReadLine();
                inicio = ValidacionEntero.ValidarEntero(cadena);

                Console.WriteLine("\nIngrese el año de inicio\n");
                cadena = Console.ReadLine();
                final = ValidacionEntero.ValidarEntero(cadena);
                Console.WriteLine("\n\n----------------------------------\n\n");
                for (int i = inicio; i <= final; i++)
                {
                    if (((i % 4) == 0) || ((i % 100) == 0) && (i % 400) == 0)
                    {
                        Console.WriteLine("{0} es año bisiesto", i);
                    }

                }
                Console.ReadKey();
            }
        }
    }
}