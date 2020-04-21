using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objetos
{
    namespace Ejercicio_16
    {
        class Program
        {
            static void Main(string[] args)
            {
                Alumno primerAlumno = new Alumno("Angel", "Guten", 1107460);
                Alumno segundoAlumno = new Alumno("Ariel", "Meirell", 4450751);
                Alumno tercerAlumno = new Alumno("Lucas", "Hein", 1278235);

                primerAlumno.Mostrar();
                segundoAlumno.Mostrar();
                tercerAlumno.Mostrar();

                Console.ReadKey();
            }
        }
    }
}