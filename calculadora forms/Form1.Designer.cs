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
            this.botaoIgual = new System.Windows.Forms.Button();
            this.Pnumero = new System.Windows.Forms.TextBox();
            this.lblResultado = new System.Windows.Forms.Label();
            this.botaoNove = new System.Windows.Forms.Button();
            this.botaoOito = new System.Windows.Forms.Button();
            this.botaoSeis = new System.Windows.Forms.Button();
            this.botaoCinco = new System.Windows.Forms.Button();
            this.botaoSete = new System.Windows.Forms.Button();
            this.botaoQuatro = new System.Windows.Forms.Button();
            this.botaoDois = new System.Windows.Forms.Button();
            this.botaoTres = new System.Windows.Forms.Button();
            this.botaoUm = new System.Windows.Forms.Button();
            this.botaoZero = new System.Windows.Forms.Button();
            this.lblPrimeiroValor = new System.Windows.Forms.Label();
            this.lblSegundoValor = new System.Windows.Forms.Label();
            this.botaoSoma = new System.Windows.Forms.Button();
            this.botaoSubtracao = new System.Windows.Forms.Button();
            this.botaoMultiplicacao = new System.Windows.Forms.Button();
            this.botaoDivisao = new System.Windows.Forms.Button();
            this.lblSinal = new System.Windows.Forms.Label();
            this.botaoInversaoSinal = new System.Windows.Forms.Button();
            this.botaoClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // botaoIgual
            // 
            this.botaoIgual.Location = new System.Drawing.Point(255, 133);
            this.botaoIgual.Name = "igual";
            this.botaoIgual.Size = new System.Drawing.Size(75, 60);
            this.botaoIgual.TabIndex = 0;
            this.botaoIgual.Text = "=";
            this.botaoIgual.UseVisualStyleBackColor = true;
            this.botaoIgual.Click += new System.EventHandler(this.btnIgual);
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
            // botaoNove
            // 
            this.botaoNove.Location = new System.Drawing.Point(174, 199);
            this.botaoNove.Name = "nove";
            this.botaoNove.Size = new System.Drawing.Size(75, 60);
            this.botaoNove.TabIndex = 5;
            this.botaoNove.Text = "9";
            this.botaoNove.UseVisualStyleBackColor = true;
            this.botaoNove.Click += new System.EventHandler(this.btnNove);
            // 
            // botaoOito
            // 
            this.botaoOito.Location = new System.Drawing.Point(93, 199);
            this.botaoOito.Name = "oito";
            this.botaoOito.Size = new System.Drawing.Size(75, 60);
            this.botaoOito.TabIndex = 6;
            this.botaoOito.Text = "8";
            this.botaoOito.UseVisualStyleBackColor = true;
            this.botaoOito.Click += new System.EventHandler(this.btnOito);
            // 
            // botaoSeis
            // 
            this.botaoSeis.Location = new System.Drawing.Point(174, 265);
            this.botaoSeis.Name = "seis";
            this.botaoSeis.Size = new System.Drawing.Size(75, 60);
            this.botaoSeis.TabIndex = 7;
            this.botaoSeis.Text = "6";
            this.botaoSeis.UseVisualStyleBackColor = true;
            this.botaoSeis.Click += new System.EventHandler(this.btnSeis);
            // 
            // botaoCinco
            // 
            this.botaoCinco.Location = new System.Drawing.Point(93, 265);
            this.botaoCinco.Name = "cinco";
            this.botaoCinco.Size = new System.Drawing.Size(75, 60);
            this.botaoCinco.TabIndex = 5;
            this.botaoCinco.Text = "5";
            this.botaoCinco.UseVisualStyleBackColor = true;
            this.botaoCinco.Click += new System.EventHandler(this.btnCinco);
            // 
            // botaoSete
            // 
            this.botaoSete.Location = new System.Drawing.Point(12, 199);
            this.botaoSete.Name = "sete";
            this.botaoSete.Size = new System.Drawing.Size(75, 60);
            this.botaoSete.TabIndex = 5;
            this.botaoSete.Text = "7";
            this.botaoSete.UseVisualStyleBackColor = true;
            this.botaoSete.Click += new System.EventHandler(this.btnSete);
            // 
            // botaoQuatro
            // 
            this.botaoQuatro.Location = new System.Drawing.Point(12, 265);
            this.botaoQuatro.Name = "quatro";
            this.botaoQuatro.Size = new System.Drawing.Size(75, 60);
            this.botaoQuatro.TabIndex = 5;
            this.botaoQuatro.Text = "4";
            this.botaoQuatro.UseVisualStyleBackColor = true;
            this.botaoQuatro.Click += new System.EventHandler(this.btnQuatro);
            // 
            // botaoDois
            // 
            this.botaoDois.Location = new System.Drawing.Point(93, 331);
            this.botaoDois.Name = "dois";
            this.botaoDois.Size = new System.Drawing.Size(75, 60);
            this.botaoDois.TabIndex = 5;
            this.botaoDois.Text = "2";
            this.botaoDois.UseVisualStyleBackColor = true;
            this.botaoDois.Click += new System.EventHandler(this.btnDois);
            // 
            // botaoTres
            // 
            this.botaoTres.Location = new System.Drawing.Point(174, 331);
            this.botaoTres.Name = "tres";
            this.botaoTres.Size = new System.Drawing.Size(75, 60);
            this.botaoTres.TabIndex = 5;
            this.botaoTres.Text = "3";
            this.botaoTres.UseVisualStyleBackColor = true;
            this.botaoTres.Click += new System.EventHandler(this.btnTres);
            // 
            // botaoUm
            // 
            this.botaoUm.Location = new System.Drawing.Point(12, 331);
            this.botaoUm.Name = "um";
            this.botaoUm.Size = new System.Drawing.Size(75, 60);
            this.botaoUm.TabIndex = 5;
            this.botaoUm.Text = "1";
            this.botaoUm.UseVisualStyleBackColor = true;
            this.botaoUm.Click += new System.EventHandler(this.btnUm);
            // 
            // botaoZero
            // 
            this.botaoZero.Location = new System.Drawing.Point(93, 397);
            this.botaoZero.Name = "zero";
            this.botaoZero.Size = new System.Drawing.Size(75, 60);
            this.botaoZero.TabIndex = 5;
            this.botaoZero.Text = "0";
            this.botaoZero.UseVisualStyleBackColor = true;
            this.botaoZero.Click += new System.EventHandler(this.btnZero);
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
            // botaoSoma
            // 
            this.botaoSoma.Location = new System.Drawing.Point(255, 199);
            this.botaoSoma.Name = "soma";
            this.botaoSoma.Size = new System.Drawing.Size(75, 60);
            this.botaoSoma.TabIndex = 10;
            this.botaoSoma.Text = "+";
            this.botaoSoma.UseVisualStyleBackColor = true;
            this.botaoSoma.Click += new System.EventHandler(this.btnSoma);
            // 
            // botaoSubtracao
            // 
            this.botaoSubtracao.Location = new System.Drawing.Point(255, 265);
            this.botaoSubtracao.Name = "subtracao";
            this.botaoSubtracao.Size = new System.Drawing.Size(75, 60);
            this.botaoSubtracao.TabIndex = 11;
            this.botaoSubtracao.Text = "-";
            this.botaoSubtracao.UseVisualStyleBackColor = true;
            this.botaoSubtracao.Click += new System.EventHandler(this.btnSubtracao);
            // 
            // botaoMultiplicacao
            // 
            this.botaoMultiplicacao.Location = new System.Drawing.Point(255, 332);
            this.botaoMultiplicacao.Name = "multiplicacao";
            this.botaoMultiplicacao.Size = new System.Drawing.Size(75, 59);
            this.botaoMultiplicacao.TabIndex = 12;
            this.botaoMultiplicacao.Text = "*";
            this.botaoMultiplicacao.UseVisualStyleBackColor = true;
            this.botaoMultiplicacao.Click += new System.EventHandler(this.btnMultiplicacao);
            // 
            // botaoDivisao
            // 
            this.botaoDivisao.Location = new System.Drawing.Point(255, 397);
            this.botaoDivisao.Name = "divisao";
            this.botaoDivisao.Size = new System.Drawing.Size(75, 60);
            this.botaoDivisao.TabIndex = 13;
            this.botaoDivisao.Text = "/";
            this.botaoDivisao.UseVisualStyleBackColor = true;
            this.botaoDivisao.Click += new System.EventHandler(this.btnDivisao);
            // 
            // lblSinal
            // 
            this.lblSinal.AutoSize = true;
            this.lblSinal.Location = new System.Drawing.Point(56, 13);
            this.lblSinal.Name = "label5";
            this.lblSinal.Size = new System.Drawing.Size(0, 15);
            this.lblSinal.TabIndex = 15;
            // 
            // botaoInversaoSinal
            // 
            this.botaoInversaoSinal.Location = new System.Drawing.Point(13, 398);
            this.botaoInversaoSinal.Name = "inversao de sinal";
            this.botaoInversaoSinal.Size = new System.Drawing.Size(75, 59);
            this.botaoInversaoSinal.TabIndex = 16;
            this.botaoInversaoSinal.Text = "+/-";
            this.botaoInversaoSinal.UseVisualStyleBackColor = true;
            this.botaoInversaoSinal.Click += new System.EventHandler(this.btnInverteSinal);
            // 
            // botaoClear
            // 
            this.botaoClear.Location = new System.Drawing.Point(174, 397);
            this.botaoClear.Name = "clear";
            this.botaoClear.Size = new System.Drawing.Size(75, 60);
            this.botaoClear.TabIndex = 18;
            this.botaoClear.Text = "C";
            this.botaoClear.UseVisualStyleBackColor = true;
            this.botaoClear.Click += new System.EventHandler(this.btnClear);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 469);
            this.Controls.Add(this.botaoClear);
            this.Controls.Add(this.botaoInversaoSinal);
            this.Controls.Add(this.lblSinal);
            this.Controls.Add(this.botaoDivisao);
            this.Controls.Add(this.botaoMultiplicacao);
            this.Controls.Add(this.botaoSubtracao);
            this.Controls.Add(this.botaoSoma);
            this.Controls.Add(this.lblSegundoValor);
            this.Controls.Add(this.lblPrimeiroValor);
            this.Controls.Add(this.botaoZero);
            this.Controls.Add(this.botaoUm);
            this.Controls.Add(this.botaoTres);
            this.Controls.Add(this.botaoDois);
            this.Controls.Add(this.botaoQuatro);
            this.Controls.Add(this.botaoSete);
            this.Controls.Add(this.botaoCinco);
            this.Controls.Add(this.botaoSeis);
            this.Controls.Add(this.botaoOito);
            this.Controls.Add(this.botaoNove);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.Pnumero);
            this.Controls.Add(this.botaoIgual);
            this.Name = "Form1";
            this.Text = "Calculadora Rampister";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botaoZero;
        private System.Windows.Forms.Button botaoUm;
        private System.Windows.Forms.Button botaoDois;
        private System.Windows.Forms.Button botaoTres;
        private System.Windows.Forms.Button botaoQuatro;
        private System.Windows.Forms.Button botaoCinco;
        private System.Windows.Forms.Button botaoSeis;
        private System.Windows.Forms.Button botaoSete;
        private System.Windows.Forms.Button botaoOito;
        private System.Windows.Forms.Button botaoNove;
        private System.Windows.Forms.Button botaoSoma;
        private System.Windows.Forms.Button botaoSubtracao;
        private System.Windows.Forms.Button botaoMultiplicacao;
        private System.Windows.Forms.Button botaoDivisao;
        private System.Windows.Forms.Button botaoIgual;
        private System.Windows.Forms.Button botaoInversaoSinal;
        private System.Windows.Forms.Button botaoClear;

        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Label lblPrimeiroValor;
        private System.Windows.Forms.Label lblSegundoValor;
        private System.Windows.Forms.Label lblSinal;

        private System.Windows.Forms.TextBox Pnumero;
    }
}

