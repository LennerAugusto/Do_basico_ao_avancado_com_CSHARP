namespace Exercicio1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void formulToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formulario1 Form1 = new formulario1();

            Form1.Show();
        }

        private void segundoFormulárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formulario2 Form1 = new formulario2();

            Form1.Show();

        }
    }
}