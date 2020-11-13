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
        //ponto que vai ser utilizado
        //private string ponto;
        private int passos = 1;
        private int pontoum;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnSoma(object sender, EventArgs e)
        {
            operador = ((Button)sender).Text;

            if (passos == 3)
            {
                passos = 2;

                primeiroValor = Convert.ToInt32(resultadoMatematico);
                resultadoMatematico = 0;
                segundoValor = 0;
                s1 = Convert.ToString(primeiroValor);
                lblResultado.Text = "0"; lblPrimeiroValor.Text = s1; lblSegundoValor.Text = "0"; lblSinal.Text = "";
            }
            passos = 2;
            if (passos == 2)
            {
                pontoum = 1;
                Pnumero.Text = operador;
                lblSinal.Text = operador;
            }
        }

        private void btnDivisao(object sender, EventArgs e)
        {
            operador = ((Button)sender).Text;

            if (passos == 3)
            {
                passos = 2;

                primeiroValor = Convert.ToInt32(resultadoMatematico);
                resultadoMatematico = 0;
                segundoValor = 0;
                Pnumero.Text = "";
                s1 = Convert.ToString(primeiroValor);
                lblResultado.Text = "0"; lblPrimeiroValor.Text = s1; lblSegundoValor.Text = "0"; lblSinal.Text = "";
            }
            passos = 2;
            if (passos == 2)
            {
                pontoum = 2;
                Pnumero.Text = operador;
                lblSinal.Text = operador;
            }
        }

        private void btnMultiplicacao(object sender, EventArgs e)
        {
            operador = ((Button)sender).Text;

            if (passos == 3)
            {
                passos = 2;

                primeiroValor = Convert.ToInt32(resultadoMatematico);
                resultadoMatematico = 0;
                segundoValor = 0;
                Pnumero.Text = "";
                s1 = Convert.ToString(primeiroValor);
                lblResultado.Text = "0"; lblPrimeiroValor.Text = s1; lblSegundoValor.Text = "0"; lblSinal.Text = "";
            }
            passos = 2;
            if (passos == 2)
            {
                pontoum = 3;
                Pnumero.Text = operador;
                lblSinal.Text = operador;
            }
        }

        private void btnSubtracao(object sender, EventArgs e)
        {
            operador = ((Button)sender).Text;

            if (passos == 3)
            {
                passos = 2;

                primeiroValor = Convert.ToInt32(resultadoMatematico);
                resultadoMatematico = 0;
                segundoValor = 0;
                Pnumero.Text = "";
                s1 = Convert.ToString(primeiroValor);
                lblResultado.Text = "0"; lblPrimeiroValor.Text = s1; lblSegundoValor.Text = "0"; lblSinal.Text = "";
            }
            passos = 2;
            if (passos == 2)
            {
                pontoum = 4;
                Pnumero.Text = operador;
                lblSinal.Text = operador;
            }
        }

        private void btnIgual(object sender, EventArgs e)
        {
            // funcao que diz qual vai ser o resultado pela funçao matematica
            switch (operador)
            {
                case ("+"):
                    resultadoMatematico = primeiroValor + segundoValor;
                    break;

                case ("/"):
                    if (segundoValor == 0)
                    {
                        lblResultado.Text = "Não dividirás por zero!";
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
            
            lblResultado.Text = " = " + resultadoMatematico.ToString();
            Pnumero.Text = string.Empty;

            if (passos >= 4)
            {
                passos = 0;
            }
        }
        private void btnZero(object sender, EventArgs e)
        {
            AtribuirValor(((Button)sender).Text);
        }

        private void btnUm(object sender, EventArgs e)
        {
            AtribuirValor(((Button)sender).Text);
        }

        private void btnDois(object sender, EventArgs e)
        {
            AtribuirValor(((Button)sender).Text);
        }

        private void btnTres(object sender, EventArgs e)
        {
            AtribuirValor(((Button)sender).Text);
        }

        private void btnQuatro(object sender, EventArgs e)
        {
            AtribuirValor(((Button)sender).Text);
        }

        private void btnCinco(object sender, EventArgs e)
        {
            AtribuirValor(((Button)sender).Text);
        }

        private void btnSeis(object sender, EventArgs e)
        {
            AtribuirValor(((Button)sender).Text);
        }

        private void btnSete(object sender, EventArgs e)
        {
            AtribuirValor(((Button)sender).Text);
        }

        private void btnOito(object sender, EventArgs e)
        {
            AtribuirValor(((Button)sender).Text);
        }

        private void btnNove(object sender, EventArgs e)
        {
            AtribuirValor(((Button)sender).Text);
        }

        private void btnInverteSinal(object sender, EventArgs e)
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

        private void btnClear(object sender, EventArgs e)
        {
            passos = 1;
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
