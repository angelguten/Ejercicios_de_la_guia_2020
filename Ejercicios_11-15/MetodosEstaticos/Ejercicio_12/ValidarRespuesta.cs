using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosEstaticos
{
    namespace Ejercicio_12
    {
        public class ValidarRespuesta
        {
            public static bool ValidaS_N(char continuar)
            {
                bool retorno = false;

                if ((continuar=='S') || (continuar=='s'))
                {
                    retorno = true;
                }
                return retorno;
            }

            public static char CovertirStringAchar(string cadena)
            {
                char retorno = ' ';
               
                retorno = cadena[0];
        
                return retorno;
            }
        }
    }
}

