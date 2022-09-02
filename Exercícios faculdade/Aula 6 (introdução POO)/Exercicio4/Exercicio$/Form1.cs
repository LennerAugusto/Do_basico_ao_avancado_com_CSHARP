namespace Exercicio_
{
    public partial class Form1 : Form
    {
        Aluno aluno1 = new Aluno();
        Aluno aluno2 = new Aluno();
        Aluno aluno3 = new Aluno();

        int contador = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            contador++;

            if(contador == 1)
            {
                aluno1.nome = txtNome.Text;
                aluno1.media = int.Parse(txtMedia.Text);
                aluno1.dataNascimento = DateTime.Parse(txtData.Text);

                
            }
            
            if(contador == 2)
            {
                aluno2.nome = txtNome.Text;
                aluno2.media = int.Parse(txtMedia.Text);
                aluno2.dataNascimento = DateTime.Parse(txtData.Text);

             
            }

            if(contador == 3)
            {
                aluno3.nome = txtNome.Text;
                aluno3.media = int.Parse(txtMedia.Text);
                aluno3.dataNascimento = DateTime.Parse(txtData.Text);

          
            }

            MessageBox.Show("Dados registrados com sucesso");
        }

        private void btnVisualizar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Aluno 1:\n Nome: " + aluno1.nome + "\nMédia: " + aluno1.media + "\nData de nascimento: " + aluno1.dataNascimento + "\n\n" +
                "Aluno 2:\n Nome: " + aluno2.nome + "\nMédia: " + aluno2.media + "\nData de nascimento: " + aluno2.dataNascimento + "\n\n" +
                "Aluno 3:\n Nome: " + aluno3.nome + "\nMédia: " + aluno3.media + "\nData de nascimento: " + aluno3.dataNascimento + "\n\n");
        }

        private void btnMaiorMedia_Click(object sender, EventArgs e)
        {
            if(aluno1.media > aluno2.media && aluno1.media > aluno3.media)
            {
                MessageBox.Show("A maior média é do aluno: " + aluno1.nome);
            }

            if (aluno2.media > aluno1.media && aluno2.media > aluno3.media)
            {
                MessageBox.Show("A maior média é do aluno: " + aluno2.nome);
            }

            if (aluno3.media > aluno1.media && aluno3.media > aluno2.media)
            {
                MessageBox.Show("A maior média é do aluno: " + aluno3.nome);
            }
        }
    }
}