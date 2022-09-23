using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condicao
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Condicional Simples
            //int valor = 15;

            //if (valor < 5)
            //{
            //    Console.WriteLine("Condição verdadeira");
            //}
            //else
            //{
            //    Console.WriteLine("Condição falsa");
            //}
            #endregion

            #region Condicional encadeadas
            //int valor = 15;

            //if (valor < 5)
            //{
            //    Console.WriteLine("Condição verdadeira");
            //}
            //else if (valor >= 5 && valor < 10)
            //{
            //    Console.WriteLine("Condição alternativa 1");
            //}
            //else if (valor >= 10 && valor < 20)
            //{
            //    Console.WriteLine("Condição alternativa 2");
            //}
            //else
            //{
            //    Console.WriteLine("Condição alternativa final");

            //}
            //Console.ReadKey();
            #endregion

            #region Condicionais aninhadas
            //int numero = 13;

            //if (numero > 5)
            //{
            //    Console.Write("O número é maior do que 5 ");
            //    if(numero % 2 == 0)
            //    {
            //        Console.WriteLine("e também é par.");
            //    }
            //    else
            //    {
            //        Console.WriteLine("e também é impar.");
            //    }
            //}
            //Console.ReadKey();
            #endregion

            int numero = 10;
            //string mensagem = numero > 5 ? "Maior que 5" : "Menor que 5";

            //mensagem = numero > 5 ? "Maior que 5" : "Menor que 5";

            //if (numero > 5)
            //{
            //    mensagem = "é maior que 5";
            //}
            //else
            //{
            //    mensagem = "é menor ou igual a 5";
            //}

            Console.WriteLine(numero > 5 ? "Maior que 5" : "Menor que 5");
            Console.ReadKey(true);

        }
    }
}
