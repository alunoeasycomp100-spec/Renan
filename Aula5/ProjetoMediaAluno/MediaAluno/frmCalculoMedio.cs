using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaAluno
{
    public partial class frmCalculoMedio : Form
    {
        public frmCalculoMedio()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            // Variáveis responsáveis por receberem as notas calculadas com o peso.
            double Nota1, Nota2, Trabalho;
            // converte o conteúdo dos componente TextBox e ComboBox para double e realiza a multiplicação dos mesmos.
            Nota1 = Convert.ToDouble(txtNota1.Text) * Convert.ToDouble(cboPesoNota1.Text);
            Nota2 = double.Parse(txtNota2.Text) * double.Parse(cboPesoNota2.Text);
            Trabalho = Convert.ToDouble(txtTrabalho.Text) * Convert.ToDouble(cboPesoTrabalho.Text);

            // Soma das variáveis para que se obteha a média
            double Media = Nota1 + Nota2 + Trabalho;

            txtMediaFinal.Text = Media.ToString();

            // Variáveis responsáves por receberem as quantidades de aulas e faltas
            double txtQdeAulas, QdeFaltas;

            // Converte o conteúdo dos componentes TextBox(Qde Aulas e Qde Faltas)
            txtQdeAulas = Convert.ToDouble(this.txtQdeAulas.Text);
            QdeFaltas = Convert.ToDouble(this.QdeFaltas.Text);

            // Realiza a conta necessária para se achar a porcentafem de presença do aluno
            double PorcentagemPresenca = 100 - ((QdeFaltas / txtQdeAulas) * 100);

            // Realiza a conta do aproveitamento do aluno e converte o valor em string para ser exibido no txtAproveitamento
            txtAproveitamento.Text = Convert.ToString(((Media * 10) + (PorcentagemPresenca)) / 2) + "%";

            //Este if irá verificar se o campo txtRecuperacao.Text está vazio
            if (txtRecuperacao.Text == "")
            {

                //Se no caso o if acimafor verdade este if irá verificar se a média é maior que a nota de corte
                //E se presença é igual ou superior a 75%
                if (Media >= Convert.ToDouble(numNotaCorte.Value) && PorcentagemPresenca >= 75)
                {
                    //No caso do if retornar verdade:
                    lblsituacao.Text = "Aprovado"; // irá aparecer Aprovado no campo lblSituacao.Text,
                    lblsituacao.ForeColor = Color.Green; // com a cor verde
                }

                //Caso o if antrior retornar falso, será verificado se a média obtida é manor que 2,5
                //Ou se a presença é inferior a 75%
                else
                    if (Media <=2.5 || PorcentagemPresenca < 75)
                {
                    //No caso do Else if retornar a Verdade:
                    lblsituacao.Text = "Reprovado"; //irá aparecer Reprovado no campo lblsituacao.Text,
                    lblsituacao.ForeColor = Color.Firebrick; // com a cor firebrick (vermelho).
                }

                //No caso de o if e o Else if retornarm falso, obrigatóriamente a execução irá passar por este Else
                else
                {
                    lblsituacao.Text = "Recuperação"; // irá aparecer Recuperação no campo lblsituacao.Text
                    lblsituacao.ForeColor = Color.Firebrick; // com a cor Firebrick(vermelho).
                }
            }
            // no caso do campo lblRecuperacao possuir conteúdo, a execução do progama será desviada para este else
            else
            {
                //Cálculo da nova média, somando-a ela mesma com o conteúdo do componente txtRecuperacao.Text e dividido por 2
                Media = (Media + Convert.ToDouble(txtRecuperacao.Text)) / 2;

                //Atribuição do novo cálculo sobre o aproveitamento do aluno para o campo txtAproveitamento
                txtAproveitamento.Text = Convert.ToString(((Media * 10) + (PorcentagemPresenca)) / 2) + "%";

                //A partir da nova média é verificado se o aluno atingiu nota igual ou superior a 5
                if (Media >= 5)
                {
                    //Se a condição retornar verdde, então:
                    lblsituacao.Text = "Aprovado";//Irá aparecer aprovado no campo lblsituacao.Text,
                    lblsituacao.ForeColor = Color.Green;// com a cor verde.
                }

                //caso  if acima retornar falso, será executado as instruções que estão dentro do Else abaixo.
                else
                {
                    lblsituacao.Text = "Reprovado";//Irá aparecer reprovado no campo lblsituacao.Text,
                    lblsituacao.ForeColor = Color.Firebrick;// com a cor Firebrick(vermelho).
                }

                txtMediaFinal.Text = Media.ToString();

            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            lblsituacao.Text = "";
            txtRecuperacao.Text = String.Empty;

            //laço de repetição que irá percorrer todos os componentes do formulário.
            foreach (Control Componente in this.Controls)
            {
                if (Componente is TextBox)
                {
                    (Componente as TextBox).Clear();
                }
                else
                {
                    if (Componente is ComboBox)
                    {
                        (Componente as ComboBox). SelectedIndex = -1;
                    }
                    else
                    {
                        if (Componente is NumericUpDown)
                        {
                            (Componente as NumericUpDown).Value = 5;
                        }
                    }
                }
            }
        }
    }
}


