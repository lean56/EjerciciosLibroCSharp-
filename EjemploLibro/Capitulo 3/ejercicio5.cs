using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploLibro.Capitulo_3
{
    class ejercicio5
    {
        static void Main(string[] args)
        {
            string lector = "";
            int opc=0;
            Console.WriteLine("Que decea calcular: ");
            Console.WriteLine("1 - El perimetro");
            Console.WriteLine("2 - El area");
            Console.Write("Seleccione una opcion: ");
            lector = Console.ReadLine();
            opc = Convert.ToInt32(lector);
            switch (opc)
            {
                case 1:
                    {
                        float lado, t, p;
                        Console.Write("Cuantos lados tiene el poligono: ");
                        lector = Console.ReadLine();
                        lado = Convert.ToSingle(lector);
                        Console.Write("Cual es el tamaño de estos: ");
                        lector = Console.ReadLine();
                        t = Convert.ToSingle(lector);
                        p = lado * t;
                        Console.WriteLine("El perimetro del poligono es: {0}", p);
                    };
                    break;
                case 2:
                    {
                        float b, a, ar;
                        Console.Write("tamano de la base: ");
                        lector = Console.ReadLine();
                        b = Convert.ToSingle(lector);
                        Console.Write("tamano de la altura: ");
                        lector = Console.ReadLine();
                        a = Convert.ToSingle(lector);
                        ar = (b * a) / 2;
                        Console.WriteLine("El area del poligono es: {0}", ar);
                    };
                    break;
            }
            Console.ReadKey();
        }
    }
}
