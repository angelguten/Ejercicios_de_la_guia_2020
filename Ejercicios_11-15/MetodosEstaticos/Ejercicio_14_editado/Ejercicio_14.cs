using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosEstaticos
{
    namespace Ejercicio_14
    {
        public class Ejercicio_14
        {
            static void Main(string[] args)
            {
               
                int opcion = 0;
               
                double lado = 0;
                double b = 0;
                double h = 0;
                double radio = 0;

                double area = 0;

                string cadena = "";

                char continuar = 'S';

                do
                {
                    Console.Clear();

                    Console.WriteLine("\n\nCALCULO DE AREAS DE FIGURAS GEOMETRICAS\n\n");
                    Console.WriteLine("\n 1_Calculo de Area CUADRADO\n");
                    Console.WriteLine("\n 2_Calculo de Area TRIANGULO\n");
                    Console.WriteLine("\n 3_Calculo de Area CIRCULO\n");

                    Console.WriteLine("\n\nSeleccionar una Opcion de Conversion\n\n");

                    cadena = Console.ReadLine();
                    while ((!(MetodosEstaticos.Ejercicio_11.Validacion.Validar(cadena))) || ((cadena != "1") && (cadena != "2")&&(cadena!="3")))
                    {
                        Console.Clear();
                        Console.WriteLine("\n\nCALCULO DE AREAS DE FIGURAS GEOMETRICAS\n\n");
                        Console.WriteLine("\n 1_Calculo de Area CUADRADO\n");
                        Console.WriteLine("\n 2_Calculo de Area TRIANGULO\n");
                        Console.WriteLine("\n 3_Calculo de Area CIRCULO\n");
            
                        Console.WriteLine("\n\nERROR...Reingrese un numero de Opcion\n\n");
                        cadena = Console.ReadLine();
                    }

                    opcion = Convert.ToInt32(cadena);

                    switch (opcion)
                    {
                        case 1:
                            Console.Clear();
                            Console.WriteLine("\n1_Calculo de Area CUADRADO\n");

                            Console.WriteLine("\n\nIngrese LADO\n\n");
                            cadena = Console.ReadLine();

                            while (!(Ejercicio_11.Validacion.Validar(cadena)))
                            {
                                Console.WriteLine("\n\nERROR...Reingrese un numero\n\n");
                                cadena = Console.ReadLine();
                            }

                            lado = Convert.ToDouble(cadena);

                            area = CalculoDeArea.CalcularCuadrado(lado);
                           

                            Console.WriteLine("\n\nEl Area del CUADRADO es: {0} \n\n",area);
                          
                            break;
                        case 2:
                            Console.Clear();
                            Console.WriteLine("\n 2_Calculo de Area TRIANGULO\n\n");

                            Console.WriteLine("\n\nIngrese la BASE\n\n");
                            cadena = Console.ReadLine();

                            while (!(Ejercicio_11.Validacion.Validar(cadena)))
                            {
                                Console.WriteLine("\n\nERROR...Reingrese la BASE\n\n");
                                cadena = Console.ReadLine();
                            }

                            b = Convert.ToDouble(cadena);

                            Console.WriteLine("\n\nIngrese la ALTURA\n\n");
                            cadena = Console.ReadLine();

                            while (!(Ejercicio_11.Validacion.Validar(cadena)))
                            {
                                Console.WriteLine("\n\nERROR...Reingrese la ALTURA\n\n");
                                cadena = Console.ReadLine();
                            }

                            h = Convert.ToDouble(cadena);

                            area = CalculoDeArea.CalcularTriangulo(b,h);


                            Console.WriteLine("\n\nEl Area del TRIANGULO es: {0} \n\n", area);
                            break;

                        case 3:
                            Console.Clear();
                            Console.WriteLine("\n1_Calculo de Area CIRCULO\n");

                            Console.WriteLine("\n\nIngrese el RADIO\n\n");
                            cadena = Console.ReadLine();

                            while (!(Ejercicio_11.Validacion.Validar(cadena)))
                            {
                                Console.WriteLine("\n\nERROR...Reingrese el RADIO\n\n");
                                cadena = Console.ReadLine();
                            }

                            radio = Convert.ToDouble(cadena);

                            area = CalculoDeArea.CalcularCirculo(radio);


                            Console.WriteLine("\n\nEl Area del CIRCULO es: {0} \n\n", area);

                            break;

                    }

                    Console.WriteLine("\n\n¿Continuar?\n\n");
                    cadena = Console.ReadLine();

                    //continuar = Convert.ToChar(cadena);
                    while (cadena == "")
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
        