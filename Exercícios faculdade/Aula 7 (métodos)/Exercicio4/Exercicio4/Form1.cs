namespace Exercicio4
{
    public partial class Form1 : Form
    {
        Calculadora conta = new Calculadora();
  

        int resultado;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtNum1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSubtrair_Click(object sender, EventArgs e)
        {
            conta.a = int.Parse(txtNum1.Text);
            conta.b = int.Parse(txtNum2.Text);

           resultado = conta.subtrai();
        }

        private void btnResultado_Click(object sender, EventArgs e)
        {
           txtResultado.Text = resultado.ToString();
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            conta.a = int.Parse(txtNum1.Text);
            conta.b = int.Parse(txtNum2.Text);

            resultado = conta.multiplica();
        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            conta.a = int.Parse(txtNum1.Text);
            conta.b = int.Parse(txtNum2.Text);

            resultado = conta.soma();
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            conta.a = int.Parse(txtNum1.Text);
            conta.b = int.Parse(txtNum2.Text);

            resultado = conta.divide();

        
        }
    }
}