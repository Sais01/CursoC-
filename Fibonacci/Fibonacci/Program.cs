using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            //Cada número é a soma dos seus dois antecessores: 0, 1, 1, 2, 3, 5, 8

            int a = 0, b = 1, c = 0;

            int valores = int.Parse(Console.ReadLine());
            Console.Write("Quantos valores: ");

            Console.WriteLine("Sequência de Fibonacci com " + valores + " valores");

            for (int i = 0; i < valores; i++)
            {
                if (i < valores - 1)
                {
                    Console.Write(a + ", ");
                }
                else
                {
                    Console.Write(a);
                }
                c = a + b;
                a = b;
                b = c;
            }
            Console.ReadKey(true);
        }
    }
}
