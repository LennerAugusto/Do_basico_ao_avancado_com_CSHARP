namespace Exercicio3
{
    public partial class Form1 : Form
    {
        Retangulo ret = new Retangulo();
        
       
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCalculaArea_Click(object sender, EventArgs e)
        {
            ret.baseRetangulo = int.Parse(txtBase.Text);
            ret.altura = int.Parse(txtAltura.Text);
     
            MessageBox.Show("Área do retângulo: " + ret.calculaArea());
        }

        private void btnCalculaPerimetro_Click(object sender, EventArgs e)
        {
            ret.baseRetangulo = int.Parse(txtBase.Text);
            ret.altura = int.Parse(txtAltura.Text);

            MessageBox.Show("Perímetro do retângulo: " + ret.calculaPerimetro());
        }

        private void btnImprime_Click(object sender, EventArgs e)
        {
            MessageBox.Show(ret.imprime());
        }
    }
}