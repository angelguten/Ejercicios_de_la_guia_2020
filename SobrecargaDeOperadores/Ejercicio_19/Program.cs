using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_19
{
    class Program
    {
        static void Main(string[] args)
        {
            Sumador miSumador = new Sumador();
            Console.WriteLine("\n La suma es\n"+miSumador.Sumar(2, 3));
            Console.WriteLine("\nLa concatenacion es\n"+miSumador.Sumar("Angel","Ariel"));
            Console.ReadKey();
            Console.WriteLine("\nLa cantidad de Sumas es:\n"+(int)miSumador);
            Console.ReadKey();

            Sumador otroSumador = new Sumador();
            Console.WriteLine("\n La suma es\n" + otroSumador.Sumar(2, 3));
            //Console.WriteLine("\nLa concatenacion es\n"+otroSumador.Sumar("Juliane", "Meirelles"));
            Console.ReadKey();
            Console.WriteLine("\nLa cantidad de Sumas es:\n" + (int)otroSumador);
            Console.ReadKey();

            Console.WriteLine("\n La suma de los Sumadores es:\n" + (miSumador + otroSumador));
            Console.WriteLine("\n La suma de los Sumadores es Identica:\n" + (miSumador | otroSumador));
            Console.ReadKey();
             
        }
    }
}
