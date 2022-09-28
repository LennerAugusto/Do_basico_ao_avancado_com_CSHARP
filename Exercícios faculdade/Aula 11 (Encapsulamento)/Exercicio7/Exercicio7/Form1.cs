using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcula_Click(object sender, EventArgs e)
        {

        }

        private void btnImprime_Click(object sender, EventArgs e)
        {
            Circulo circulo = new Circulo();

            circulo.setRaio(int.Parse(txtRaio.Text));

            circulo.calculaArea();
            circulo.calculaPerimetro();
            MessageBox.Show(circulo.imprimir());
        }
    }
}
