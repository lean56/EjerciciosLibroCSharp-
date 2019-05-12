using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploLibro.Capitulo_2
{
    class Ejercicio5
    {
        static void Main(string[] args)
        {
          
            int n;
            double d, c, e;
            Console.Write("Valor del dolar en Euro: ");
            n =Convert.ToInt32(Console.ReadLine());
            d = Convert.ToInt32(n);
            Console.Write("Cuantos dolares desea cabiar: ");
            n = Convert.ToInt32(Console.ReadLine());
            c = Convert.ToInt32(n);
            e = d * c;
            Console.Write("{0} Dolares hacen un total de: {1} Euros", c, e);
            Console.ReadKey();
        }
    }
}
