namespace Exercicio5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lblclick_Click(object sender, EventArgs e)
        {
            lblClick.Text = "PARE DE CLICAR AQUI !";
        }
    }
}