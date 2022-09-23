using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modificadores
{
    class Program
    {
        static void Main(string[] args)
        {
            Teste t = new Teste();
           //t._nome = "";
            t._sobrenome = "";
           // t.Metodo1();
            t.Executar();

            Homem h = new Homem();
            h._idade = 18;


        }
    }
}
