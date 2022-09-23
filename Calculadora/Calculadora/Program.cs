using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            Inicio:
            Console.Clear();
            Console.Write("Digite o primeiro número: ");
            double num1 = double.Parse(Console.ReadLine());

            Segundo:
            Console.Write("Digite o seegundo número: ");
            double num2 = double.Parse(Console.ReadLine());

            Operação:
            Console.Write("Escolha a operação (+ - x /): ");
            char op = char.Parse(Console.ReadLine());

            double resultado;

            switch(op)
            {
                default:
                    Console.WriteLine("Erro opção inválida.");
                    goto Operação;
                case '+':
                    resultado = num1 + num2;
                        break;
                case '-':
                    resultado = num1 - num2;
                    break;
                case 'x':
                case 'X':
                    resultado = num1 * num2;
                    break;
                case '/':
                    if (num2 == 0)
                    {
                        Console.WriteLine("Não é possível dividir por 0.");
                        goto Segundo;

                    }
                    else
                    {
                        resultado = num1 / num2;
                        break;
                    }
                    break;
            }
            Console.WriteLine("Resultado final= " + resultado);
            Console.WriteLine("Continuar calculando (s/n)?");
            string opcao = Console.ReadLine();

            if (opcao == "s" || opcao == "S")
            {
                goto Inicio;
            }



        }
    }
}
