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
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
                lblQuilometragem.Visible = false;
                txtQuilometragem.Visible = false;

                lblHoras.Visible = false;
                txtHoras.Visible = false;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (rdbAviao.Checked == true)
            {
                lblQuilometragem.Visible = false;
                txtQuilometragem.Visible = false;

                lblHoras.Visible = true;
                txtHoras.Visible = true;
            }
            else
            {
                lblQuilometragem.Visible = true;
                txtQuilometragem.Visible = true;

                lblHoras.Visible = false;
                txtHoras.Visible = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Carro carro = new Carro();

            Aviao aviao = new Aviao();

            carro.Descricao = txtDescricao.Text;
            carro.Capacidade = int.Parse(txtCapacidade.Text);
            carro.Quilometragem = int.Parse(txtQuilometragem.Text);


            MessageBox.Show(carro.imprime() + carro.imprimeCarro());
           

            aviao.Descricao = txtDescricao.Text;
            aviao.Capacidade = int.Parse(txtCapacidade.Text);
            aviao.HorasVoo = int.Parse(txtHoras.Text);

            MessageBox.Show(aviao.imprime() + aviao.imprimeAviao());



        }
    }
}
