namespace PrimeiroAplicativo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            chkPessoaJuridica = new CheckBox();
            chkPessoaFísica = new CheckBox();
            pnlPessoaFisica = new Panel();
            textBox2 = new TextBox();
            label2 = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            pnlPessoaJuridica = new Panel();
            textBox3 = new TextBox();
            label3 = new Label();
            textBox4 = new TextBox();
            label4 = new Label();
            btnImagens = new Button();
            pnlPessoaFisica.SuspendLayout();
            pnlPessoaJuridica.SuspendLayout();
            SuspendLayout();
            // 
            // chkPessoaJuridica
            // 
            chkPessoaJuridica.AutoSize = true;
            chkPessoaJuridica.Location = new Point(74, 83);
            chkPessoaJuridica.Name = "chkPessoaJuridica";
            chkPessoaJuridica.Size = new Size(105, 19);
            chkPessoaJuridica.TabIndex = 0;
            chkPessoaJuridica.Text = "Pessoa Jurídica";
            chkPessoaJuridica.UseVisualStyleBackColor = true;
            chkPessoaJuridica.CheckedChanged += chkPessoaJuridica_CheckedChanged;
            // 
            // chkPessoaFísica
            // 
            chkPessoaFísica.AutoSize = true;
            chkPessoaFísica.Location = new Point(73, 137);
            chkPessoaFísica.Name = "chkPessoaFísica";
            chkPessoaFísica.Size = new Size(94, 19);
            chkPessoaFísica.TabIndex = 1;
            chkPessoaFísica.Text = "Pessoa Física";
            chkPessoaFísica.UseVisualStyleBackColor = true;
            chkPessoaFísica.CheckedChanged += chkPessoaFísica_CheckedChanged;
            chkPessoaFísica.CheckStateChanged += chkPessoaFísica_CheckStateChanged;
            // 
            // pnlPessoaFisica
            // 
            pnlPessoaFisica.BorderStyle = BorderStyle.FixedSingle;
            pnlPessoaFisica.Controls.Add(textBox2);
            pnlPessoaFisica.Controls.Add(label2);
            pnlPessoaFisica.Controls.Add(textBox1);
            pnlPessoaFisica.Controls.Add(label1);
            pnlPessoaFisica.Location = new Point(382, 62);
            pnlPessoaFisica.Name = "pnlPessoaFisica";
            pnlPessoaFisica.Size = new Size(200, 100);
            pnlPessoaFisica.TabIndex = 2;
            pnlPessoaFisica.Visible = false;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(79, 54);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 54);
            label2.Name = "label2";
            label2.Size = new Size(31, 15);
            label2.TabIndex = 2;
            label2.Text = "CPF:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(79, 25);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 25);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 0;
            label1.Text = "Nome";
            // 
            // pnlPessoaJuridica
            // 
            pnlPessoaJuridica.BorderStyle = BorderStyle.FixedSingle;
            pnlPessoaJuridica.Controls.Add(textBox3);
            pnlPessoaJuridica.Controls.Add(label3);
            pnlPessoaJuridica.Controls.Add(textBox4);
            pnlPessoaJuridica.Controls.Add(label4);
            pnlPessoaJuridica.Location = new Point(382, 193);
            pnlPessoaJuridica.Name = "pnlPessoaJuridica";
            pnlPessoaJuridica.Size = new Size(200, 100);
            pnlPessoaJuridica.TabIndex = 4;
            pnlPessoaJuridica.Visible = false;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(79, 54);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(33, 54);
            label3.Name = "label3";
            label3.Size = new Size(47, 20);
            label3.TabIndex = 2;
            label3.Text = "CNPJ:";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(79, 25);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(33, 25);
            label4.Name = "label4";
            label4.Size = new Size(40, 15);
            label4.TabIndex = 0;
            label4.Text = "Nome";
            // 
            // btnImagens
            // 
            btnImagens.Location = new Point(223, 15);
            btnImagens.Name = "btnImagens";
            btnImagens.Size = new Size(75, 23);
            btnImagens.TabIndex = 5;
            btnImagens.Text = "Imagens";
            btnImagens.UseVisualStyleBackColor = true;
            btnImagens.Click += btnImagens_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnImagens);
            Controls.Add(pnlPessoaJuridica);
            Controls.Add(pnlPessoaFisica);
            Controls.Add(chkPessoaFísica);
            Controls.Add(chkPessoaJuridica);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Propriedades do CheckBox";
            pnlPessoaFisica.ResumeLayout(false);
            pnlPessoaFisica.PerformLayout();
            pnlPessoaJuridica.ResumeLayout(false);
            pnlPessoaJuridica.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox chkPessoaJuridica;
        private CheckBox chkPessoaFísica;
        private Panel pnlPessoaFisica;
        private Panel pnlPessoaJuridica;
        private TextBox textBox3;
        private Label label3;
        private TextBox textBox4;
        private Label label4;
        private TextBox textBox2;
        private Label label2;
        private TextBox textBox1;
        private Label label1;
        private Button btnImagens;
    }
}
