namespace Exercicio3
{
    public partial class Form1 : Form
    {
        int contador = 0;
        int contadorPrint = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) // Cadastra Empresa
        {
            if(contador == 0)
            {
                Empresa empresa1 = new Empresa();

                empresa1.nome = txtNome.Text;
                empresa1.endereco = txtEndereco.Text;
                empresa1.cidade = txtCidade.Text;
                empresa1.estado = txtEstado.Text;
                empresa1.valorPatrimonial = double.Parse(txtValor.Text);
                empresa1.qtdeFuncionarios = int.Parse(txtQtde.Text);

                MessageBox.Show("Empresa " + empresa1.nome + " cadastrada com sucesso !!");

                contador++;
            }



            if (contador == 1)
            {
                Empresa empresa2 = new Empresa();

                empresa2.nome = txtNome.Text;
                empresa2.endereco = txtEndereco.Text;
                empresa2.cidade = txtCidade.Text;
                empresa2.estado = txtEstado.Text;
                empresa2.valorPatrimonial = double.Parse(txtValor.Text);
                empresa2.qtdeFuncionarios = int.Parse(txtQtde.Text);

                MessageBox.Show("Empresa " + empresa2.nome + " cadastrada com sucesso !!");
            }

        }

        private void button2_Click(object sender, EventArgs e) //Mostra os dados
        {
            if (contadorPrint == 0)
            {
                Empresa empresa1 = new Empresa();

                empresa1.nome = txtNome.Text;
                empresa1.endereco = txtEndereco.Text;
                empresa1.cidade = txtCidade.Text;
                empresa1.estado = txtEstado.Text;
                empresa1.valorPatrimonial = double.Parse(txtValor.Text);
                empresa1.qtdeFuncionarios = int.Parse(txtQtde.Text);

                MessageBox.Show( empresa1.print());

                contadorPrint++;
            }



            if (contadorPrint == 1)
            {
                Empresa empresa2 = new Empresa();

                empresa2.nome = txtNome.Text;
                empresa2.endereco = txtEndereco.Text;
                empresa2.cidade = txtCidade.Text;
                empresa2.estado = txtEstado.Text;
                empresa2.valorPatrimonial = double.Parse(txtValor.Text);
                empresa2.qtdeFuncionarios = int.Parse(txtQtde.Text);

                MessageBox.Show(empresa2.print());
            }

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Empresa LennerTec");
        }
    }
}