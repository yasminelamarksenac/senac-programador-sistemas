﻿namespace Login
{
<<<<<<< HEAD
    partial class labelCadastrar
=======
    partial class FormLogin
>>>>>>> 2602750860fa9895c8be5ddb014b518380978897
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
            textBoxUsuario = new TextBox();
            textBoxSenha = new TextBox();
            buttonEntrar = new Button();
            label1 = new Label();
            label2 = new Label();
            labelResultado = new Label();
<<<<<<< HEAD
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            labelEmail = new Label();
            label4 = new Label();
            button2 = new Button();
            labelResultadoCadastro = new Label();
=======
            labelNovoUsuario = new Label();
            label4 = new Label();
            label5 = new Label();
            buttonCadastrar = new Button();
            textBoxNovaSenha = new TextBox();
            textBoxNovoUsuario = new TextBox();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
>>>>>>> 2602750860fa9895c8be5ddb014b518380978897
            SuspendLayout();
            // 
            // textBoxUsuario
            // 
<<<<<<< HEAD
            textBoxEmail.Location = new Point(399, 225);
            textBoxEmail.Margin = new Padding(5);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(266, 33);
            textBoxEmail.TabIndex = 0;
=======
            textBoxUsuario.Location = new Point(64, 66);
            textBoxUsuario.Name = "textBoxUsuario";
            textBoxUsuario.Size = new Size(191, 23);
            textBoxUsuario.TabIndex = 0;
>>>>>>> 2602750860fa9895c8be5ddb014b518380978897
            // 
            // textBoxSenha
            // 
            textBoxSenha.Location = new Point(64, 95);
            textBoxSenha.Name = "textBoxSenha";
            textBoxSenha.Size = new Size(191, 23);
            textBoxSenha.TabIndex = 1;
            // 
            // buttonEntrar
            // 
            buttonEntrar.Location = new Point(122, 124);
            buttonEntrar.Name = "buttonEntrar";
            buttonEntrar.Size = new Size(75, 23);
            buttonEntrar.TabIndex = 2;
            buttonEntrar.Text = "entrar";
            buttonEntrar.UseVisualStyleBackColor = true;
            buttonEntrar.Click += buttonEntrar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 69);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 3;
            label1.Text = "usuario";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 98);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 4;
            label2.Text = "senha";
            // 
            // labelResultado
            // 
            labelResultado.AutoSize = true;
            labelResultado.Font = new Font("Segoe UI", 14F);
            labelResultado.Location = new Point(43, 184);
            labelResultado.Name = "labelResultado";
            labelResultado.Size = new Size(0, 25);
            labelResultado.TabIndex = 5;
            // 
<<<<<<< HEAD
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
=======
            // labelNovoUsuario
>>>>>>> 2602750860fa9895c8be5ddb014b518380978897
            // 
            labelNovoUsuario.AutoSize = true;
            labelNovoUsuario.Font = new Font("Segoe UI", 14F);
            labelNovoUsuario.Location = new Point(389, 184);
            labelNovoUsuario.Name = "labelNovoUsuario";
            labelNovoUsuario.Size = new Size(0, 25);
            labelNovoUsuario.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(269, 98);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 10;
            label4.Text = "senha";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(269, 69);
            label5.Name = "label5";
            label5.Size = new Size(46, 15);
            label5.TabIndex = 9;
            label5.Text = "usuario";
            // 
            // buttonCadastrar
            // 
            buttonCadastrar.Location = new Point(379, 124);
            buttonCadastrar.Name = "buttonCadastrar";
            buttonCadastrar.Size = new Size(75, 23);
            buttonCadastrar.TabIndex = 8;
            buttonCadastrar.Text = "cadastrar";
            buttonCadastrar.UseVisualStyleBackColor = true;
            buttonCadastrar.Click += buttonCadastrar_Click;
            // 
            // textBoxNovaSenha
            // 
            textBoxNovaSenha.Location = new Point(321, 95);
            textBoxNovaSenha.Name = "textBoxNovaSenha";
            textBoxNovaSenha.Size = new Size(191, 23);
            textBoxNovaSenha.TabIndex = 7;
            // 
            // textBoxNovoUsuario
            // 
            textBoxNovoUsuario.Location = new Point(321, 66);
            textBoxNovoUsuario.Name = "textBoxNovoUsuario";
            textBoxNovoUsuario.Size = new Size(191, 23);
            textBoxNovoUsuario.TabIndex = 6;
            textBoxNovoUsuario.TextChanged += textBoxNovoUsuario_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BorderStyle = BorderStyle.FixedSingle;
            label6.Font = new Font("Segoe UI", 72F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(261, 37);
            label6.Name = "label6";
            label6.Size = new Size(2, 130);
            label6.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 16F);
            label7.Location = new Point(126, 9);
            label7.Name = "label7";
            label7.Size = new Size(66, 30);
            label7.TabIndex = 13;
            label7.Text = "Login";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 16F);
            label8.Location = new Point(345, 9);
            label8.Name = "label8";
            label8.Size = new Size(142, 30);
            label8.TabIndex = 14;
            label8.Text = "Novo usuario";
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
<<<<<<< HEAD
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(1262, 857);
            Controls.Add(labelResultadoCadastro);
            Controls.Add(button2);
            Controls.Add(label4);
            Controls.Add(labelEmail);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
=======
            BackColor = SystemColors.Control;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(536, 321);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(labelNovoUsuario);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(buttonCadastrar);
            Controls.Add(textBoxNovaSenha);
            Controls.Add(textBoxNovoUsuario);
>>>>>>> 2602750860fa9895c8be5ddb014b518380978897
            Controls.Add(labelResultado);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonEntrar);
            Controls.Add(textBoxSenha);
<<<<<<< HEAD
            Controls.Add(textBoxEmail);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = SystemColors.ControlText;
            Margin = new Padding(5);
            Name = "labelCadastrar";
            Text = "Form1";
=======
            Controls.Add(textBoxUsuario);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "FormLogin";
            Text = "Login :)";
>>>>>>> 2602750860fa9895c8be5ddb014b518380978897
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxUsuario;
        private TextBox textBoxSenha;
        private Button buttonEntrar;
        private Label label1;
        private Label label2;
        private Label labelResultado;
<<<<<<< HEAD
        private TextBox textBox2;
        private TextBox textBox3;
        private Label labelEmail;
        private Label label4;
        private Button button2;
        private Label labelResultadoCadastro;
=======
        private Label labelNovoUsuario;
        private Label label4;
        private Label label5;
        private Button buttonCadastrar;
        private TextBox textBoxNovaSenha;
        private TextBox textBoxNovoUsuario;
        private Label label6;
        private Label label7;
        private Label label8;
>>>>>>> 2602750860fa9895c8be5ddb014b518380978897
    }
}
