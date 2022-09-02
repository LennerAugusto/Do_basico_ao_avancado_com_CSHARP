namespace Exercicio3
{
    public partial class Form1 : Form
    {
        Turma aluno1 = new Turma();
        Turma aluno2 = new Turma();
        public Form1()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            aluno2.periodo = txtPeriodo.Text;
            aluno2.serie = int.Parse(txtSerie.Text);
            aluno2.sigla = txtSigla.Text;
            aluno2.tipoEnsino = txtTipo.Text;

            MessageBox.Show("Alunos registrados com sucesso");        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            aluno1.periodo = txtPeriodo.Text;
            aluno1.serie = int.Parse(txtSerie.Text);
            aluno1.sigla = txtSigla.Text;
            aluno1.tipoEnsino = txtTipo.Text;

            
        }

        private void btnVisualizar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Aluno 1: \n" + "Período: " + aluno1.periodo + "\n Série: " + aluno1.serie + "\nSigla: " + aluno1.sigla + "\nTipo de Ensino: " + aluno1.tipoEnsino + "\n\n\n Aluno 1: \n" + "Período: " + aluno2.periodo + "\n Série: " + aluno2.serie + "\nSigla: " + aluno2.sigla + "\nTipo de Ensino: " + aluno2.tipoEnsino);
           
        }
    }
}