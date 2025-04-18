namespace CadastroProduto
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
            buttonCadastrar = new Button();
            textBoxProduto = new TextBox();
            textBoxPreco = new TextBox();
            buttonDeletar = new Button();
            dataGridViewProduto = new DataGridView();
            label1 = new Label();
            comboBoxQuantidade = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProduto).BeginInit();
            SuspendLayout();
            // 
            // buttonCadastrar
            // 
            buttonCadastrar.Location = new Point(221, 331);
            buttonCadastrar.Name = "buttonCadastrar";
            buttonCadastrar.Size = new Size(178, 32);
            buttonCadastrar.TabIndex = 0;
            buttonCadastrar.Text = "Cadastrar";
            buttonCadastrar.UseVisualStyleBackColor = true;
            buttonCadastrar.Click += buttonCadastrar_Click;
            // 
            // textBoxProduto
            // 
            textBoxProduto.Location = new Point(190, 190);
            textBoxProduto.Name = "textBoxProduto";
            textBoxProduto.Size = new Size(209, 23);
            textBoxProduto.TabIndex = 1;
            // 
            // textBoxPreco
            // 
            textBoxPreco.Location = new Point(205, 233);
            textBoxPreco.Name = "textBoxPreco";
            textBoxPreco.Size = new Size(100, 23);
            textBoxPreco.TabIndex = 2;
            // 
            // buttonDeletar
            // 
            buttonDeletar.Location = new Point(498, 345);
            buttonDeletar.Name = "buttonDeletar";
            buttonDeletar.Size = new Size(75, 23);
            buttonDeletar.TabIndex = 3;
            buttonDeletar.Text = "Deletar";
            buttonDeletar.UseVisualStyleBackColor = true;
            buttonDeletar.Click += buttonDeletar_Click;
            // 
            // dataGridViewProduto
            // 
            dataGridViewProduto.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProduto.Location = new Point(448, 25);
            dataGridViewProduto.Name = "dataGridViewProduto";
            dataGridViewProduto.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewProduto.Size = new Size(324, 301);
            dataGridViewProduto.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(205, 139);
            label1.Name = "label1";
            label1.Size = new Size(184, 29);
            label1.TabIndex = 5;
            label1.Text = "Cadastrar Produtos";
            // 
            // comboBoxQuantidade
            // 
            comboBoxQuantidade.FormattingEnabled = true;
            comboBoxQuantidade.Items.AddRange(new object[] { "1  ", "2  ", "3  ", "4  ", "5  ", "6  ", "7  ", "8  ", "9  ", "10  ", "11  ", "12  ", "13  ", "14  ", "15  ", "16  ", "17  ", "18  ", "19  ", "20  ", "21  ", "22  ", "23  ", "24  ", "25  ", "26  ", "27  ", "28  ", "29  ", "30  ", "31  ", "32  ", "33  ", "34  ", "35  ", "36  ", "37  ", "38  ", "39  ", "40  ", "41  ", "42  ", "43  ", "44  ", "45  ", "46  ", "47  ", "48  ", "49  ", "50  ", "51  ", "52  ", "53  ", "54  ", "55  ", "56  ", "57  ", "58  ", "59  ", "60  ", "61  ", "62  ", "63  ", "64  ", "65  ", "66  ", "67  ", "68  ", "69  ", "70  ", "71  ", "72  ", "73  ", "74  ", "75  ", "76  ", "77  ", "78  ", "79  ", "80  ", "81  ", "82  ", "83  ", "84  ", "85  ", "86  ", "87  ", "88  ", "89  ", "90  ", "91  ", "92  ", "93  ", "94  ", "95  ", "96  ", "97  ", "98  ", "99  ", "100" });
            comboBoxQuantidade.Location = new Point(335, 233);
            comboBoxQuantidade.Name = "comboBoxQuantidade";
            comboBoxQuantidade.Size = new Size(45, 23);
            comboBoxQuantidade.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(comboBoxQuantidade);
            Controls.Add(label1);
            Controls.Add(dataGridViewProduto);
            Controls.Add(buttonDeletar);
            Controls.Add(textBoxPreco);
            Controls.Add(textBoxProduto);
            Controls.Add(buttonCadastrar);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridViewProduto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonCadastrar;
        private TextBox textBoxProduto;
        private TextBox textBoxPreco;
        private Button buttonDeletar;
        private DataGridView dataGridViewProduto;
        private Label label1;
        private ComboBox comboBoxQuantidade;
    }
}
