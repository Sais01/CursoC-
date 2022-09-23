using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colecao
{
    class Program
    {
        static void Main(string[] args)
        {
            #region vetores
            //int[] numeros = new int[5];
            //numeros[0] = 10;
            //numeros[1] = 20;
            //numeros[2] = 30;
            //numeros[3] = 40;
            //numeros[4] = 50;

            //numeros[2] = 55;

            //string[] nomes = { "Julia", "Cristofer", "Arthur"};
            //nomes[1] = "Vila Maria";

            //Console.WriteLine(numeros[2]);
            //Console.WriteLine(nomes[1]);
            //Console.ReadKey();
            #endregion

            #region Matrizes

            int[,] numeros = new int[2, 3];//linhas,colunas
            numeros[0, 0] = 10;
            numeros[0, 1] = 20;
            numeros[0, 2] = 30;

            numeros[1, 0] = 40;
            numeros[1, 1] = 50;
            numeros[1, 2] = 60;

            Console.Write("[" + numeros[0, 0] + "]");
            Console.Write("[" + numeros[0, 1] + "]");
            Console.WriteLine("[" + numeros[0, 2] + "]");

            Console.Write("[" + numeros[1, 0] + "]");
            Console.Write("[" + numeros[1, 1] + "]");
            Console.WriteLine("[" + numeros[1, 2] + "]");

            string[,] nomes =
            {
                {"Cristofer", "Julia", "Arthur" },
                {"Carla", "Enzo", "Denis" }

            };
            Console.WriteLine(nomes[0, 1]);

            Console.ReadKey();


            #endregion
        }
    }
}
