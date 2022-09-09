using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio3
{
    internal class Quadrado
    {
        private int lado;

        public void setLado(int lado)
        {
             this.lado = lado;
        }

        public int getLado()
        {
            return lado;
        }

        public int calculaArea()
        {
            return lado * lado;
        }
    }
}
