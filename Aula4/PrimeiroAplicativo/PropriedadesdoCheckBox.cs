namespace PrimeiroAplicativo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void chkPessoaFísica_CheckedChanged(object sender, EventArgs e)
        {

        }
        // Evento que verifica se o CheckBox está marcado ou desmarcado
        private void chkPessoaFísica_CheckStateChanged(object sender, EventArgs e)
        {
            if (chkPessoaFísica.Checked == true) // se o CheckBox chkPessoaFisica estiver marcado
            {
                pnlPessoaFisica.Visible = true; // o panel pnlPessoaFisica ficará visivel

            }
            else                                // senão
            {
                pnlPessoaFisica.Visible = false; // o Panel pnlPessoaFisica ficará oculto
            }
        }

        private void chkPessoaJuridica_CheckedChanged(object sender, EventArgs e)
        {
            if (chkPessoaJuridica.Checked == true)
            {
                pnlPessoaJuridica.Visible = true;
            }
            else
            {
                pnlPessoaJuridica.Visible = false;
            }
        }

        private void btnImagens_Click(object sender, EventArgs e)
        {
            frmVisualizadorImagens imagens = new frmVisualizadorImagens(); //intanciando o formulario frmVisualizadorImagens
            imagens.ShowDialog(); // o formuário é exibido através do método ShowDialog
        }

        private void btnTabuada_Click(object sender, EventArgs e)
        {
            frmTabuada tabuada = new frmTabuada(); // instanciando o formulário frmTabuada.
            tabuada.ShowDialog(); // o formulário é exibido atraves do método ShowDialog. 
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnMostrarMensagem_Click(object sender, EventArgs e)
        {
            lblMensagem.Text = "Primeiro Aplicativo em c#"; // A label lblMensagem exibe um texto
            lblMensagem.ForeColor = Color.RoyalBlue; //e a cor do mesmo é definido como azul royal 
            btnCheckBox.Enabled = true; // habilita o botão btnPropriedadesCheckBox
            btnImagens.Enabled = true; // habilita o botãobtnVisualizadorImagens
            btnTabuada.Enabled = true; // habilita o botão btnTabuada
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
