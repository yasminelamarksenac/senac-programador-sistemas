namespace Calculadora
{
    partial class Form2
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
            labelResultado2 = new Label();
            SuspendLayout();
            // 
            // labelResultado2
            // 
            labelResultado2.AutoSize = true;
            labelResultado2.Location = new Point(302, 90);
            labelResultado2.Name = "labelResultado2";
            labelResultado2.Size = new Size(69, 15);
            labelResultado2.TabIndex = 0;
            labelResultado2.Text = "RESULTADO";
      
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelResultado2);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelResultado2;
    }
}