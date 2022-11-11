using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1
{
    class Produto
    {
        private string descricao;
        private double preco;
        private int saldo;

        public Produto(string descricao, double preco, int saldo)
        {
            this.descricao = descricao;
            this.preco = preco;
            this.saldo = saldo;
        }

        public string Descricao { get => descricao; set => descricao = value; }
        public double Preco { get => preco; set => preco = value; }
        public int Saldo { get => saldo; set => saldo = value; }

    }
}
