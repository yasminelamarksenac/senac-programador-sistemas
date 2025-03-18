namespace Calculoesfera
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
            txtRaio = new TextBox();
            comboOperacao = new ComboBox();
            buttonCalcular = new Button();
            buttonLimpar = new Button();
            lblResultado = new Label();
            SuspendLayout();
            // 
            // txtRaio
            // 
            txtRaio.Location = new Point(201, 34);
            txtRaio.Name = "txtRaio";
            txtRaio.Size = new Size(158, 23);
            txtRaio.TabIndex = 0;
            // 
            // comboOperacao
            // 
            comboOperacao.FormattingEnabled = true;
            comboOperacao.Location = new Point(211, 144);
            comboOperacao.Name = "comboOperacao";
            comboOperacao.Size = new Size(126, 23);
            comboOperacao.TabIndex = 1;
            // 
            // buttonCalcular
            // 
            buttonCalcular.Location = new Point(242, 273);
            buttonCalcular.Name = "buttonCalcular";
            buttonCalcular.Size = new Size(71, 29);
            buttonCalcular.TabIndex = 2;
            buttonCalcular.Text = "Calcular";
            buttonCalcular.UseVisualStyleBackColor = true;
            buttonCalcular.Click += buttonCalcular_Click;
            // 
            // buttonLimpar
            // 
            buttonLimpar.Location = new Point(236, 323);
            buttonLimpar.Name = "buttonLimpar";
            buttonLimpar.Size = new Size(82, 32);
            buttonLimpar.TabIndex = 3;
            buttonLimpar.Text = "Limpar";
            buttonLimpar.UseVisualStyleBackColor = true;
            buttonLimpar.Click += buttonLimpar_Click;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(433, 295);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(59, 15);
            lblResultado.TabIndex = 4;
            lblResultado.Text = "Resultado";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblResultado);
            Controls.Add(buttonLimpar);
            Controls.Add(buttonCalcular);
            Controls.Add(comboOperacao);
            Controls.Add(txtRaio);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtRaio;
        private ComboBox comboOperacao;
        private Button buttonCalcular;
        private Button buttonLimpar;
        private Label lblResultado;
    }
}
