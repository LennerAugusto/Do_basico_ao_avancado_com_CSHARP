namespace Exercicio2
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
            this.tabPrincipal = new System.Windows.Forms.TabControl();
            this.tabNovo = new System.Windows.Forms.TabPage();
            this.tabVelho = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.txtAdicional = new System.Windows.Forms.TextBox();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.txtEnderecoVelho = new System.Windows.Forms.TextBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.txtPrecoVelho = new System.Windows.Forms.TextBox();
            this.txtDesconto = new System.Windows.Forms.TextBox();
            this.tabPrincipal.SuspendLayout();
            this.tabNovo.SuspendLayout();
            this.tabVelho.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPrincipal
            // 
            this.tabPrincipal.Controls.Add(this.tabNovo);
            this.tabPrincipal.Controls.Add(this.tabVelho);
            this.tabPrincipal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPrincipal.Location = new System.Drawing.Point(-2, 12);
            this.tabPrincipal.Name = "tabPrincipal";
            this.tabPrincipal.SelectedIndex = 0;
            this.tabPrincipal.Size = new System.Drawing.Size(802, 315);
            this.tabPrincipal.TabIndex = 0;
            // 
            // tabNovo
            // 
            this.tabNovo.Controls.Add(this.txtPreco);
            this.tabNovo.Controls.Add(this.txtAdicional);
            this.tabNovo.Controls.Add(this.txtEndereco);
            this.tabNovo.Controls.Add(this.label3);
            this.tabNovo.Controls.Add(this.label2);
            this.tabNovo.Controls.Add(this.label1);
            this.tabNovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabNovo.Location = new System.Drawing.Point(4, 33);
            this.tabNovo.Name = "tabNovo";
            this.tabNovo.Padding = new System.Windows.Forms.Padding(3);
            this.tabNovo.Size = new System.Drawing.Size(794, 278);
            this.tabNovo.TabIndex = 0;
            this.tabNovo.Text = "Imóvel novo";
            this.tabNovo.UseVisualStyleBackColor = true;
            // 
            // tabVelho
            // 
            this.tabVelho.Controls.Add(this.txtDesconto);
            this.tabVelho.Controls.Add(this.txtPrecoVelho);
            this.tabVelho.Controls.Add(this.txtEnderecoVelho);
            this.tabVelho.Controls.Add(this.label6);
            this.tabVelho.Controls.Add(this.label5);
            this.tabVelho.Controls.Add(this.label4);
            this.tabVelho.Location = new System.Drawing.Point(4, 33);
            this.tabVelho.Name = "tabVelho";
            this.tabVelho.Padding = new System.Windows.Forms.Padding(3);
            this.tabVelho.Size = new System.Drawing.Size(794, 278);
            this.tabVelho.TabIndex = 1;
            this.tabVelho.Text = "Imóvel usado";
            this.tabVelho.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(102, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Endereço:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(102, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Preço:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(102, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Adicional:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(103, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 24);
            this.label4.TabIndex = 1;
            this.label4.Text = "Endereço:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(107, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 24);
            this.label5.TabIndex = 2;
            this.label5.Text = "Preço:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(107, 189);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 24);
            this.label6.TabIndex = 3;
            this.label6.Text = "Desconto:";
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(228, 93);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(254, 31);
            this.txtEndereco.TabIndex = 3;
            // 
            // txtAdicional
            // 
            this.txtAdicional.Location = new System.Drawing.Point(228, 200);
            this.txtAdicional.Name = "txtAdicional";
            this.txtAdicional.Size = new System.Drawing.Size(254, 31);
            this.txtAdicional.TabIndex = 4;
            // 
            // txtPreco
            // 
            this.txtPreco.Location = new System.Drawing.Point(228, 149);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(254, 31);
            this.txtPreco.TabIndex = 5;
            // 
            // txtEnderecoVelho
            // 
            this.txtEnderecoVelho.Location = new System.Drawing.Point(226, 93);
            this.txtEnderecoVelho.Name = "txtEnderecoVelho";
            this.txtEnderecoVelho.Size = new System.Drawing.Size(254, 29);
            this.txtEnderecoVelho.TabIndex = 4;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.Location = new System.Drawing.Point(109, 359);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(179, 60);
            this.btnCadastrar.TabIndex = 5;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.Location = new System.Drawing.Point(446, 359);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(179, 60);
            this.btnImprimir.TabIndex = 6;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // txtPrecoVelho
            // 
            this.txtPrecoVelho.Location = new System.Drawing.Point(226, 140);
            this.txtPrecoVelho.Name = "txtPrecoVelho";
            this.txtPrecoVelho.Size = new System.Drawing.Size(254, 29);
            this.txtPrecoVelho.TabIndex = 5;
            // 
            // txtDesconto
            // 
            this.txtDesconto.Location = new System.Drawing.Point(226, 189);
            this.txtDesconto.Name = "txtDesconto";
            this.txtDesconto.Size = new System.Drawing.Size(254, 29);
            this.txtDesconto.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.tabPrincipal);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabPrincipal.ResumeLayout(false);
            this.tabNovo.ResumeLayout(false);
            this.tabNovo.PerformLayout();
            this.tabVelho.ResumeLayout(false);
            this.tabVelho.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabPrincipal;
        private System.Windows.Forms.TabPage tabNovo;
        private System.Windows.Forms.TabPage tabVelho;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.TextBox txtAdicional;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEnderecoVelho;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.TextBox txtDesconto;
        private System.Windows.Forms.TextBox txtPrecoVelho;
    }
}

