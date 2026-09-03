namespace PrimeiroAplicativo
{
    partial class frmVisualizadorImagens
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVisualizadorImagens));
            pictureBox1 = new PictureBox();
            pblmagens = new PictureBox();
            rbStretch = new RadioButton();
            rbNormal = new RadioButton();
            ofdImagens = new OpenFileDialog();
            btnMostrarImagem = new Button();
            btnLimparImagem = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pblmagens).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.moldura;
            pictureBox1.Location = new Point(0, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(538, 407);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pblmagens
            // 
            pblmagens.Location = new Point(85, 86);
            pblmagens.Name = "pblmagens";
            pblmagens.Size = new Size(371, 235);
            pblmagens.SizeMode = PictureBoxSizeMode.StretchImage;
            pblmagens.TabIndex = 1;
            pblmagens.TabStop = false;
            // 
            // rbStretch
            // 
            rbStretch.AutoSize = true;
            rbStretch.Location = new Point(293, 419);
            rbStretch.Name = "rbStretch";
            rbStretch.Size = new Size(62, 19);
            rbStretch.TabIndex = 2;
            rbStretch.TabStop = true;
            rbStretch.Text = "Stretch";
            rbStretch.UseVisualStyleBackColor = true;
            rbStretch.CheckedChanged += rbStretch_CheckedChanged;
            // 
            // rbNormal
            // 
            rbNormal.AutoSize = true;
            rbNormal.Location = new Point(421, 421);
            rbNormal.Name = "rbNormal";
            rbNormal.Size = new Size(65, 19);
            rbNormal.TabIndex = 3;
            rbNormal.TabStop = true;
            rbNormal.Text = "Normal";
            rbNormal.UseVisualStyleBackColor = true;
            rbNormal.CheckedChanged += rbNormal_CheckedChanged;
            // 
            // ofdImagens
            // 
            ofdImagens.FileName = "openFileDialog1";
            // 
            // btnMostrarImagem
            // 
            btnMostrarImagem.Location = new Point(30, 423);
            btnMostrarImagem.Name = "btnMostrarImagem";
            btnMostrarImagem.Size = new Size(119, 23);
            btnMostrarImagem.TabIndex = 4;
            btnMostrarImagem.Text = "Mostrar imagem";
            btnMostrarImagem.UseVisualStyleBackColor = true;
            btnMostrarImagem.Click += btnMostrarImagem_Click;
            // 
            // btnLimparImagem
            // 
            btnLimparImagem.Location = new Point(155, 423);
            btnLimparImagem.Name = "btnLimparImagem";
            btnLimparImagem.Size = new Size(118, 23);
            btnLimparImagem.TabIndex = 5;
            btnLimparImagem.Text = "Limpar imagem";
            btnLimparImagem.UseVisualStyleBackColor = true;
            btnLimparImagem.Click += button2_Click;
            // 
            // frmVisualizadorImagens
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(527, 450);
            Controls.Add(btnLimparImagem);
            Controls.Add(btnMostrarImagem);
            Controls.Add(rbNormal);
            Controls.Add(rbStretch);
            Controls.Add(pblmagens);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "frmVisualizadorImagens";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Visualizador de imagens";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pblmagens).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pblmagens;
        private RadioButton rbStretch;
        private RadioButton rbNormal;
        private OpenFileDialog ofdImagens;
        private Button btnMostrarImagem;
        private Button btnLimparImagem;
    }
}