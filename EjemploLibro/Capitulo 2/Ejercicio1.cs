using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploLibro.Capitulo_2
{
    class Ejercicio1
    {
        static void Main(string[] args)
        {
            int lado;
            float t, p;
            Console.Write("Cuantos lados tiene el poligono: ");
            lado = Convert.ToInt32(Console.ReadLine());
            Console.Write("Cual es el tamaño de estos: ");
            t = Convert.ToInt32(Console.ReadLine());
            p = lado * t;
            Console.WriteLine("El perimetro de este poligono es: {0}", p);
        }
    }
}
