using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MétodosDasClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Metodos m = new Metodos();

            #region Métodos simples
            //m/*.Cumprimentar();*/
            #endregion

            #region Métodos com parâmetros
            //m.Somar(10, 5);
            //m.Apresentar("Cristofer", 17);
            #endregion

            #region Passagem de parâmetros por valor e por referência
            //int valor1 = 100;
            //int valor2 = 100;

            //m.AumentarValor(valor1);
            //m.AumentarRef(ref valor2);
            //Console.WriteLine("Valor 1: " + valor1);
            //Console.WriteLine("Valor 2: " + valor2);
            #endregion

            #region Métodos com retorno
            //string nomeCompleto = m.MontaNome("Cristofer", "Sais");
            //int codigo = m.CodigoChar('S');
            //double valor = m.ValorPi();
            //Console.WriteLine(nomeCompleto);
            //Console.WriteLine(codigo);
            //Console.WriteLine(valor);
            #endregion

            m.Cumprimentar();
            m.Cumprimentar("cristofer");
            m.Cumprimentar("Cristofer", 11);

            bool res1 = m.Comparar(1, 1);
            bool res2 = m.Comparar("Arroz", "ArRoZ");
            Console.WriteLine(res1);
            Console.WriteLine(res2);
           
            
                Console.ReadKey(true);

        }
    }
}
