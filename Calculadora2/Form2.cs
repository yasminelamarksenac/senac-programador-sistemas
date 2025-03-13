using System;
using System.Windows.Forms;

namespace Calculadora2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

           
            {
                InitializeComponent();

                comboOperacao.Items.Add("Quadrado");
                comboOperacao.Items.Add("Retângulo");
                comboOperacao.SelectedIndex = 0;

                comboOperacao.Items.Add("Perímetro");
                comboOperacao.Items.Add("Área");
                comboOperacao.Items.Add("Volume");

                comboOperacao.SelectedIndex = 0;
            }

        }

        private void buttonCalcular_Click(object sender, EventArgs e)
        {
           
                double lado, altura;

                // Verifica qual forma foi selecionada
                string forma = comboOperacao.SelectedItem.ToString();

                if (!double.TryParse(txtLado.Text, out lado) || lado <= 0)
                {
                    MessageBox.Show("Insira um valor válido para a base/lado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (forma == "Retângulo")
                {
                    if (!double.TryParse(txtAltura.Text, out altura) || altura <= 0)
                    {
                        MessageBox.Show("Insira um valor válido para a altura.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                else
                {
                    altura = lado; // No quadrado, altura = lado
                }

                string operacao = comboOperacao.SelectedItem.ToString();
                double resultado = 0;

                switch (operacao)
                {
                    case "Perímetro":
                        resultado = forma == "Quadrado" ? 4 * lado : 2 * (lado + altura);
                        break;
                    case "Área":
                        resultado = lado * altura;
                        break;
                    case "Volume":
                        resultado = lado * lado * altura; // Volume de um paralelepípedo (caso seja retângulo) ou cubo (caso seja quadrado)
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
            txtAltura.Clear();
            lblResultado.Text = "Resultado:";
        }
    }
}
