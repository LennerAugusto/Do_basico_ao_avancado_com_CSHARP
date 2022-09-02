namespace Exercicio1
{
    public partial class Form1 : Form
    {
        Empregado funcionario = new Empregado();
       
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void mostraDados_Click(object sender, EventArgs e)
        {

            funcionario.nome = txtNome.Text;
            funcionario.departamento = txtDep.Text;
            funcionario.horasTrabalhadasNoMes = int.Parse(txtHoras.Text);
            funcionario.salarioPorHora = int.Parse(txtSalarioPorHora.Text);

            MessageBox.Show(funcionario.mostrarDados());
        }

        private void calculaSalario_Click(object sender, EventArgs e)
        {
           

            funcionario.nome = txtNome.Text;
            funcionario.departamento = txtDep.Text;
            funcionario.horasTrabalhadasNoMes = int.Parse(txtHoras.Text);
            funcionario.salarioPorHora = int.Parse(txtSalarioPorHora.Text);
            int salario = funcionario.calculaSalarioMensal();

            MessageBox.Show("Salário: " + salario);

        }
    }
}