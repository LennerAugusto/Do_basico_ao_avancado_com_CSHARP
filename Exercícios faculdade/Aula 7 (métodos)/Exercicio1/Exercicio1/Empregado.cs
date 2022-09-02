using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1
{
    internal class Empregado
    {

        public string nome;
        public string departamento;
        public int horasTrabalhadasNoMes;
        public int salarioPorHora;

       public string mostrarDados()
        {
            return "Nome: " + nome + "\nDepartamento: " + departamento +
               "\nHoras trabalhadas no mês: " + horasTrabalhadasNoMes + "\nSalário por hora: " + salarioPorHora;
        }

      public  int calculaSalarioMensal()
        {
           return salarioPorHora * horasTrabalhadasNoMes;
        }
    }
}
