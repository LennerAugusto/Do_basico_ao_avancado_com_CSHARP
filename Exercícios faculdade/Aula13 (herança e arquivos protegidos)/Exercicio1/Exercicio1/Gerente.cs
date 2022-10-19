using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1
{
    class Gerente : Empregado
    {

        private double gratificacao;

        public Gerente(string nome, double salarioFixo, double gratificacao) : base(nome, salarioFixo)
        {
        
            this.gratificacao = gratificacao;
        }

        public override string imprimeDados()
        {
            return "Nome do Funcionário: " + Nome + "\nSalário: " + salarioFixo + "\nGratificação: " + gratificacao + "\nTotal de ganhos: " + calculaSalario();
        }

        public override double calculaSalario()
        {
            return salarioFixo + gratificacao;
        }
    } 
}   
