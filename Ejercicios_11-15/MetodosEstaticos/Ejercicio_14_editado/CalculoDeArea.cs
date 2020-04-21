using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosEstaticos
{
    namespace Ejercicio_14
    {
        public class CalculoDeArea
        {
            public static double CalcularCuadrado(double lado)
            {
                double area = 0;
                area = lado * lado;
                return area;
            }
            public static double CalcularTriangulo(double b, double h)
            {
                double area = 0;
                area = (b * h) / 2;
                return area;
            }
            public static double CalcularCirculo(double radio)
            {
                double area = 0;
                area = Math.PI * (Math.Pow(radio, 2));
                return area;
            }
        }
    }
}