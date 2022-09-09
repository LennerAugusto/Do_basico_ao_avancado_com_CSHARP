using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.Pkcs;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2
{
    internal class Bola
    {
        private string cor;
        private double circunferencia;
        private string material;

        public string getCor()
        {
            return this.cor;
        }

        public string setCor(string cor)
        {
            return cor = cor;
        }

        public double getCircunferencia()
        {
            return this.circunferencia;
        }

        public double setCircunferencia(double circunferencia)
        {
            return circunferencia = circunferencia;
        }

        public string getMaterial()
        {
            return this.material;
        }

        public string setMaterial(string material)
        {
            return material = material;
        }
    }
}
