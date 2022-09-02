namespace Exercicio1
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
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDep = new System.Windows.Forms.TextBox();
            this.txtHoras = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSalarioPorHora = new System.Windows.Forms.TextBox();
            this.calculaSalario = new System.Windows.Forms.Button();
            this.mostraDados = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(339, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dados do Funcionário:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(268, 87);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(221, 23);
            this.txtNome.TabIndex = 1;
            this.txtNome.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(44, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nome: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(44, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 32);
            this.label3.TabIndex = 3;
            this.label3.Text = "Departamento:";
            // 
            // txtDep
            // 
            this.txtDep.Location = new System.Drawing.Point(268, 150);
            this.txtDep.Name = "txtDep";
            this.txtDep.Size = new System.Drawing.Size(221, 23);
            this.txtDep.TabIndex = 4;
            // 
            // txtHoras
            // 
            this.txtHoras.Location = new System.Drawing.Point(345, 219);
            this.txtHoras.Name = "txtHoras";
            this.txtHoras.Size = new System.Drawing.Size(144, 23);
            this.txtHoras.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(44, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(295, 32);
            this.label4.TabIndex = 6;
            this.label4.Text = "Horas trabalhadas no mês:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(44, 276);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(188, 32);
            this.label5.TabIndex = 7;
            this.label5.Text = "Salário por hora:";
            // 
            // txtSalarioPorHora
            // 
            this.txtSalarioPorHora.Location = new System.Drawing.Point(268, 287);
            this.txtSalarioPorHora.Name = "txtSalarioPorHora";
            this.txtSalarioPorHora.Size = new System.Drawing.Size(221, 23);
            this.txtSalarioPorHora.TabIndex = 8;
            // 
            // calculaSalario
            // 
            this.calculaSalario.Location = new System.Drawing.Point(596, 331);
            this.calculaSalario.Name = "calculaSalario";
            this.calculaSalario.Size = new System.Drawing.Size(143, 50);
            this.calculaSalario.TabIndex = 9;
            this.calculaSalario.Text = "Calcular salário";
            this.calculaSalario.UseVisualStyleBackColor = true;
            this.calculaSalario.Click += new System.EventHandler(this.calculaSalario_Click);
            // 
            // mostraDados
            // 
            this.mostraDados.Location = new System.Drawing.Point(61, 331);
            this.mostraDados.Name = "mostraDados";
            this.mostraDados.Size = new System.Drawing.Size(156, 50);
            this.mostraDados.TabIndex = 10;
            this.mostraDados.Text = "Mostrar dados";
            this.mostraDados.UseVisualStyleBackColor = true;
            this.mostraDados.Click += new System.EventHandler(this.mostraDados_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mostraDados);
            this.Controls.Add(this.calculaSalario);
            this.Controls.Add(this.txtSalarioPorHora);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtHoras);
            this.Controls.Add(this.txtDep);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox txtNome;
        private Label label2;
        private Label label3;
        private TextBox txtDep;
        private TextBox txtHoras;
        private Label label4;
        private Label label5;
        private TextBox txtSalarioPorHora;
        private Button calculaSalario;
        private Button mostraDados;
    }
}