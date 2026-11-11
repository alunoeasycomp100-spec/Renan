namespace calculadora
{
    partial class calculadora
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(calculadora));
            txthistorico = new TextBox();
            txtvisor = new TextBox();
            btn7 = new Button();
            btn8 = new Button();
            btn9 = new Button();
            btn4 = new Button();
            btn5 = new Button();
            btn6 = new Button();
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btnvirgula = new Button();
            btn0 = new Button();
            btnC = new Button();
            button13 = new Button();
            btnadicao = new Button();
            button15 = new Button();
            button16 = new Button();
            button17 = new Button();
            button18 = new Button();
            button19 = new Button();
            SuspendLayout();
            // 
            // txthistorico
            // 
            txthistorico.Location = new Point(12, 12);
            txthistorico.Name = "txthistorico";
            txthistorico.Size = new Size(298, 23);
            txthistorico.TabIndex = 0;
            txthistorico.TextAlign = HorizontalAlignment.Right;
            // 
            // txtvisor
            // 
            txtvisor.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtvisor.Location = new Point(12, 41);
            txtvisor.Name = "txtvisor";
            txtvisor.Size = new Size(298, 43);
            txtvisor.TabIndex = 0;
            txtvisor.Text = "0";
            txtvisor.TextAlign = HorizontalAlignment.Right;
            // 
            // btn7
            // 
            btn7.Location = new Point(12, 90);
            btn7.Name = "btn7";
            btn7.Size = new Size(44, 43);
            btn7.TabIndex = 1;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += clicoubotao;
            // 
            // btn8
            // 
            btn8.Location = new Point(62, 90);
            btn8.Name = "btn8";
            btn8.Size = new Size(44, 43);
            btn8.TabIndex = 1;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += clicoubotao;
            // 
            // btn9
            // 
            btn9.Location = new Point(112, 90);
            btn9.Name = "btn9";
            btn9.Size = new Size(44, 43);
            btn9.TabIndex = 1;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += clicoubotao;
            // 
            // btn4
            // 
            btn4.Location = new Point(12, 139);
            btn4.Name = "btn4";
            btn4.Size = new Size(44, 43);
            btn4.TabIndex = 1;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += clicoubotao;
            // 
            // btn5
            // 
            btn5.Location = new Point(62, 139);
            btn5.Name = "btn5";
            btn5.Size = new Size(44, 43);
            btn5.TabIndex = 1;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += clicoubotao;
            // 
            // btn6
            // 
            btn6.Location = new Point(112, 139);
            btn6.Name = "btn6";
            btn6.Size = new Size(44, 43);
            btn6.TabIndex = 1;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += clicoubotao;
            // 
            // btn1
            // 
            btn1.Location = new Point(12, 188);
            btn1.Name = "btn1";
            btn1.Size = new Size(44, 43);
            btn1.TabIndex = 1;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += clicoubotao;
            // 
            // btn2
            // 
            btn2.Location = new Point(62, 188);
            btn2.Name = "btn2";
            btn2.Size = new Size(44, 43);
            btn2.TabIndex = 1;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += clicoubotao;
            // 
            // btn3
            // 
            btn3.Location = new Point(112, 188);
            btn3.Name = "btn3";
            btn3.Size = new Size(44, 43);
            btn3.TabIndex = 1;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += clicoubotao;
            // 
            // btnvirgula
            // 
            btnvirgula.Location = new Point(112, 237);
            btnvirgula.Name = "btnvirgula";
            btnvirgula.Size = new Size(44, 43);
            btnvirgula.TabIndex = 1;
            btnvirgula.Text = ",";
            btnvirgula.UseVisualStyleBackColor = true;
            btnvirgula.Click += clicoubotao;
            // 
            // btn0
            // 
            btn0.Location = new Point(12, 237);
            btn0.Name = "btn0";
            btn0.Size = new Size(94, 43);
            btn0.TabIndex = 1;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = true;
            btn0.Click += clicoubotao;
            // 
            // btnC
            // 
            btnC.BackColor = Color.Red;
            btnC.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnC.ForeColor = SystemColors.Menu;
            btnC.Location = new Point(199, 90);
            btnC.Name = "btnC";
            btnC.Size = new Size(44, 43);
            btnC.TabIndex = 1;
            btnC.Text = "C";
            btnC.UseVisualStyleBackColor = false;
            btnC.Click += btnC_Click;
            // 
            // button13
            // 
            button13.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button13.Location = new Point(249, 90);
            button13.Name = "button13";
            button13.Size = new Size(44, 43);
            button13.TabIndex = 1;
            button13.Text = "<-";
            button13.UseVisualStyleBackColor = true;
            button13.Click += button13_Click;
            // 
            // btnadicao
            // 
            btnadicao.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnadicao.Location = new Point(199, 139);
            btnadicao.Name = "btnadicao";
            btnadicao.Size = new Size(44, 43);
            btnadicao.TabIndex = 1;
            btnadicao.Text = "+";
            btnadicao.UseVisualStyleBackColor = true;
            // 
            // button15
            // 
            button15.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button15.Location = new Point(249, 139);
            button15.Name = "button15";
            button15.Size = new Size(44, 43);
            button15.TabIndex = 1;
            button15.Text = "-";
            button15.UseVisualStyleBackColor = true;
            // 
            // button16
            // 
            button16.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button16.Location = new Point(199, 188);
            button16.Name = "button16";
            button16.Size = new Size(44, 43);
            button16.TabIndex = 1;
            button16.Text = "*";
            button16.UseVisualStyleBackColor = true;
            // 
            // button17
            // 
            button17.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button17.Location = new Point(249, 188);
            button17.Name = "button17";
            button17.Size = new Size(44, 43);
            button17.TabIndex = 1;
            button17.Text = "/";
            button17.UseVisualStyleBackColor = true;
            // 
            // button18
            // 
            button18.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button18.Location = new Point(199, 237);
            button18.Name = "button18";
            button18.Size = new Size(44, 43);
            button18.TabIndex = 1;
            button18.Text = "R²";
            button18.UseVisualStyleBackColor = true;
            // 
            // button19
            // 
            button19.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button19.Location = new Point(249, 237);
            button19.Name = "button19";
            button19.Size = new Size(44, 43);
            button19.TabIndex = 1;
            button19.Text = "=";
            button19.UseVisualStyleBackColor = true;
            // 
            // calculadora
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(322, 300);
            Controls.Add(btnvirgula);
            Controls.Add(btn3);
            Controls.Add(btn6);
            Controls.Add(button19);
            Controls.Add(button17);
            Controls.Add(button15);
            Controls.Add(button13);
            Controls.Add(btn9);
            Controls.Add(btn2);
            Controls.Add(btn0);
            Controls.Add(btn1);
            Controls.Add(button18);
            Controls.Add(button16);
            Controls.Add(btn5);
            Controls.Add(btnadicao);
            Controls.Add(btn4);
            Controls.Add(btnC);
            Controls.Add(btn8);
            Controls.Add(btn7);
            Controls.Add(txtvisor);
            Controls.Add(txthistorico);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "calculadora";
            Text = "calculadora";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txthistorico;
        private TextBox txtvisor;
        private Button btn7;
        private Button btn8;
        private Button btn9;
        private Button btn4;
        private Button btn5;
        private Button btn6;
        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button btnvirgula;
        private Button btn0;
        private Button btnC;
        private Button button13;
        private Button btnadicao;
        private Button button15;
        private Button button16;
        private Button button17;
        private Button button18;
        private Button button19;
    }
}
