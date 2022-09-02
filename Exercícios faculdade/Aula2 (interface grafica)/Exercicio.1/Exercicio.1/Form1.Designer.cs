namespace Exercicio._1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbDobrar = new System.Windows.Forms.RadioButton();
            this.rdbTriplicar = new System.Windows.Forms.RadioButton();
            this.txtLeitura = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAplicar = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbTriplicar);
            this.groupBox1.Controls.Add(this.rdbDobrar);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(255, 236);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Selecione";
            // 
            // rdbDobrar
            // 
            this.rdbDobrar.AutoSize = true;
            this.rdbDobrar.Location = new System.Drawing.Point(23, 69);
            this.rdbDobrar.Name = "rdbDobrar";
            this.rdbDobrar.Size = new System.Drawing.Size(77, 25);
            this.rdbDobrar.TabIndex = 0;
            this.rdbDobrar.TabStop = true;
            this.rdbDobrar.Text = "Dobrar";
            this.rdbDobrar.UseVisualStyleBackColor = true;
            // 
            // rdbTriplicar
            // 
            this.rdbTriplicar.AutoSize = true;
            this.rdbTriplicar.Location = new System.Drawing.Point(23, 150);
            this.rdbTriplicar.Name = "rdbTriplicar";
            this.rdbTriplicar.Size = new System.Drawing.Size(83, 25);
            this.rdbTriplicar.TabIndex = 1;
            this.rdbTriplicar.TabStop = true;
            this.rdbTriplicar.Text = "Triplicar";
            this.rdbTriplicar.UseVisualStyleBackColor = true;
            // 
            // txtLeitura
            // 
            this.txtLeitura.Location = new System.Drawing.Point(347, 150);
            this.txtLeitura.Name = "txtLeitura";
            this.txtLeitura.Size = new System.Drawing.Size(232, 23);
            this.txtLeitura.TabIndex = 2;
            this.txtLeitura.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(347, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Digite um número:";
            // 
            // btnAplicar
            // 
            this.btnAplicar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAplicar.Location = new System.Drawing.Point(618, 130);
            this.btnAplicar.Name = "btnAplicar";
            this.btnAplicar.Size = new System.Drawing.Size(170, 65);
            this.btnAplicar.TabIndex = 4;
            this.btnAplicar.Text = "Aplicar";
            this.btnAplicar.UseVisualStyleBackColor = true;
            this.btnAplicar.Click += new System.EventHandler(this.btnAplicar_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblResultado.Location = new System.Drawing.Point(347, 261);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(140, 37);
            this.lblResultado.TabIndex = 5;
            this.lblResultado.Text = "Resultado:";
            // 
            // txtResultado
            // 
            this.txtResultado.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtResultado.Location = new System.Drawing.Point(347, 334);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(232, 29);
            this.txtResultado.TabIndex = 6;
            this.txtResultado.TextChanged += new System.EventHandler(this.txtResultado_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnAplicar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtLeitura);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox groupBox1;
        private RadioButton rdbTriplicar;
        private RadioButton rdbDobrar;
        private TextBox txtLeitura;
        private Label label1;
        private Button btnAplicar;
        private Label lblResultado;
        private TextBox txtResultado;
    }
}