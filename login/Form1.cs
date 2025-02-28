namespace login
{
    public partial class Form1 : Form
    {
       

        Dictionary<string, string> usuarios = new Dictionary<string, string>()
        {
            { "Yasmine", "senhaYasmine" },
            { "Lara", "senhaLara" },
            { "Lamark", "senhaLamark" }
        };

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string usuarioBuscado = textBoxEmail.Text;
            string senha = textBoxSenha.Text;

   

            if (string.IsNullOrWhiteSpace(usuarioBuscado))
            {
                labelResultado.Text = "Todos os campos são obrigatórios!";
                labelResultado.ForeColor = Color.Red;
                return;
            }

            if (string.IsNullOrEmpty(senha))
            {
                labelResultado.Text = "Senha é obrigatória!";
                labelResultado.ForeColor = Color.Red;
                return;
            }

          

            if (usuarios.ContainsKey(usuarioBuscado))
            {
          

                if (usuarios[usuarioBuscado] == senha)
                {
                    labelResultado.Text = "Autenticado com sucesso!";
                    labelResultado.ForeColor = Color.Green;
                }
                else
                {
                    labelResultado.Text = "Usuário ou senha incorretos!";
                    labelResultado.ForeColor = Color.Red;
                }
            }
            else
            {
                labelResultado.Text = "Usuário não encontrado!";
                labelResultado.ForeColor = Color.Red;
            }
        }
    }
}
