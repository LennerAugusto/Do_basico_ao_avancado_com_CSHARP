using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1
{
    internal class Metodos
    {
        public int num1;
        public int num2;
        public double parametros(double num1)
        {
            return Math.Pow(num1, 2);
        }

        public double parametros(double num1, double num2)
        {
            return Math.Pow(num1, num2);    
        }
    }
}
