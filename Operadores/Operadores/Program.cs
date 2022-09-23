using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operadores
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Operadores matemáticos
            // int num1 = 10;
            // int num2 = 2;
            // //int resultado = num1 + num2;
            // Console.WriteLine(num1 + num2);
            // Console.WriteLine(num1 - num2);
            // Console.WriteLine(num1 * num2);
            // Console.WriteLine(num1 / num2);
            // Console.WriteLine(num1 % num2);
            //Console.ReadKey(true);
            #endregion

            #region Precedencia de operadores
            //double num1 = 100;
            //double num2 = 10;
            //double num3 = 5;
            //double res = (num1 + num2) * (num3 / 3);

            //Console.WriteLine(res);
            //Console.ReadKey(true);
            #endregion

            #region incremento e decremento
            //int num1 = 10;
            //num1++;
            //++num1;
            //--num1;
            //num1--; // = num1 = num1 - 1;
            //Console.WriteLine(num1--);
            //Console.WriteLine(num1);
            //Console.ReadKey(true);
            #endregion

            #region concatenação
            //string nome = "Cristofer ";
            //string sobreNome = "Sais";
            //string nomeCompleto = nome + sobreNome + " " + 198.3;
            //Console.WriteLine(nomeCompleto);
            //Console.ReadKey(true);
            #endregion

            #region Operadores de atribuição
            //int num1 = 10;
            //num1 += 30;
            //num1 -= 2;
            //num1 *= 3;
            //num1 /= 2;
            //num1 %= 2;

            //string nome = "Gabriel ";
            //nome += "Artigas";
            #endregion

            #region Igualdade/Comparação
            //bool res = 100 == (50 * 2);
            //bool res2 = (200/2) != (100 + 100);
            //string nome = "Sais";
            //bool res3 = nome == "Sais";
            //Console.WriteLine(res3);
            //Console.ReadKey();
            #endregion

            #region Relacionais
            //bool res = 100 < 50 + 65;
            //bool res = 100 + 25 > 50 + 65;
            //bool res = 100 + 25 <= 50 + 65;
            // bool res = 100 + 25 >= 50 + 65;
            #endregion

            #region Lógicos (and/or)

            bool res1 = 100 > 50;
            bool res2 = 50 != 50;

            bool final = res1 && res2;
            bool final2 = (100 > 50) || (50 != 50);
            Console.WriteLine(final2);
            Console.ReadKey();
            #endregion




        }
    }
}
