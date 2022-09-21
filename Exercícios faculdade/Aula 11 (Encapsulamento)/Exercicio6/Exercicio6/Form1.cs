namespace Exercicio6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cadastro pessoa1 = new Cadastro();

            pessoa1.setNome(txtNome.Text);
            pessoa1.setSobrenome(txtSobrenome.Text);
            pessoa1.setIdade(int.Parse(txtIdade.Text));
            pessoa1.setNaturalidade(txtNaturalidade.Text);
            pessoa1.setEstado(txtEstado.Text);
            pessoa1.setCidade(txtCidade.Text);
            pessoa1.setEndereco(txtEndereco.Text);

            //Verificando o sexo da pessoa
            if (rdbMasc.Checked == true){
                pessoa1.setSexo("Masculino");
            }
            else if(rdbFem.Checked == true)
            {
                pessoa1.setSexo("Feminino");
            }

            //Message box//
            if(rdbSr.Checked == true)
            {
                MessageBox.Show("O " + pessoa1.tituloSr() + pessoa1.getNome() + "" + pessoa1.getSobrenome() + " é natural de " + pessoa1.getNaturalidade() +
                  " e hoje reside na rua: " + pessoa1.getEndereco() + " " + pessoa1.getCidade() + " estado de " + pessoa1.getEstado()) ;
            }

            if(rdbSra.Checked == true)
            {
                MessageBox.Show("O " + pessoa1.tituloSra() + pessoa1.getNome() + "" + pessoa1.getSobrenome() + " é natural de " + pessoa1.getNaturalidade() +
                  " e hoje reside na rua: " + pessoa1.getEndereco() + " " + pessoa1.getCidade() + " estado de " + pessoa1.getEstado());
            }

            if (rdbMs.Checked == true) 
            {
                MessageBox.Show("O " + pessoa1.tituloMs() + pessoa1.getNome() + "" + pessoa1.getSobrenome() + " é natural de " + pessoa1.getNaturalidade() +
                  " e hoje reside na rua: " + pessoa1.getEndereco() + " " + pessoa1.getCidade() + " estado de " + pessoa1.getEstado());
            }

            if(rdbDr.Checked == true)
            {
                MessageBox.Show("O " + pessoa1.tituloDr() + pessoa1.getNome() + "" + pessoa1.getSobrenome() + " é natural de " + pessoa1.getNaturalidade() +
                  " e hoje reside na rua: " + pessoa1.getEndereco() + " " + pessoa1.getCidade() + " estado de " + pessoa1.getEstado());
            }
        }
    }
}