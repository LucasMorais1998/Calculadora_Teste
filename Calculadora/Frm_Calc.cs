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
        bool CondicaoCE = false;

        public Frm_Calc()
        {
            InitializeComponent();
        }

        private void AddNumero(object sender, EventArgs e)
        {
            var button = (Button)sender;

            if (Txt_Resultado.Text == "0")
            {
                Txt_Resultado.Text = "";
            }
            Txt_Resultado.Text += button.Text;
        }

        private void Operador(object sender, EventArgs e)
        {
            Txt_Operacao.Text = "";
            var button = (Button)sender;
            Valor1 = Convert.ToDecimal(Txt_Resultado.Text, CultureInfo.InvariantCulture);
            Operacao = Convert.ToString(button.Text);
            Txt_Operacao.Text = Valor1 + " " + Operacao;
            Txt_Resultado.Text = "0";
        }

        private void Btn_Resultado_Click(object sender, EventArgs e)
        {
            CondicaoCE = true;
            Valor2 = Convert.ToDecimal(Txt_Resultado.Text, CultureInfo.InvariantCulture);

            switch (Operacao)
            {
                case "+":
                    Txt_Resultado.Text = (Valor1 + Valor2).ToString();
                    Txt_Operacao.Text = Valor1.ToString() + " + " + Valor2.ToString() + " = ";
                    Valor1 = Convert.ToDecimal(Txt_Resultado.Text);
                    CondicaoCE = false;
                    break;

                case "-":
                    Txt_Resultado.Text = (Valor1 - Valor2).ToString();
                    Txt_Operacao.Text = Valor1.ToString() + " - " + Valor2.ToString() + " = ";
                    Valor1 = Convert.ToDecimal(Txt_Resultado.Text);
                    CondicaoCE = false;
                    break;

                case "x":
                    Txt_Resultado.Text = (Valor1 * Valor2).ToString();
                    Txt_Operacao.Text = Valor1.ToString() + " x " + Valor2.ToString() + " = ";
                    Valor1 = Convert.ToDecimal(Txt_Resultado.Text);
                    CondicaoCE = false;
                    break;

                case "÷":
                    if (Valor2 != 0)
                    {
                        Txt_Resultado.Text = (Valor1 / Valor2).ToString();
                        Txt_Operacao.Text = Valor1.ToString() + " ÷ " + Valor2.ToString() + " = ";
                        Valor1 = Convert.ToDecimal(Txt_Resultado.Text);
                        CondicaoCE = false;
                    }
                    else
                    {
                        Txt_Resultado.Font = new Font("Lucida Sans", 18.25F, GraphicsUnit.Pixel);
                        Txt_Resultado.Text = "Cannot divide by zero";
                        Txt_Operacao.Text = "";
                        CondicaoCE = false;
                    }
                    break;

                default:
                    break;
            }            
        }

        private void Btn_C_Click(object sender, EventArgs e)
        {
            Valor1 = 0;
            Valor2 = 0;
            Txt_Operacao.Text = "";
            Txt_Resultado.Text = "0";
        }

        private void Btn_CE_Click(object sender, EventArgs e) // (?) CE também deve apagar tudo apos resulte
        {
            if (CondicaoCE == false)
            {
                Txt_Resultado.Text = "0";
            }
            else
            {
                Txt_Resultado.Text = "0";
                Txt_Operacao.Text = "";
            }
        }

        private void Btn_Backspace_Click(object sender, EventArgs e)
        {
            if (Txt_Resultado.Text.Length > 1)
            {
                Txt_Resultado.Text = Txt_Resultado.Text.Substring(0, Txt_Resultado.Text.Length - 1);
            }
            else
            {
                Txt_Resultado.Text = "0";
            }
        }

        private void Btn_Ponto_Click(object sender, EventArgs e)
        {
            if (!Txt_Resultado.Text.Contains("."))
            {
                Txt_Resultado.Text += ".";
            }
        }
    }
}

