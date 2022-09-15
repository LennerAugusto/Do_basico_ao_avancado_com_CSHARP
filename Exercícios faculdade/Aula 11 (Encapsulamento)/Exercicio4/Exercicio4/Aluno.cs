using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio4
{
    internal class Aluno
    {
        private string nome;
        private int matricula;
        private double nota1;
        private double nota2;

        public string getNome()
        {
            return nome;
        }

        public void setNome(string nome)
        {
            this.nome =nome;
        }
        public  int getMatricula()
        {
            return matricula;
        }
        public void setMatricula(int matricula)
        {
          this.matricula = matricula;
        }

        public double getNota1()
        {
          return nota1;
        }

        public void setNota1(double nota1)
        {
           this.nota1 = nota1;
        }

        public double getNota2()
        {
          return nota2;
        }

        public void setNota2(double nota2)
        {
            this.nota2 = nota2;
        }


        /*Solicita os dados*/
        public void solicitaDados()
        {
            MessageBox.Show("Preencha os dados faltantes");
        }

        public double calculaMedia()
        {
           double media = (getNota1() + getNota2())/ 2;

            return media;
        }

        public string imprimeDados()
        {
            return "Nome: " + getNome() + "\nMatricula: " + getMatricula() + "\nNota 1: " + getNota1() +
                    "\nNota 2 : " + getNota2() + "\nMédia: " + calculaMedia();
        }
    }
}
   
