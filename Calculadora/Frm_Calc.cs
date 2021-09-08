using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Frm_Calc : Form
    {
        decimal Valor1 = 0; decimal Valor2 = 0;
        string Operacao;
        bool Condicao = false; bool Ponto = false; bool JaTemPonto = false;

        public Frm_Calc()
        {
            InitializeComponent();
        }

        private void Btn_0_Click(object sender, EventArgs e)
        {
            Txt_ValorDigitado.Text = Txt_ValorDigitado.Text + "0";
            Ponto = false;
        }

        private void Btn_1_Click(object sender, EventArgs e)
        {
            Txt_ValorDigitado.Text = Txt_ValorDigitado.Text + "1";
            Ponto = false;
        }

        private void Btn_2_Click(object sender, EventArgs e)
        {
            Txt_ValorDigitado.Text = Txt_ValorDigitado.Text + "2";
            Ponto = false;
        }

        private void Btn_3_Click(object sender, EventArgs e)
        {
            Txt_ValorDigitado.Text = Txt_ValorDigitado.Text + "3";
            Ponto = false;
        }

        private void Btn_4_Click(object sender, EventArgs e)
        {
            Txt_ValorDigitado.Text = Txt_ValorDigitado.Text + "4";
            Ponto = false;
        }

        private void Btn_5_Click(object sender, EventArgs e)
        {
            Txt_ValorDigitado.Text = Txt_ValorDigitado.Text + "5";
            Ponto = false;
        }

        private void Btn_6_Click(object sender, EventArgs e)
        {
            Txt_ValorDigitado.Text = Txt_ValorDigitado.Text + "6";
            Ponto = false;
        }

        private void Btn_7_Click(object sender, EventArgs e)
        {
            Txt_ValorDigitado.Text = Txt_ValorDigitado.Text + "7";
            Ponto = false;
        }

        private void Btn_8_Click(object sender, EventArgs e)
        {
            Txt_ValorDigitado.Text = Txt_ValorDigitado.Text + "8";
            Ponto = false;
        }

        private void Btn_9_Click(object sender, EventArgs e)
        {
            Txt_ValorDigitado.Text = Txt_ValorDigitado.Text + "9";
            Ponto = false;
        }

        private void Btn_Ponto_Click(object sender, EventArgs e)
        {
            if (Ponto == false && JaTemPonto == false)
            {
                Txt_ValorDigitado.Text = Txt_ValorDigitado.Text + ".";
                Ponto = true;
            }
        }

        private void Btn_CE_Click(object sender, EventArgs e)
        {
            Txt_ValorDigitado.Text = "";
        }

        private void Btn_C_Click(object sender, EventArgs e)
        {
            Txt_ValorDigitado.Text = "";
            Txt_Operacao.Text = "";
            Valor1 = 0;
            Valor2 = 0;

        }

        private void Btn_Adicao_Click(object sender, EventArgs e)
        {
            if (Txt_ValorDigitado.Text != "")
            {
                Valor1 = Convert.ToDecimal(Txt_ValorDigitado.Text, CultureInfo.InvariantCulture);
                Txt_ValorDigitado.Text = "";
                Operacao = "+";
                Txt_Operacao.Text = Valor1.ToString() + " +";
                Condicao = true;
            }
        }

        private void Btn_Subtracao_Click(object sender, EventArgs e)
        {
            if (Txt_ValorDigitado.Text != "")
            {
                Valor1 = Convert.ToDecimal(Txt_ValorDigitado.Text, CultureInfo.InvariantCulture);
                Txt_ValorDigitado.Text = "";
                Operacao = "-";
                Txt_Operacao.Text = Valor1.ToString() + " -";
                Condicao = true;
            }
        }

        private void Btn_Multiplicacao_Click(object sender, EventArgs e)
        {
            if (Txt_ValorDigitado.Text != "")
            {
                Valor1 = Convert.ToDecimal(Txt_ValorDigitado.Text, CultureInfo.InvariantCulture);
                Txt_ValorDigitado.Text = "";
                Operacao = "x";
                Txt_Operacao.Text = Valor1.ToString() + " x";
                Condicao = true;
            }
        }

        private void Btn_Divisao_Click(object sender, EventArgs e)
        {
            if (Txt_ValorDigitado.Text != "")
            {
                Valor1 = Convert.ToDecimal(Txt_ValorDigitado.Text, CultureInfo.InvariantCulture);
                Txt_ValorDigitado.Text = "";
                Operacao = "/";
                Txt_Operacao.Text = Valor1.ToString() + " /";
                Condicao = true;
            }
        }

        private void Btn_Backspace_Click(object sender, EventArgs e)
        {

            if (Txt_ValorDigitado.Text.Length > 0)
            {
                Txt_ValorDigitado.Text = Txt_ValorDigitado.Text.Substring(0, Txt_ValorDigitado.Text.Length - 1);
            }
            else if (Txt_ValorDigitado.Text == ".")
            {
                JaTemPonto = true;
            }
            Ponto = false;

        }

        private void Btn_Resultado_Click(object sender, EventArgs e)
        {
            if (Condicao == true && Txt_ValorDigitado.Text != ".")
            {
                Valor2 = Convert.ToDecimal(Txt_ValorDigitado.Text, CultureInfo.InvariantCulture);

                switch (Operacao)
                {
                    case "+":
                        Txt_ValorDigitado.Text = Convert.ToString(Valor1 + Valor2);
                        Txt_Operacao.Text = Valor1.ToString() + " + " + Valor2.ToString() + " = " + Txt_ValorDigitado.Text.ToString();
                        break;

                    case "-":
                        Txt_ValorDigitado.Text = Convert.ToString(Valor1 - Valor2);
                        Txt_Operacao.Text = Valor1.ToString() + " - " + Valor2.ToString() + " = " + Txt_ValorDigitado.Text.ToString();

                        break;

                    case "x":
                        Txt_ValorDigitado.Text = Convert.ToString(Valor1 * Valor2);
                        Txt_Operacao.Text = Valor1.ToString() + " x " + Valor2.ToString() + " = " + Txt_ValorDigitado.Text.ToString();

                        break;

                    case "/":
                        if (Valor2 != 0)
                        {
                            Txt_ValorDigitado.Text = Convert.ToString(Valor1 / Valor2);
                            Txt_Operacao.Text = Valor1.ToString() + " / " + Valor2.ToString() + " = " + Txt_ValorDigitado.Text.ToString();

                        }
                        else
                        {
                            Txt_ValorDigitado.Font = new Font("Lucida Sans", 14.25F, GraphicsUnit.Pixel);
                            Txt_ValorDigitado.Text = "Cannot divide by zero";
                            Txt_Operacao.Text = "";
                        }
                        break;

                    default:
                        break;
                }
            }

        }


    }
}
