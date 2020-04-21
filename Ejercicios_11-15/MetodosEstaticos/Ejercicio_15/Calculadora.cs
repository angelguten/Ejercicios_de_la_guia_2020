using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace MetodosEstaticos
{
    namespace Ejercicio_15
    {
        public class Calculadora
        {
            public static double Calcular(double numero_1, double numero_2, char operacion)
            {
                double resultado = 0;

                switch (operacion)
                {
                    case '+':
                        Console.Clear();
                        Console.WriteLine("\n (+)  SUMA\n");

                        resultado = numero_1 + numero_2;
                    
                        break;

                     case '-' :

                        Console.Clear();
                        Console.WriteLine("\n (-)  RESTA\n");
                        resultado = numero_1 - numero_2;
                        break;

                    case '*':

                        Console.Clear();
                        Console.WriteLine("\n (*)  MULTIPLICACION\n");
                        resultado = numero_1 * numero_2;
                        break;
                    case '/':

                        Console.Clear();
                        Console.WriteLine("\n (/)  DIVISION\n");
                        if (Validar(numero_2))
                        {
                            resultado = numero_1 / numero_2;
                        }
                        else
                        {
                            resultado = 0;
                        }
                        break;

                }


                return resultado;
            }
            private static bool Validar(double numero_2)
            {
                bool retorno = false;

                if (numero_2 !=0)
                {
                    retorno = true;
                }

                return retorno;
            }
        }
    }
}