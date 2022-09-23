using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversao
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Implícita
            //byte num1 = 100; //1 byte de 0 a 255
            //ushort num2; //2 byte de 0 a 65.535
            //float num3 = 1250.45f;
            //double num4 = num3;

            //num2 = num1;
            //num3 = num1;

            //char letra = 'C';
            //int numero = letra;
            #endregion

            #region Explícita
            //ushort num1 = 500;
            //byte num2 = (byte)num1;

            //float num3 = 2500.786f;
            //int num4 = (int)num3;

            //char letra = (char)97;

            #endregion

            #region Parse
            //string txtNumero = "1985";
            //int numero = int.Parse(txtNumero);

            //byte num1 = byte.Parse("123");

            //double num2 = double.Parse("125623,57");
            //float num3 = float.Parse("123,45");
          
            #endregion

            string texto = Convert.ToString(2500);

            double num1 = Convert.ToDouble(true);

            int num2 = Convert.ToInt32('C');

            Console.WriteLine(num2);
            Console.ReadKey(true);

        }
    }
}
