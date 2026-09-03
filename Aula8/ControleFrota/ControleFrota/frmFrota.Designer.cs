namespace ControleFrota
{
    partial class frmFrota
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblEixos = new System.Windows.Forms.Label();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.txtPlaca = new System.Windows.Forms.TextBox();
            this.txtKm = new System.Windows.Forms.TextBox();
            this.txtEixos = new System.Windows.Forms.TextBox();
            this.txtCarros = new System.Windows.Forms.TextBox();
            this.txtCaminhoes = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnCaminhoes = new System.Windows.Forms.Button();
            this.btnCarros = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(48, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Modelo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(60, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Placa:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(77, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Km:";
            // 
            // lblEixos
            // 
            this.lblEixos.AutoSize = true;
            this.lblEixos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEixos.Location = new System.Drawing.Point(211, 115);
            this.lblEixos.Name = "lblEixos";
            this.lblEixos.Size = new System.Drawing.Size(49, 16);
            this.lblEixos.TabIndex = 7;
            this.lblEixos.Text = "Eixos:";
            this.lblEixos.Visible = false;
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(117, 60);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(475, 20);
            this.txtModelo.TabIndex = 8;
            // 
            // txtPlaca
            // 
            this.txtPlaca.Location = new System.Drawing.Point(117, 86);
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.Size = new System.Drawing.Size(475, 20);
            this.txtPlaca.TabIndex = 9;
            // 
            // txtKm
            // 
            this.txtKm.Location = new System.Drawing.Point(115, 112);
            this.txtKm.Name = "txtKm";
            this.txtKm.Size = new System.Drawing.Size(81, 20);
            this.txtKm.TabIndex = 10;
            // 
            // txtEixos
            // 
            this.txtEixos.Location = new System.Drawing.Point(266, 115);
            this.txtEixos.Name = "txtEixos";
            this.txtEixos.Size = new System.Drawing.Size(75, 20);
            this.txtEixos.TabIndex = 11;
            this.txtEixos.Visible = false;
            // 
            // txtCarros
            // 
            this.txtCarros.Location = new System.Drawing.Point(12, 191);
            this.txtCarros.Multiline = true;
            this.txtCarros.Name = "txtCarros";
            this.txtCarros.Size = new System.Drawing.Size(296, 233);
            this.txtCarros.TabIndex = 12;
            // 
            // txtCaminhoes
            // 
            this.txtCaminhoes.Location = new System.Drawing.Point(492, 191);
            this.txtCaminhoes.Multiline = true;
            this.txtCaminhoes.Name = "txtCaminhoes";
            this.txtCaminhoes.Size = new System.Drawing.Size(296, 233);
            this.txtCaminhoes.TabIndex = 13;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ControleFrota.Properties.Resources.Caminhao2;
            this.pictureBox2.Location = new System.Drawing.Point(492, 141);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(69, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ControleFrota.Properties.Resources.car1;
            this.pictureBox1.Location = new System.Drawing.Point(12, 141);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(59, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Image = global::ControleFrota.Properties.Resources.salvar;
            this.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalvar.Location = new System.Drawing.Point(430, 12);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(87, 42);
            this.btnSalvar.TabIndex = 2;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click); // <-- faltava isso
            // 
            // btnCaminhoes
            // 
            this.btnCaminhoes.Image = global::ControleFrota.Properties.Resources.Caminhão;
            this.btnCaminhoes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCaminhoes.Location = new System.Drawing.Point(312, 12);
            this.btnCaminhoes.Name = "btnCaminhoes";
            this.btnCaminhoes.Size = new System.Drawing.Size(100, 42);
            this.btnCaminhoes.TabIndex = 1;
            this.btnCaminhoes.Text = "Caminhões";
            this.btnCaminhoes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCaminhoes.UseVisualStyleBackColor = true;
            this.btnCaminhoes.Click += new System.EventHandler(this.btnCaminhoes_Click); // <-- falta isso
            // 
            // btnCarros
            // 
            this.btnCarros.Image = global::ControleFrota.Properties.Resources.Carro;
            this.btnCarros.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCarros.Location = new System.Drawing.Point(202, 12);
            this.btnCarros.Name = "btnCarros";
            this.btnCarros.Size = new System.Drawing.Size(90, 42);
            this.btnCarros.TabIndex = 0;
            this.btnCarros.Text = "Carros";
            this.btnCarros.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCarros.UseVisualStyleBackColor = true;
            this.btnCarros.Click += new System.EventHandler(this.btnCarros_Click);
            // 
            // frmFrota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtCaminhoes);
            this.Controls.Add(this.txtCarros);
            this.Controls.Add(this.txtEixos);
            this.Controls.Add(this.txtKm);
            this.Controls.Add(this.txtPlaca);
            this.Controls.Add(this.txtModelo);
            this.Controls.Add(this.lblEixos);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnCaminhoes);
            this.Controls.Add(this.btnCarros);
            this.Name = "frmFrota";
            this.Text = "Controle de frota";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCarros;
        private System.Windows.Forms.Button btnCaminhoes;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblEixos;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.TextBox txtPlaca;
        private System.Windows.Forms.TextBox txtKm;
        private System.Windows.Forms.TextBox txtEixos;
        private System.Windows.Forms.TextBox txtCarros;
        private System.Windows.Forms.TextBox txtCaminhoes;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

