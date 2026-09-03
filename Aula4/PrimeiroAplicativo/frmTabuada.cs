using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimeiroAplicativo
{
    public partial class frmTabuada : Form
    {
        public frmTabuada()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (txtNumero.Text == "") // se o txtNumero estiver vazio
            {
                // aparecerá uma caixa de mensagens avisando o usuário que ele dev digitar um número
                MessageBox.Show("Você precisa digitar o número para calcular uma tabuada", "Informação", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else // senão
            {
                double numero, resultado; // declaração das variáveis
                numero = double.Parse(txtNumero.Text); // o número digitado no txtNumero é convertido para double

                for (int i = 0; i <= 10; i++) // laço de repetição FOR, onde há o
                {
                    resultado = numero * i; // cálculo do resulado e
                    // o mesmo é exibido no txtTabuada
                    txtTabuada.Text += numero + "x" + i + "=" + resultado + "\r\n";
                }
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNumero.Text =""; // o txtNumero ficará em branco
            txtTabuada.Text = ""; // e o txtTabuadatambém ficará em branco
        }
    }
}
