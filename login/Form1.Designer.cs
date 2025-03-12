namespace login
{
    partial class labelCadastrar
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
            components = new System.ComponentModel.Container();
            textBoxEmail = new TextBox();
            textBoxSenha = new TextBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            label3 = new Label();
            labelLogin = new Label();
            labelResultado = new Label();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            labelEmail = new Label();
            label4 = new Label();
            button2 = new Button();
            labelResultadoCadastro = new Label();
            SuspendLayout();
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(399, 225);
            textBoxEmail.Margin = new Padding(5);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(266, 33);
            textBoxEmail.TabIndex = 0;
            // 
            // textBoxSenha
            // 
            textBoxSenha.Location = new Point(399, 278);
            textBoxSenha.Margin = new Padding(5);
            textBoxSenha.Name = "textBoxSenha";
            textBoxSenha.Size = new Size(266, 33);
            textBoxSenha.TabIndex = 1;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(314, 228);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(39, 17);
            label1.TabIndex = 3;
            label1.Text = "Email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(310, 282);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(43, 17);
            label2.TabIndex = 4;
            label2.Text = "Senha";
            // 
            // button1
            // 
            button1.Location = new Point(486, 448);
            button1.Margin = new Padding(5);
            button1.Name = "button1";
            button1.Size = new Size(118, 38);
            button1.TabIndex = 5;
            button1.Text = "Enviar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.DarkSlateGray;
            label3.Location = new Point(486, 133);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(0, 25);
            label3.TabIndex = 6;
            // 
            // labelLogin
            // 
            labelLogin.AutoSize = true;
            labelLogin.Location = new Point(498, 150);
            labelLogin.Margin = new Padding(5, 0, 5, 0);
            labelLogin.Name = "labelLogin";
            labelLogin.Size = new Size(59, 25);
            labelLogin.TabIndex = 7;
            labelLogin.Text = "Login\r\n";
            // 
            // labelResultado
            // 
            labelResultado.AutoSize = true;
            labelResultado.Location = new Point(483, 341);
            labelResultado.Name = "labelResultado";
            labelResultado.Size = new Size(63, 25);
            labelResultado.TabIndex = 8;
            labelResultado.Text = "label4";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(915, 219);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(274, 33);
            textBox2.TabIndex = 9;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(915, 273);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(274, 33);
            textBox3.TabIndex = 10;
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.FlatStyle = FlatStyle.System;
            labelEmail.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelEmail.Location = new Point(851, 222);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(46, 20);
            labelEmail.TabIndex = 11;
            labelEmail.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(833, 278);
            label4.Name = "label4";
            label4.Size = new Size(49, 20);
            label4.TabIndex = 10;
            label4.Text = "Senha";
            // 
            // button2
            // 
            button2.Location = new Point(995, 456);
            button2.Name = "button2";
            button2.Size = new Size(143, 30);
            button2.TabIndex = 12;
            button2.Text = "Cadastrar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // labelResultadoCadastro
            // 
            labelResultadoCadastro.AutoSize = true;
            labelResultadoCadastro.Location = new Point(982, 341);
            labelResultadoCadastro.Name = "labelResultadoCadastro";
            labelResultadoCadastro.Size = new Size(63, 25);
            labelResultadoCadastro.TabIndex = 13;
            labelResultadoCadastro.Text = "label5";
            // 
            // labelCadastrar
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(1262, 857);
            Controls.Add(labelResultadoCadastro);
            Controls.Add(button2);
            Controls.Add(label4);
            Controls.Add(labelEmail);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(labelResultado);
            Controls.Add(labelLogin);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxSenha);
            Controls.Add(textBoxEmail);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = SystemColors.ControlText;
            Margin = new Padding(5);
            Name = "labelCadastrar";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBoxSenha;
        private ContextMenuStrip contextMenuStrip1;
        private Label label1;
        private Label label2;
        private Button button1;
        private Label label3;
        private TextBox textBoxEmail;
        private Label labelLogin;
        private Label labelResultado;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label labelEmail;
        private Label label4;
        private Button button2;
        private Label labelResultadoCadastro;
    }
}
