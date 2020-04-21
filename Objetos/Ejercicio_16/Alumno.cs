using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Objetos
{
    namespace Ejercicio_16
    {
        public class Alumno
        {
            private byte nota1;
            private byte nota2;
            private float notaFinal;
            public string apellido;
            public int legajo;
            public string nombre;

            public Alumno(string nombre, string apellido, int legajo)
            {
                this.nombre = nombre;
                this.apellido = apellido;
                this.legajo = legajo;

            }

            public void Estudiar(byte notaUno, byte notaDos)
            {
                this.nota1 = notaUno;
                this.nota2 = notaDos;
            }
            public void CalcularFinal()
            {
                Random num = new Random();
                if ((this.nota1 >= 4) && (this.nota2 >= 4))
                {
                    notaFinal = num.Next();//(nota1 + nota2) / 2;
                }
                else
                {
                    notaFinal = -1;
                }
            }
            public string Mostrar()
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine(this.nombre.ToString() + this.apellido.ToString() + this.legajo.ToString());
                if (notaFinal != -1)
                {
                    sb.Append(this.notaFinal.ToString());
                }
                else
                {
                    sb.Append("Alumno Desaprobado\n");
                }

                return sb.ToString();
            }
        }
    }
}