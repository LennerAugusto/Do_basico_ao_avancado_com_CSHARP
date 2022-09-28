namespace Conta_bancaria
{
    public partial class Cadastro_conta : Form
    {
        ContaBancaria cliente1 = new ContaBancaria();
        public Cadastro_conta()
        {
            InitializeComponent();
        }

        private void btnAbreConta_Click(object sender, EventArgs e)
        {
            if (int.Parse(txtRecebeValor.Text) <= 0)
            {
                cliente1.setSaldo(0);

                MessageBox.Show("Erro, valor inválido");
            }
            else
            {
                cliente1.setSaldo(Convert.ToDouble(txtRecebeValor.Text));
            }
        }

        private void btnCredito_Click(object sender, EventArgs e)
        {
            cliente1.credito(Convert.ToDouble(txtRecebeValor.Text));
        }

        private void btnDébito_Click(object sender, EventArgs e)
        {
            cliente1.debito(Convert.ToDouble(txtRecebeValor.Text));
        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            MessageBox.Show(cliente1.consultaSaldo());
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}