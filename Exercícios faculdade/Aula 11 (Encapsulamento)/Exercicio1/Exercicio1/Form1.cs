namespace Exercicio1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Pessoa pessoa = new Pessoa();

            MessageBox.Show("Nome: " + pessoa.setNome(txtNome.Text)+"\nIdade: " + (Convert.ToString(pessoa.setIdade(int.Parse(txtIdade.Text)))));
  
        }
    }
} 