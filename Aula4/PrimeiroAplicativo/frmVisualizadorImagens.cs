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
    public partial class frmVisualizadorImagens : Form
    {
        public frmVisualizadorImagens()
        {
            InitializeComponent();
        }

        private void btnMostrarImagem_Click(object sender, EventArgs e)
        {
            if (ofdImagens.ShowDialog() == DialogResult.OK) // se o resultado da janela aberta pelo ofdImagens for uma ação de confirmação,
            {
                pblmagens.Load(ofdImagens.FileName); // a imagem selecionada será exibida no picturebox
                btnMostrarImagem.Enabled = false; // desabilita o botão btnMostrarImagem
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pblmagens.Image = null; // Limpa imagem do PictureBox pblmagens
            btnMostrarImagem.Enabled = true; // habilita o botão btnMostrarImagem
        }

        private void rbStretch_CheckedChanged(object sender, EventArgs e)
        {
            if (rbStretch.Checked == true) // se o RadioButton Stretch estiver marcado
            {
                pblmagens.SizeMode = PictureBoxSizeMode.StretchImage; // a proprieade SizeMode da imagem no PictureBOx ficará Maximizada
            }
        }

        private void rbNormal_CheckedChanged(object sender, EventArgs e)
        {
            if(rbNormal.Checked == true) // se o RadioButton Normal estiver marcado
            {
                pblmagens.SizeMode = PictureBoxSizeMode.Normal; // a propriedade SizeMode da imagem no PictureBox ficará Normal
            }
        }
    }
}
