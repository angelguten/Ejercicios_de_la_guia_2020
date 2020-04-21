using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MetodosEstaticos
{ 
    namespace Ejercicio_13
    {
        public class Ejercicio_13
        {
            static void Main(string[] args)
            {
                double numero = 0;
                int opcion = 0;
                double acumuladorDouble = 0;
                string cadena = "";
                char continuar = 'S';

                do
                {
                    Console.Clear();

                    Console.WriteLine("\n\nCONVERSOR DE NUMEROS DE DIFERENTES BASES\n\n");
                    Console.WriteLine("\n 1_Convertir de DECIMAL A BINARIO\n");
                    Console.WriteLine("\n 2_Convertir de BINARIO A DECIMAL\n");

                    Console.WriteLine("\n\nSeleccionar una Opcion de Conversion\n\n");

                    cadena = Console.ReadLine();
                    while ((!(Ejercicio_11.Validacion.Validar(cadena)))||((cadena!="1")&&(cadena!="2")))
                    {
                        Console.Clear();
                        Console.WriteLine("\n\nCONVERSOR DE NUMEROS DE DIFERENTES BASES\n\n");
                        Console.WriteLine("\n 1_Convertir de DECIMAL A BINARIO\n");
                        Console.WriteLine("\n 2_Convertir de BINARIO A DECIMAL\n");

                        Console.WriteLine("\n\nERROR...Reingrese un numero de Opcion\n\n");
                        cadena = Console.ReadLine();
                    }

                    opcion = Convert.ToInt32(cadena);

                    switch(opcion)
                    {
                        case 1:
                            Console.Clear();
                            Console.WriteLine("\n 1_Convertir de DECIMAL A BINARIO\n");
                         
                                Console.WriteLine("\n\nIngrese el numero a convertir\n\n");
                                cadena = Console.ReadLine();

                                while (!(Ejercicio_11.Validacion.ValidarDouble(cadena)))
                                {
                                    Console.WriteLine("\n\nERROR...Reingrese un numero\n\n");
                                    cadena = Console.ReadLine();
                                }
                                numero = Convert.ToDouble(cadena);
                     
                                cadena = Conversor.DecimalBinario(numero);
                                Console.WriteLine("\n\nEl numero Binario es: {0} \n\n",cadena);
                       
                            break;
                        case 2:
                            Console.Clear();
                            Console.WriteLine("\n 2_Convertir de BINARIO A DECIMAL\n");

                            Console.WriteLine("\n\nIngrese el numero a convertir\n\n");
                            cadena = Console.ReadLine();
                            acumuladorDouble = Conversor.BinarioDecimal(cadena);

                            Console.WriteLine("\n\nEl numero Decimal es: {0} \n\n", acumuladorDouble);
                    
                            break;
                    }

                    Console.WriteLine("\n\n¿Continuar?\n\n");
                    cadena = Console.ReadLine();

                    //continuar = Convert.ToChar(cadena);
                    while (cadena=="")
                    {
                        Console.WriteLine("\n\nERROR...Ingrese S para continuar, o cualquier otra letra para salir...¿Desea Continuar?\n\n");
                        cadena = Console.ReadLine();
                    }
                    continuar = Ejercicio_12.ValidarRespuesta.CovertirStringAchar(cadena);


                } while (Ejercicio_12.ValidarRespuesta.ValidaS_N(continuar));

            }
        }
    }
}