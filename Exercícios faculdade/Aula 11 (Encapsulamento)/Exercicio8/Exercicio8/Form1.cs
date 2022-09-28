using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Televisao televisao1 = new Televisao();

            televisao1.Marca = txtMarca.Text;
            televisao1.Modelo = txtModelo.Text;
            televisao1.Data_lancamento = Convert.ToDateTime(txtData.Text);
            televisao1.Preco = Convert.ToDouble(txtPreco.Text);
            televisao1.Polegadas = int.Parse(txtPolegadas.Text);
            
            if(rdbTrue.Checked == true)
            {
                televisao1.Lcd = "Possui LCD";
            }
            else
            {
                televisao1.Lcd = "Não possui LCD";
            }

            MessageBox.Show(televisao1.imprime());
        }
    }
}
