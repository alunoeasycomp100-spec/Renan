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
            frmVisualizadorImagens frm = new frmVisualizadorImagens();
            frm.Show();
        }
    }
}
