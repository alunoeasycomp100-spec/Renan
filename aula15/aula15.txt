using System.DirectoryServices.ActiveDirectory;

namespace calculadora
{
    public partial class calculadora : Form
    {
        double valorvisor = 0, valoranterior = 0;
        string operacao = "";
        bool primeiraoperacao = true, botaoigual = false;
        public calculadora()
        {
            InitializeComponent();
        }

        private void clicoubotao(object sender, EventArgs e)
        {
            if (txtvisor.Text == "0")
            {
                txtvisor.Clear();
            }

            Button botaoacionado = (Button)sender;

            switch (botaoacionado.Name)
            {
                case "btn1":
                    txtvisor.Text += "1";
                    break;

                case "btn2":
                    txtvisor.Text += "2";
                    break;

                case "btn3":
                    txtvisor.Text += "3";
                    break;

                case "btn4":
                    txtvisor.Text += "4";
                    break;

                case "btn5":
                    txtvisor.Text += "5";
                    break;

                case "btn6":
                    txtvisor.Text += "6";
                    break;

                case "btn7":
                    txtvisor.Text += "7";
                    break;

                case "btn8":
                    txtvisor.Text += "8";
                    break;

                case "btn9":
                    txtvisor.Text += "9";
                    break;

                case "btn0":
                    txtvisor.Text += "0";
                    break;

                case "btnvirgula":
                    if (txtvisor.Text == "")
                    {
                        txtvisor.Text += "0,";
                    }
                    else
                    {
                        txtvisor.Text += ",";
                    }
                    break;
                default:
                    break;


            }
        }

        private void btnC_Click(object sender, EventArgs e) //Botão responsavel por limpar o visor
        {
            txtvisor.Clear();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            txtvisor.Text = txtvisor.Text.Remove(txtvisor.Text.Length - 1);
        }

        private void btnadicao_Click(object sender, EventArgs e) //Botão responsável por realizar somas
        {
            if (primeiraoperacao) //se for primeira operação realizada
            {
                valoranterior = Convert.ToDouble(txtvisor.Text); //valor anterior passa a ser o que estiver no txtVisor

                if (botaoigual == false) //se o botaoIgual estiver como false
                {
                    txthistorico.Text += txtvisor.Text + " + ";//o txthistorico adiciona o que estiver no txtvisor
                }

                txtvisor.Clear(); //Limpar o txtvisor
                operacao = "+"; //determina que a operação realizada é adição
                primeiraoperacao = false; //primeiraoperação a passa a ser false

            }
            else //sanão
            {
                valorvisor = Convert.ToDouble(txtvisor.Text); //coverte o numero do txtvisor para double

                txthistorico.Text += operacao + txtvisor.Text; //o txthistorico recebe a operação anteriormente e o número do txtVisor
                txtvisor.Text = Convert.ToString(valoranterior + valorvisor); //realiza a soma dos números e exibe o txtvisor


                operacao = "+";//determina que a operação realizada é adição
                txthistorico.Text += "=" + txtvisor.Text; //txthistorico recebe o sinal de = e o último numero inserido no txtvisor
                valoranterior = Convert.ToDouble(txtvisor.Text); //valor anterior passa a ser o que estiver no txtvisor
                botaoigual = true; //a variável botaoigual passa a ser true

            }
        }

    }
}
