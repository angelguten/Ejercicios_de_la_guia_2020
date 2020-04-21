using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosEstaticos
{
    namespace Ejercicio_11
    {
        public class Ejercicio_11
        {
            static void Main(string[] args)
            {
                int minimo = 0;
                int maximo = 0;

                int acumulador = 0;
                float promedio = 0;

                int numero = 0;
                string cadena = "";

                for (int i=0;i<10;i++)
                {
                    int flag = 0;
                    
                    do
                    {
                        Console.Clear();
                        if (flag == 0)
                        {
                            Console.WriteLine("Ingrese un numero");
                            cadena = Console.ReadLine();
                        }
                        else
                        {
                            Console.WriteLine("ERROR...Reingrese un numero MAYOR A -100 y MENOR A 100");
                            cadena = Console.ReadLine();
                        }

                        flag++;

                        while (!(int.TryParse(cadena, out numero)))
                        {
                            Console.WriteLine("ERROR...Reingrese un numero");
                            cadena = Console.ReadLine();
                        }
                        
                    } while (!(Validacion.Validar(numero, -100, 100)));

                    acumulador = acumulador + numero;
                    if (i == 0)
                    {
                        minimo = numero;
                        maximo = numero;

                    }
                    else if (numero < minimo)
                        {
                            minimo = numero;
                        }
                        if (numero > maximo)
                        {
                            maximo = numero;
                        }
                }

                Console.Clear();

                promedio = acumulador / 10;

                Console.WriteLine("\n\n El MINIMO es {0} \n\n",minimo);
                Console.WriteLine("\n\n El MAXIMO es {0} \n\n", maximo);
                Console.WriteLine("\n\n El PROMEDIO es {0} \n\n", promedio);

                Console.ReadKey();
            }
        }
    }


}

