using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploLibro.Capitulo_3
{
    class Ejercicio4
    {
        static void Main(string[] args)
        {
            string lector = "";
            int n;
            Console.Write("Digite un numero del 1 al 7: ");
            lector = Console.ReadLine();
            n = Convert.ToInt32(lector);
            switch (n)
            {
                case 1:
                    Console.Write(" Domingo");
                    break;
                case 2:
                    Console.Write("Lunes");
                    break;
                case 3:
                    Console.Write("Marte");
                    break;
                case 4:
                    Console.Write("Miercole");
                    break;
                case 5:
                    Console.Write(" Jueve");
                    break;
                case 6:
                    Console.Write(" Vierne");
                    break;
                case 7:
                    Console.Write(" Sabado");
                    break;
                default: break;
            }
            Console.ReadKey();
        }
    }
}
