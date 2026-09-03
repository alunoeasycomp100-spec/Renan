namespace CadastroClientes
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
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtRG = new System.Windows.Forms.TextBox();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.txtPessoaFisica = new System.Windows.Forms.TextBox();
            this.txtCPF = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnJuridica = new System.Windows.Forms.Button();
            this.btnFisica = new System.Windows.Forms.Button();
            this.pnlFisica = new System.Windows.Forms.Panel();
            this.pnlJuridica = new System.Windows.Forms.Panel();
            this.txtPessoaJuridica = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNomeJur = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCNPJ = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtEnderecoJur = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtIE = new System.Windows.Forms.TextBox();
            this.pnlFisica.SuspendLayout();
            this.pnlJuridica.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(86, 25);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(363, 20);
            this.txtNome.TabIndex = 3;
            // 
            // txtRG
            // 
            this.txtRG.Location = new System.Drawing.Point(86, 77);
            this.txtRG.Name = "txtRG";
            this.txtRG.Size = new System.Drawing.Size(167, 20);
            this.txtRG.TabIndex = 4;
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(86, 51);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(363, 20);
            this.txtEndereco.TabIndex = 5;
            // 
            // txtPessoaFisica
            // 
            this.txtPessoaFisica.Location = new System.Drawing.Point(11, 117);
            this.txtPessoaFisica.Multiline = true;
            this.txtPessoaFisica.Name = "txtPessoaFisica";
            this.txtPessoaFisica.Size = new System.Drawing.Size(526, 206);
            this.txtPessoaFisica.TabIndex = 6;
            // 
            // txtCPF
            // 
            this.txtCPF.Location = new System.Drawing.Point(333, 78);
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(116, 20);
            this.txtCPF.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "Endereço:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "RG:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(290, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "CPF:";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Image = global::CadastroClientes.Properties.Resources.checklist__1_;
            this.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalvar.Location = new System.Drawing.Point(370, 21);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 47);
            this.btnSalvar.TabIndex = 2;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnJuridica
            // 
            this.btnJuridica.Image = global::CadastroClientes.Properties.Resources.PessoaJurídica2;
            this.btnJuridica.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnJuridica.Location = new System.Drawing.Point(248, 21);
            this.btnJuridica.Name = "btnJuridica";
            this.btnJuridica.Size = new System.Drawing.Size(81, 47);
            this.btnJuridica.TabIndex = 1;
            this.btnJuridica.Text = "Pessoa Jurídica";
            this.btnJuridica.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnJuridica.UseVisualStyleBackColor = true;
            this.btnJuridica.Click += new System.EventHandler(this.btnJuridica_Click);
            // 
            // btnFisica
            // 
            this.btnFisica.Image = global::CadastroClientes.Properties.Resources.PessoaFisica;
            this.btnFisica.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFisica.Location = new System.Drawing.Point(131, 21);
            this.btnFisica.Name = "btnFisica";
            this.btnFisica.Size = new System.Drawing.Size(75, 47);
            this.btnFisica.TabIndex = 0;
            this.btnFisica.Text = "Pessoa Física";
            this.btnFisica.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFisica.UseVisualStyleBackColor = true;
            this.btnFisica.Click += new System.EventHandler(this.btnFisica_Click);
            // 
            // pnlFisica
            // 
            this.pnlFisica.Controls.Add(this.txtPessoaFisica);
            this.pnlFisica.Controls.Add(this.label4);
            this.pnlFisica.Controls.Add(this.txtNome);
            this.pnlFisica.Controls.Add(this.label3);
            this.pnlFisica.Controls.Add(this.txtRG);
            this.pnlFisica.Controls.Add(this.label2);
            this.pnlFisica.Controls.Add(this.txtEndereco);
            this.pnlFisica.Controls.Add(this.label1);
            this.pnlFisica.Controls.Add(this.txtCPF);
            this.pnlFisica.Location = new System.Drawing.Point(29, 98);
            this.pnlFisica.Name = "pnlFisica";
            this.pnlFisica.Size = new System.Drawing.Size(548, 342);
            this.pnlFisica.TabIndex = 12;
            this.pnlFisica.Visible = false;
            // 
            // pnlJuridica
            // 
            this.pnlJuridica.Controls.Add(this.txtPessoaJuridica);
            this.pnlJuridica.Controls.Add(this.label5);
            this.pnlJuridica.Controls.Add(this.txtNomeJur);
            this.pnlJuridica.Controls.Add(this.label6);
            this.pnlJuridica.Controls.Add(this.txtCNPJ);
            this.pnlJuridica.Controls.Add(this.label7);
            this.pnlJuridica.Controls.Add(this.txtEnderecoJur);
            this.pnlJuridica.Controls.Add(this.label8);
            this.pnlJuridica.Controls.Add(this.txtIE);
            this.pnlJuridica.Location = new System.Drawing.Point(32, 95);
            this.pnlJuridica.Name = "pnlJuridica";
            this.pnlJuridica.Size = new System.Drawing.Size(548, 342);
            this.pnlJuridica.TabIndex = 13;
            this.pnlJuridica.Visible = false;
            // 
            // txtPessoaJuridica
            // 
            this.txtPessoaJuridica.Location = new System.Drawing.Point(11, 117);
            this.txtPessoaJuridica.Multiline = true;
            this.txtPessoaJuridica.Name = "txtPessoaJuridica";
            this.txtPessoaJuridica.Size = new System.Drawing.Size(526, 206);
            this.txtPessoaJuridica.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(290, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "IE:";
            // 
            // txtNomeJur
            // 
            this.txtNomeJur.Location = new System.Drawing.Point(86, 25);
            this.txtNomeJur.Name = "txtNomeJur";
            this.txtNomeJur.Size = new System.Drawing.Size(363, 20);
            this.txtNomeJur.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(8, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "CNPJ:";
            // 
            // txtCNPJ
            // 
            this.txtCNPJ.Location = new System.Drawing.Point(86, 77);
            this.txtCNPJ.Name = "txtCNPJ";
            this.txtCNPJ.Size = new System.Drawing.Size(167, 20);
            this.txtCNPJ.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(8, 51);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 15);
            this.label7.TabIndex = 9;
            this.label7.Text = "Endereço:";
            // 
            // txtEnderecoJur
            // 
            this.txtEnderecoJur.Location = new System.Drawing.Point(86, 51);
            this.txtEnderecoJur.Name = "txtEnderecoJur";
            this.txtEnderecoJur.Size = new System.Drawing.Size(363, 20);
            this.txtEnderecoJur.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(8, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 15);
            this.label8.TabIndex = 8;
            this.label8.Text = "Nome:";
            // 
            // txtIE
            // 
            this.txtIE.Location = new System.Drawing.Point(333, 78);
            this.txtIE.Name = "txtIE";
            this.txtIE.Size = new System.Drawing.Size(116, 20);
            this.txtIE.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 463);
            this.Controls.Add(this.pnlJuridica);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnJuridica);
            this.Controls.Add(this.btnFisica);
            this.Controls.Add(this.pnlFisica);
            this.Name = "Form1";
            this.Text = "Cadastro de Clientes";
            this.pnlFisica.ResumeLayout(false);
            this.pnlFisica.PerformLayout();
            this.pnlJuridica.ResumeLayout(false);
            this.pnlJuridica.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFisica;
        private System.Windows.Forms.Button btnJuridica;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtRG;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.TextBox txtPessoaFisica;
        private System.Windows.Forms.TextBox txtCPF;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel pnlFisica;
        private System.Windows.Forms.Panel pnlJuridica;
        private System.Windows.Forms.TextBox txtPessoaJuridica;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNomeJur;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCNPJ;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtEnderecoJur;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtIE;
    }
}

