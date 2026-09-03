using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConversaoDeTemperatura
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnConverter_Click(object sender, EventArgs e)
        {
            double valor = Convert.ToDouble(txtValor.Text);

            // Entrada: Celsius
            if (rbCelsius1.Checked == true)
            {
                if (rbCelsius2.Checked == true)
                {
                    txtResultado.Text = valor + "°C";
                }
                else if (rbFahrenheit2.Checked == true)
                {
                    txtResultado.Text = (valor * 1.8 + 32) + "°F";
                }
                else if (rbKelvin2.Checked == true)
                {
                    txtResultado.Text = (valor + 273.15) + " K";
                }
            }

            // Entrada: Fahrenheit
            else if (rbFahrenheit1.Checked == true)
            {
                if (rbCelsius2.Checked == true)
                {
                    txtResultado.Text = ((valor - 32) / 1.8) + "°C";
                }
                else if (rbFahrenheit2.Checked == true)
                {
                    txtResultado.Text = valor + "°F";
                }
                else if (rbKelvin2.Checked == true)
                {
                    txtResultado.Text = (((valor - 32) / 1.8) + 273.15) + " K";
                }
            }

            // Entrada: Kelvin
            else if (rbKelvin1.Checked == true)
            {
                if (rbCelsius2.Checked == true)
                {
                    txtResultado.Text = (valor - 273.15) + "°C";
                }
                else if (rbFahrenheit2.Checked == true)
                {
                    txtResultado.Text = (((valor - 273.15) * 1.8) + 32) + "°F";
                }
                else if (rbKelvin2.Checked == true)
                {
                    txtResultado.Text = valor + " K";
                }
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtValor.Text = "";
            txtResultado.Clear(); 

            foreach (Control componente in gbEntrada.Controls)
            {
                (componente as RadioButton).Checked = false;
            }

            foreach (Control componente in gbSaida.Controls)
            {
                (componente as RadioButton).Checked = false;
            }
        }
    }
}


