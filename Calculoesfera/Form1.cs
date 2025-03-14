using System;
using System.Windows.Forms;

namespace Calculoesfera
{
    // Aqui estamos criando a classe 'Form1' que é a janela (formulário) do nosso programa
    public partial class Form1 : Form
    {
        // Este é o construtor da classe, chamado quando a janela é aberta
        public Form1()
        {
            InitializeComponent(); // Chama o método para inicializar todos os componentes da janela (botões, campos de texto, etc.)

            // Preenche o ComboBox (a lista suspensa) com as opções que o usuário pode escolher
            comboOperacao.Items.Add("Perímetro");
            comboOperacao.Items.Add("Raio");
            comboOperacao.Items.Add("Diâmetro");
            comboOperacao.Items.Add("Área da Superfície");
            comboOperacao.Items.Add("Volume");

            // Seleciona automaticamente a primeira opção da lista
            comboOperacao.SelectedIndex = 0;
        }

        // Este é o método que é chamado quando o botão "Calcular" é clicado
        private void buttonCalcular_Click(object sender, EventArgs e)
        {
            // Exibe uma mensagem de teste para saber se o botão foi clicado
            MessageBox.Show("Botão Calcular Clicado!");

            double raio; // Declara uma variável 'raio' para armazenar o valor que o usuário vai digitar

            // Verifica se o campo de texto (txtRaio) está vazio ou se o valor digitado não pode ser convertido para um número
            // Ou se o valor digitado é menor ou igual a 0 (não é válido para o cálculo)
            if (string.IsNullOrEmpty(txtRaio.Text) || !double.TryParse(txtRaio.Text, out raio) || raio <= 0)
            {
                // Se for inválido, exibe uma mensagem de erro
                MessageBox.Show("Insira um valor válido para o raio.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Se o valor for inválido, o código é interrompido aqui e não faz mais nada
            }

            string operacao = comboOperacao.Text; // Obtém o valor da operação selecionada no ComboBox (ex: "Perímetro", "Raio", etc.)
            double resultado = 0; // Inicializa a variável 'resultado' com 0 (vai armazenar o resultado do cálculo)

            // Este é o comando 'switch', que verifica qual operação o usuário escolheu e realiza o cálculo correspondente
            switch (operacao)
            {
                // Se a operação for "Perímetro", calcula o perímetro da esfera
                case "Perímetro":
                    resultado = 2 * Math.PI * raio; // Fórmula do perímetro da esfera
                    break;

                // Se a operação for "Raio", retorna o valor do raio que o usuário digitou
                case "Raio":
                    resultado = raio;
                    break;

                // Se a operação for "Diâmetro", calcula o diâmetro da esfera (diâmetro = 2 * raio)
                case "Diâmetro":
                    resultado = 2 * raio;
                    break;

                // Se a operação for "Área da Superfície", calcula a área da superfície da esfera
                case "Área da Superfície":
                    resultado = 4 * Math.PI * Math.Pow(raio, 2); // Fórmula da área da superfície de uma esfera
                    break;

                // Se a operação for "Volume", calcula o volume da esfera
                case "Volume":
                    resultado = (4.0 / 3.0) * Math.PI * Math.Pow(raio, 3); // Fórmula do volume da esfera
                    break;

                // Se a operação não for uma das opções válidas, exibe uma mensagem de erro
                default:
                    MessageBox.Show("Selecione uma operação válida.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; // Interrompe a execução do código
            }

            // Exibe uma mensagem com o valor do raio, a operação escolhida e o resultado do cálculo
            MessageBox.Show($"Raio: {raio}\nOperação: {operacao}\nResultado: {resultado}");

            // Exibe o resultado na label 'lblResultado' com 2 casas decimais
            lblResultado.Text = "Resultado: " + resultado.ToString("F2");

            // Torna a label 'lblResultado' visível para mostrar o resultado
            lblResultado.Visible = true;
        }

        // Este é o método que é chamado quando o botão "Limpar" é clicado
        private void buttonLimpar_Click(object sender, EventArgs e)
        {
            // Limpa o campo de texto onde o usuário digitou o raio
            txtRaio.Clear();

            // Reseta o texto da label para "Resultado:" (sem valor)
            lblResultado.Text = "Resultado:";

            // Torna a label invisível novamente, já que o resultado foi apagado
            lblResultado.Visible = false;
        }
    }
}
