namespace Exercicio2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
        
            Triangulo tri1 = new Triangulo();

            tri1.baseTriangulo = double.Parse(txtBase.Text);
            tri1.alturaTriangulo = double.Parse(txtAltura.Text);

            MessageBox.Show ("¡rea do Tri‚ngulo: " + Convert.ToString(tri1.Area()));

        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            Triangulo tri1 = new Triangulo();

            tri1.baseTriangulo = double.Parse(txtBase.Text);
            tri1.alturaTriangulo = double.Parse(txtAltura.Text);

            MessageBox.Show("Base do Tri‚ngulo: " + tri1.baseTriangulo + "\nAltura do Tri‚ngulo: " + tri1.alturaTriangulo + "\n¡rea do Tr‚ngulo: " + tri1.Area());
        }
    }
}