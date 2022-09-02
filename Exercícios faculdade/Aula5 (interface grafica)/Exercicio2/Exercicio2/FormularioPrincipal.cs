namespace Exercicio2
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void cadastroProdutosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroProdutos cadastro_produtos = new CadastroProdutos();

            cadastro_produtos.Show();
        }

        private void cadastroClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroClientes cadastro_Clientes = new CadastroClientes();

            cadastro_Clientes.Show();
        }

        private void custoMensalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustoMensal custo_mensal = new CustoMensal();

            custo_mensal.Show();
        }

        private void contábilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Contabil contabil = new Contabil();

            contabil.Show();
        }
    }
}