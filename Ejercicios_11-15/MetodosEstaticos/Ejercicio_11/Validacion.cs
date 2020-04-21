using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MetodosEstaticos
{
    namespace Ejercicio_11
    {
        public class Validacion
        {
            public static bool Validar(int valor, int min, int max)
            {
                bool retorno = true;

                if ((valor < min) || (valor > max))
                {
                    retorno = false;
                }
                return retorno;
            }

            public static bool Validar(string Cadena)
            {
                int numero = 0;
                return (int.TryParse(Cadena, out numero));
            }

            public static bool ValidarDouble(string Cadena)
            {
                double numero = 0;
                return (double.TryParse(Cadena, out numero));
            }

            public static int ValidarEntero(string cadena)
            {
                int numero = 0;
           
                while((int.TryParse(cadena, out numero)))
                {
                    Console.WriteLine("ERROR...Reingrese un numero");
                    cadena = Console.ReadLine();
                }
                Convert.ToInt32(cadena);
                return numero;
            }   
        }
    }
}

