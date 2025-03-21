namespace CadastroCliente
{
    partial class FormUsuario
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
            labelNome = new Label();
            textBoxNome = new TextBox();
            maskedTextBoxDataNasc = new MaskedTextBox();
            labelDataNasc = new Label();
            labelTelefone = new Label();
            maskedTextBoxTelefone = new MaskedTextBox();
            labelEmail = new Label();
            textBoxEmail = new TextBox();
            comboBoxGenero = new ComboBox();
            labelGenero = new Label();
            comboBoxEtnia = new ComboBox();
            labelEtnia = new Label();
            checkBoxEstrangeiro = new CheckBox();
            labelEstrangeiro = new Label();
            radioButtonPJ = new RadioButton();
            radioButtonPF = new RadioButton();
            buttonAdicionarClientes = new Button();
            textBoxLogradouro = new TextBox();
            labelLogradouro = new Label();
            textBoxNumero = new TextBox();
            labelNumero = new Label();
            textBoxComplemento = new TextBox();
            labelComplemento = new Label();
            textBoxBairro = new TextBox();
            label1 = new Label();
            labelMunicipio = new Label();
            textBoxMunicipio = new TextBox();
            labelEstado = new Label();
            comboBoxEstado = new ComboBox();
            maskedTextBoxCep = new MaskedTextBox();
            labelCep = new Label();
            textBoxNomeSocial = new TextBox();
            labelNomeSocial = new Label();
            labelTitulo = new Label();
            dataGridView1 = new DataGridView();
            buttonMostrarClientes = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // labelNome
            // 
            labelNome.AutoSize = true;
            labelNome.Location = new Point(25, 47);
            labelNome.Name = "labelNome";
            labelNome.Size = new Size(100, 15);
            labelNome.TabIndex = 2;
            labelNome.Text = "Nome do Usuario";
            // 
            // textBoxNome
            // 
            textBoxNome.Location = new Point(145, 47);
            textBoxNome.Name = "textBoxNome";
            textBoxNome.Size = new Size(135, 23);
            textBoxNome.TabIndex = 3;
            // 
            // maskedTextBoxDataNasc
            // 
            maskedTextBoxDataNasc.Location = new Point(145, 88);
            maskedTextBoxDataNasc.Mask = "00/00/0000";
            maskedTextBoxDataNasc.Name = "maskedTextBoxDataNasc";
            maskedTextBoxDataNasc.Size = new Size(135, 23);
            maskedTextBoxDataNasc.TabIndex = 4;
            maskedTextBoxDataNasc.ValidatingType = typeof(DateTime);
            // 
            // labelDataNasc
            // 
            labelDataNasc.AutoSize = true;
            labelDataNasc.Location = new Point(25, 88);
            labelDataNasc.Name = "labelDataNasc";
            labelDataNasc.Size = new Size(114, 15);
            labelDataNasc.TabIndex = 5;
            labelDataNasc.Text = "Data de Nascimento";
            // 
            // labelTelefone
            // 
            labelTelefone.AutoSize = true;
            labelTelefone.Location = new Point(49, 126);
            labelTelefone.Name = "labelTelefone";
            labelTelefone.Size = new Size(51, 15);
            labelTelefone.TabIndex = 6;
            labelTelefone.Text = "Telefone";
            // 
            // maskedTextBoxTelefone
            // 
            maskedTextBoxTelefone.Location = new Point(145, 123);
            maskedTextBoxTelefone.Mask = "(00) 00000-0000";
            maskedTextBoxTelefone.Name = "maskedTextBoxTelefone";
            maskedTextBoxTelefone.Size = new Size(135, 23);
            maskedTextBoxTelefone.TabIndex = 7;
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Location = new Point(49, 165);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(36, 15);
            labelEmail.TabIndex = 8;
            labelEmail.Text = "Email";
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(145, 162);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(135, 23);
            textBoxEmail.TabIndex = 9;
            // 
            // comboBoxGenero
            // 
            comboBoxGenero.FormattingEnabled = true;
            comboBoxGenero.Location = new Point(366, 85);
            comboBoxGenero.Name = "comboBoxGenero";
            comboBoxGenero.Size = new Size(164, 23);
            comboBoxGenero.TabIndex = 10;
            // 
            // labelGenero
            // 
            labelGenero.AutoSize = true;
            labelGenero.Location = new Point(301, 91);
            labelGenero.Name = "labelGenero";
            labelGenero.Size = new Size(45, 15);
            labelGenero.TabIndex = 11;
            labelGenero.Text = "Gênero";
            // 
            // comboBoxEtnia
            // 
            comboBoxEtnia.FormattingEnabled = true;
            comboBoxEtnia.Location = new Point(366, 118);
            comboBoxEtnia.Name = "comboBoxEtnia";
            comboBoxEtnia.Size = new Size(164, 23);
            comboBoxEtnia.TabIndex = 12;
            // 
            // labelEtnia
            // 
            labelEtnia.AutoSize = true;
            labelEtnia.Location = new Point(301, 123);
            labelEtnia.Name = "labelEtnia";
            labelEtnia.Size = new Size(33, 15);
            labelEtnia.TabIndex = 13;
            labelEtnia.Text = "Etnia";
            // 
            // checkBoxEstrangeiro
            // 
            checkBoxEstrangeiro.AutoSize = true;
            checkBoxEstrangeiro.Location = new Point(384, 162);
            checkBoxEstrangeiro.Name = "checkBoxEstrangeiro";
            checkBoxEstrangeiro.Size = new Size(46, 19);
            checkBoxEstrangeiro.TabIndex = 14;
            checkBoxEstrangeiro.Text = "Sim";
            checkBoxEstrangeiro.UseVisualStyleBackColor = true;
            // 
            // labelEstrangeiro
            // 
            labelEstrangeiro.AutoSize = true;
            labelEstrangeiro.Location = new Point(301, 162);
            labelEstrangeiro.Name = "labelEstrangeiro";
            labelEstrangeiro.Size = new Size(66, 15);
            labelEstrangeiro.TabIndex = 15;
            labelEstrangeiro.Text = "Estrangeiro";
            // 
            // radioButtonPJ
            // 
            radioButtonPJ.AutoSize = true;
            radioButtonPJ.Location = new Point(301, 196);
            radioButtonPJ.Name = "radioButtonPJ";
            radioButtonPJ.Size = new Size(93, 19);
            radioButtonPJ.TabIndex = 16;
            radioButtonPJ.TabStop = true;
            radioButtonPJ.Text = "Pessoa Física";
            radioButtonPJ.UseVisualStyleBackColor = true;
            // 
            // radioButtonPF
            // 
            radioButtonPF.AutoSize = true;
            radioButtonPF.Location = new Point(416, 196);
            radioButtonPF.Name = "radioButtonPF";
            radioButtonPF.Size = new Size(104, 19);
            radioButtonPF.TabIndex = 17;
            radioButtonPF.TabStop = true;
            radioButtonPF.Text = "Pessoa Jurídica";
            radioButtonPF.UseVisualStyleBackColor = true;
            // 
            // buttonAdicionarClientes
            // 
            buttonAdicionarClientes.Location = new Point(217, 243);
            buttonAdicionarClientes.Name = "buttonAdicionarClientes";
            buttonAdicionarClientes.Size = new Size(177, 52);
            buttonAdicionarClientes.TabIndex = 18;
            buttonAdicionarClientes.Text = "Cadastrar";
            buttonAdicionarClientes.UseVisualStyleBackColor = true;
            buttonAdicionarClientes.Click += buttonAdicionarClientes_Click;
            // 
            // textBoxLogradouro
            // 
            textBoxLogradouro.Location = new Point(758, 41);
            textBoxLogradouro.Name = "textBoxLogradouro";
            textBoxLogradouro.Size = new Size(227, 23);
            textBoxLogradouro.TabIndex = 19;
            // 
            // labelLogradouro
            // 
            labelLogradouro.AutoSize = true;
            labelLogradouro.Location = new Point(673, 47);
            labelLogradouro.Name = "labelLogradouro";
            labelLogradouro.Size = new Size(69, 15);
            labelLogradouro.TabIndex = 20;
            labelLogradouro.Text = "Logradouro";
            // 
            // textBoxNumero
            // 
            textBoxNumero.Location = new Point(758, 80);
            textBoxNumero.Name = "textBoxNumero";
            textBoxNumero.Size = new Size(112, 23);
            textBoxNumero.TabIndex = 21;
            // 
            // labelNumero
            // 
            labelNumero.AutoSize = true;
            labelNumero.Location = new Point(710, 88);
            labelNumero.Name = "labelNumero";
            labelNumero.Size = new Size(21, 15);
            labelNumero.TabIndex = 22;
            labelNumero.Text = "Nº";
            // 
            // textBoxComplemento
            // 
            textBoxComplemento.Location = new Point(758, 123);
            textBoxComplemento.Name = "textBoxComplemento";
            textBoxComplemento.Size = new Size(119, 23);
            textBoxComplemento.TabIndex = 23;
            // 
            // labelComplemento
            // 
            labelComplemento.AutoSize = true;
            labelComplemento.Location = new Point(658, 129);
            labelComplemento.Name = "labelComplemento";
            labelComplemento.Size = new Size(84, 15);
            labelComplemento.TabIndex = 24;
            labelComplemento.Text = "Complemento";
            // 
            // textBoxBairro
            // 
            textBoxBairro.Location = new Point(758, 166);
            textBoxBairro.Name = "textBoxBairro";
            textBoxBairro.Size = new Size(119, 23);
            textBoxBairro.TabIndex = 25;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(693, 174);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 26;
            label1.Text = "Bairro";
            // 
            // labelMunicipio
            // 
            labelMunicipio.AutoSize = true;
            labelMunicipio.Location = new Point(673, 222);
            labelMunicipio.Name = "labelMunicipio";
            labelMunicipio.Size = new Size(61, 15);
            labelMunicipio.TabIndex = 27;
            labelMunicipio.Text = "Municipio";
            // 
            // textBoxMunicipio
            // 
            textBoxMunicipio.Location = new Point(758, 214);
            textBoxMunicipio.Name = "textBoxMunicipio";
            textBoxMunicipio.Size = new Size(156, 23);
            textBoxMunicipio.TabIndex = 28;
            // 
            // labelEstado
            // 
            labelEstado.AutoSize = true;
            labelEstado.Location = new Point(676, 267);
            labelEstado.Name = "labelEstado";
            labelEstado.Size = new Size(42, 15);
            labelEstado.TabIndex = 29;
            labelEstado.Text = "Estado";
            // 
            // comboBoxEstado
            // 
            comboBoxEstado.FormattingEnabled = true;
            comboBoxEstado.Items.AddRange(new object[] { "SP,", "MG,", "BA" });
            comboBoxEstado.Location = new Point(757, 259);
            comboBoxEstado.Name = "comboBoxEstado";
            comboBoxEstado.Size = new Size(157, 23);
            comboBoxEstado.TabIndex = 30;
            // 
            // maskedTextBoxCep
            // 
            maskedTextBoxCep.Location = new Point(762, 304);
            maskedTextBoxCep.Mask = " 00000-000";
            maskedTextBoxCep.Name = "maskedTextBoxCep";
            maskedTextBoxCep.Size = new Size(153, 23);
            maskedTextBoxCep.TabIndex = 31;
            // 
            // labelCep
            // 
            labelCep.AutoSize = true;
            labelCep.Location = new Point(690, 312);
            labelCep.Name = "labelCep";
            labelCep.Size = new Size(28, 15);
            labelCep.TabIndex = 32;
            labelCep.Text = "Cep";
            // 
            // textBoxNomeSocial
            // 
            textBoxNomeSocial.Location = new Point(366, 47);
            textBoxNomeSocial.Name = "textBoxNomeSocial";
            textBoxNomeSocial.Size = new Size(164, 23);
            textBoxNomeSocial.TabIndex = 33;
            // 
            // labelNomeSocial
            // 
            labelNomeSocial.AutoSize = true;
            labelNomeSocial.Location = new Point(286, 50);
            labelNomeSocial.Name = "labelNomeSocial";
            labelNomeSocial.Size = new Size(74, 15);
            labelNomeSocial.TabIndex = 34;
            labelNomeSocial.Text = "Nome Social";
            // 
            // labelTitulo
            // 
            labelTitulo.AutoSize = true;
            labelTitulo.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelTitulo.Location = new Point(252, 9);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(103, 24);
            labelTitulo.TabIndex = 35;
            labelTitulo.Text = "Cadastro";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(49, 301);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(511, 136);
            dataGridView1.TabIndex = 36;
            // 
            // buttonMostrarClientes
            // 
            buttonMostrarClientes.Location = new Point(592, 393);
            buttonMostrarClientes.Name = "buttonMostrarClientes";
            buttonMostrarClientes.Size = new Size(181, 47);
            buttonMostrarClientes.TabIndex = 37;
            buttonMostrarClientes.Text = "MostrarClientes";
            buttonMostrarClientes.UseVisualStyleBackColor = true;
            // 
            // FormUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RosyBrown;
            ClientSize = new Size(1141, 450);
            Controls.Add(buttonMostrarClientes);
            Controls.Add(dataGridView1);
            Controls.Add(labelTitulo);
            Controls.Add(labelNomeSocial);
            Controls.Add(textBoxNomeSocial);
            Controls.Add(labelCep);
            Controls.Add(maskedTextBoxCep);
            Controls.Add(comboBoxEstado);
            Controls.Add(labelEstado);
            Controls.Add(textBoxMunicipio);
            Controls.Add(labelMunicipio);
            Controls.Add(label1);
            Controls.Add(textBoxBairro);
            Controls.Add(labelComplemento);
            Controls.Add(textBoxComplemento);
            Controls.Add(labelNumero);
            Controls.Add(textBoxNumero);
            Controls.Add(labelLogradouro);
            Controls.Add(textBoxLogradouro);
            Controls.Add(buttonAdicionarClientes);
            Controls.Add(radioButtonPF);
            Controls.Add(radioButtonPJ);
            Controls.Add(labelEstrangeiro);
            Controls.Add(checkBoxEstrangeiro);
            Controls.Add(labelEtnia);
            Controls.Add(comboBoxEtnia);
            Controls.Add(labelGenero);
            Controls.Add(comboBoxGenero);
            Controls.Add(textBoxEmail);
            Controls.Add(labelEmail);
            Controls.Add(maskedTextBoxTelefone);
            Controls.Add(labelTelefone);
            Controls.Add(labelDataNasc);
            Controls.Add(maskedTextBoxDataNasc);
            Controls.Add(textBoxNome);
            Controls.Add(labelNome);
            Name = "FormUsuario";
            Text = "Email";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label labelNome;
        private TextBox textBoxNome;
        private MaskedTextBox maskedTextBoxDataNasc;
        private Label labelDataNasc;
        private Label labelTelefone;
        private MaskedTextBox maskedTextBoxTelefone;
        private Label labelEmail;
        private TextBox textBoxEmail;
        private ComboBox comboBoxGenero;
        private Label labelGenero;
        private ComboBox comboBoxEtnia;
        private Label labelEtnia;
        private CheckBox checkBoxEstrangeiro;
        private Label labelEstrangeiro;
        private RadioButton radioButtonPJ;
        private RadioButton radioButtonPF;
        private Button buttonAdicionarClientes;
        private TextBox textBoxLogradouro;
        private Label labelLogradouro;
        private TextBox textBoxNumero;
        private Label labelNumero;
        private TextBox textBoxComplemento;
        private Label labelComplemento;
        private TextBox textBoxBairro;
        private Label label1;
        private Label labelMunicipio;
        private TextBox textBoxMunicipio;
        private Label labelEstado;
        private ComboBox comboBoxEstado;
        private MaskedTextBox maskedTextBoxCep;
        private Label labelCep;
        private TextBox textBoxNomeSocial;
        private Label labelNomeSocial;
        private Label labelTitulo;
        private DataGridView dataGridView1;
        private Button buttonMostrarClientes;
    }
}
