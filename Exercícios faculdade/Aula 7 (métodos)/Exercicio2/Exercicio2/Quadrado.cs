using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2
{
    internal class Quadrado
    {
        public int lado;
        public int area;
        public int perimetro;

        public int calculaArea()
        {
            return lado * lado;
        }

        public int calculaPerimetro()
        {
            return lado * 4;
        }

        public string imprimir()
        {
            int area = lado * lado;
            int perimetro = lado *4;
            
            return "Lado:" + lado + "\nÁrea: "+ area + "\nPerímetro: " + perimetro;
        }
    }
}
