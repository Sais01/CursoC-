using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace termoThis
{
    class Program
    {
        static void Main(string[] args)
        {
            Acessar a = new Acessar();
            Console.WriteLine("Digite a senha:");

            if (a.Login(Console.ReadLine()))
            {
                Console.WriteLine("Seja bem vindo!");
            }
            else
            {
                Console.WriteLine("Acesso negado");
            }
            Console.ReadKey(true);
        }
    }
}
