using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_6
{
    class Program
    {
        public static int ValidarEntero(string cadena)
        {
            int retorno = 0;

            while (!(int.TryParse(cadena,out retorno)))
            {
                Console.WriteLine("\nERROR,..Reingrese un numero\n");
                cadena = Console.ReadLine();
            }

            return retorno;
        }
    }
}
