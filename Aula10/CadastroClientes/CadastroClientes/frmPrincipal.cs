using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadastroClientes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnFisica_Click(object sender, EventArgs e) //Evento Click do botão Pessoa Física
        {
            pnlFisica.Visible = true;    //Deixa visível o painel destinado à Pessoa Física
            pnlJuridica.Visible = false; //Deixa invísivel o painel destinado à Pessoa Jurídica
        }

        private void btnJuridica_Click(object sender, EventArgs e) //Evento Click do botão Pessoa Jurídica 
        {
            pnlJuridica.Visible = true; //Deixa Vísivel o painel destinado a Pessoa Jurídica
            pnlFisica.Visible = false;  //deixa Invísivel o painel destinado a Pessoa Física
            
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (pnlFisica.Visible == true)
            {
                PessoaFisica novaPessoaFisica = new PessoaFisica();

                novaPessoaFisica.propriedadeNome = txtNome.Text;
                novaPessoaFisica.propriedadeEndereco = txtEndereco.Text;
                novaPessoaFisica.propriedadeRg = txtRG.Text;
                novaPessoaFisica.propriedadeCpf = txtCPF.Text;

                txtPessoaFisica.AppendText(novaPessoaFisica.propriedadeNome + "\t");
                txtPessoaFisica.AppendText(novaPessoaFisica.propriedadeEndereco + "\t");
                txtPessoaFisica.AppendText(novaPessoaFisica.propriedadeRg + "\t");
                txtPessoaFisica.AppendText(novaPessoaFisica.propriedadeCpf + Environment.NewLine.ToString());

                Limpar();
            }
            else
            {
                PessoaJuridica novaPessoaJuridica = new PessoaJuridica();

                novaPessoaJuridica.propriedadeNome = txtNomeJur.Text;
                novaPessoaJuridica.propriedadeEndereco = txtEnderecoJur.Text;
                novaPessoaJuridica.propriedadeCnpl = txtCNPJ.Text;
                novaPessoaJuridica.propriedadeIe = txtIE.Text;

                txtPessoaJuridica.AppendText(novaPessoaJuridica.propriedadeNome + "\t");
                txtPessoaJuridica.AppendText(novaPessoaJuridica.propriedadeEndereco + "\t");
                txtPessoaJuridica.AppendText(novaPessoaJuridica.propriedadeCnpl + "\t");
                txtPessoaJuridica.AppendText(novaPessoaJuridica.propriedadeIe + Environment.NewLine.ToString());

                Limpar();''
            }
        }

        public void Limpar()
        {
            if (pnlFisica.Visible == true)
            {
                txtNome.Text = "";
                txtEndereco.Text = "";
                txtRG.Text = "";
                txtCPF.Text = "";
            }
            else
            {
                txtNomeJur.Text = "";
                txtEnderecoJur.Text = "";
                txtCNPJ.Text = "";
                txtIE.Text = "";
            }
        }
    }

    public class Pessoa
    {
        private string nome;            //atributo nome
        private string endereco;        //Atributo endereco

        public string propriedadeNome   //propriedade do Atributo nome
        {
            set { nome = value; }       //Método do acesso gravação
            get { return nome; }        //Método do acesso leitura
        }
        public string propriedadeEndereco
        {
            set { endereco = value; }       //Método do acesso gravação
            get { return endereco; }
        }
    }

    public class PessoaFisica : Pessoa //Classe PessoaFísica
    {
        public string propriedadeRg { set; get; } //Propriedade auto-implementada do atributo rg
        public string propriedadeCpf { set; get; } //propriedadeauto-implementada do atributo cpf
    }

    public class PessoaJuridica : Pessoa //Classe PessoaJuridica
    {
        public string propriedadeCnpl { set; get; } //Propriedade auto-implementada do atributo cnpj
        public string propriedadeIe { set; get; } //propriedade auto-implementada do atributo ie
    }
}