using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2
{
    class Imovel
    {
        private string endereco;
        private double preco;

        //MÉTODOS DE ACESSO
        public string Endereco { get => endereco; set => endereco = value; }
        public double Preco { get => preco; set => preco = value; }

        public virtual double calculaTotal()
        {
            return preco;
        }
    }


    class Novo: Imovel
    {
        private double adicional;

        //MÉTODOS DE ACESSO
        public double Adicional { get => adicional; set => adicional = value; }

        public override double calculaTotal()
        {
            return Preco + Adicional;
        }
    }

    class Velho: Imovel
    {
        private double desconto;

        //MÉTODOS DE ACESSO
        public double Desconto { get => desconto; set => desconto = value; }

        public override double calculaTotal()
        {
            return Preco - Desconto;
        }

    }
}
