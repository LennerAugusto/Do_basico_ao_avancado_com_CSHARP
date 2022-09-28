using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio7
{
    class Circulo
    {
        private int raio;
        private double area;
        private double perimetro;

        public void setRaio(int raio)
        {
            this.raio = raio;
        }

        public int getRaio()
        {
            return raio;
        }

        public void setArea(double area)
        {
            this.area = area;
        }
       
        public double getArea()
        {
            return area;
        }

        public void setPerimetro(double perimetro)
        {
            this.perimetro = perimetro;
        }

        public double getPerimetro()
        {
            return perimetro;
        }

        public void calculaArea()
        {
             area = 3.14 * raio * raio;
        }

        public void calculaPerimetro()
        {
            perimetro = 2 * 3.14 * raio;
        }

        public string imprimir()
        {
            return "Raio: " + raio + "\nÁrea: " + area + "\nPerímetro: " + perimetro;
           
        }
    }
}
