namespace Exercicio3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcula_Click(object sender, EventArgs e)
        {
            Quadrado quadrado = new Quadrado();

            quadrado.setLado(int.Parse(txtLado.Text));

            MessageBox.Show("Lado do quadrado: " + quadrado.getLado() + "\n¡rea do quadrado: " + quadrado.calculaArea());
        }
    }
}