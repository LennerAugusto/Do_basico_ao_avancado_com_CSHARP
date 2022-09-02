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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLado = new System.Windows.Forms.TextBox();
            this.txtCalculaPerimetro = new System.Windows.Forms.Button();
            this.txtImprimir = new System.Windows.Forms.Button();
            this.txtcalculaArea = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(242, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(315, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Atributos do quadrado:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(220, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Lado:";
            // 
            // txtLado
            // 
            this.txtLado.Location = new System.Drawing.Point(296, 115);
            this.txtLado.Name = "txtLado";
            this.txtLado.Size = new System.Drawing.Size(238, 23);
            this.txtLado.TabIndex = 2;
            // 
            // txtCalculaPerimetro
            // 
            this.txtCalculaPerimetro.Location = new System.Drawing.Point(305, 233);
            this.txtCalculaPerimetro.Name = "txtCalculaPerimetro";
            this.txtCalculaPerimetro.Size = new System.Drawing.Size(171, 65);
            this.txtCalculaPerimetro.TabIndex = 3;
            this.txtCalculaPerimetro.Text = "Calcular Perímetro";
            this.txtCalculaPerimetro.UseVisualStyleBackColor = true;
            this.txtCalculaPerimetro.Click += new System.EventHandler(this.txtCalculaPerimetro_Click);
            // 
            // txtImprimir
            // 
            this.txtImprimir.Location = new System.Drawing.Point(587, 233);
            this.txtImprimir.Name = "txtImprimir";
            this.txtImprimir.Size = new System.Drawing.Size(175, 65);
            this.txtImprimir.TabIndex = 4;
            this.txtImprimir.Text = "Imrpimir dados";
            this.txtImprimir.UseVisualStyleBackColor = true;
            this.txtImprimir.Click += new System.EventHandler(this.txtImprimir_Click);
            // 
            // txtcalculaArea
            // 
            this.txtcalculaArea.Location = new System.Drawing.Point(41, 233);
            this.txtcalculaArea.Name = "txtcalculaArea";
            this.txtcalculaArea.Size = new System.Drawing.Size(175, 65);
            this.txtcalculaArea.TabIndex = 5;
            this.txtcalculaArea.Text = "Calcular Área";
            this.txtcalculaArea.UseVisualStyleBackColor = false;
            this.txtcalculaArea.Click += new System.EventHandler(this.txtcalculaArea_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtcalculaArea);
            this.Controls.Add(this.txtImprimir);
            this.Controls.Add(this.txtCalculaPerimetro);
            this.Controls.Add(this.txtLado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Quadrado:";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtLado;
        private Button txtCalculaPerimetro;
        private Button txtImprimir;
        private Button txtcalculaArea;
    }
}