using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random dado = new Random();
            int aleatorio1 = dado.Next(1, 7);
            Random dado2 = new Random();
            int aleatorio2 = dado.Next(11, 21);
            Console.WriteLine("El numero del 1º dado es {0}", aleatorio1);
            Console.WriteLine("El numero del 2º dado es {0}", aleatorio2);
            Console.ReadKey();
        }
    }
}
