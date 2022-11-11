using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio1
{
    public partial class Form1 : Form
    {
        Revista revista = new Revista();
        Artigo artigo = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            revista.Nome = txtNomeRevista.Text;
            revista.Edicao = int.Parse(txtEdicaoRevista.Text);
             
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            MessageBox.Show(revista.imprimirDados()); 
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            artigo = new Artigo();
            artigo.Titulo = txtTituloArtigo.Text;
            artigo.NumeroPaginas = int.Parse(txtNumeroDePaginas.Text);

            revista.ListaArtigo.Add(artigo);
        }
    }
}
