using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1
{
    class Artigo
    {
        private string titulo;
        private int numeroPaginas;

        public string Titulo { get => titulo; set => titulo = value; }
        public int NumeroPaginas { get => numeroPaginas; set => numeroPaginas = value; }
    }
}
