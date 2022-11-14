namespace Exercicio2
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabCadastrar = new System.Windows.Forms.TabPage();
            this.tabVender = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtQtde = new System.Windows.Forms.TextBox();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnMostraEstoque = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.tabCadastrar.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabCadastrar);
            this.tabControl.Controls.Add(this.tabVender);
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1013, 584);
            this.tabControl.TabIndex = 0;
            // 
            // tabCadastrar
            // 
            this.tabCadastrar.Controls.Add(this.btnMostraEstoque);
            this.tabCadastrar.Controls.Add(this.btnCadastrar);
            this.tabCadastrar.Controls.Add(this.txtPreco);
            this.tabCadastrar.Controls.Add(this.txtQtde);
            this.tabCadastrar.Controls.Add(this.txtNome);
            this.tabCadastrar.Controls.Add(this.label4);
            this.tabCadastrar.Controls.Add(this.label3);
            this.tabCadastrar.Controls.Add(this.label2);
            this.tabCadastrar.Controls.Add(this.label1);
            this.tabCadastrar.Location = new System.Drawing.Point(4, 30);
            this.tabCadastrar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabCadastrar.Name = "tabCadastrar";
            this.tabCadastrar.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabCadastrar.Size = new System.Drawing.Size(1005, 550);
            this.tabCadastrar.TabIndex = 0;
            this.tabCadastrar.Text = "Cadastrar e consultar produtos";
            this.tabCadastrar.UseVisualStyleBackColor = true;
            this.tabCadastrar.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // tabVender
            // 
            this.tabVender.Location = new System.Drawing.Point(4, 30);
            this.tabVender.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabVender.Name = "tabVender";
            this.tabVender.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabVender.Size = new System.Drawing.Size(1005, 550);
            this.tabVender.TabIndex = 1;
            this.tabVender.Text = "Comprar produtos";
            this.tabVender.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(57, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastrar Refrigerante";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(57, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Marca:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(57, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Preço:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(57, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(179, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Quantidade em estoque:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(119, 69);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(204, 29);
            this.txtNome.TabIndex = 4;
            // 
            // txtQtde
            // 
            this.txtQtde.Location = new System.Drawing.Point(242, 153);
            this.txtQtde.Name = "txtQtde";
            this.txtQtde.Size = new System.Drawing.Size(81, 29);
            this.txtQtde.TabIndex = 5;
            // 
            // txtPreco
            // 
            this.txtPreco.Location = new System.Drawing.Point(119, 108);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(204, 29);
            this.txtPreco.TabIndex = 6;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(379, 69);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(156, 44);
            this.btnCadastrar.TabIndex = 7;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnMostraEstoque
            // 
            this.btnMostraEstoque.Location = new System.Drawing.Point(379, 138);
            this.btnMostraEstoque.Name = "btnMostraEstoque";
            this.btnMostraEstoque.Size = new System.Drawing.Size(156, 44);
            this.btnMostraEstoque.TabIndex = 8;
            this.btnMostraEstoque.Text = "Mostrar estoque";
            this.btnMostraEstoque.UseVisualStyleBackColor = true;
            this.btnMostraEstoque.Click += new System.EventHandler(this.btnMostraEstoque_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 630);
            this.Controls.Add(this.tabControl);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl.ResumeLayout(false);
            this.tabCadastrar.ResumeLayout(false);
            this.tabCadastrar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl;
        private TabPage tabCadastrar;
        private TabPage tabVender;
        private Button btnCadastrar;
        private TextBox txtPreco;
        private TextBox txtQtde;
        private TextBox txtNome;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnMostraEstoque;
    }
}