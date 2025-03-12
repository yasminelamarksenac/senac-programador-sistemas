using System;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCalcular_Click(object sender, EventArgs e)
        {
            double numero1, numero2, resultado = 0;
            string numero2Texto = textNumero2.Text;

            if (double.TryParse(textNumero1.Text, out numero1) && double.TryParse(numero2Texto, out numero2))
            {
                char operador = numero2Texto[0];
                numero2Texto = numero2Texto.Substring(1);

                // Calculando o resultado
                if (operador == '+') resultado = numero1 + numero2;
                else if (operador == '-') resultado = numero1 - numero2;
                else if (operador == '*') resultado = numero1 * numero2;
                else if (operador == '/') resultado = numero2 != 0 ? numero1 / numero2 : double.NaN;


            }
            else
            {
                lblResultado.Text = "Digite números válidos!";
            }
        }

        private void buttonAbrir_Click(object sender, EventArgs e)
        {

           string resultado = lblResultado.Text;
            Form2 novoForm = new Form2(resultado);
            novoForm.Show();
        }

        private void lblResultado_Click(object sender, EventArgs e)
        {
 
        }
    }
}
