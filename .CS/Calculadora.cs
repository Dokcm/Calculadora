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
    public partial class Calculadora : Form
    {
        decimal calculo;
        bool adicao = false;
        bool subtracao = false;
        bool multiplicacao = false;
        bool divisao = false;
        bool resultado = false;

        public Calculadora()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtresultado.Text += "1";

            txtOperação.Text += "1";

        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtresultado.Text += "2";

            txtOperação.Text += "2";

        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtresultado.Text += "3";

            txtOperação.Text += "3";

        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtresultado.Text += "4";

            txtOperação.Text += "4";

        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtresultado.Text += "5";

            txtOperação.Text += "5";

        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtresultado.Text += "6";

            txtOperação.Text += "6";

        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtresultado.Text += "7";

            txtOperação.Text += "7";

        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtresultado.Text += "8";

            txtOperação.Text += "8";

        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtresultado.Text += "9";

            txtOperação.Text += "9";

        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtresultado.Text += "0";

            txtOperação.Text += "0";

        }

        private void btnporcentagem_Click(object sender, EventArgs e)
        {
            if(subtracao == true)
            {
                double valor1 = Convert.ToDouble(calculo);
                double percentual = Convert.ToDouble(txtresultado.Text) / 100;

                txtresultado.Text = Convert.ToString(valor1 - (percentual * valor1));

                txtOperação.Text += "% =";
                txtOperação.Text += txtresultado.Text;

            }
            else if (adicao == true)
            {
                double valor1 = Convert.ToDouble(calculo);
                double percentual = Convert.ToDouble(txtresultado.Text) / 100;

                txtresultado.Text = Convert.ToString(valor1 + (percentual * valor1));

                txtOperação.Text += "% =";
                txtOperação.Text += txtresultado.Text;

            }


        }

        private void btnadição_Click(object sender, EventArgs e)
        {
            calculo = Convert.ToDecimal(txtresultado.Text);
            
            txtOperação.Text += "+";

            txtresultado.Text = "";

            adicao = true;
            subtracao = false;
            multiplicacao = false;
            divisao = false;


        }

        private void btnsubtracao_Click(object sender, EventArgs e)
        {
            calculo = Convert.ToDecimal(txtresultado.Text);

            txtOperação.Text += "-";

            txtresultado.Text = "";

            adicao = false;
            subtracao = true;
            multiplicacao = false;
            divisao = false;
        }

        private void btnmultiplicação_Click(object sender, EventArgs e)
        {
            calculo = Convert.ToDecimal(txtresultado.Text);

            txtOperação.Text += "x";

            txtresultado.Text = "";

            adicao = false;
            subtracao = false;
            multiplicacao = true;
            divisao = false;
        }

        private void btndivisão_Click(object sender, EventArgs e)
        {
            calculo = Convert.ToDecimal(txtresultado.Text);

            txtOperação.Text += "/";

            txtresultado.Text = "";

            adicao = false;
            subtracao = false;
            multiplicacao = false;
            divisao = true;
        }

        private void btnvirgula_Click(object sender, EventArgs e)
        {
            txtOperação.Text += ",";
        }

        private void btnigualdade_Click(object sender, EventArgs e)
        {

            resultado = true;

            txtOperação.Text += "=";

            if(adicao == true)
            {
                txtresultado.Text = Convert.ToString(Convert.ToDecimal(txtresultado.Text) + calculo);

                txtOperação.Text += txtresultado.Text;
            }

            if (subtracao == true)
            {
                txtresultado.Text = Convert.ToString(calculo - Convert.ToDecimal(txtresultado.Text));

                txtOperação.Text += txtresultado.Text;
            }
            
            if (multiplicacao == true)
            {
                txtresultado.Text = Convert.ToString(Convert.ToDecimal(txtresultado.Text) * calculo);

                txtOperação.Text += txtresultado.Text;
            }

            if (divisao == true)
            {
                txtresultado.Text = Convert.ToString(calculo / Convert.ToDecimal(txtresultado.Text));

                txtOperação.Text += txtresultado.Text;
            }

        }

        private void btnac_Click(object sender, EventArgs e)
        {
            txtresultado.Text = "";
            txtOperação.Text = "";
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtresultado.Text != "")
                {
                    string Apagar = txtresultado.Text;

                    Apagar = Apagar.Remove(Apagar.Length - 1);

                    txtresultado.Text = Apagar;
                }

                string apagar_operacao = txtOperação.Text;

                apagar_operacao = apagar_operacao.Remove(apagar_operacao.Length - 1);

                txtOperação.Text = apagar_operacao;

            }
            catch (Exception)
            {

            }

        }

        private void btnraiz_Click(object sender, EventArgs e)
        {
            try
            {
                double x = Convert.ToDouble(txtresultado.Text);
                if(x < 0)
                {
                    MessageBox.Show("Valor Inválido");
                }
                else
                {
                    x = Math.Sqrt(x);

                    txtresultado.Text = x.ToString();

                    txtOperação.Text += "√ =";
                    txtOperação.Text += x.ToString();
                }

            }
            catch (Exception) { }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}

