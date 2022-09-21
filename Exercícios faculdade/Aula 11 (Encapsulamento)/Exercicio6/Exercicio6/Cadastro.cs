using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio6
{
    internal class Cadastro
    {
        private string nome;
        private string sobrenome;
        private int idade;
        private string sexo; 
        private string titulacao;
        private string naturalidade;
        private String endereco;
        private string cidade;
        private string estado;
        public void setNome(string nome)
        {
            this.nome = nome;
        }

        public string getNome()
        {
            return nome;
        }

        public void setSobrenome(string sobrenome)
        {
            this.sobrenome = sobrenome;
        }

        public string getSobrenome()
        {
            return sobrenome;
        }

        public void setIdade(int idade)
        {
            this.idade = idade;
        }

        public int getIdade()
        {
            return idade;   
        }

        public void setSexo( string sexo)
        {
            this.sexo = sexo;
        }

        public string getSexo()
        {
            return sexo;
        }

        public void setNaturalidade(string naturalidade)
        {
            this.naturalidade = naturalidade;
        }
        public string getNaturalidade()
        {
            return naturalidade;
        }

        public void setEndereco(string endereco)
        {
            this.endereco = endereco;
        }
        public string getEndereco()
        {
            return endereco;
        }

        public void setCidade(string cidade)
        {
            this.cidade = cidade;
        }
        public string getCidade()
        {
            return cidade;
        }

        public void setEstado(string estado)
        {
            this.estado = estado;
        }

        public string getEstado()
        {
            return estado;
        }

        //UM MÉTODO PARA CADA TITULAÇÃO
        public string tituloSr() 
        {
            return "Sr.";
        }
        public string tituloMs()
        {
            return "Ms.";
        }
        public string tituloDr()
        {
            return "Dr.";
        }
        public string tituloSra()
        {
            return "Sra.";
        }

        

    }
}
