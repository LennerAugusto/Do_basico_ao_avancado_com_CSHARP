namespace Exercicio2
{
    public partial class Form1 : Form
    {
        Banco cliente1 = new Banco();
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            cliente1.Nome = txtNome.Text;
            cliente1.codigo = int.Parse(txtCodigo.Text);
            cliente1.saldo = double.Parse(txtSaldo.Text);

            MessageBox.Show("Dados salvos com sucesso!!");
        }

        private void btnVisualizar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nome do Cliente: " + cliente1.Nome + "\n Código do Cliente: " + cliente1.codigo + "\nSaldo disonível: " + cliente1.saldo);
        }
    }
}