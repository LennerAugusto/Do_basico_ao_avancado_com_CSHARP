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

        Empregado empregado1 = null;
        Gerente gerente1 = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(gerente1.imprimeDados());
        }

        private void btnCadastraFunc_Click(object sender, EventArgs e)
        { 
             empregado1 = new Empregado(txtNomeFunc.Text, Convert.ToDouble(txtSalarioFunc.Text));
        
        }

        private void btnCadastraGer_Click(object sender, EventArgs e)
        {
            gerente1 = new Gerente(txtNomeGer.Text, Convert.ToDouble(txtSalarioGer.Text), Convert.ToDouble(txtGratificacao.Text));
        }

        private void btnImprimeFunc_Click(object sender, EventArgs e)
        {
            MessageBox.Show(empregado1.imprimeDados());
        }
    }
}
