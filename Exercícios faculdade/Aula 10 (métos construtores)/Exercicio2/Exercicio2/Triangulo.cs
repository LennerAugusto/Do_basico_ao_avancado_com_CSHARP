using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2
{
    internal class Triangulo
    {
        public double baseTriangulo;
        public double alturaTriangulo;

        public Triangulo() //Construtor padrão
        {

        }
        public Triangulo(double baseTriangulo, double alturaTriangulo)
        {
            this.alturaTriangulo = alturaTriangulo;
            this.baseTriangulo = baseTriangulo;
        }

        public double Area()
        {
            return (baseTriangulo * alturaTriangulo)/ 2;
        }
    }
}
