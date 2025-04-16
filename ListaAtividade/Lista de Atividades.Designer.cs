namespace ListaAtividade
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
            TextBoxAtividadeAndamento = new TextBox();
            buttonFinalizar = new Button();
            dataGridViewAtividades = new DataGridView();
            buttonAtualizar = new Button();
            buttonCriar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAtividades).BeginInit();
            SuspendLayout();
            // 
            // TextBoxAtividadeAndamento
            // 
            TextBoxAtividadeAndamento.Location = new Point(32, 27);
            TextBoxAtividadeAndamento.Name = "TextBoxAtividadeAndamento";
            TextBoxAtividadeAndamento.ReadOnly = true;
            TextBoxAtividadeAndamento.Size = new Size(496, 23);
            TextBoxAtividadeAndamento.TabIndex = 0;
            
            // buttonFinalizar
            // 
            buttonFinalizar.Location = new Point(534, 27);
            buttonFinalizar.Name = "buttonFinalizar";
            buttonFinalizar.Size = new Size(126, 23);
            buttonFinalizar.TabIndex = 1;
            buttonFinalizar.Text = "Finalizar";
            buttonFinalizar.UseVisualStyleBackColor = true;
            // 
            // dataGridViewAtividades
            // 
            dataGridViewAtividades.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAtividades.Location = new Point(32, 81);
            dataGridViewAtividades.Name = "dataGridViewAtividades";
            dataGridViewAtividades.Size = new Size(522, 437);
            dataGridViewAtividades.TabIndex = 2;
            // 
            // buttonAtualizar
            // 
            buttonAtualizar.Location = new Point(576, 81);
            buttonAtualizar.Name = "buttonAtualizar";
            buttonAtualizar.Size = new Size(127, 27);
            buttonAtualizar.TabIndex = 3;
            buttonAtualizar.Text = "Atualizar";
            buttonAtualizar.UseVisualStyleBackColor = true;
            
            // 
            // buttonCriar
            // 
            buttonCriar.Location = new Point(576, 497);
            buttonCriar.Name = "buttonCriar";
            buttonCriar.Size = new Size(162, 21);
            buttonCriar.TabIndex = 4;
            buttonCriar.Text = "Criar";
            buttonCriar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 530);
            Controls.Add(buttonCriar);
            Controls.Add(buttonAtualizar);
            Controls.Add(dataGridViewAtividades);
            Controls.Add(buttonFinalizar);
            Controls.Add(TextBoxAtividadeAndamento);
            Name = "Form1";
            Text = "Lista de Atividades";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewAtividades).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TextBoxAtividadeAndamento;
        private Button buttonFinalizar;
        private DataGridView dataGridViewAtividades;
        private Button buttonAtualizar;
        private Button buttonCriar;
    }
}
