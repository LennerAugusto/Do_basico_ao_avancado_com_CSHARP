using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1
{
    class Empregado
    {
        private string nome;
        protected double salarioFixo;

        public string Nome { get => nome; set => nome = value; }

        public Empregado(string nome, double salarioFixo)
        {
            this.nome = nome;
            this.salarioFixo = salarioFixo;
        }

        public virtual string imprimeDados()
        {
            return "Nome do Funcionário: " + nome + "\nSalário: " + salarioFixo; 
        }

        public virtual double calculaSalario()
        {
            return salarioFixo;
        }
    }

}


