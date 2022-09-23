using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ciclos
{
    class Program
    {
        static void Main(string[] args)
        {
            #region while
            //int valor = 0;

            //while(valor < 10)
            //{
            //    Console.WriteLine("O valor é: " + valor);
            //    valor++;
            //}
            //Console.ReadKey();
            #endregion

            #region do-while
            //int valor = 15;

            //do
            //{
            //    Console.WriteLine("O valor é: " + valor);
            //    valor++;
            //} while (valor < 10);
            //Console.ReadKey();
            #endregion

            #region for
            //for (int i = 0, j = 10; i < 10; i++, j--)
            //{
            //    Console.WriteLine("O valor é: " + i +" " + j);
            //}
            //Console.ReadKey(true);
            #endregion

            string[] nomes = { "Cris", "JU", "Tuca", "Enzo" };

            foreach (string nome in nomes)
            {
                Console.WriteLine("Nome: " + nome);
            }

            Console.ReadKey(true);
        }

    }
}
