using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio3
{
    internal class Retangulo
    {
        public int baseRetangulo;
        public int altura;

        public int calculaArea()
        {
            return baseRetangulo * altura;
        }

        public int calculaPerimetro()
        {
            return 2 * (baseRetangulo * altura);
        }

        public string imprime()
        {
            return "Base do retângulo: " + baseRetangulo + "\nAltura do retângulo: " + altura;
        }
    }
}
