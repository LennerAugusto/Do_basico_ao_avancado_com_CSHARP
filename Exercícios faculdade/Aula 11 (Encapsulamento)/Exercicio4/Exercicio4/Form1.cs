namespace Exercicio4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnMedia_Click(object sender, EventArgs e)
        {
            Aluno aluno1 = new Aluno();

            aluno1.setNota1(Convert.ToDouble(txtN1.Text));
            aluno1.setNota2(Convert.ToDouble(txtN2.Text));

            MessageBox.Show("Média do Aluno: " + Convert.ToString(aluno1.calculaMedia()));
        }

        private void btnImprime_Click(object sender, EventArgs e)
        {
            Aluno aluno1 = new Aluno();

            aluno1.setNome(txtNome.Text);
            aluno1.setMatricula(int.Parse(txtMatricula.Text));
            aluno1.setNota1(Convert.ToDouble(txtN1.Text));
            aluno1.setNota2(Convert.ToDouble(txtN2.Text));

            MessageBox.Show(Convert.ToString(aluno1.imprimeDados()));
        }
    }
}