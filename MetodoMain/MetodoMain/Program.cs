﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodoMain
{
    class Program
    {
        static void Main(string[] args)
        {
            string senha = "abc123";
            if( senha != args[1])
            {
                Console.WriteLine("Acesso negado!");
            }
            else
            {
                Console.WriteLine("Olá, " + args[0]);

            }

        }
    }
}
