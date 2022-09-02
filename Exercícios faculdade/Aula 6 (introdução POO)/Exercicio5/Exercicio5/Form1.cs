namespace Exercicio5
{
    public partial class Form1 : Form
    {
        int total1, total2; 

        Loja produto1 = new Loja();
        Loja produto2 = new Loja();
        
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (rdbProduto1.Checked == true)
            {
                produto1.nome = txtNome.Text;
                produto1.qtde = int.Parse(txtQtdde.Text);
                produto1.preco = int.Parse(txtPreco.Text);
            }
            else
            {
                produto2.nome = txtNome.Text;
                produto2.qtde = int.Parse(txtQtdde.Text);
                produto2.preco = int.Parse(txtPreco.Text);
            }

            MessageBox.Show("Produto salvo com sucesso !!");
        }

        private void btnvisualizar_Click(object sender, EventArgs e)
        {
            if (rdbProduto1.Checked == true)
            {
                MessageBox.Show("Produto 1: \n" + "Nome: " + produto1.nome + "\nQuantidade selecionada: " + produto1.qtde + "\nPreço unitário: " + produto1.preco);
            }
            else
            {
                MessageBox.Show("Produto 2: \n" + "Nome: " + produto2.nome + "\nQuantidade selecionada: " + produto2.qtde + "\nPreço unitário: " + produto2.preco);
            }
        }

        private void btnTotal_Click(object sender, EventArgs e)
        {
            if (rdbProduto1.Checked == true)
            {
                total1 = produto1.qtde * produto1.preco;

                MessageBox.Show("Total: " + total1);
            }
            else
            {
                total2 = produto2.qtde * produto2.preco;

                MessageBox.Show("Total: " + total2);
            }
        }
    }
}