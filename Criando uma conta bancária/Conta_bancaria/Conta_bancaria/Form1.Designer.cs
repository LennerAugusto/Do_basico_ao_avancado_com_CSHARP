namespace Conta_bancaria
{
    partial class Cadastro_conta
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
            this.txtRecebeValor = new System.Windows.Forms.TextBox();
            this.btnAbreConta = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnConsulta = new System.Windows.Forms.Button();
            this.btnDébito = new System.Windows.Forms.Button();
            this.btnCredito = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(76, 183);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Valor: ";
            // 
            // txtRecebeValor
            // 
            this.txtRecebeValor.Location = new System.Drawing.Point(152, 187);
            this.txtRecebeValor.Name = "txtRecebeValor";
            this.txtRecebeValor.Size = new System.Drawing.Size(167, 29);
            this.txtRecebeValor.TabIndex = 1;
            // 
            // btnAbreConta
            // 
            this.btnAbreConta.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAbreConta.Location = new System.Drawing.Point(401, 58);
            this.btnAbreConta.Name = "btnAbreConta";
            this.btnAbreConta.Size = new System.Drawing.Size(154, 43);
            this.btnAbreConta.TabIndex = 2;
            this.btnAbreConta.Text = "Abrir conta";
            this.btnAbreConta.UseVisualStyleBackColor = true;
            this.btnAbreConta.Click += new System.EventHandler(this.btnAbreConta_Click);
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSair.Location = new System.Drawing.Point(401, 312);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(154, 43);
            this.btnSair.TabIndex = 3;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnConsulta
            // 
            this.btnConsulta.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnConsulta.Location = new System.Drawing.Point(401, 247);
            this.btnConsulta.Name = "btnConsulta";
            this.btnConsulta.Size = new System.Drawing.Size(154, 43);
            this.btnConsulta.TabIndex = 4;
            this.btnConsulta.Text = "Consulta Saldo";
            this.btnConsulta.UseVisualStyleBackColor = true;
            this.btnConsulta.Click += new System.EventHandler(this.btnConsulta_Click);
            // 
            // btnDébito
            // 
            this.btnDébito.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDébito.Location = new System.Drawing.Point(401, 187);
            this.btnDébito.Name = "btnDébito";
            this.btnDébito.Size = new System.Drawing.Size(154, 43);
            this.btnDébito.TabIndex = 5;
            this.btnDébito.Text = "Débito";
            this.btnDébito.UseVisualStyleBackColor = true;
            this.btnDébito.Click += new System.EventHandler(this.btnDébito_Click);
            // 
            // btnCredito
            // 
            this.btnCredito.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCredito.Location = new System.Drawing.Point(401, 124);
            this.btnCredito.Name = "btnCredito";
            this.btnCredito.Size = new System.Drawing.Size(154, 43);
            this.btnCredito.TabIndex = 6;
            this.btnCredito.Text = "Crédito";
            this.btnCredito.UseVisualStyleBackColor = true;
            this.btnCredito.Click += new System.EventHandler(this.btnCredito_Click);
            // 
            // Cadastro_conta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 629);
            this.Controls.Add(this.btnCredito);
            this.Controls.Add(this.btnDébito);
            this.Controls.Add(this.btnConsulta);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnAbreConta);
            this.Controls.Add(this.txtRecebeValor);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Cadastro_conta";
            this.Text = "Cadastro conta bancária";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox txtRecebeValor;
        private Button btnAbreConta;
        private Button btnSair;
        private Button btnConsulta;
        private Button btnDébito;
        private Button btnCredito;
    }
}