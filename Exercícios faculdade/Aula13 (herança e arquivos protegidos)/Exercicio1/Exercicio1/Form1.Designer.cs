namespace Exercicio1
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabFuncionario = new System.Windows.Forms.TabPage();
            this.tabGerente = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNomeFunc = new System.Windows.Forms.TextBox();
            this.txtSalarioFunc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNomeGer = new System.Windows.Forms.TextBox();
            this.txtSalarioGer = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtGratificacao = new System.Windows.Forms.TextBox();
            this.btnCadastraGer = new System.Windows.Forms.Button();
            this.btnImprimeGer = new System.Windows.Forms.Button();
            this.btnCadastraFunc = new System.Windows.Forms.Button();
            this.btnImprimeFunc = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabFuncionario.SuspendLayout();
            this.tabGerente.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabFuncionario);
            this.tabControl1.Controls.Add(this.tabGerente);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(796, 445);
            this.tabControl1.TabIndex = 0;
            // 
            // tabFuncionario
            // 
            this.tabFuncionario.Controls.Add(this.btnImprimeFunc);
            this.tabFuncionario.Controls.Add(this.btnCadastraFunc);
            this.tabFuncionario.Controls.Add(this.txtSalarioFunc);
            this.tabFuncionario.Controls.Add(this.txtNomeFunc);
            this.tabFuncionario.Controls.Add(this.label2);
            this.tabFuncionario.Controls.Add(this.label1);
            this.tabFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabFuncionario.Location = new System.Drawing.Point(4, 22);
            this.tabFuncionario.Name = "tabFuncionario";
            this.tabFuncionario.Padding = new System.Windows.Forms.Padding(3);
            this.tabFuncionario.Size = new System.Drawing.Size(788, 419);
            this.tabFuncionario.TabIndex = 0;
            this.tabFuncionario.Text = "Cadastrar Funcionário";
            this.tabFuncionario.UseVisualStyleBackColor = true;
            // 
            // tabGerente
            // 
            this.tabGerente.Controls.Add(this.btnImprimeGer);
            this.tabGerente.Controls.Add(this.btnCadastraGer);
            this.tabGerente.Controls.Add(this.txtGratificacao);
            this.tabGerente.Controls.Add(this.label5);
            this.tabGerente.Controls.Add(this.txtSalarioGer);
            this.tabGerente.Controls.Add(this.txtNomeGer);
            this.tabGerente.Controls.Add(this.label4);
            this.tabGerente.Controls.Add(this.label3);
            this.tabGerente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabGerente.Location = new System.Drawing.Point(4, 22);
            this.tabGerente.Name = "tabGerente";
            this.tabGerente.Padding = new System.Windows.Forms.Padding(3);
            this.tabGerente.Size = new System.Drawing.Size(788, 419);
            this.tabGerente.TabIndex = 1;
            this.tabGerente.Text = "Cadastrar Gerente";
            this.tabGerente.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Salário:";
            // 
            // txtNomeFunc
            // 
            this.txtNomeFunc.Location = new System.Drawing.Point(174, 88);
            this.txtNomeFunc.Name = "txtNomeFunc";
            this.txtNomeFunc.Size = new System.Drawing.Size(204, 29);
            this.txtNomeFunc.TabIndex = 2;
            // 
            // txtSalarioFunc
            // 
            this.txtSalarioFunc.Location = new System.Drawing.Point(174, 177);
            this.txtSalarioFunc.Name = "txtSalarioFunc";
            this.txtSalarioFunc.Size = new System.Drawing.Size(204, 29);
            this.txtSalarioFunc.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(89, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 24);
            this.label3.TabIndex = 1;
            this.label3.Text = "Nome:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(89, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 24);
            this.label4.TabIndex = 2;
            this.label4.Text = "Salário:";
            // 
            // txtNomeGer
            // 
            this.txtNomeGer.Location = new System.Drawing.Point(196, 93);
            this.txtNomeGer.Name = "txtNomeGer";
            this.txtNomeGer.Size = new System.Drawing.Size(204, 29);
            this.txtNomeGer.TabIndex = 3;
            // 
            // txtSalarioGer
            // 
            this.txtSalarioGer.Location = new System.Drawing.Point(196, 186);
            this.txtSalarioGer.Name = "txtSalarioGer";
            this.txtSalarioGer.Size = new System.Drawing.Size(204, 29);
            this.txtSalarioGer.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(89, 268);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 24);
            this.label5.TabIndex = 5;
            this.label5.Text = "Gratificação:";
            // 
            // txtGratificacao
            // 
            this.txtGratificacao.Location = new System.Drawing.Point(196, 263);
            this.txtGratificacao.Name = "txtGratificacao";
            this.txtGratificacao.Size = new System.Drawing.Size(204, 29);
            this.txtGratificacao.TabIndex = 6;
            // 
            // btnCadastraGer
            // 
            this.btnCadastraGer.Location = new System.Drawing.Point(93, 338);
            this.btnCadastraGer.Name = "btnCadastraGer";
            this.btnCadastraGer.Size = new System.Drawing.Size(205, 63);
            this.btnCadastraGer.TabIndex = 7;
            this.btnCadastraGer.Text = "Cadastrar";
            this.btnCadastraGer.UseVisualStyleBackColor = true;
            this.btnCadastraGer.Click += new System.EventHandler(this.btnCadastraGer_Click);
            // 
            // btnImprimeGer
            // 
            this.btnImprimeGer.Location = new System.Drawing.Point(423, 338);
            this.btnImprimeGer.Name = "btnImprimeGer";
            this.btnImprimeGer.Size = new System.Drawing.Size(205, 63);
            this.btnImprimeGer.TabIndex = 8;
            this.btnImprimeGer.Text = "Imprimir Dados";
            this.btnImprimeGer.UseVisualStyleBackColor = true;
            this.btnImprimeGer.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCadastraFunc
            // 
            this.btnCadastraFunc.Location = new System.Drawing.Point(70, 319);
            this.btnCadastraFunc.Name = "btnCadastraFunc";
            this.btnCadastraFunc.Size = new System.Drawing.Size(205, 63);
            this.btnCadastraFunc.TabIndex = 8;
            this.btnCadastraFunc.Text = "Cadastrar";
            this.btnCadastraFunc.UseVisualStyleBackColor = true;
            this.btnCadastraFunc.Click += new System.EventHandler(this.btnCadastraFunc_Click);
            // 
            // btnImprimeFunc
            // 
            this.btnImprimeFunc.Location = new System.Drawing.Point(424, 319);
            this.btnImprimeFunc.Name = "btnImprimeFunc";
            this.btnImprimeFunc.Size = new System.Drawing.Size(205, 63);
            this.btnImprimeFunc.TabIndex = 9;
            this.btnImprimeFunc.Text = "Imprimir Dados";
            this.btnImprimeFunc.UseVisualStyleBackColor = true;
            this.btnImprimeFunc.Click += new System.EventHandler(this.btnImprimeFunc_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabFuncionario.ResumeLayout(false);
            this.tabFuncionario.PerformLayout();
            this.tabGerente.ResumeLayout(false);
            this.tabGerente.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabFuncionario;
        private System.Windows.Forms.TabPage tabGerente;
        private System.Windows.Forms.TextBox txtSalarioFunc;
        private System.Windows.Forms.TextBox txtNomeFunc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnImprimeGer;
        private System.Windows.Forms.Button btnCadastraGer;
        private System.Windows.Forms.TextBox txtGratificacao;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSalarioGer;
        private System.Windows.Forms.TextBox txtNomeGer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnImprimeFunc;
        private System.Windows.Forms.Button btnCadastraFunc;
    }
}

