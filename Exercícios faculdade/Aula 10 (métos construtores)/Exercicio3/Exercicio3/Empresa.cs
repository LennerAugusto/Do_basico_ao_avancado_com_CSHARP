using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio3
{
    internal class Empresa
    {
        public string nome;
        public string endereco;
        public string cidade;
        public string estado;
        public double valorPatrimonial;
        public int qtdeFuncionarios;

        public Empresa() //Construtor Padrão
        {

        }
        public Empresa(string nome, string endereco, string cidade, string estado, double valorPatrimonial, int qtdeFuncionarios)
        {

            this.nome = nome;
            this.endereco = endereco;
            this.cidade = cidade;
            this.estado = estado;
            this.valorPatrimonial = valorPatrimonial;
            this.qtdeFuncionarios = qtdeFuncionarios;

        }

        public string print()
        {
            return "Nome da Empresa: " + this.nome + "\nEndereço da empresa: " + this.endereco + "\nCidade: " + this.cidade +
                    "\nEstado: " + this.estado + "\nValor patrimonial: " + this.valorPatrimonial + "\nQuantidade de funcionários: " + this.qtdeFuncionarios;
        }


    }
}