using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseObjetos
{
    class Program
    {
        static void Main(string[] args)
        {
            #region classes e objetos
            //MinhaClasse mClasse = new MinhaClasse();
            //MinhaClasse m2 = null;

            //OutraClasse outra = new OutraClasse();
            //OutraClasse outra2 = outra;
            #endregion

            Pessoa p1 = new Pessoa();
            p1.nome = "Gabriel";
            p1.sobrenome = "Artigas";
            p1.anoNascimento = 1985;

            Pessoa p2 = new Pessoa()
            {
                nome = "Cristofer",
                sobrenome = "Sais",
                anoNascimento = 2002
                
            };
            Console.WriteLine("Pessoa 1: " + p1.nome);
            p1.Cumprimentar();
            Console.WriteLine("Pessoa 2: " + p2.nome);
            p2.Cumprimentar();
            Console.ReadKey(true);
        }
    }

    class MinhaClasse
    {

    }
}
