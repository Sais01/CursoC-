using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controle
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Switch - Case
            //int escolha = 5;

            //switch (escolha)
            //{
            //    default:
            //        Console.WriteLine("Opção default");
            //        break;
            //    case 1:
            //        Console.WriteLine("Opção 1");
            //        break;

            //    case 2:
            //        Console.WriteLine("Opção 2");
            //        break;

            //    case 3:
            //    case 4:
            //        Console.WriteLine("Opção Combinada");
            //        break;
            //}
            //Console.ReadKey(true);
            #endregion

            Inicio:
            Console.Write("Escolha uma opção: ");
            int op = int.Parse(Console.ReadLine());
            int valor = 0;

            switch(op)
            {
                default:
                    goto Inicio;
                case 1:
                    valor += 100;
                    break;
                case 2:
                    valor += 50;
                    goto case 1;
            }
            Console.WriteLine( valor);
            Console.ReadKey();
        }
    }
}
