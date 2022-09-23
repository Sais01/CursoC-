using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modificadores
{
    class Teste
    {
        private string _nome;
        public string _sobrenome;
        

        private void Metodo1() { }
        public void Executar() { }
    }
    class Humano
    {
        protected string _nome;
        private string _sobrenome;
        internal int _idade;

    }
    class Homem : Humano
    {
        public void Metodo()
        {
            _nome = "";
        }
    }

}
