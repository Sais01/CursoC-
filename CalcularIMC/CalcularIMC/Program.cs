using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcularIMC
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite seu peso em kg: ");
            double peso = double.Parse(Console.ReadLine());

            Console.Write("Digite sua altura em metros: ");
            double altura = double.Parse(Console.ReadLine());

            //Calcular IMC
            double imc = peso / Math.Pow(altura,2);

            //Respostas
            if (imc < 20)
            {
                Console.WriteLine("\n IMC = " + imc + "--> Você está abaixo do peso");
            }
            else if ((imc >= 20) && (imc <= 24))
            {
                Console.WriteLine("\n IMC = " + imc + "--> Seu peso está normal");
            }
            else if ((imc >= 25) && (imc <= 29))
            {
                Console.WriteLine("\n IMC = " + imc + "--> Você está acima do peso");
            }
            else if ((imc >= 30) && (imc <= 34))
            {
                Console.WriteLine("\n IMC = " + imc + "--> Você está obeso");
            }
            else
            {
                Console.WriteLine("\n IMC = " + imc + "--> Você está muito obeso");
            }
            Console.ReadKey();
        }
    }
}
