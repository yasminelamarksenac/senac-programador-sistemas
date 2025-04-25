using GestaoRH.BancoDeDados;
using MySql.Data.MySqlClient;

namespace GestaoRH
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)


        {
            
            if (string.IsNullOrWhiteSpace(textBoxUsuario.Text) || string.IsNullOrWhiteSpace(textBoxSenha.Text))
            {
                MessageBox.Show("Preencha todos os campos!");
               
                return; 
            }

            string senha = textBoxSenha.Text;

            if (senha.Length < 6)
            {
                MessageBox.Show("A senha deve ter pelo menos 6 caracteres.");
                return;
            }




            using (var con = DataBase.GetConnection())
            {
                con.Open();
                string query = "SELECT * FROM Usuario WHERE NomeUsuario = @nome AND Senha = @senha";


                using (var cmd = new MySqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@nome", textBoxUsuario.Text);
                    cmd.Parameters.AddWithValue("@senha", textBoxSenha.Text);

                    var reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        LoginForm loginForm = new LoginForm();
                        loginForm.Show();
                        this.Hide();
                        
                    }
                    else
                    {
                        MessageBox.Show("Usuário ou senha inválidos!");

                    }

                }
            }

        }
    }
}
