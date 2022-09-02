namespace Exercicio2
{
    public partial class Form1 : Form
    {
        Quadrado quadrado = new Quadrado();
        public Form1()
        {
            InitializeComponent();
        }

        private void txtcalculaArea_Click(object sender, EventArgs e)
        {
            quadrado.lado = int.Parse(txtLado.Text);

            MessageBox.Show("Área do quadrado: " + quadrado.calculaArea());
        }

        private void txtCalculaPerimetro_Click(object sender, EventArgs e)
        {
            quadrado.lado = int.Parse(txtLado.Text);

            MessageBox.Show("Perímetro do quadrado: " + quadrado.calculaPerimetro());
        }

        private void txtImprimir_Click(object sender, EventArgs e)
        {
            quadrado.lado = int.Parse(txtLado.Text);

            MessageBox.Show(quadrado.imprimir());
        }
    }
}