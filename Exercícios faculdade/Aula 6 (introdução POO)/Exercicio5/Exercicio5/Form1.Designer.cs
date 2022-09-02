namespace Exercicio5
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtQtdde = new System.Windows.Forms.TextBox();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbProduto1 = new System.Windows.Forms.RadioButton();
            this.rdbProduto2 = new System.Windows.Forms.RadioButton();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnvisualizar = new System.Windows.Forms.Button();
            this.btnTotal = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(157, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome: ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(157, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Preço unitário:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(157, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Quantidade:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(284, 36);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(246, 23);
            this.txtNome.TabIndex = 3;
            this.txtNome.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtQtdde
            // 
            this.txtQtdde.Location = new System.Drawing.Point(284, 101);
            this.txtQtdde.Name = "txtQtdde";
            this.txtQtdde.Size = new System.Drawing.Size(246, 23);
            this.txtQtdde.TabIndex = 4;
            // 
            // txtPreco
            // 
            this.txtPreco.Location = new System.Drawing.Point(298, 161);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(232, 23);
            this.txtPreco.TabIndex = 5;
            this.txtPreco.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnvisualizar);
            this.groupBox1.Controls.Add(this.btnSalvar);
            this.groupBox1.Controls.Add(this.rdbProduto2);
            this.groupBox1.Controls.Add(this.rdbProduto1);
            this.groupBox1.Location = new System.Drawing.Point(193, 209);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(373, 127);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Selecione:";
            // 
            // rdbProduto1
            // 
            this.rdbProduto1.AutoSize = true;
            this.rdbProduto1.Location = new System.Drawing.Point(41, 37);
            this.rdbProduto1.Name = "rdbProduto1";
            this.rdbProduto1.Size = new System.Drawing.Size(77, 19);
            this.rdbProduto1.TabIndex = 0;
            this.rdbProduto1.TabStop = true;
            this.rdbProduto1.Text = "Produto 1";
            this.rdbProduto1.UseVisualStyleBackColor = true;
            // 
            // rdbProduto2
            // 
            this.rdbProduto2.AutoSize = true;
            this.rdbProduto2.Location = new System.Drawing.Point(198, 37);
            this.rdbProduto2.Name = "rdbProduto2";
            this.rdbProduto2.Size = new System.Drawing.Size(77, 19);
            this.rdbProduto2.TabIndex = 1;
            this.rdbProduto2.TabStop = true;
            this.rdbProduto2.Text = "Produto 2";
            this.rdbProduto2.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(25, 72);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(112, 33);
            this.btnSalvar.TabIndex = 2;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnvisualizar
            // 
            this.btnvisualizar.Location = new System.Drawing.Point(198, 72);
            this.btnvisualizar.Name = "btnvisualizar";
            this.btnvisualizar.Size = new System.Drawing.Size(112, 33);
            this.btnvisualizar.TabIndex = 3;
            this.btnvisualizar.Text = "Visualizar";
            this.btnvisualizar.UseVisualStyleBackColor = true;
            this.btnvisualizar.Click += new System.EventHandler(this.btnvisualizar_Click);
            // 
            // btnTotal
            // 
            this.btnTotal.Location = new System.Drawing.Point(218, 342);
            this.btnTotal.Name = "btnTotal";
            this.btnTotal.Size = new System.Drawing.Size(75, 37);
            this.btnTotal.TabIndex = 7;
            this.btnTotal.Text = "Total:";
            this.btnTotal.UseVisualStyleBackColor = true;
            this.btnTotal.Click += new System.EventHandler(this.btnTotal_Click);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(315, 350);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(136, 23);
            this.textBox4.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.btnTotal);
            this.Controls.Add(this.txtPreco);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtQtdde);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Cadastro de produtos";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtNome;
        private TextBox txtQtdde;
        private TextBox txtPreco;
        private GroupBox groupBox1;
        private Button btnvisualizar;
        private Button btnSalvar;
        private RadioButton rdbProduto2;
        private RadioButton rdbProduto1;
        private Button btnTotal;
        private TextBox textBox4;
    }
}