namespace Calculadora2
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
            txtNumero1 = new TextBox();
            txtNumero2 = new TextBox();
            label1 = new Label();
            cmbOperacao = new ComboBox();
            btnCalcular = new Button();
            Form2 = new Button();
            SuspendLayout();
            // 
            // txtNumero1
            // 
            txtNumero1.Location = new Point(247, 80);
            txtNumero1.Name = "txtNumero1";
            txtNumero1.Size = new Size(253, 23);
            txtNumero1.TabIndex = 0;
            // 
            // txtNumero2
            // 
            txtNumero2.Location = new Point(247, 170);
            txtNumero2.Name = "txtNumero2";
            txtNumero2.Size = new Size(253, 23);
            txtNumero2.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(331, 274);
            label1.Name = "label1";
            label1.Size = new Size(59, 15);
            label1.TabIndex = 2;
            label1.Text = "Resultado";
            // 
            // cmbOperacao
            // 
            cmbOperacao.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbOperacao.FormattingEnabled = true;
            cmbOperacao.Items.AddRange(new object[] { "*", "+", "/", "-" });
            cmbOperacao.Location = new Point(312, 126);
            cmbOperacao.Name = "cmbOperacao";
            cmbOperacao.Size = new Size(115, 23);
            cmbOperacao.TabIndex = 3;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(331, 219);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(65, 24);
            btnCalcular.TabIndex = 4;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // Form2
            // 
            Form2.Location = new Point(512, 361);
            Form2.Name = "Form2";
            Form2.Size = new Size(107, 42);
            Form2.TabIndex = 5;
            Form2.Text = "Abrir Form 2";
            Form2.UseVisualStyleBackColor = true;
            Form2.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Form2);
            Controls.Add(btnCalcular);
            Controls.Add(cmbOperacao);
            Controls.Add(label1);
            Controls.Add(txtNumero2);
            Controls.Add(txtNumero1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNumero1;
        private TextBox txtNumero2;
        private Label label1;
        private ComboBox cmbOperacao;
        private Button btnCalcular;
        private Button Form2;
    }
}
