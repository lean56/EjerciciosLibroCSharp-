using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploLibro.Capitulo_2
{
    class ejercicio3
    {
        static void Main(string[] args)
        {
            string lector = "";
            double grado, radiane;
            Console.Write("Digite la cantidad de grado convertir a radianes: ");
            lector = Console.ReadLine();
            grado = Convert.ToInt32(lector);
            radiane= grado * (3.1416 / 180);
            Console.WriteLine("{0} grados es igual a {1} radianes", grado, radiane);
            Console.ReadLine();
        }
    }
}
