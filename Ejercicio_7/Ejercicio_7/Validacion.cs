using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_7
{
   
    public class Validacion
    {
        public static int ValidarEntero(string cadena)
        {
            int retorno = 0;

            while (!(int.TryParse(cadena, out retorno)))
            {
                Console.WriteLine("\nERROR,..Reingrese un numero\n");
                cadena = Console.ReadLine();
            }

            return retorno;
        }

        public static bool AnioBisiesto(int anio)
        {
            bool retorno = false;

           
            if (((anio % 4) == 0) || ((anio % 100) == 0) && (anio % 400) == 0)
            {
                retorno=true;
            }

            return retorno;
        }

    }
    
}
