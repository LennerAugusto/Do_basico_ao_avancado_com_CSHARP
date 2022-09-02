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
        Metodos potencia = new Metodos();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcula_Click(object sender, EventArgs e)
        {
            potencia.num1 = int.Parse(txtNum.Text);

           MessageBox.Show(Convert.ToString(potencia.parametros(potencia.num1)));
        }

        private void btnPotencia_Click(object sender, EventArgs e)
        {
            potencia.num1 = int.Parse(txtNum.Text);
            potencia.num2 = int.Parse(txtPotencia.Text);

            MessageBox.Show(Convert.ToString(potencia.parametros(potencia.num1, potencia.num2)));
        }
    } 
}
