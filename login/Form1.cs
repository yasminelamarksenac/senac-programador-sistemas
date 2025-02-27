namespace login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string usuario = textBoxEmail.Text;
            string senha = textBoxSenha.Text;
       

            
            if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(senha))
            {
                labelResultado.Text = "Todos os campos sao obrigatorios!";
                labelResultado.ForeColor = Color.Red;
                return;
            }

            
            if (usuario == "yasmine" && senha == "1234")
            {
                labelResultado.Text = "Autenticado com sucesso!";
                labelResultado.ForeColor = Color.Green;
            }
            else
            {
                labelResultado.Text = "Usuario ou Senha incorretos.";
                labelResultado.ForeColor = Color.Red;
            }
        }

        private void labelResultado_Click(object sender, EventArgs e)
        {
        }
    }
}
