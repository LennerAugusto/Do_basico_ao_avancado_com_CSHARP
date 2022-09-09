namespace Exercicio2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bola bola1 = new Bola();

            MessageBox.Show("Cor: " + bola1.setCor(txtCor.Text) + "\nMaterial: " + bola1.setMaterial(txtMaterial.Text) + "\nCircunferência: " + bola1.setCircunferencia(Convert.ToDouble(txtCircunferencia.Text)));
        }
    }
}