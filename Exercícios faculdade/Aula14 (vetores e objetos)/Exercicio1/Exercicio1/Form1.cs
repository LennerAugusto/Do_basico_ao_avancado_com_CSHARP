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
        Produto[] vetProdutos = new Produto[5];
        int i = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            if(i < 5)
            {
                string descricao = txtDescricao.Text;
                double preco = Convert.ToDouble(txtPreco.Text);
                int saldo = int.Parse(txtSaldo.Text);

                vetProdutos[i] = new Produto(descricao, preco, saldo);

                MessageBox.Show("Produto cadastrado!!");

                i++;
            }
            else
            {
                MessageBox.Show("Número máximo de produtos atingidos!!");
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if(rdbTodosProdutos.Checked == true)
            {
                int x; //Variável para percorrer e mostrar os elementos do vetor

                for(x = 0; x>i; x++)
                {
                    listBox1.Items.Add(vetProdutos[x].Descricao + " " + vetProdutos[x].Saldo + " " + vetProdutos[x].;
                }
            }
            else
            {

            }
        }
    }
}
