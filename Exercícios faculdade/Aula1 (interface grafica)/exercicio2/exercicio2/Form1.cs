namespace exercicio2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClick_Click(object sender, EventArgs e)
        {
            btnClick.Enabled = false;
            btnClick.Text = "Estou desabilitado, pois clicaram em mim!";
        }
    }
}