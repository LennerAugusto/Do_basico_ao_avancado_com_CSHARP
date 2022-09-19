using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio5
{
    internal class Funcionario
    {
            private string nome;
            private double salario;
            private int tempoServico;
            private int idade;


            // FUNÇÕES DE ACESSO:
            public void setNome(string nome)
            {
                this.nome = nome;
            }

            public string getNome()
            {
                return nome;
            }

            public void setSalario(double salario)
            {
                this.salario = salario;
            }

            public double getSalario()
            {
                return salario;
            }

            public void setTempoServico(int tempoServico)
            {
                this.tempoServico = tempoServico;
            }

            public int getTempoServico()
            {
                return tempoServico;
            }

            public void setIdade(int idade)
            {
                this.idade = idade;
            }

            public int getIdade()
            {
                return idade;
            }

            //OUTRAS CLASSES
            public string Aposentadoria()
            {
                if (getTempoServico() > 35 && getIdade() > 60)
                {
                    return "\nO Funcionário já pode se aposentar";
                }
                else
                {
                    return "\nO funcionário ainda não pode se aposentar";
                }
            }

            public string imprimeDados()
            {
                return "DADOS DOS FUNCIONÁRIOS CADASTRADOS: \n\n" + "\nNome: " + getNome() + "\nIdade: " + getIdade() + "\nTempo de serviço: " + getTempoServico() + "\nSalário: "
                        + getSalario() + "\nSituação da aposentadoria: " + Aposentadoria();
            }
        
    }
}
