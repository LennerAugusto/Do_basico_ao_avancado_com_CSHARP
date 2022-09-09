using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.Pkcs;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1
{
    internal class Pessoa
    {
        private string nome;
        private int idade;

        public string setNome(string nome)
        {
            return nome = nome;
        }

        public int setIdade(int idade)
        {
            return idade = idade;
        }

        public string getNome()
        {
            return nome;
        }
        public int getIdade()
        {
            return idade;
        }

    }
}
