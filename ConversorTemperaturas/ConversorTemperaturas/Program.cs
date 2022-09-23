using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversorTemperaturas
{
    class Program
    {
        static void Main(string[] args)
        {
            double c, f, k;

            Console.WriteLine("###CONVERSOR DE TEMPERATURAS###");
            Console.Write("Digite a temperatura em °C: ");
            c = double.Parse(Console.ReadLine());
            Console.WriteLine("-------------------------");

            //Conversão
            f = ((c * 9) / 5) + 32;
            k = (c + 273.15);

            //Respostas
            Console.WriteLine("Temperatura em °F: " + f);
            Console.WriteLine("Temperatura em K: " + k);
            Console.WriteLine("-------------------------");

            Console.ReadKey(true);



            




        }
    }
}
