using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {

        String operador;
        double a = 0;
        bool validar = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnNumeradorClick(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            txtValor.Text = txtValor.Text + bt.Text;


        }

        private void btnAdicao_Click(object sender, EventArgs e)
        {
            if( validar == true)
            {
                a = a + Convert.ToDouble(txtValor.Text);
                label1.Text =Convert.ToString(a) + "+";
                txtValor.Text = "";
                operador = "+";

            }
            else
            {
                label1.Text = txtValor.Text + btnAdicao.Text;
                a = Convert.ToDouble(txtValor.Text);
                txtValor.Text = "";
                operador = "+";
                validar = true;

            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtValor.Text = "";
            label1.Text = "";
            a = 0;
            validar = false;
        }

        private void btnSubtracao_Click(object sender, EventArgs e)
        {
            if (validar == true)
            {
                a = a + Convert.ToDouble(txtValor.Text);
                label1.Text = Convert.ToString(a) + "-";
                txtValor.Text = "";
                operador = "-";

            }
            else
            {
                label1.Text = txtValor.Text + btnSubtracao.Text;
                a = Convert.ToDouble(txtValor.Text);
                txtValor.Text = "";
                operador = "-";
                validar = true;

            }

        }

        private void btnMultiplicacao_Click(object sender, EventArgs e)
        {
            if (validar == true)
            {
                a = a + Convert.ToDouble(txtValor.Text);
                label1.Text = Convert.ToString(a) + "*";
                txtValor.Text = "";
                operador = "*";

            }
            else
            {
                label1.Text = txtValor.Text + btnMultiplicacao.Text;
                a = Convert.ToDouble(txtValor.Text);
                txtValor.Text = "";
                operador = "*";
                validar = true;

            }
        }

        private void btnDivisao_Click(object sender, EventArgs e)
        {
            if (validar == true)
            {
                a = a + Convert.ToDouble(txtValor.Text);
                label1.Text = Convert.ToString(a) + "/";
                txtValor.Text = "";
                operador = "/";

            }
            else
            {
                label1.Text = txtValor.Text + btnDivisao.Text;
                a = Convert.ToDouble(txtValor.Text);
                txtValor.Text = "";
                operador = "/";
                validar = true;

            }
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            if(operador == "+")
            {
                label1.Text = label1.Text + txtValor.Text + "=";
                txtValor.Text = Convert.ToString(a + Convert.ToDouble(txtValor.Text));
            }
            else if (operador == "-")
            {
                label1.Text = label1.Text + txtValor.Text + "=";
                txtValor.Text = Convert.ToString(a - Convert.ToDouble(txtValor.Text));
            }
           else if (operador == "*")
            {
                label1.Text = label1.Text + txtValor.Text + "=";
                txtValor.Text = Convert.ToString(a * Convert.ToDouble(txtValor.Text));
            }
            else if (operador == "/")
            {
                label1.Text = label1.Text + txtValor.Text + "=";
                txtValor.Text = Convert.ToString(a / Convert.ToDouble(txtValor.Text));
            }
        }

        private void btnVirgula_Click(object sender, EventArgs e)
        {
            if(!txtValor.Text.Contains(","))
            {
                txtValor.Text+= ",";
            }
            

        }
    }
}
