namespace Exercicio2
{
    public partial class Form1 : Form
    {
        Refrigerante refri = null;
        List<Refrigerante> listaProdutos = new List<Refrigerante>();
        public Form1()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            refri = new Refrigerante(txtNome.Text, Convert.ToDouble(txtPreco.Text), int.Parse(txtQtde.Text));

            listaProdutos.Add(refri);

        }

        private void btnMostraEstoque_Click(object sender, EventArgs e)
        {
            int contador;
            for(contador = 0; contador < listaProdutos.Count(); contador++)
            {
                MessageBox.Show("Marca: " + listaProdutos.Nome + "Preço: " + contador.Preco + "\nQuantidade em estoque: " + contador.QtdeEstoque);
            }
        }
    }
}