namespace Exercicio5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       
        private void btnCadastro_Click(object sender, EventArgs e)
        {
           int count = 0;

            if (count == 0)
            {
                Funcionario func1 = new Funcionario();

                func1.setNome(txtNome.Text);
                func1.setIdade(int.Parse(txtIdade.Text));
                func1.setSalario(Convert.ToDouble(txtSalario.Text));
                func1.setTempoServico(int.Parse(txtTempo.Text));

                count++;

                txtNome.Clear();
                txtIdade.Clear();
                txtSalario.Clear();
                txtTempo.Clear();

                MessageBox.Show(func1.imprimeDados());
            }

            if(count == 1)
            {
                Funcionario func2 = new Funcionario();

                func2.setNome(txtNome.Text);
                func2.setIdade(int.Parse(txtIdade.Text));
                func2.setSalario(Convert.ToDouble(txtSalario.Text));
                func2.setTempoServico(int.Parse(txtTempo.Text));

                count++;

                txtNome.Clear();
                txtIdade.Clear();
                txtSalario.Clear();
                txtTempo.Clear();

                MessageBox.Show(func2.imprimeDados());
            }

            
        }

        private void btnImrpime_Click(object sender, EventArgs e)
        {
      

        }
    }
}