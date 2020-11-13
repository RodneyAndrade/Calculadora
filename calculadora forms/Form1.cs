using System;
using System.Windows.Forms;

namespace calculadora_forms
{
    public partial class Form1 : Form
    {
        private decimal resultadoMatematico;
        private decimal primeiroValor;
        private decimal segundoValor;
        private string operador;
        private string s1;
        private string s2;
        private int passos = 1;

        public Form1()
        {
            InitializeComponent();
        }

        private void BtnOperacao(object sender, EventArgs e)
        {
            operador = ((Button)sender).Text;
            lblSinal.Text = operador;
        }

        private void BtnIgual(object sender, EventArgs e)
        {
            switch (operador)
            {
                case ("+"):
                    resultadoMatematico = primeiroValor + segundoValor;
                    break;

                case ("/"):
                    if (segundoValor == 0)
                    {
                        lblResultado.Text = "Não é possível dividir por zero";
                        break;
                    }
                    resultadoMatematico = primeiroValor / segundoValor;
                    break;

                case ("*"):
                    resultadoMatematico = primeiroValor * segundoValor;
                    break;

                case ("-"):
                    resultadoMatematico = primeiroValor - segundoValor;
                    break;
            }

            primeiroValor = resultadoMatematico;

            operador = string.Empty;

            Pnumero.Text = string.Empty;
        }
        private void BtnZero(object sender, EventArgs e)
        {
            AtribuirValor(((Button)sender).Text);
        }

        private void BtnUm(object sender, EventArgs e)
        {
            AtribuirValor(((Button)sender).Text);
        }

        private void BtnDois(object sender, EventArgs e)
        {
            AtribuirValor(((Button)sender).Text);
        }

        private void BtnTres(object sender, EventArgs e)
        {
            AtribuirValor(((Button)sender).Text);
        }

        private void BtnQuatro(object sender, EventArgs e)
        {
            AtribuirValor(((Button)sender).Text);
        }

        private void BtnCinco(object sender, EventArgs e)
        {
            AtribuirValor(((Button)sender).Text);
        }

        private void BtnSeis(object sender, EventArgs e)
        {
            AtribuirValor(((Button)sender).Text);
        }

        private void BtnSete(object sender, EventArgs e)
        {
            AtribuirValor(((Button)sender).Text);
        }

        private void BtnOito(object sender, EventArgs e)
        {
            AtribuirValor(((Button)sender).Text);
        }

        private void BtnNove(object sender, EventArgs e)
        {
            AtribuirValor(((Button)sender).Text);
        }

        private void BtnInverteSinal(object sender, EventArgs e)
        {
            if (passos == 1)
            {
                primeiroValor *= -1;
                s1 = Convert.ToString(primeiroValor);
                lblPrimeiroValor.Text = s1;
                Pnumero.Text = s1;
            }
            if (passos == 2)
            {
                Pnumero.Text = "";
                segundoValor *= -1;
                s2 = Convert.ToString(segundoValor);
                lblSegundoValor.Text = s2;

                Pnumero.Text = s2;
            }
        }

        private void BtnClear(object sender, EventArgs e)
        {
            primeiroValor = 0;
            segundoValor = 0;
            Pnumero.Text = string.Empty;
            lblResultado.Text = string.Empty;
            lblPrimeiroValor.Text = string.Empty;
            lblSegundoValor.Text = string.Empty;
            lblSinal.Text = string.Empty;
        }

        private void AtribuirValor(string valor)
        {

            if (string.IsNullOrEmpty(operador))
            {
                lblPrimeiroValor.Text += valor;
                primeiroValor = Convert.ToDecimal(lblPrimeiroValor.Text);
            }
            else
            {
                lblSegundoValor.Text += valor;
                segundoValor = Convert.ToDecimal(lblSegundoValor.Text);
            }
        }
    }
}
