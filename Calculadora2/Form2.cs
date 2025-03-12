using System;
using System.Windows.Forms;

namespace Calculadora2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

            comboOperacao.Items.Add("Perímetro");
            comboOperacao.Items.Add("Área");
            comboOperacao.Items.Add("Volume");

            comboOperacao.SelectedIndex = 0;
        }

        private void buttonCalcular_Click(object sender, EventArgs e)
        {

            double lado;
            if (!double.TryParse(txtLado.Text, out lado) || lado <= 0)
            {
                MessageBox.Show("Por favor, insira um valor válido para o lado do quadrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string operacao = comboOperacao.SelectedItem.ToString();
            double resultado = 0;


            switch (operacao)
            {
                case "Perímetro":
                    resultado = 4 * lado;
                    break;
                case "Área":
                    resultado = lado * lado;
                    break;
                case "Volume":
                    resultado = lado * lado * lado;
                    break;
                default:
                    MessageBox.Show("Selecione uma operação válida.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
            }


            lblResultado.Text = $"Resultado: {resultado}";
        }

        private void buttonLimpar_Click(object sender, EventArgs e)
        {

            txtLado.Clear();
            lblResultado.Text = "Resultado:";
        }
    }
}
