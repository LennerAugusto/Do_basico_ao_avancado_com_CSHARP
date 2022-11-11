using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio_Teste_novo_componente_
{
    public partial class Form1 : Form
    {
        List<Pessoa> pessoas = new List<Pessoa>();

        Pessoa pessoa1 = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            pessoa1 = new Pessoa();

            pessoa1.Nome = txtNome.Text;
            pessoa1.Idade = int.Parse(txtIdade.Text);

            pessoas.Add(pessoa1);
            txtNome.Clear();
            txtIdade.Clear();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            int i;
            dgvPessoas.Rows.Clear();
            for(i=0; i<pessoas.Count; i++)
            {
                dgvPessoas.Rows.Add(pessoas[i].Nome, pessoas[i].Idade);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

            if(pessoas.Count == 0)
            {
                MessageBox.Show("Nenhuma pessoa para excluir");
            }
            else
            {
                int indiceLinha = dgvPessoas.CurrentRow.Index;

                pessoas.RemoveAt(indiceLinha);

                btnListar.PerformClick();
            }
            
        }
    }
}
