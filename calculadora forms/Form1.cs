using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadora_forms
{
    public partial class Form1 : Form
    {
        private decimal resultadoMatematico;
        private decimal primeiroVAlor;
        private decimal segundoValor;
        private string s1;
        private string s2;
        //ponto que vai ser utilizado
        private string ponto;
        private int passos = 1;
        private int pontoum;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnSoma(object sender, EventArgs e)
        {
            if (passos == 3)
            {
                passos = 2;

                primeiroVAlor = Convert.ToInt32(resultadoMatematico);
                resultadoMatematico = 0;
                segundoValor = 0;
                Pnumero.Text = "";
                ponto = "";
                s1 = Convert.ToString(primeiroVAlor);
                label1.Text = "0"; label2.Text = s1; label3.Text = "0"; label5.Text = "";
            }
            passos = 2;
            if (passos == 2)
            {
                ponto = "+";
                pontoum = 1;
                Pnumero.Text = ponto;
                label5.Text = ponto;
            }
        }

        private void btnDivisao(object sender, EventArgs e)
        {
            if (passos == 3)
            {
                passos = 2;

                primeiroVAlor = Convert.ToInt32(resultadoMatematico);
                resultadoMatematico = 0;
                segundoValor = 0;
                Pnumero.Text = "";
                ponto = "";
                s1 = Convert.ToString(primeiroVAlor);
                label1.Text = "0"; label2.Text = s1; label3.Text = "0"; label5.Text = "";
            }
            passos = 2;
            if (passos == 2)
            {
                ponto = "/";
                pontoum = 2;
                label5.Text = ponto;
                Pnumero.Text = ponto;
                label5.Text = ponto;
            }
        }

        private void btnMultiplicacao(object sender, EventArgs e)
        {
            if (passos == 3)
            {
                passos = 2;

                primeiroVAlor = Convert.ToInt32(resultadoMatematico);
                resultadoMatematico = 0;
                segundoValor = 0;
                Pnumero.Text = "";
                ponto = "";
                s1 = Convert.ToString(primeiroVAlor);
                label1.Text = "0"; label2.Text = s1; label3.Text = "0"; label5.Text = "";
            }
            passos = 2;
            if (passos == 2)
            {
                ponto = "*";
                pontoum = 3;
                Pnumero.Text = ponto;
                label5.Text = ponto;
            }
        }

        private void btnSubtracao(object sender, EventArgs e)
        {
            if (passos == 3)
            {
                passos = 2;

                primeiroVAlor = Convert.ToInt32(resultadoMatematico);
                resultadoMatematico = 0;
                segundoValor = 0;
                Pnumero.Text = "";
                ponto = "";
                s1 = Convert.ToString(primeiroVAlor);
                label1.Text = "0"; label2.Text = s1; label3.Text = "0"; label5.Text = "";
            }
            passos = 2;
            if (passos == 2)
            {
                ponto = "-";
                pontoum = 4;
                Pnumero.Text = ponto;
                label5.Text = ponto;
            }
        }


        private void btnIgual(object sender, EventArgs e)
        {
            // funcao que diz qual vai ser o resultado pela funçao matematica
            switch (ponto)
            {
                case ("+"):
                    resultadoMatematico = primeiroVAlor + segundoValor;
                    break;

                case ("/"):
                    if (segundoValor == 0)
                    {
                        label1.Text = "Não dividirás por zero!";
                        break;
                    }
                    resultadoMatematico = primeiroVAlor / segundoValor;
                    break;

                case ("*"):
                    resultadoMatematico = primeiroVAlor * segundoValor;
                    break;

                case ("-"):
                    resultadoMatematico = primeiroVAlor - segundoValor;
                    break;
            }

            primeiroVAlor = resultadoMatematico;
            
            label1.Text = resultadoMatematico.ToString();
            Pnumero.Text = string.Empty;

            if (passos >= 4)
            {
                passos = 0;
            }
        }

        private void btnTres(object sender, EventArgs e)
        {
            if (passos == 3)
            {
                passos = 1;

                primeiroVAlor = Convert.ToInt32(resultadoMatematico);
                resultadoMatematico = 0;
                segundoValor = 0;
                Pnumero.Text = "";
                ponto = "";
                s1 = Convert.ToString(primeiroVAlor);
                label1.Text = "0"; label2.Text = s1; label3.Text = "0"; label5.Text = "";
            }
            if (passos == 1)
            {
                primeiroVAlor = (primeiroVAlor * 10) + 3;
                s1 = Convert.ToString(primeiroVAlor);
                label2.Text = s1;
                Pnumero.Text = s1;
            }
            if (passos == 2)
            {
                Pnumero.Text = "";
                segundoValor = (segundoValor * 10) + 3;
                s2 = Convert.ToString(segundoValor);
                label3.Text = s2;

                Pnumero.Text = s2;
            }
        }

        private void btnUm(object sender, EventArgs e)
        {
            if (passos == 3)
            {
                passos = 1;

                primeiroVAlor = Convert.ToInt32(resultadoMatematico);
                resultadoMatematico = 0;
                segundoValor = 0;
                Pnumero.Text = "";
                ponto = "";
                s1 = Convert.ToString(primeiroVAlor);
                label1.Text = "0"; label2.Text = s1; label3.Text = "0"; label5.Text = "";
            }
            if (passos == 1)
            {
                primeiroVAlor = (primeiroVAlor * 10) + 1;
                s1 = Convert.ToString(primeiroVAlor);
                label2.Text = s1;
                Pnumero.Text = s1;
            }
            if (passos == 2)
            {
                Pnumero.Text = "";
                segundoValor = (segundoValor * 10) + 1;
                s2 = Convert.ToString(segundoValor);
                label3.Text = s2;

                Pnumero.Text = s2;
            }

        }

        private void btnNove(object sender, EventArgs e)
        {
            if (passos == 3)
            {
                passos = 1;

                primeiroVAlor = Convert.ToInt32(resultadoMatematico);
                resultadoMatematico = 0;
                segundoValor = 0;
                Pnumero.Text = "";
                ponto = "";
                s1 = Convert.ToString(primeiroVAlor);
                label1.Text = "0"; label2.Text = s1; label3.Text = "0"; label5.Text = "";
            }
            if (passos == 1)
            {
                primeiroVAlor = (primeiroVAlor * 10) + 9;
                s1 = Convert.ToString(primeiroVAlor);
                label2.Text = s1;
                Pnumero.Text = s1;
            }
            if (passos == 2)
            {
                Pnumero.Text = "";
                segundoValor = (segundoValor * 10) + 9;
                s2 = Convert.ToString(segundoValor);
                label3.Text = s2;

                Pnumero.Text = s2;
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (passos == 3)
            {
                passos = 1;

                primeiroVAlor = Convert.ToInt32(resultadoMatematico);
                resultadoMatematico = 0;
                segundoValor = 0;
                Pnumero.Text = "";
                ponto = "";
                s1 = Convert.ToString(primeiroVAlor);
                label1.Text = "0"; label2.Text = s1; label3.Text = "0"; label5.Text = "";
            }
            if (passos == 1)
            {
                primeiroVAlor = (primeiroVAlor * 10) + 8;
                s1 = Convert.ToString(primeiroVAlor);
                label2.Text = s1;
                Pnumero.Text = s1;
            }
            if (passos == 2)
            {
                Pnumero.Text = "";
                segundoValor = (segundoValor * 10) + 8;
                s2 = Convert.ToString(segundoValor);
                label3.Text = s2;

                Pnumero.Text = s2;
            }


        }

        private void btnSete(object sender, EventArgs e)
        {
            if (passos == 3)
            {
                passos = 1;

                primeiroVAlor = Convert.ToInt32(resultadoMatematico);
                resultadoMatematico = 0;
                segundoValor = 0;
                Pnumero.Text = "";
                ponto = "";
                s1 = Convert.ToString(primeiroVAlor);
                label1.Text = "0"; label2.Text = s1; label3.Text = "0"; label5.Text = "";
            }
            if (passos == 1)
            {
                primeiroVAlor = (primeiroVAlor * 10) + 7;
                s1 = Convert.ToString(primeiroVAlor);
                label2.Text = s1;
                Pnumero.Text = s1;
            }
            if (passos == 2)
            {
                Pnumero.Text = "";
                segundoValor = (segundoValor * 10) + 7;
                s2 = Convert.ToString(segundoValor);
                label3.Text = s2;

                Pnumero.Text = s2;
            }

        }

        private void btnSeis(object sender, EventArgs e)
        {
            if (passos == 3)
            {
                passos = 1;

                primeiroVAlor = Convert.ToInt32(resultadoMatematico);
                resultadoMatematico = 0;
                segundoValor = 0;
                Pnumero.Text = "";
                ponto = "";
                s1 = Convert.ToString(primeiroVAlor);
                label1.Text = "0"; label2.Text = s1; label3.Text = "0"; label5.Text = "";
            }
            if (passos == 1)
            {
                primeiroVAlor = (primeiroVAlor * 10) + 6;
                s1 = Convert.ToString(primeiroVAlor);
                label2.Text = s1;
                Pnumero.Text = s1;
            }
            if (passos == 2)
            {
                Pnumero.Text = "";
                segundoValor = (segundoValor * 10) + 6;
                s2 = Convert.ToString(segundoValor);
                label3.Text = s2;

                Pnumero.Text = s2;
            }
        }

        private void btnCinco(object sender, EventArgs e)
        {
            if (passos == 3)
            {
                passos = 1;

                primeiroVAlor = Convert.ToInt32(resultadoMatematico);
                resultadoMatematico = 0;
                segundoValor = 0;
                Pnumero.Text = "";
                ponto = "";
                s1 = Convert.ToString(primeiroVAlor);
                label1.Text = "0"; label2.Text = s1; label3.Text = "0"; label5.Text = "";
            }
            if (passos == 1)
            {

                primeiroVAlor = (primeiroVAlor * 10) + 5;
                s1 = Convert.ToString(primeiroVAlor);
                label2.Text = s1;
                Pnumero.Text = s1;
            }
            if (passos == 2)
            {
                Pnumero.Text = "";
                segundoValor = (segundoValor * 10) + 5;
                s2 = Convert.ToString(segundoValor);
                label3.Text = s2;

                Pnumero.Text = s2;
            }
        }

        private void btnQuatro(object sender, EventArgs e)
        {
            if (passos == 3)
            {
                passos = 1;

                primeiroVAlor = Convert.ToInt32(resultadoMatematico);
                resultadoMatematico = 0;
                segundoValor = 0;
                Pnumero.Text = "";
                ponto = "";
                s1 = Convert.ToString(primeiroVAlor);
                label1.Text = "0"; label2.Text = s1; label3.Text = "0"; label5.Text = "";
            }
            if (passos == 1)
            {
                primeiroVAlor = (primeiroVAlor * 10) + 4;
                s1 = Convert.ToString(primeiroVAlor);
                label2.Text = s1;
                Pnumero.Text = s1;
            }
            if (passos == 2)
            {
                Pnumero.Text = "";
                segundoValor = (segundoValor * 10) + 4;
                s2 = Convert.ToString(segundoValor);
                label3.Text = s2;

                Pnumero.Text = s2;
            }
        }

        private void btnDois(object sender, EventArgs e)
        {
            if (passos == 3)
            {
                passos = 1;

                primeiroVAlor = Convert.ToInt32(resultadoMatematico);
                resultadoMatematico = 0;
                segundoValor = 0;
                Pnumero.Text = "";
                ponto = "";
                s1 = Convert.ToString(primeiroVAlor);
                label1.Text = "0"; label2.Text = s1; label3.Text = "0"; label5.Text = "";
            }
            if (passos == 1)
            {
                primeiroVAlor = (primeiroVAlor * 10) + 2;
                s1 = Convert.ToString(primeiroVAlor);
                label2.Text = s1;
                Pnumero.Text = s1;
            }
            if (passos == 2)
            {
                Pnumero.Text = "";
                segundoValor = (segundoValor * 10) + 2;
                s2 = Convert.ToString(segundoValor);
                label3.Text = s2;

                Pnumero.Text = s2;
            }
        }
        private void btnZero(object sender, EventArgs e)
        {
            if (passos == 3)
            {
                passos = 1;

                primeiroVAlor = Convert.ToInt32(resultadoMatematico);
                resultadoMatematico = 0;
                segundoValor = 0;
                Pnumero.Text = "";
                ponto = "";
                s1 = Convert.ToString(primeiroVAlor);
                label1.Text = "0"; label2.Text = s1; label3.Text = "0"; label5.Text = "";
            }
            if (passos == 1)
            {
                primeiroVAlor *= 10;
                s1 = Convert.ToString(primeiroVAlor);
                label2.Text = s1;
                Pnumero.Text = s1;
            }
            if (passos == 2)
            {
                Pnumero.Text = "";
                segundoValor *= 10;
                s2 = Convert.ToString(segundoValor);
                label3.Text = s2;

                Pnumero.Text = s2;
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (passos == 1)
            {
                primeiroVAlor *= -1;
                s1 = Convert.ToString(primeiroVAlor);
                label2.Text = s1;
                Pnumero.Text = s1;
            }
            if (passos == 2)
            {
                Pnumero.Text = "";
                segundoValor *= -1;
                s2 = Convert.ToString(segundoValor);
                label3.Text = s2;

                Pnumero.Text = s2;
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            passos = 1;
            primeiroVAlor = 0;
            segundoValor = 0;
            Pnumero.Text = "";
            ponto = "";
            label1.Text = "0"; label2.Text = "0"; label3.Text = "0"; label5.Text = "";
        }
    }
}
