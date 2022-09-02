namespace Criando_novos_formularios
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClick_Click(object sender, EventArgs e)
        {
            Formulario2 segundoformulario = new Formulario2();

            segundoformulario.Show();
        }
    }
}