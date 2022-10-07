using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio2
{
    public partial class Form1 : Form
    {

        Novo novo = null;
        Velho velho = null;


        public Form1()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (tabPrincipal.SelectedTab == tabNovo)
            {
                novo = new Novo();

                novo.Endereco = txtEndereco.Text;
                novo.Preco = Convert.ToDouble(txtPreco.Text);
                novo.Adicional = Convert.ToDouble(txtAdicional.Text);
            }
            else
            {
                velho = new Velho();

                velho.Endereco = txtEnderecoVelho.Text;
                velho.Preco = Convert.ToDouble(txtPrecoVelho.Text);
                velho.Desconto = Convert.ToDouble(txtDesconto.Text);
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            if(tabPrincipal.SelectedTab == tabNovo)
            {
                MessageBox.Show("Endereço: " + novo.Endereco + "\nPreço: " + novo.Preco +
                                  "\nAdicional:" + novo.Adicional + "\nValor Total:" + novo.calculaTotal());
            }
            else
            {
                MessageBox.Show("Endereço: " + velho.Endereco + "\nPreço: " + velho.Preco +
                                 "\nDesconto:" + velho.Desconto + "\nValor Total:" + velho.calculaTotal());
            }
        }
    }
}
