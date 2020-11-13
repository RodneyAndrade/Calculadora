namespace calculadora_forms
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnZero = new System.Windows.Forms.Button();
            this.btnUm = new System.Windows.Forms.Button();
            this.btnDois = new System.Windows.Forms.Button();
            this.btnTres = new System.Windows.Forms.Button();
            this.btnQuatro = new System.Windows.Forms.Button();
            this.btnCinco = new System.Windows.Forms.Button();
            this.btnSeis = new System.Windows.Forms.Button();
            this.btnSete = new System.Windows.Forms.Button();
            this.btnOito = new System.Windows.Forms.Button();
            this.btnNove = new System.Windows.Forms.Button();

            this.btnSoma = new System.Windows.Forms.Button();
            this.btnSubtracao = new System.Windows.Forms.Button();
            this.btnMultiplicacao = new System.Windows.Forms.Button();
            this.btnDivisao = new System.Windows.Forms.Button();

            this.btnIgual = new System.Windows.Forms.Button();

            this.btnInversaoSinal = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();

            this.Pnumero = new System.Windows.Forms.TextBox();
            this.lblResultado = new System.Windows.Forms.Label();
            this.lblPrimeiroValor = new System.Windows.Forms.Label();
            this.lblSegundoValor = new System.Windows.Forms.Label();
            this.lblSinal = new System.Windows.Forms.Label();

            this.SuspendLayout();

            // 
            // btnZero
            // 
            this.btnZero.Location = new System.Drawing.Point(93, 397);
            this.btnZero.Name = "zero";
            this.btnZero.Size = new System.Drawing.Size(75, 60);
            this.btnZero.TabIndex = 5;
            this.btnZero.Text = "0";
            this.btnZero.UseVisualStyleBackColor = true;
            this.btnZero.Click += new System.EventHandler(this.AtribuirValor);
            // 
            // btnUm
            // 
            this.btnUm.Location = new System.Drawing.Point(12, 331);
            this.btnUm.Name = "um";
            this.btnUm.Size = new System.Drawing.Size(75, 60);
            this.btnUm.TabIndex = 5;
            this.btnUm.Text = "1";
            this.btnUm.UseVisualStyleBackColor = true;
            this.btnUm.Click += new System.EventHandler(this.AtribuirValor);
            // 
            // btnDois
            // 
            this.btnDois.Location = new System.Drawing.Point(93, 331);
            this.btnDois.Name = "dois";
            this.btnDois.Size = new System.Drawing.Size(75, 60);
            this.btnDois.TabIndex = 5;
            this.btnDois.Text = "2";
            this.btnDois.UseVisualStyleBackColor = true;
            this.btnDois.Click += new System.EventHandler(this.AtribuirValor);
            // 
            // btnTres
            // 
            this.btnTres.Location = new System.Drawing.Point(174, 331);
            this.btnTres.Name = "tres";
            this.btnTres.Size = new System.Drawing.Size(75, 60);
            this.btnTres.TabIndex = 5;
            this.btnTres.Text = "3";
            this.btnTres.UseVisualStyleBackColor = true;
            this.btnTres.Click += new System.EventHandler(this.AtribuirValor);
            // 
            // btnQuatro
            // 
            this.btnQuatro.Location = new System.Drawing.Point(12, 265);
            this.btnQuatro.Name = "quatro";
            this.btnQuatro.Size = new System.Drawing.Size(75, 60);
            this.btnQuatro.TabIndex = 5;
            this.btnQuatro.Text = "4";
            this.btnQuatro.UseVisualStyleBackColor = true;
            this.btnQuatro.Click += new System.EventHandler(this.AtribuirValor);
            // 
            // btnCinco
            // 
            this.btnCinco.Location = new System.Drawing.Point(93, 265);
            this.btnCinco.Name = "cinco";
            this.btnCinco.Size = new System.Drawing.Size(75, 60);
            this.btnCinco.TabIndex = 5;
            this.btnCinco.Text = "5";
            this.btnCinco.UseVisualStyleBackColor = true;
            this.btnCinco.Click += new System.EventHandler(this.AtribuirValor);
            // 
            // btnSeis
            // 
            this.btnSeis.Location = new System.Drawing.Point(174, 265);
            this.btnSeis.Name = "seis";
            this.btnSeis.Size = new System.Drawing.Size(75, 60);
            this.btnSeis.TabIndex = 7;
            this.btnSeis.Text = "6";
            this.btnSeis.UseVisualStyleBackColor = true;
            this.btnSeis.Click += new System.EventHandler(this.AtribuirValor);
            // 
            // btnSete
            // 
            this.btnSete.Location = new System.Drawing.Point(12, 199);
            this.btnSete.Name = "sete";
            this.btnSete.Size = new System.Drawing.Size(75, 60);
            this.btnSete.TabIndex = 5;
            this.btnSete.Text = "7";
            this.btnSete.UseVisualStyleBackColor = true;
            this.btnSete.Click += new System.EventHandler(this.AtribuirValor);
            // 
            // btnOito
            // 
            this.btnOito.Location = new System.Drawing.Point(93, 199);
            this.btnOito.Name = "oito";
            this.btnOito.Size = new System.Drawing.Size(75, 60);
            this.btnOito.TabIndex = 6;
            this.btnOito.Text = "8";
            this.btnOito.UseVisualStyleBackColor = true;
            this.btnOito.Click += new System.EventHandler(this.AtribuirValor);
            // 
            // btnNove
            // 
            this.btnNove.Location = new System.Drawing.Point(174, 199);
            this.btnNove.Name = "nove";
            this.btnNove.Size = new System.Drawing.Size(75, 60);
            this.btnNove.TabIndex = 5;
            this.btnNove.Text = "9";
            this.btnNove.UseVisualStyleBackColor = true;
            this.btnNove.Click += new System.EventHandler(this.AtribuirValor);


            // 
            // btnSoma
            // 
            this.btnSoma.Location = new System.Drawing.Point(255, 199);
            this.btnSoma.Name = "soma";
            this.btnSoma.Size = new System.Drawing.Size(75, 60);
            this.btnSoma.TabIndex = 10;
            this.btnSoma.Text = "+";
            this.btnSoma.UseVisualStyleBackColor = true;
            this.btnSoma.Click += new System.EventHandler(this.AtribuirOperacao);
            // 
            // btnSubtracao
            // 
            this.btnSubtracao.Location = new System.Drawing.Point(255, 265);
            this.btnSubtracao.Name = "subtracao";
            this.btnSubtracao.Size = new System.Drawing.Size(75, 60);
            this.btnSubtracao.TabIndex = 11;
            this.btnSubtracao.Text = "-";
            this.btnSubtracao.UseVisualStyleBackColor = true;
            this.btnSubtracao.Click += new System.EventHandler(this.AtribuirOperacao);
            // 
            // btnMultiplicacao
            // 
            this.btnMultiplicacao.Location = new System.Drawing.Point(255, 332);
            this.btnMultiplicacao.Name = "multiplicacao";
            this.btnMultiplicacao.Size = new System.Drawing.Size(75, 59);
            this.btnMultiplicacao.TabIndex = 12;
            this.btnMultiplicacao.Text = "*";
            this.btnMultiplicacao.UseVisualStyleBackColor = true;
            this.btnMultiplicacao.Click += new System.EventHandler(this.AtribuirOperacao);
            // 
            // btnDivisao
            // 
            this.btnDivisao.Location = new System.Drawing.Point(255, 397);
            this.btnDivisao.Name = "divisao";
            this.btnDivisao.Size = new System.Drawing.Size(75, 60);
            this.btnDivisao.TabIndex = 13;
            this.btnDivisao.Text = "/";
            this.btnDivisao.UseVisualStyleBackColor = true;
            this.btnDivisao.Click += new System.EventHandler(this.AtribuirOperacao);


            // 
            // botaoIgual
            // 
            this.btnIgual.Location = new System.Drawing.Point(255, 133);
            this.btnIgual.Name = "igual";
            this.btnIgual.Size = new System.Drawing.Size(75, 60);
            this.btnIgual.TabIndex = 0;
            this.btnIgual.Text = "=";
            this.btnIgual.UseVisualStyleBackColor = true;
            this.btnIgual.Click += new System.EventHandler(this.BtnIgual);

            // 
            // btnInversaoSinal
            // 
            this.btnInversaoSinal.Location = new System.Drawing.Point(13, 398);
            this.btnInversaoSinal.Name = "inversao de sinal";
            this.btnInversaoSinal.Size = new System.Drawing.Size(75, 59);
            this.btnInversaoSinal.TabIndex = 16;
            this.btnInversaoSinal.Text = "+/-";
            this.btnInversaoSinal.UseVisualStyleBackColor = true;
            this.btnInversaoSinal.Click += new System.EventHandler(this.BtnInverteSinal);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(174, 397);
            this.btnLimpar.Name = "clear";
            this.btnLimpar.Size = new System.Drawing.Size(75, 60);
            this.btnLimpar.TabIndex = 18;
            this.btnLimpar.Text = "C";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.BtnLimpar);

            // 
            // Pnumero
            // 
            this.Pnumero.Font = new System.Drawing.Font("Niagara Solid", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Pnumero.Location = new System.Drawing.Point(12, 42);
            this.Pnumero.Name = "Pnumero";
            this.Pnumero.Size = new System.Drawing.Size(318, 59);
            this.Pnumero.TabIndex = 1;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(144, 13);
            this.lblResultado.Name = "label1";
            this.lblResultado.Size = new System.Drawing.Size(13, 15);
            this.lblResultado.TabIndex = 4;
            this.lblResultado.Text = string.Empty;
            // 
            // lblPrimeiroValor
            // 
            this.lblPrimeiroValor.AutoSize = true;
            this.lblPrimeiroValor.Location = new System.Drawing.Point(12, 13);
            this.lblPrimeiroValor.Name = "primeiro valor";
            this.lblPrimeiroValor.Size = new System.Drawing.Size(13, 15);
            this.lblPrimeiroValor.TabIndex = 8;
            this.lblPrimeiroValor.Text = string.Empty;
            // 
            // lblSegundoValor
            // 
            this.lblSegundoValor.AutoSize = true;
            this.lblSegundoValor.Location = new System.Drawing.Point(100, 13);
            this.lblSegundoValor.Name = "segundo valor";
            this.lblSegundoValor.Size = new System.Drawing.Size(13, 15);
            this.lblSegundoValor.TabIndex = 9;
            this.lblSegundoValor.Text = string.Empty;
            // 
            // lblSinal
            // 
            this.lblSinal.AutoSize = true;
            this.lblSinal.Location = new System.Drawing.Point(56, 13);
            this.lblSinal.Name = "label5";
            this.lblSinal.Size = new System.Drawing.Size(0, 15);
            this.lblSinal.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 469);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnInversaoSinal);
            this.Controls.Add(this.lblSinal);
            this.Controls.Add(this.btnDivisao);
            this.Controls.Add(this.btnMultiplicacao);
            this.Controls.Add(this.btnSubtracao);
            this.Controls.Add(this.btnSoma);
            this.Controls.Add(this.lblSegundoValor);
            this.Controls.Add(this.lblPrimeiroValor);
            this.Controls.Add(this.btnZero);
            this.Controls.Add(this.btnUm);
            this.Controls.Add(this.btnTres);
            this.Controls.Add(this.btnDois);
            this.Controls.Add(this.btnQuatro);
            this.Controls.Add(this.btnSete);
            this.Controls.Add(this.btnCinco);
            this.Controls.Add(this.btnSeis);
            this.Controls.Add(this.btnOito);
            this.Controls.Add(this.btnNove);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.Pnumero);
            this.Controls.Add(this.btnIgual);
            this.Name = "Form1";
            this.Text = "Calculadora Rampister";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnZero;
        private System.Windows.Forms.Button btnUm;
        private System.Windows.Forms.Button btnDois;
        private System.Windows.Forms.Button btnTres;
        private System.Windows.Forms.Button btnQuatro;
        private System.Windows.Forms.Button btnCinco;
        private System.Windows.Forms.Button btnSeis;
        private System.Windows.Forms.Button btnSete;
        private System.Windows.Forms.Button btnOito;
        private System.Windows.Forms.Button btnNove;
        private System.Windows.Forms.Button btnSoma;
        private System.Windows.Forms.Button btnSubtracao;
        private System.Windows.Forms.Button btnMultiplicacao;
        private System.Windows.Forms.Button btnDivisao;
        private System.Windows.Forms.Button btnIgual;
        private System.Windows.Forms.Button btnInversaoSinal;
        private System.Windows.Forms.Button btnLimpar;

        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Label lblPrimeiroValor;
        private System.Windows.Forms.Label lblSegundoValor;
        private System.Windows.Forms.Label lblSinal;

        private System.Windows.Forms.TextBox Pnumero;
    }
}

