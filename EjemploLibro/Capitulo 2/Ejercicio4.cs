using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploLibro.Capitulo_2
{
    class Ejercicio4
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingresa Grados Centigrados");

            double c = Convert.ToDouble(Console.ReadLine());

            double f = (c * 9 / 5) + (32);

            Console.WriteLine(c + "ºC equivale a " + f + "ºF");

            Console.ReadLine();

        }
    }
}
