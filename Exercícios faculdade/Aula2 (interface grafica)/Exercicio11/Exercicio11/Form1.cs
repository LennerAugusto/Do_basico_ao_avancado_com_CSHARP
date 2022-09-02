namespace Exercicio11
{
    public partial class Form1 : Form
    {
        int a, b, c;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClick_Click(object sender, EventArgs e)
        {
            a = Int32.Parse(txtBox1.Text);
            b = Int32.Parse(txtBox2.Text);
            c = Int32.Parse(txtBox3.Text);

            if (a > b && a > c)
            {
                a = mairo
            }

            if(a > b && a < c)
            {
                a = medio;
            }

            if(a < b && a < c )
            {
                a = menor;
            }

            if (b > a && b > c)
            {
                b = maior;
            }

            if (b > a && b < c)
            {
                b = medio;
            }

            if (b < a && b < c)
            {
                b = menor;
            }

            if (c > a && c > b)
            {
                c = maior;
            }

            if (c > a && c < b)
            {
                c = medio;
            }

            if (c < a &&  c < b)
            {
                c = menor;
            }


            
        }
    }
}