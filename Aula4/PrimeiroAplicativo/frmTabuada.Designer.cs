namespace PrimeiroAplicativo
{
    partial class frmTabuada
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTabuada));
            label1 = new Label();
            btnCalcular = new Button();
            btnLimpar = new Button();
            txtNumero = new TextBox();
            txtTabuada = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(42, 23);
            label1.Name = "label1";
            label1.Size = new Size(204, 15);
            label1.TabIndex = 0;
            label1.Text = "Informe qual tabuada deseja calcular:";
            label1.Click += label1_Click;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(36, 76);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(75, 23);
            btnCalcular.TabIndex = 1;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // btnLimpar
            // 
            btnLimpar.Location = new Point(36, 114);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(75, 23);
            btnLimpar.TabIndex = 2;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(273, 23);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(100, 23);
            txtNumero.TabIndex = 3;
            // 
            // txtTabuada
            // 
            txtTabuada.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTabuada.Location = new Point(170, 73);
            txtTabuada.Multiline = true;
            txtTabuada.Name = "txtTabuada";
            txtTabuada.Size = new Size(203, 267);
            txtTabuada.TabIndex = 4;
            // 
            // frmTabuada
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(424, 352);
            Controls.Add(txtTabuada);
            Controls.Add(txtNumero);
            Controls.Add(btnLimpar);
            Controls.Add(btnCalcular);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmTabuada";
            Text = "Tabuada";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnCalcular;
        private Button btnLimpar;
        private TextBox txtNumero;
        private TextBox txtTabuada;
    }
}