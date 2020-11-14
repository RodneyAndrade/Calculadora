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
        private int passos = 1;

        public Form1()
        {
            InitializeComponent();
        }

        private void AtribuirValor(object sender, EventArgs e)
        {
            var valor = ((Button)sender).Text;

            if (string.IsNullOrEmpty(operador))
            {
                lblSegundaLinha.Text += valor;
                primeiroValor = Convert.ToDecimal(lblSegundaLinha.Text);
            }
            else
            {
                lblSegundaLinha.Text += valor;
                segundoValor = Convert.ToDecimal(lblSegundaLinha.Text);
            }
        }

        private void AtribuirOperacao(object sender, EventArgs e)
        {
            var operacao = ((Button)sender).Text;

            if (string.IsNullOrEmpty(operador))
            {
                operador = operacao;
                lblPrimeiraLinha.Text = lblSegundaLinha.Text + " " + operador + " ";
            }
            else
            {
                lblPrimeiraLinha.Text = lblPrimeiraLinha.Text.Replace(operador, operacao);
                operador = operacao;
            }

            lblSegundaLinha.Text = string.Empty;
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
                        lblPrimeiraLinha.Text = primeiroValor.ToString() + " " + operador + " " + segundoValor.ToString() + " = ";
                        lblSegundaLinha.Text = "Não é possível dividir por zero";
                        return;
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

            lblPrimeiraLinha.Text = primeiroValor.ToString() + " " + operador + " " + segundoValor.ToString() + " = ";

            lblSegundaLinha.Text = resultadoMatematico.ToString();
        }

        private void BtnInverteSinal(object sender, EventArgs e)
        {
            if (passos == 1)
            {
                primeiroValor *= -1;
            }
            if (passos == 2)
            {
                segundoValor *= -1;
            }
        }

        private void BtnLimpar(object sender, EventArgs e)
        {
            primeiroValor = 0;
            segundoValor = 0;
            lblPrimeiraLinha.Text = string.Empty;
            lblSegundaLinha.Text = string.Empty;
        }
    }
}
