using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosEstaticos
{
    namespace Ejercicio_12
    {
        

        public class Ejercicio_12
        {
            static void Main(string[] args)
            {
                int numero1 = 0;
                int numero2 = 0;
                int suma = 0;
                char continuar = 'S';

                int numero = 0;
                string cadena = "";

                do
                {

                    Console.WriteLine("\n\nIngrese un numero\n\n");
                    cadena = Console.ReadLine();

                    while (!(Ejercicio_11.Validacion.Validar(cadena)))
                    {
                        Console.WriteLine("\n\nERROR...Reingrese un numero\n\n");
                        cadena = Console.ReadLine();
                    }

                    numero1 = Convert.ToInt32(cadena);

                    Console.WriteLine("\n\nIngrese un numero\n\n");
                    cadena = Console.ReadLine();

                    while (!(Ejercicio_11.Validacion.Validar(cadena)))
                    {
                        Console.WriteLine("\n\nERROR...Reingrese un numero\n\n");
                        cadena = Console.ReadLine();
                    }

                    numero2 = Convert.ToInt32(cadena);

                    suma = numero1 + numero2;
                    
                    Console.WriteLine("\n\nLa suma de {0} + {1} =  {2}\n\n",numero1,numero2,suma);
                    Console.WriteLine("\n\n¿Continuar?\n\n");
                    cadena = Console.ReadLine();

                    //continuar = Convert.ToChar(cadena);
                    continuar = ValidarRespuesta.CovertirStringAchar(cadena);
                } while (ValidarRespuesta.ValidaS_N(continuar));
            }
        }

    }
    
}
