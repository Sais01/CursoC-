using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Propriedades
{
    class Program
    {
        static void Main(string[] args)
        {
            Teste t = new Teste();
            t.Nome = "Cristofer";
            t.Idade = 18;
           

            Teste r = new Teste();
            r.Nome = "Carlita";
            

            Console.WriteLine(t.Nome + " " + t.Sobrenome);
            Console.WriteLine(t.Idade);
            t.Apresentar();
            Console.WriteLine(r.Nome);

            Console.ReadKey(true);
        }
    }
}
