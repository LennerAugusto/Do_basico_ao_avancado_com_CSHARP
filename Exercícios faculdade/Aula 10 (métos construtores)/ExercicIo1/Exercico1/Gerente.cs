using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercico1
{
    internal class Gerente
    {
        public double salario;

        public Gerente(double sal)
        {
            this.salario = sal;
        }

        public void AumentoSalarial()
        {
            salario = salario * 1.1;
        }

        public void AumentoSalarial(double taxa)
        {
            salario = salario + (salario * taxa / 100);
        }
    }
}
