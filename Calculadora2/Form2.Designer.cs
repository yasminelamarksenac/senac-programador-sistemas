﻿namespace Calculadora2
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtLado = new TextBox();
            comboOperacao = new ComboBox();
            buttonCalcular = new Button();
            buttonLimpar = new Button();
            lblResultado = new Label();
            lblLado = new Label();
            txtAltura = new TextBox();
            lblAltura = new Label();
            SuspendLayout();
            // 
            // txtLado
            // 
            txtLado.Location = new Point(266, 62);
            txtLado.Name = "txtLado";
            txtLado.Size = new Size(182, 23);
            txtLado.TabIndex = 0;
            // 
            // comboOperacao
            // 
            comboOperacao.FormattingEnabled = true;
            comboOperacao.Items.AddRange(new object[] { "Perímetro\t", "Área", "Volume" });
            comboOperacao.Location = new Point(305, 138);
            comboOperacao.Name = "comboOperacao";
            comboOperacao.Size = new Size(98, 23);
            comboOperacao.TabIndex = 1;
            // 
            // buttonCalcular
            // 
            buttonCalcular.Location = new Point(315, 224);
            buttonCalcular.Name = "buttonCalcular";
            buttonCalcular.Size = new Size(110, 30);
            buttonCalcular.TabIndex = 2;
            buttonCalcular.Text = "Calcular";
            buttonCalcular.UseVisualStyleBackColor = true;
            buttonCalcular.Click += buttonCalcular_Click;
            // 
            // buttonLimpar
            // 
            buttonLimpar.Location = new Point(341, 283);
            buttonLimpar.Name = "buttonLimpar";
            buttonLimpar.Size = new Size(57, 29);
            buttonLimpar.TabIndex = 3;
            buttonLimpar.Text = "Limpar";
            buttonLimpar.UseVisualStyleBackColor = true;
            buttonLimpar.Click += buttonLimpar_Click;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(341, 186);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(59, 15);
            lblResultado.TabIndex = 4;
            lblResultado.Text = "Resultado";
            // 
            // lblLado
            // 
            lblLado.AutoSize = true;
            lblLado.Location = new Point(295, 348);
            lblLado.Name = "lblLado";
            lblLado.Size = new Size(62, 15);
            lblLado.TabIndex = 5;
            lblLado.Text = "Base/Lado";
            // 
                     
            // 
            // txtAltura
            // 
            txtAltura.Location = new Point(300, 422);
            txtAltura.Name = "txtAltura";
            txtAltura.Size = new Size(91, 23);
            txtAltura.TabIndex = 7;
            // 
            // lblAltura
            // 
            lblAltura.AutoSize = true;
            lblAltura.Location = new Point(278, 308);
            lblAltura.Name = "lblAltura";
            lblAltura.Size = new Size(42, 15);
            lblAltura.TabIndex = 8;
            lblAltura.Text = "Altura:";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblAltura);
            Controls.Add(txtAltura);
            Controls.Add(lblLado);
            Controls.Add(lblResultado);
            Controls.Add(buttonLimpar);
            Controls.Add(buttonCalcular);
            Controls.Add(comboOperacao);
            Controls.Add(txtLado);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtLado;
        private ComboBox comboOperacao;
        private Button buttonCalcular;
        private Button buttonLimpar;
        private Label lblResultado;
        private Label lblLado;
        private TextBox txtAltura;
        private Label lblAltura;
        private object textLado;
    }
}