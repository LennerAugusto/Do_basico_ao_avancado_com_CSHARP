namespace Exercício1
{
    public partial class Form1 : Form
    {
        Empregado PrimeiroCadastro = new Empregado();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            PrimeiroCadastro.nome = txtNome.Text;
            PrimeiroCadastro.idade = int.Parse(txtIdade.Text);

            saidaNome.Text = PrimeiroCadastro.nome;
            saidaIdade.Text = Convert.ToString(PrimeiroCadastro.idade);
        }

        private void saidaNome_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}