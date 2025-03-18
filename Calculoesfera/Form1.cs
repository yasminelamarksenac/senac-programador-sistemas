using System;
using System.Windows.Forms;

namespace Calculoesfera
{
    // Aqui estamos criando a classe 'Form1' que � a janela (formul�rio) do nosso programa
    public partial class Form1 : Form
    {
        // Este � o construtor da classe, chamado quando a janela � aberta
        public Form1()
        {
            InitializeComponent(); // Chama o m�todo para inicializar todos os componentes da janela (bot�es, campos de texto, etc.)

            // Preenche o ComboBox (a lista suspensa) com as op��es que o usu�rio pode escolher
            comboOperacao.Items.Add("Per�metro");
            comboOperacao.Items.Add("Raio");
            comboOperacao.Items.Add("Di�metro");
            comboOperacao.Items.Add("�rea da Superf�cie");
            comboOperacao.Items.Add("Volume");

            // Seleciona automaticamente a primeira op��o da lista
            comboOperacao.SelectedIndex = 0;
        }

        // Este � o m�todo que � chamado quando o bot�o "Calcular" � clicado
        private void buttonCalcular_Click(object sender, EventArgs e)
        {
            // Exibe uma mensagem de teste para saber se o bot�o foi clicado
            MessageBox.Show("Bot�o Calcular Clicado!");

            double raio; // Declara uma vari�vel 'raio' para armazenar o valor que o usu�rio vai digitar

            // Verifica se o campo de texto (txtRaio) est� vazio ou se o valor digitado n�o pode ser convertido para um n�mero
            // Ou se o valor digitado � menor ou igual a 0 (n�o � v�lido para o c�lculo)
            if (string.IsNullOrEmpty(txtRaio.Text) || !double.TryParse(txtRaio.Text, out raio) || raio <= 0)
            {
                // Se for inv�lido, exibe uma mensagem de erro
                MessageBox.Show("Insira um valor v�lido para o raio.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Se o valor for inv�lido, o c�digo � interrompido aqui e n�o faz mais nada
            }

            string operacao = comboOperacao.Text; // Obt�m o valor da opera��o selecionada no ComboBox (ex: "Per�metro", "Raio", etc.)
            double resultado = 0; // Inicializa a vari�vel 'resultado' com 0 (vai armazenar o resultado do c�lculo)

            // Este � o comando 'switch', que verifica qual opera��o o usu�rio escolheu e realiza o c�lculo correspondente
            switch (operacao)
            {
                // Se a opera��o for "Per�metro", calcula o per�metro da esfera
                case "Per�metro":
                    resultado = 2 * Math.PI * raio; // F�rmula do per�metro da esfera
                    break;

                // Se a opera��o for "Raio", retorna o valor do raio que o usu�rio digitou
                case "Raio":
                    resultado = raio;
                    break;

                // Se a opera��o for "Di�metro", calcula o di�metro da esfera (di�metro = 2 * raio)
                case "Di�metro":
                    resultado = 2 * raio;
                    break;

                // Se a opera��o for "�rea da Superf�cie", calcula a �rea da superf�cie da esfera
                case "�rea da Superf�cie":
                    resultado = 4 * Math.PI * Math.Pow(raio, 2); // F�rmula da �rea da superf�cie de uma esfera
                    break;

                // Se a opera��o for "Volume", calcula o volume da esfera
                case "Volume":
                    resultado = (4.0 / 3.0) * Math.PI * Math.Pow(raio, 3); // F�rmula do volume da esfera
                    break;

                // Se a opera��o n�o for uma das op��es v�lidas, exibe uma mensagem de erro
                default:
                    MessageBox.Show("Selecione uma opera��o v�lida.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; // Interrompe a execu��o do c�digo
            }

            // Exibe uma mensagem com o valor do raio, a opera��o escolhida e o resultado do c�lculo
            MessageBox.Show($"Raio: {raio}\nOpera��o: {operacao}\nResultado: {resultado}");

            // Exibe o resultado na label 'lblResultado' com 2 casas decimais
            lblResultado.Text = "Resultado: " + resultado.ToString("F2");

            // Torna a label 'lblResultado' vis�vel para mostrar o resultado
            lblResultado.Visible = true;
        }

        // Este � o m�todo que � chamado quando o bot�o "Limpar" � clicado
        private void buttonLimpar_Click(object sender, EventArgs e)
        {
            // Limpa o campo de texto onde o usu�rio digitou o raio
            txtRaio.Clear();

            // Reseta o texto da label para "Resultado:" (sem valor)
            lblResultado.Text = "Resultado:";

            // Torna a label invis�vel novamente, j� que o resultado foi apagado
            lblResultado.Visible = false;
        }
    }
}
