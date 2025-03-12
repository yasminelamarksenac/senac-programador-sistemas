namespace Calculadora
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
            buttonCalcular = new Button();
            textNumero1 = new TextBox();
            textNumero2 = new TextBox();
            buttonAbrir = new Button();
            lblResultado = new Label();
            SuspendLayout();
            // 
            // buttonCalcular
            // 
            buttonCalcular.Location = new Point(358, 192);
            buttonCalcular.Name = "buttonCalcular";
            buttonCalcular.Size = new Size(104, 25);
            buttonCalcular.TabIndex = 0;
            buttonCalcular.Text = "Calcular";
            buttonCalcular.UseVisualStyleBackColor = true;
            buttonCalcular.Click += buttonCalcular_Click;
            // 
            // textNumero1
            // 
            textNumero1.Location = new Point(292, 102);
            textNumero1.Name = "textNumero1";
            textNumero1.Size = new Size(230, 23);
            textNumero1.TabIndex = 1;
            // 
            // textNumero2
            // 
            textNumero2.Location = new Point(292, 163);
            textNumero2.Name = "textNumero2";
            textNumero2.Size = new Size(230, 23);
            textNumero2.TabIndex = 2;
            // 
            // buttonAbrir
            // 
            buttonAbrir.Location = new Point(536, 261);
            buttonAbrir.Name = "buttonAbrir";
            buttonAbrir.Size = new Size(113, 41);
            buttonAbrir.TabIndex = 4;
            buttonAbrir.Text = "Abrir Forms2";
            buttonAbrir.UseVisualStyleBackColor = true;
            buttonAbrir.Click += buttonAbrir_Click;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(377, 248);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(59, 15);
            lblResultado.TabIndex = 5;
            lblResultado.Text = "Resultado";
            lblResultado.Click += lblResultado_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 329);
            Controls.Add(lblResultado);
            Controls.Add(buttonAbrir);
            Controls.Add(textNumero2);
            Controls.Add(textNumero1);
            Controls.Add(buttonCalcular);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonCalcular;
        private TextBox textNumero1;
        private TextBox textNumero2;
        private Button buttonAbrir;
        private Label lblResultado;
    }
}
