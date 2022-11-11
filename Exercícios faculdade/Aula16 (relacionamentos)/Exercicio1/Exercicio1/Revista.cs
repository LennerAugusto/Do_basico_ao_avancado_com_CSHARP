using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1
{
    class Revista
    {
        private int edicao;
        private string nome;

        private List<Artigo> listaArtigo = new List<Artigo>();

        public int Edicao { get => edicao; set => edicao = value; }
        public string Nome { get => nome; set => nome = value; }
        internal List<Artigo> ListaArtigo { get => listaArtigo; set => listaArtigo = value; }

        public string imprimirDados()
        {
            string dados = "";

            dados = "Nome da revista: " + nome + "\nEdição: " + edicao + "\nArtigos:\n\n";

            int i;
            for(i = 0; i > listaArtigo.Count(); i++)
            {
                dados = dados + "Título: " + listaArtigo[i].Titulo + "Páginas: " + listaArtigo[i].NumeroPaginas;
            }

            return dados;

        }
    }
}
