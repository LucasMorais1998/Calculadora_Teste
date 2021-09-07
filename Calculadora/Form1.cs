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
        decimal Valor1 = 0;
        decimal Valor2 = 0;
        string Operacao = "";
        bool Condicao = false;

        public Frm_Calc()
        {
            InitializeComponent();
        }

        private void Btn_0_Click(object sender, EventArgs e)
        {
            Txt_Resultado.Text = Txt_Resultado.Text + "0";
        }

        private void Btn_1_Click(object sender, EventArgs e)
        {
            Txt_Resultado.Text = Txt_Resultado.Text + "1";
        }

        private void Btn_2_Click(object sender, EventArgs e)
        {
            Txt_Resultado.Text = Txt_Resultado.Text + "2";
        }

        private void Btn_3_Click(object sender, EventArgs e)
        {
            Txt_Resultado.Text = Txt_Resultado.Text + "3";
        }

        private void Btn_4_Click(object sender, EventArgs e)
        {
            Txt_Resultado.Text = Txt_Resultado.Text + "4";
        }

        private void Btn_5_Click(object sender, EventArgs e)
        {
            Txt_Resultado.Text = Txt_Resultado.Text + "5";
        }

        private void Btn_6_Click(object sender, EventArgs e)
        {
            Txt_Resultado.Text = Txt_Resultado.Text + "6";
        }

        private void Btn_7_Click(object sender, EventArgs e)
        {
            Txt_Resultado.Text = Txt_Resultado.Text + "7";
        }

        private void Btn_8_Click(object sender, EventArgs e)
        {
            Txt_Resultado.Text = Txt_Resultado.Text + "8";
        }

        private void Btn_9_Click(object sender, EventArgs e)
        {
            Txt_Resultado.Text = Txt_Resultado.Text + "9";
        }

        private void Btn_Ponto_Click(object sender, EventArgs e)
        {
            Txt_Resultado.Text = Txt_Resultado.Text + ".";
        }

        private void Btn_Adicao_Click(object sender, EventArgs e)
        {
            if (Txt_Resultado.Text != "")
            {
                Valor1 = decimal.Parse(Txt_Resultado.Text, CultureInfo.InvariantCulture);
                Txt_Resultado.Text = "";
                Operacao = "SOMA";
                Lbl_Operacao.Text = "+";
                Condicao = true;
            }
        }

        private void Btn_Subtracao_Click(object sender, EventArgs e)
        {
            if (Txt_Resultado.Text != "")
            {
                Valor1 = decimal.Parse(Txt_Resultado.Text, CultureInfo.InvariantCulture);
                Txt_Resultado.Text = "";
                Operacao = "SUB";
                Lbl_Operacao.Text = "-";
                Condicao = true;
            }
        }

        private void Btn_Multiplicacao_Click(object sender, EventArgs e)
        {
            if (Txt_Resultado.Text != "")
            {
                Valor1 = decimal.Parse(Txt_Resultado.Text, CultureInfo.InvariantCulture);
                Txt_Resultado.Text = "";
                Operacao = "MULT";
                Lbl_Operacao.Text = "X";
                Condicao = true;

            }
        }

        private void Btn_Divisao_Click(object sender, EventArgs e)
        {
            if (Txt_Resultado.Text != "")
            {
                Valor1 = decimal.Parse(Txt_Resultado.Text, CultureInfo.InvariantCulture);
                Txt_Resultado.Text = "";
                Operacao = "DIV";
                Lbl_Operacao.Text = "/";
                Condicao = true;
            }
        }

        private void Btn_Resultado_Click(object sender, EventArgs e)
        {
            if (Condicao == true)
            {
                Valor2 = decimal.Parse(Txt_Resultado.Text, CultureInfo.InvariantCulture);

                if (Operacao == "SOMA")
                {
                    Txt_Resultado.Text = Convert.ToString(Valor1 + Valor2);
                }
                else if (Operacao == "SUB")
                {
                    Txt_Resultado.Text = Convert.ToString(Valor1 - Valor2);
                }
                else if (Operacao == "MULT")
                {
                    Txt_Resultado.Text = Convert.ToString(Valor1 * Valor2);
                }
                else if (Operacao == "DIV")
                {
                    if (Valor2 != 0)
                    {
                        Txt_Resultado.Text = Convert.ToString(Valor1 / Valor2);
                    }
                    else
                    {
                        Txt_Resultado.Text = "Cannot divide by zero";
                    }

                }
            }
            
            



        }

        private void Btn_CE_Click(object sender, EventArgs e)
        {
            Txt_Resultado.Text = "";
            Lbl_Operacao.Text = "";
        }

        private void Btn_C_Click(object sender, EventArgs e)
        {
            Txt_Resultado.Text = "";
            Lbl_Operacao.Text = "";
            Valor1 = 0;
            Valor2 = 0;
        }
    }
}
