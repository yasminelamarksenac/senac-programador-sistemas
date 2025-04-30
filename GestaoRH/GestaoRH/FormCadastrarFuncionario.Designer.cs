namespace GestaoRH
{
    partial class FormCadastrarFuncionario
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
            labelNomeCompleto = new Label();
            groupBox1 = new GroupBox();
            maskedTextBox1 = new MaskedTextBox();
            labelCpf = new Label();
            textBox1 = new TextBox();
            labelDataDeNasc = new Label();
            maskedTextBox2 = new MaskedTextBox();
            labelGenero = new Label();
            comboBoxGenero = new ComboBox();
            labelParentesco = new Label();
            comboBoxParentesco = new ComboBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // labelNomeCompleto
            // 
            labelNomeCompleto.AutoSize = true;
            labelNomeCompleto.Location = new Point(19, 62);
            labelNomeCompleto.Name = "labelNomeCompleto";
            labelNomeCompleto.Size = new Size(96, 15);
            labelNomeCompleto.TabIndex = 1;
            labelNomeCompleto.Text = "Nome Completo";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(comboBoxParentesco);
            groupBox1.Controls.Add(labelParentesco);
            groupBox1.Controls.Add(comboBoxGenero);
            groupBox1.Controls.Add(labelGenero);
            groupBox1.Controls.Add(maskedTextBox2);
            groupBox1.Controls.Add(labelDataDeNasc);
            groupBox1.Controls.Add(maskedTextBox1);
            groupBox1.Controls.Add(labelCpf);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(labelNomeCompleto);
            groupBox1.Location = new Point(31, 35);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(900, 446);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(121, 93);
            maskedTextBox1.Mask = "000.000.000-00";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(152, 23);
            maskedTextBox1.TabIndex = 10;
            // 
            // labelCpf
            // 
            labelCpf.AutoSize = true;
            labelCpf.Location = new Point(19, 101);
            labelCpf.Name = "labelCpf";
            labelCpf.Size = new Size(28, 15);
            labelCpf.TabIndex = 9;
            labelCpf.Text = "CPF";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(121, 59);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(152, 23);
            textBox1.TabIndex = 8;
            // 
            // labelDataDeNasc
            // 
            labelDataDeNasc.AutoSize = true;
            labelDataDeNasc.Location = new Point(0, 141);
            labelDataDeNasc.Name = "labelDataDeNasc";
            labelDataDeNasc.Size = new Size(115, 15);
            labelDataDeNasc.TabIndex = 11;
            labelDataDeNasc.Text = "Data De Nascimento";
            // 
            // maskedTextBox2
            // 
            maskedTextBox2.Location = new Point(121, 133);
            maskedTextBox2.Mask = "00/00/0000";
            maskedTextBox2.Name = "maskedTextBox2";
            maskedTextBox2.Size = new Size(152, 23);
            maskedTextBox2.TabIndex = 12;
            maskedTextBox2.ValidatingType = typeof(DateTime);
            // 
            // labelGenero
            // 
            labelGenero.AutoSize = true;
            labelGenero.Location = new Point(6, 180);
            labelGenero.Name = "labelGenero";
            labelGenero.Size = new Size(45, 15);
            labelGenero.TabIndex = 13;
            labelGenero.Text = "Genero";
            // 
            // comboBoxGenero
            // 
            comboBoxGenero.FormattingEnabled = true;
            comboBoxGenero.Location = new Point(121, 172);
            comboBoxGenero.Name = "comboBoxGenero";
            comboBoxGenero.Size = new Size(152, 23);
            comboBoxGenero.TabIndex = 14;
            // 
            // labelParentesco
            // 
            labelParentesco.AutoSize = true;
            labelParentesco.Location = new Point(6, 229);
            labelParentesco.Name = "labelParentesco";
            labelParentesco.Size = new Size(65, 15);
            labelParentesco.TabIndex = 15;
            labelParentesco.Text = "Parentesco";
            // 
            // comboBoxParentesco
            // 
            comboBoxParentesco.FormattingEnabled = true;
            comboBoxParentesco.Location = new Point(121, 221);
            comboBoxParentesco.Name = "comboBoxParentesco";
            comboBoxParentesco.Size = new Size(152, 23);
            comboBoxParentesco.TabIndex = 16;
            // 
            // FormCadastrarFuncionario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1153, 670);
            Controls.Add(groupBox1);
            Name = "FormCadastrarFuncionario";
            Text = "FormCadastrarFuncionario";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label labelNomeCompleto;
        private GroupBox groupBox1;
        private MaskedTextBox maskedTextBox1;
        private Label labelCpf;
        private TextBox textBox1;
        private ComboBox comboBoxParentesco;
        private Label labelParentesco;
        private ComboBox comboBoxGenero;
        private Label labelGenero;
        private MaskedTextBox maskedTextBox2;
        private Label labelDataDeNasc;
    }
}