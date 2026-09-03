using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleFrota
{
    public partial class frmFrota : Form
    {
        public frmFrota()
        {
            InitializeComponent();
        }

         /*public class Veiculo
         {
             private string modelo, placa, Km;

             public void gravaModelo(string modelo)
             {
                 this.modelo = modelo;
             }

             public void gravaPlaca(string placa)
             {
                 this.placa = placa;
             }

             public void gravaKm(string Km)
             {
                 this.Km = Km;
             }

             public string mostraModelo()
             {
                 return modelo;
             }

             public string mostraPlaca()
             {
                 return placa;
             }

             public string mostraKm()
             {
                 return Km;
             }
         */
         
        

        private void btnSalvar_Click(object sender, EventArgs e) // evento click do botão btnSalvar
        {
            
            if(txtEixos.Visible == false)
            {

                Veiculo novoCarro = new Veiculo(); //Instanciando um objeto do tipo veiculo

                /*novoCarro.gravaModelo(txtModelo.Text);//Gravar o texto que escrever dentro do txtModelo
                novoCarro.gravaPlaca(txtPlaca.Text); // Gravar o texto que escrever dentro do txtPlaca
                novoCarro.gravaKm(txtKm.Text); //Gravar o texto que escrever dentro do txtKm

                txtCarros.Text += novoCarro.mostraModelo() + "\t";//mostrar o modelo no txtCarros
                txtCarros.Text += novoCarro.mostraPlaca() + "\t";//mostrar a placa no txtcarros
                txtCarros.Text += novoCarro.mostraKm() + "\r\n";//mostrar a Kilometragem no txtCarros
                */

                novoCarro.propriedadesModelo = txtModelo.Text;
                novoCarro.propriedadePlaca = txtPlaca.Text;
                novoCarro.propriedadeKm = txtKm.Text;

                txtCarros.AppendText(novoCarro.propriedadesModelo + "\t");
                txtCarros.AppendText(novoCarro.propriedadePlaca + "\t");
                txtCarros.AppendText(novoCarro.propriedadeKm + Environment.NewLine.ToString());
            }
            else
            {
                caminhao novoCaminhao = new caminhao();

                novoCaminhao.propriedadesModelo = txtModelo.Text;
                novoCaminhao.propriedadePlaca = txtPlaca.Text;
                novoCaminhao.propriedadeKm = txtKm.Text;
                novoCaminhao.propriedadeEixo = txtEixos.Text;


                txtCaminhoes.AppendText(novoCaminhao.propriedadesModelo + "\t");
                txtCaminhoes.AppendText(novoCaminhao.propriedadePlaca + "\t");
                txtCaminhoes.AppendText(novoCaminhao.propriedadeKm + "\t");
                txtCaminhoes.AppendText(novoCaminhao.propriedadeEixo + Environment.NewLine.ToString());
            }

            Limpar();



        }

        private void btnCaminhoes_Click(object sender, EventArgs e)
        {
            lblEixos.Visible = true;
            txtEixos.Visible = true;
        }

        private void btnCarros_Click(object sender, EventArgs e) // evento click do botão btnCarros
        {
            lblEixos.Visible = false; // transforma em "ínvisivel" o componente lblEixos
            txtEixos.Visible = false; // transforma em "ínvisivel" o componente txtEixos
        }

        private void Limpar()
        {
            txtModelo.Clear();
            txtPlaca.Clear();
            txtKm.Clear();
            txtEixos.Clear();
        }
    }



    public class Veiculo // classe veículo
    {
        string modelo, placa, Km; // atributos do veículo


        public string propriedadesModelo
        {
            set { modelo = value; }
            get { return modelo; }
        }
        public string propriedadePlaca
        {
            set { placa = value; }
            get { return placa; }
        }
        public string propriedadeKm
        {
            set { Km = value; }
            get { return Km; }
        }
    }

    public class caminhao: Veiculo
    {
        public string propriedadeEixo { set; get; }
    }
    
}
