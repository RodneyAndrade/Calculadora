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
        private int delete = -1;

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
            delete++;
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
            delete = -1;
            lblSegundaLinha.Text = string.Empty;
        }

        private void BtnIgual(object sender, EventArgs e)
        {
            switch (operador)
            {
                case ("+"):
                    resultadoMatematico = primeiroValor + segundoValor;
                    break;

                case ("÷"):
                    if (segundoValor == 0)
                    {
                        lblPrimeiraLinha.Text = primeiroValor.ToString() + " " + operador + " " + segundoValor.ToString() + " = ";
                        lblSegundaLinha.Text = "Não é possível dividir por zero";
                        return;
                    }
                    resultadoMatematico = primeiroValor / segundoValor;
                    break;

                case ("x"):
                    resultadoMatematico = primeiroValor * segundoValor;
                    break;

                case ("-"):
                    resultadoMatematico = primeiroValor - segundoValor;
                    break;
            }

            lblPrimeiraLinha.Text = primeiroValor.ToString() + " " + operador + " " + segundoValor.ToString() + " = ";

            primeiroValor = resultadoMatematico;
            
            lblSegundaLinha.Text = resultadoMatematico.ToString();
        }

        private void BtnInverteSinal(object sender, EventArgs e)
        {
            const string negativo = "-";

            if (string.IsNullOrEmpty(lblSegundaLinha.Text))
            {
                lblSegundaLinha.Text = negativo;
                return;
            }

            var primeiroCaracter = lblSegundaLinha.Text.Substring(0, 1);

            if (primeiroCaracter.Equals(negativo))
            {
                lblSegundaLinha.Text = lblSegundaLinha.Text.Replace(negativo, string.Empty);
            }
            else
            {
                lblSegundaLinha.Text = negativo + lblSegundaLinha.Text;
            }

            if (string.IsNullOrEmpty(operador))
            {
                primeiroValor = Convert.ToDecimal(lblSegundaLinha.Text);
            }
            else
            {
                segundoValor = Convert.ToDecimal(lblSegundaLinha.Text);
            }
        }

        private void BtnLimpar(object sender, EventArgs e)
        {
            primeiroValor = 0;
            segundoValor = 0;
            resultadoMatematico = 0;
            operador = string.Empty;
            lblPrimeiraLinha.Text = string.Empty;
            lblSegundaLinha.Text = string.Empty;
            delete = -1;
        }

        private void BtnRaizQdrd(object sender, EventArgs e)
        {
            if(primeiroValor == 0)
            {
                lblSegundaLinha.Text = "0";
                lblPrimeiraLinha.Text = "√(0) =";
                primeiroValor = 0;
            }
            else
            {
                double raiz1 = Convert.ToDouble(primeiroValor);
                double raiz = Math.Sqrt(raiz1);
                lblSegundaLinha.Text = raiz.ToString();
                lblPrimeiraLinha.Text = "√(" + raiz1 + ") =";
                primeiroValor = Convert.ToDecimal(raiz);
            }
        }

        private void BtnPotencia(object sender, EventArgs e)
        {
                resultadoMatematico = primeiroValor * primeiroValor;
                lblSegundaLinha.Text = resultadoMatematico.ToString();
                lblPrimeiraLinha.Text = "sqr(" + primeiroValor + ") =";
        }

        private void BtnPonto_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(operador))
            {
                lblSegundaLinha.Text = primeiroValor + ","; 
            }
            else
            {
                lblSegundaLinha.Text = segundoValor + ",";
            }
        }
        private void BtnPorcent(object sender, EventArgs e)
        {
            if (operador == "x")
            {
                segundoValor = Convert.ToDecimal(lblSegundaLinha.Text);
                segundoValor /= 100;
                lblPrimeiraLinha.Text = primeiroValor + " x";
                lblSegundaLinha.Text = segundoValor.ToString();
            }
        }

        private void BtnCE(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(operador))
            {
                primeiroValor = 0;
                lblSegundaLinha.Text = string.Empty;
            }
            else
            {
                segundoValor = 0;
                lblSegundaLinha.Text = string.Empty;
            }
        }

        private void DividirUm(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(operador))
            {
                primeiroValor = Convert.ToDecimal(lblSegundaLinha.Text);
                resultadoMatematico = 1 / primeiroValor;
                lblPrimeiraLinha.Text = "1/(" + primeiroValor + ")";
                lblSegundaLinha.Text = resultadoMatematico.ToString();
                primeiroValor = resultadoMatematico;
            }
            else
            {
                segundoValor = Convert.ToDecimal(lblSegundaLinha.Text);
                resultadoMatematico = 1 / segundoValor;
                lblPrimeiraLinha.Text = primeiroValor + " " + operador + " 1/(" + segundoValor + ")";
                lblSegundaLinha.Text = resultadoMatematico.ToString();
                segundoValor = resultadoMatematico;
            }
        }

        private void BotnDeletar(object sender, EventArgs e)
        {
            if (delete >= 0)
            {
                lblSegundaLinha.Text = lblSegundaLinha.Text.Remove(delete);
                delete--;
            }
        }
    }
}
