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
            this.lblPrimeiraLinha = new System.Windows.Forms.Label();
            this.lblSegundaLinha = new System.Windows.Forms.Label();
            this.RaizQuadrada = new System.Windows.Forms.Button();
            this.btnPonto = new System.Windows.Forms.Button();
            this.btnPotencia = new System.Windows.Forms.Button();
            this.btnPorcentagem = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnZero
            // 
            this.btnZero.Location = new System.Drawing.Point(91, 456);
            this.btnZero.Name = "btnZero";
            this.btnZero.Size = new System.Drawing.Size(75, 60);
            this.btnZero.TabIndex = 5;
            this.btnZero.Text = "0";
            this.btnZero.UseVisualStyleBackColor = true;
            this.btnZero.Click += new System.EventHandler(this.AtribuirValor);
            // 
            // btnUm
            // 
            this.btnUm.Location = new System.Drawing.Point(10, 390);
            this.btnUm.Name = "btnUm";
            this.btnUm.Size = new System.Drawing.Size(75, 60);
            this.btnUm.TabIndex = 5;
            this.btnUm.Text = "1";
            this.btnUm.UseVisualStyleBackColor = true;
            this.btnUm.Click += new System.EventHandler(this.AtribuirValor);
            // 
            // btnDois
            // 
            this.btnDois.Location = new System.Drawing.Point(91, 390);
            this.btnDois.Name = "btnDois";
            this.btnDois.Size = new System.Drawing.Size(75, 60);
            this.btnDois.TabIndex = 5;
            this.btnDois.Text = "2";
            this.btnDois.UseVisualStyleBackColor = true;
            this.btnDois.Click += new System.EventHandler(this.AtribuirValor);
            // 
            // btnTres
            // 
            this.btnTres.Location = new System.Drawing.Point(172, 390);
            this.btnTres.Name = "btnTres";
            this.btnTres.Size = new System.Drawing.Size(75, 60);
            this.btnTres.TabIndex = 5;
            this.btnTres.Text = "3";
            this.btnTres.UseVisualStyleBackColor = true;
            this.btnTres.Click += new System.EventHandler(this.AtribuirValor);
            // 
            // btnQuatro
            // 
            this.btnQuatro.Location = new System.Drawing.Point(10, 324);
            this.btnQuatro.Name = "btnQuatro";
            this.btnQuatro.Size = new System.Drawing.Size(75, 60);
            this.btnQuatro.TabIndex = 5;
            this.btnQuatro.Text = "4";
            this.btnQuatro.UseVisualStyleBackColor = true;
            this.btnQuatro.Click += new System.EventHandler(this.AtribuirValor);
            // 
            // btnCinco
            // 
            this.btnCinco.Location = new System.Drawing.Point(91, 324);
            this.btnCinco.Name = "btnCinco";
            this.btnCinco.Size = new System.Drawing.Size(75, 60);
            this.btnCinco.TabIndex = 5;
            this.btnCinco.Text = "5";
            this.btnCinco.UseVisualStyleBackColor = true;
            this.btnCinco.Click += new System.EventHandler(this.AtribuirValor);
            // 
            // btnSeis
            // 
            this.btnSeis.Location = new System.Drawing.Point(172, 324);
            this.btnSeis.Name = "btnSeis";
            this.btnSeis.Size = new System.Drawing.Size(75, 60);
            this.btnSeis.TabIndex = 7;
            this.btnSeis.Text = "6";
            this.btnSeis.UseVisualStyleBackColor = true;
            this.btnSeis.Click += new System.EventHandler(this.AtribuirValor);
            // 
            // btnSete
            // 
            this.btnSete.Location = new System.Drawing.Point(10, 258);
            this.btnSete.Name = "btnSete";
            this.btnSete.Size = new System.Drawing.Size(75, 60);
            this.btnSete.TabIndex = 5;
            this.btnSete.Text = "7";
            this.btnSete.UseVisualStyleBackColor = true;
            this.btnSete.Click += new System.EventHandler(this.AtribuirValor);
            // 
            // btnOito
            // 
            this.btnOito.Location = new System.Drawing.Point(91, 258);
            this.btnOito.Name = "btnOito";
            this.btnOito.Size = new System.Drawing.Size(75, 60);
            this.btnOito.TabIndex = 6;
            this.btnOito.Text = "8";
            this.btnOito.UseVisualStyleBackColor = true;
            this.btnOito.Click += new System.EventHandler(this.AtribuirValor);
            // 
            // btnNove
            // 
            this.btnNove.Location = new System.Drawing.Point(172, 258);
            this.btnNove.Name = "btnNove";
            this.btnNove.Size = new System.Drawing.Size(75, 60);
            this.btnNove.TabIndex = 5;
            this.btnNove.Text = "9";
            this.btnNove.UseVisualStyleBackColor = true;
            this.btnNove.Click += new System.EventHandler(this.AtribuirValor);
            // 
            // btnSoma
            // 
            this.btnSoma.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSoma.Location = new System.Drawing.Point(253, 258);
            this.btnSoma.Name = "btnSoma";
            this.btnSoma.Size = new System.Drawing.Size(75, 60);
            this.btnSoma.TabIndex = 10;
            this.btnSoma.Text = "+";
            this.btnSoma.UseVisualStyleBackColor = true;
            this.btnSoma.Click += new System.EventHandler(this.AtribuirOperacao);
            // 
            // btnSubtracao
            // 
            this.btnSubtracao.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSubtracao.Location = new System.Drawing.Point(253, 324);
            this.btnSubtracao.Name = "btnSubtracao";
            this.btnSubtracao.Size = new System.Drawing.Size(75, 60);
            this.btnSubtracao.TabIndex = 11;
            this.btnSubtracao.Text = "-";
            this.btnSubtracao.UseVisualStyleBackColor = true;
            this.btnSubtracao.Click += new System.EventHandler(this.AtribuirOperacao);
            // 
            // btnMultiplicacao
            // 
            this.btnMultiplicacao.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMultiplicacao.Location = new System.Drawing.Point(253, 391);
            this.btnMultiplicacao.Name = "btnMultiplicacao";
            this.btnMultiplicacao.Size = new System.Drawing.Size(75, 59);
            this.btnMultiplicacao.TabIndex = 12;
            this.btnMultiplicacao.Text = "x";
            this.btnMultiplicacao.UseVisualStyleBackColor = true;
            this.btnMultiplicacao.Click += new System.EventHandler(this.AtribuirOperacao);
            // 
            // btnDivisao
            // 
            this.btnDivisao.Location = new System.Drawing.Point(253, 456);
            this.btnDivisao.Name = "btnDivisao";
            this.btnDivisao.Size = new System.Drawing.Size(75, 60);
            this.btnDivisao.TabIndex = 13;
            this.btnDivisao.Text = "÷";
            this.btnDivisao.UseVisualStyleBackColor = true;
            this.btnDivisao.Click += new System.EventHandler(this.AtribuirOperacao);
            // 
            // btnIgual
            // 
            this.btnIgual.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnIgual.Location = new System.Drawing.Point(253, 192);
            this.btnIgual.Name = "btnIgual";
            this.btnIgual.Size = new System.Drawing.Size(75, 60);
            this.btnIgual.TabIndex = 0;
            this.btnIgual.Text = "=";
            this.btnIgual.UseVisualStyleBackColor = true;
            this.btnIgual.Click += new System.EventHandler(this.BtnIgual);
            // 
            // btnInversaoSinal
            // 
            this.btnInversaoSinal.Location = new System.Drawing.Point(11, 457);
            this.btnInversaoSinal.Name = "btnInversaoSinal";
            this.btnInversaoSinal.Size = new System.Drawing.Size(75, 59);
            this.btnInversaoSinal.TabIndex = 16;
            this.btnInversaoSinal.Text = "+/-";
            this.btnInversaoSinal.UseVisualStyleBackColor = true;
            this.btnInversaoSinal.Click += new System.EventHandler(this.BtnInverteSinal);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(91, 192);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 60);
            this.btnLimpar.TabIndex = 18;
            this.btnLimpar.Text = "C";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.BtnLimpar);
            // 
            // lblPrimeiraLinha
            // 
            this.lblPrimeiraLinha.AutoSize = true;
            this.lblPrimeiraLinha.Location = new System.Drawing.Point(12, 13);
            this.lblPrimeiraLinha.Name = "lblPrimeiraLinha";
            this.lblPrimeiraLinha.Size = new System.Drawing.Size(0, 15);
            this.lblPrimeiraLinha.TabIndex = 8;
            // 
            // lblSegundaLinha
            // 
            this.lblSegundaLinha.Font = new System.Drawing.Font("Niagara Solid", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSegundaLinha.Location = new System.Drawing.Point(12, 42);
            this.lblSegundaLinha.Name = "lblSegundaLinha";
            this.lblSegundaLinha.Size = new System.Drawing.Size(318, 59);
            this.lblSegundaLinha.TabIndex = 1;
            // 
            // RaizQuadrada
            // 
            this.RaizQuadrada.Location = new System.Drawing.Point(172, 192);
            this.RaizQuadrada.Name = "RaizQuadrada";
            this.RaizQuadrada.Size = new System.Drawing.Size(75, 60);
            this.RaizQuadrada.TabIndex = 19;
            this.RaizQuadrada.Text = "√";
            this.RaizQuadrada.UseVisualStyleBackColor = true;
            this.RaizQuadrada.Click += new System.EventHandler(this.BtnRaizQdrd);
            // 
            // btnPonto
            // 
            this.btnPonto.Location = new System.Drawing.Point(173, 457);
            this.btnPonto.Name = "btnPonto";
            this.btnPonto.Size = new System.Drawing.Size(75, 59);
            this.btnPonto.TabIndex = 20;
            this.btnPonto.Text = ",";
            this.btnPonto.UseVisualStyleBackColor = true;
            this.btnPonto.Click += new System.EventHandler(this.BtnPonto_Click);
            // 
            // btnPotencia
            // 
            this.btnPotencia.Location = new System.Drawing.Point(11, 192);
            this.btnPotencia.Name = "btnPotencia";
            this.btnPotencia.Size = new System.Drawing.Size(75, 60);
            this.btnPotencia.TabIndex = 21;
            this.btnPotencia.Text = "x²";
            this.btnPotencia.UseVisualStyleBackColor = true;
            this.btnPotencia.Click += new System.EventHandler(this.BtnPotencia);
            // 
            // btnPorcentagem
            // 
            this.btnPorcentagem.Location = new System.Drawing.Point(10, 126);
            this.btnPorcentagem.Name = "btnPorcentagem";
            this.btnPorcentagem.Size = new System.Drawing.Size(75, 60);
            this.btnPorcentagem.TabIndex = 22;
            this.btnPorcentagem.Text = "%";
            this.btnPorcentagem.UseVisualStyleBackColor = true;
            this.btnPorcentagem.Click += new System.EventHandler(this.BtnPorcent);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 527);
            this.Controls.Add(this.btnPorcentagem);
            this.Controls.Add(this.btnPotencia);
            this.Controls.Add(this.btnPonto);
            this.Controls.Add(this.RaizQuadrada);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnInversaoSinal);
            this.Controls.Add(this.btnDivisao);
            this.Controls.Add(this.btnMultiplicacao);
            this.Controls.Add(this.btnSubtracao);
            this.Controls.Add(this.btnSoma);
            this.Controls.Add(this.lblSegundaLinha);
            this.Controls.Add(this.lblPrimeiraLinha);
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

        //private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Label lblPrimeiraLinha;
        private System.Windows.Forms.Label lblSegundaLinha;
        private System.Windows.Forms.Button RaizQuadrada;
        private System.Windows.Forms.Button btnPonto;
        private System.Windows.Forms.Button btnPotencia;
        private System.Windows.Forms.Button btnPorcentagem;
        //private System.Windows.Forms.Label lblSinal;

        //private System.Windows.Forms.TextBox Pnumero;
    }
}

