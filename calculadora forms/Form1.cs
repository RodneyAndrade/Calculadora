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
        private decimal i1;
        private decimal i2;
        private string resultado;
        private string s1;
        private string s2;
        private string s3;
        //ponto que vai ser utilizado
        private string ponto;
        private int qvqae = 1;
        private int pontoum;

        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (qvqae == 3)
            {
                qvqae = 2;

                i1 = Convert.ToInt32(resultadoMatematico);
                resultadoMatematico = 0;
                i2 = 0;
                Pnumero.Text = "";
                ponto = "";
                s1 = Convert.ToString(i1);
                label1.Text = "0"; label2.Text = s1; label3.Text = "0"; label5.Text = "";
            }
            qvqae = 2;
            if (qvqae == 2)
            {
                ponto = "+";
                pontoum = 1;
                Pnumero.Text = ponto;
                label5.Text = ponto;
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (qvqae == 3)
            {
                qvqae = 2;

                i1 = Convert.ToInt32(resultadoMatematico);
                resultadoMatematico = 0;
                i2 = 0;
                Pnumero.Text = "";
                ponto = "";
                s1 = Convert.ToString(i1);
                label1.Text = "0"; label2.Text = s1; label3.Text = "0"; label5.Text = "";
            }
            qvqae = 2;
            if (qvqae == 2)
            {
                ponto = "/";
                pontoum = 2;
                label5.Text = ponto;
                Pnumero.Text = ponto;
                label5.Text = ponto;
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (qvqae == 3)
            {
                qvqae = 2;

                i1 = Convert.ToInt32(resultadoMatematico);
                resultadoMatematico = 0;
                i2 = 0;
                Pnumero.Text = "";
                ponto = "";
                s1 = Convert.ToString(i1);
                label1.Text = "0"; label2.Text = s1; label3.Text = "0"; label5.Text = "";
            }
            qvqae = 2;
            if (qvqae == 2)
            {
                ponto = "*";
                pontoum = 3;
                Pnumero.Text = ponto;
                label5.Text = ponto;
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (qvqae == 3)
            {
                qvqae = 2;

                i1 = Convert.ToInt32(resultadoMatematico);
                resultadoMatematico = 0;
                i2 = 0;
                Pnumero.Text = "";
                ponto = "";
                s1 = Convert.ToString(i1);
                label1.Text = "0"; label2.Text = s1; label3.Text = "0"; label5.Text = "";
            }
            qvqae = 2;
            if (qvqae == 2)
            {
                ponto = "-";
                pontoum = 4;
                Pnumero.Text = ponto;
                label5.Text = ponto;
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            // funcao que diz qual vai ser o resultado pela funçao matematica
            switch (ponto)
            {
                case ("+"):
                    resultadoMatematico = i1 + i2;
                    label1.Text = resultadoMatematico.ToString();
                    //resultado = resultadoMatematico.ToString();

                    break;
                case ("/"):
                    //label1.Text = resultado;
                    if (i2 == 0)
                    {
                        resultado = "Não dividirás por zero!";
                        label1.Text = Convert.ToString(resultadoMatematico);
                        break;
                    }
                    resultadoMatematico = i1 / i2;
                    label1.Text = Convert.ToString(resultadoMatematico);
                    break;
                case ("*"):
                    label1.Text = resultado;
                    resultado = Convert.ToString(resultadoMatematico);
                    resultadoMatematico = i1 * i2;
                    break;
                case ("-"):
                    label1.Text = resultado;
                    resultado = Convert.ToString(resultadoMatematico);
                    resultadoMatematico = i1 - i2;
                    break;
            }

            Pnumero.Text = string.Empty;

            //if (ponto == "+" )
            //{
            //    label1.Text = s;
            //    s = Convert.ToString(f);
            //    f = i1 + i2;
            //}
            //if (ponto == "/" )
            //{
            //    label1.Text = s;
            //    s = Convert.ToString(f);
            //    f = i1 / i2;
            //}
            //if (ponto == "*" )
            //{
            //    label1.Text = s;
            //    s = Convert.ToString(f);
            //    f = i1 * i2;
            //}
            //if (ponto == "-"  )
            //{
            //    label1.Text = s;
            //    s = Convert.ToString(f);
            //    f = i1 - i2;
            //}
            if (qvqae >= 4)
            {
                qvqae = 0;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (qvqae == 3)
            {
                qvqae = 1;

                i1 = Convert.ToInt32(resultadoMatematico);
                resultadoMatematico = 0;
                i2 = 0;
                Pnumero.Text = "";
                ponto = "";
                s1 = Convert.ToString(i1);
                label1.Text = "0"; label2.Text = s1; label3.Text = "0"; label5.Text = "";
            }
            if (qvqae == 1)
            {
                i1 = (i1 * 10) + 3;
                s1 = Convert.ToString(i1);
                label2.Text = s1;
                Pnumero.Text = s1;
            }
            if (qvqae == 2)
            {
                Pnumero.Text = "";
                i2 = (i2 * 10) + 3;
                s2 = Convert.ToString(i2);
                label3.Text = s2;

                Pnumero.Text = s2;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (qvqae == 3)
            {
                qvqae = 1;

                i1 = Convert.ToInt32(resultadoMatematico);
                resultadoMatematico = 0;
                i2 = 0;
                Pnumero.Text = "";
                ponto = "";
                s1 = Convert.ToString(i1);
                label1.Text = "0"; label2.Text = s1; label3.Text = "0"; label5.Text = "";
            }
            if (qvqae == 1)
            {
                i1 = (i1 * 10) + 1;
                s1 = Convert.ToString(i1);
                label2.Text = s1;
                Pnumero.Text = s1;
            }
            if (qvqae == 2)
            {
                Pnumero.Text = "";
                i2 = (i2 * 10) + 1;
                s2 = Convert.ToString(i2);
                label3.Text = s2;

                Pnumero.Text = s2;
            }

        }

        private void botao1_Click(object sender, EventArgs e)
        {
            if (qvqae == 3)
            {
                qvqae = 1;

                i1 = Convert.ToInt32(resultadoMatematico);
                resultadoMatematico = 0;
                i2 = 0;
                Pnumero.Text = "";
                ponto = "";
                s1 = Convert.ToString(i1);
                label1.Text = "0"; label2.Text = s1; label3.Text = "0"; label5.Text = "";
            }
            if (qvqae == 1)
            {
                i1 = (i1 * 10) + 9;
                s1 = Convert.ToString(i1);
                label2.Text = s1;
                Pnumero.Text = s1;
            }
            if (qvqae == 2)
            {
                Pnumero.Text = "";
                i2 = (i2 * 10) + 9;
                s2 = Convert.ToString(i2);
                label3.Text = s2;

                Pnumero.Text = s2;
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (qvqae == 3)
            {
                qvqae = 1;

                i1 = Convert.ToInt32(resultadoMatematico);
                resultadoMatematico = 0;
                i2 = 0;
                Pnumero.Text = "";
                ponto = "";
                s1 = Convert.ToString(i1);
                label1.Text = "0"; label2.Text = s1; label3.Text = "0"; label5.Text = "";
            }
            if (qvqae == 1)
            {
                i1 = (i1 * 10) + 8;
                s1 = Convert.ToString(i1);
                label2.Text = s1;
                Pnumero.Text = s1;
            }
            if (qvqae == 2)
            {
                Pnumero.Text = "";
                i2 = (i2 * 10) + 8;
                s2 = Convert.ToString(i2);
                label3.Text = s2;

                Pnumero.Text = s2;
            }


        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (qvqae == 3)
            {
                qvqae = 1;

                i1 = Convert.ToInt32(resultadoMatematico);
                resultadoMatematico = 0;
                i2 = 0;
                Pnumero.Text = "";
                ponto = "";
                s1 = Convert.ToString(i1);
                label1.Text = "0"; label2.Text = s1; label3.Text = "0"; label5.Text = "";
            }
            if (qvqae == 1)
            {
                i1 = (i1 * 10) + 7;
                s1 = Convert.ToString(i1);
                label2.Text = s1;
                Pnumero.Text = s1;
            }
            if (qvqae == 2)
            {
                Pnumero.Text = "";
                i2 = (i2 * 10) + 7;
                s2 = Convert.ToString(i2);
                label3.Text = s2;

                Pnumero.Text = s2;
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (qvqae == 3)
            {
                qvqae = 1;

                i1 = Convert.ToInt32(resultadoMatematico);
                resultadoMatematico = 0;
                i2 = 0;
                Pnumero.Text = "";
                ponto = "";
                s1 = Convert.ToString(i1);
                label1.Text = "0"; label2.Text = s1; label3.Text = "0"; label5.Text = "";
            }
            if (qvqae == 1)
            {
                i1 = (i1 * 10) + 6;
                s1 = Convert.ToString(i1);
                label2.Text = s1;
                Pnumero.Text = s1;
            }
            if (qvqae == 2)
            {
                Pnumero.Text = "";
                i2 = (i2 * 10) + 6;
                s2 = Convert.ToString(i2);
                label3.Text = s2;

                Pnumero.Text = s2;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (qvqae == 3)
            {
                qvqae = 1;

                i1 = Convert.ToInt32(resultadoMatematico);
                resultadoMatematico = 0;
                i2 = 0;
                Pnumero.Text = "";
                ponto = "";
                s1 = Convert.ToString(i1);
                label1.Text = "0"; label2.Text = s1; label3.Text = "0"; label5.Text = "";
            }
            if (qvqae == 1)
            {

                i1 = (i1 * 10) + 5;
                s1 = Convert.ToString(i1);
                label2.Text = s1;
                Pnumero.Text = s1;
            }
            if (qvqae == 2)
            {
                Pnumero.Text = "";
                i2 = (i2 * 10) + 5;
                s2 = Convert.ToString(i2);
                label3.Text = s2;

                Pnumero.Text = s2;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (qvqae == 3)
            {
                qvqae = 1;

                i1 = Convert.ToInt32(resultadoMatematico);
                resultadoMatematico = 0;
                i2 = 0;
                Pnumero.Text = "";
                ponto = "";
                s1 = Convert.ToString(i1);
                label1.Text = "0"; label2.Text = s1; label3.Text = "0"; label5.Text = "";
            }
            if (qvqae == 1)
            {
                i1 = (i1 * 10) + 4;
                s1 = Convert.ToString(i1);
                label2.Text = s1;
                Pnumero.Text = s1;
            }
            if (qvqae == 2)
            {
                Pnumero.Text = "";
                i2 = (i2 * 10) + 4;
                s2 = Convert.ToString(i2);
                label3.Text = s2;

                Pnumero.Text = s2;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (qvqae == 3)
            {
                qvqae = 1;

                i1 = Convert.ToInt32(resultadoMatematico);
                resultadoMatematico = 0;
                i2 = 0;
                Pnumero.Text = "";
                ponto = "";
                s1 = Convert.ToString(i1);
                label1.Text = "0"; label2.Text = s1; label3.Text = "0"; label5.Text = "";
            }
            if (qvqae == 1)
            {
                i1 = (i1 * 10) + 2;
                s1 = Convert.ToString(i1);
                label2.Text = s1;
                Pnumero.Text = s1;
            }
            if (qvqae == 2)
            {
                Pnumero.Text = "";
                i2 = (i2 * 10) + 2;
                s2 = Convert.ToString(i2);
                label3.Text = s2;

                Pnumero.Text = s2;
            }
        }
        private void button11_Click(object sender, EventArgs e)
        {
            if (qvqae == 3)
            {
                qvqae = 1;

                i1 = Convert.ToInt32(resultadoMatematico);
                resultadoMatematico = 0;
                i2 = 0;
                Pnumero.Text = "";
                ponto = "";
                s1 = Convert.ToString(i1);
                label1.Text = "0"; label2.Text = s1; label3.Text = "0"; label5.Text = "";
            }
            if (qvqae == 1)
            {
                i1 *= 10;
                s1 = Convert.ToString(i1);
                label2.Text = s1;
                Pnumero.Text = s1;
            }
            if (qvqae == 2)
            {
                Pnumero.Text = "";
                i2 *= 10;
                s2 = Convert.ToString(i2);
                label3.Text = s2;

                Pnumero.Text = s2;
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (qvqae == 1)
            {
                i1 *= -1;
                s1 = Convert.ToString(i1);
                label2.Text = s1;
                Pnumero.Text = s1;
            }
            if (qvqae == 2)
            {
                Pnumero.Text = "";
                i2 *= -1;
                s2 = Convert.ToString(i2);
                label3.Text = s2;

                Pnumero.Text = s2;
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            qvqae = 1;
            i1 = 0;
            i2 = 0;
            Pnumero.Text = "";
            ponto = "";
            label1.Text = "0"; label2.Text = "0"; label3.Text = "0"; label5.Text = "";
        }
    }
}
