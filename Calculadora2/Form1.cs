using System;
using System.Windows.Forms;

namespace Calculadora2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            cmbOperacao.Items.Add("+");
            cmbOperacao.Items.Add("-");
            cmbOperacao.Items.Add("*");
            cmbOperacao.Items.Add("/");
            cmbOperacao.SelectedIndex = 0;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double num1, num2, resultado = 0;
            string operacao = cmbOperacao.SelectedItem.ToString();


            if (double.TryParse(txtNumero1.Text, out num1) && double.TryParse(txtNumero2.Text, out num2))
            {
                if (operacao == "+") resultado = num1 + num2;
                else if (operacao == "-") resultado = num1 - num2;
                else if (operacao == "*") resultado = num1 * num2;
                else if (operacao == "/")
                {
                    if (num2 == 0)
                    {
                        MessageBox.Show("Erro: Não pode dividir por zero!");
                        return;
                    }
                    resultado = num1 / num2;
                }


                label1.Text = "Resultado: " + resultado.ToString();
            }
            else
            {
                MessageBox.Show("Digite números válidos!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            InitializeComponent();
            Form2 form2 = new Form2();
            form2.ShowDialog();
       }
    }
}
 