namespace GestaoRH
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
            textBoxUsuario = new TextBox();
            textBoxSenha = new TextBox();
            buttonLogin = new Button();
            labelLogin = new Label();
            labelNomeUsuario = new Label();
            labelSenha = new Label();
            SuspendLayout();
            // 
            // textBoxUsuario
            // 
            textBoxUsuario.Location = new Point(300, 133);
            textBoxUsuario.Name = "textBoxUsuario";
            textBoxUsuario.Size = new Size(208, 23);
            textBoxUsuario.TabIndex = 0;
            // 
            // textBoxSenha
            // 
            textBoxSenha.Location = new Point(300, 204);
            textBoxSenha.Name = "textBoxSenha";
            textBoxSenha.Size = new Size(204, 23);
            textBoxSenha.TabIndex = 1;
            textBoxSenha.UseSystemPasswordChar = true;
            // 
            // buttonLogin
            // 
            buttonLogin.Location = new Point(339, 262);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(123, 34);
            buttonLogin.TabIndex = 2;
            buttonLogin.Text = "Login";
            buttonLogin.UseVisualStyleBackColor = true;
            buttonLogin.Click += buttonLogin_Click;
            // 
            // labelLogin
            // 
            labelLogin.AutoSize = true;
            labelLogin.Font = new Font("Yu Gothic UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelLogin.Location = new Point(354, 66);
            labelLogin.Name = "labelLogin";
            labelLogin.Size = new Size(88, 40);
            labelLogin.TabIndex = 3;
            labelLogin.Text = "Login";
            // 
            // labelNomeUsuario
            // 
            labelNomeUsuario.AutoSize = true;
            labelNomeUsuario.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelNomeUsuario.Location = new Point(181, 136);
            labelNomeUsuario.Name = "labelNomeUsuario";
            labelNomeUsuario.Size = new Size(68, 21);
            labelNomeUsuario.TabIndex = 4;
            labelNomeUsuario.Text = " Usuario";
            // 
            // labelSenha
            // 
            labelSenha.AutoSize = true;
            labelSenha.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelSenha.Location = new Point(193, 206);
            labelSenha.Name = "labelSenha";
            labelSenha.Size = new Size(53, 21);
            labelSenha.TabIndex = 5;
            labelSenha.Text = "Senha";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelSenha);
            Controls.Add(labelNomeUsuario);
            Controls.Add(labelLogin);
            Controls.Add(buttonLogin);
            Controls.Add(textBoxSenha);
            Controls.Add(textBoxUsuario);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxUsuario;
        private TextBox textBoxSenha;
        private Button buttonLogin;
        private Label labelLogin;
        private Label labelNomeUsuario;
        private Label labelSenha;
    }
}
