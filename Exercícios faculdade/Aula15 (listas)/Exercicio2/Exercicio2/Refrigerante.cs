using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2
{
    internal class Refrigerante
    {
        private string nome;
        private double preco;
        private int qtdeEstoque;


        public string Nome { get => nome; set => nome = value; }
        public double Preco { get => preco; set => preco = value; }
        public int QtdeEstoque { get => qtdeEstoque; set => qtdeEstoque = value; }


        public Refrigerante(string nome, double preco, int qtdeEstoque)
        {
            this.Nome = nome;
            this.Preco = preco;
            this.QtdeEstoque = qtdeEstoque;
        }


        public void efetuarVenda() {
            qtdeEstoque--;
        }

    }
}
