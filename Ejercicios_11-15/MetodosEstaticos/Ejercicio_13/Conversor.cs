using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace MetodosEstaticos
{
    namespace Ejercicio_13
    {
        public class Conversor
        {
            public static string DecimalBinario(double numero)//convierte numero Entero a Binario
            {
                string binario = "";
                
                int resto = 0;
                double  cociente = 0;

                do
                {
                    cociente = (int)numero / 2;//baseDelSistema;
                    resto = (int)numero % 2;//baseDelSistema;
                    numero = cociente;

                    binario = resto.ToString() + binario;
                } while (cociente != 0);


                return binario;
            }
            public static double BinarioDecimal(string binario)//convierte numero Binario a Entero
            {
                double acumuladorNumeroDecimal = 0;

                int n = 0;
                //char bit = ' ';
                string bitCadena = "";
                double digito = 0;
                n = binario.Length - 1;

                for (int i = 0; i <= n; i++)
                {
                    //bit = cadena[i];
                    //digito =Convert.ToDouble(cadena[i])

                    bitCadena = binario[i].ToString();
                    digito = Convert.ToDouble(bitCadena);
                    

                    acumuladorNumeroDecimal = acumuladorNumeroDecimal + digito * (System.Math.Pow(2, (n - i)));
                }
                return acumuladorNumeroDecimal;
            }
        }
    }
}