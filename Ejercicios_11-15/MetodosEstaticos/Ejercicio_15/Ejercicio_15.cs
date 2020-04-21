using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace MetodosEstaticos
{
    namespace Ejercicio_15
    {
        public class Ejercicio_15
        {
            static void Main(string[] args)
            {

                char operacion = ' ';

                double numero_1 = 0;
                double numero_2 = 0;
                double Resultado = 0;
           
                string cadena = "";

                char continuar = 'S';

                do
                {
                    Console.Clear();
                    Console.WriteLine("\n\nCALCULADORA BASICA\n\n");
                    Console.WriteLine("\n (+)  SUMA\n");
                    Console.WriteLine("\n (-)  RESTA\n");
                    Console.WriteLine("\n (*)  MULTIPLICACION\n");
                    Console.WriteLine("\n (/)  DIVISION\n");
                    Console.WriteLine("\n--------------------------------------------------------------\n");
                    Console.WriteLine("\n\nIngrese EL PRIMER NUMERO\n\n");
                    cadena = Console.ReadLine();

                    while (!(Ejercicio_11.Validacion.Validar(cadena)))
                    {
                        Console.WriteLine("\n\nERROR...Reingrese EL PRIMER NUMERO\n\n");
                        cadena = Console.ReadLine();
                    }
                    numero_1 = Convert.ToDouble(cadena);


                    Console.WriteLine("\n\nIngrese EL SEGUNDO NUMERO\n\n");
                    cadena = Console.ReadLine();

                    while (!(Ejercicio_11.Validacion.Validar(cadena)))
                    {
                        Console.WriteLine("\n\nERROR...Reingrese EL SEGUNDO NUMERO\n\n");
                        cadena = Console.ReadLine();
                    }
                    numero_2 = Convert.ToDouble(cadena);

                    Console.WriteLine("\n\nPresione la tecla de la operacion que desea resolver\n\n");
                    cadena = Console.ReadLine();

                    while (((cadena != "+") && (cadena != "-") && (cadena != "/") && (cadena != "*")))
                    {
                        Console.Clear();
                        Console.WriteLine("\n\nCALCULADORA BASICA\n\n");
                        Console.WriteLine("\n (+)  SUMA\n");
                        Console.WriteLine("\n (-)  RESTA\n");
                        Console.WriteLine("\n (*)  MULTIPLICACION\n");
                        Console.WriteLine("\n (/)  DIVISION\n");

                        Console.WriteLine("\n\nERROR...Presione la tecla de la operacion que desea resolver\n\n");
                        cadena = Console.ReadLine();
                    }

                    operacion = Convert.ToChar(cadena);

                    Resultado = Calculadora.Calcular(numero_1,numero_2,operacion);
                    Console.WriteLine("\n\nEl resultado de {0} {1} {2} = {3}\n\n",numero_1,operacion,numero_2,Resultado);
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