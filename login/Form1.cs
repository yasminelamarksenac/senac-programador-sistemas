using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Login
{
    public partial class FormLogin : Form
    {
        List<string> listaUsuarios = new List<string>() { "neymar.jr", "pablo.vitar", "sukuna.silva" };
        List<string> listaSenhas = new List<string>() { "bruna", "12345", "777" };

        public FormLogin()
        {
            InitializeComponent();
        }

        private void buttonEntrar_Click(object sender, EventArgs e)
        {
            string usuarioBuscado = textBoxUsuario.Text;
            string senha = textBoxSenha.Text;


            if (string.IsNullOrWhiteSpace(usuarioBuscado))
            {
                labelResultado.Text = "Usuário é obrigatório!";
                labelResultado.ForeColor = Color.Red;
                return;
            }


            if (string.IsNullOrWhiteSpace(senha))
            {
                labelResultado.Text = "Senha é obrigatória!";
                labelResultado.ForeColor = Color.Red;
                return;
            }

            if (senha.Length < 8)
            {
                labelResultado.Text = "Senha deve ter pelo menos 8 caracteres!";
                labelResultado.ForeColor = Color.Red;
                return;
            }


            int posicaoUsuarioEncontrado = -1;
            for (int i = 0; i < listaUsuarios.Count; i++)
            {
                if (usuarioBuscado == listaUsuarios[i])
                {
                    posicaoUsuarioEncontrado = i;
                    break;
                }
            }

            if (posicaoUsuarioEncontrado > -1 && senha == listaSenhas[posicaoUsuarioEncontrado])
            {
                labelResultado.Text = "Autenticado com sucesso!";
                labelResultado.ForeColor = Color.Green;
            }
            else
            {
                labelResultado.Text = "Usuário ou senha incorretos...";
                labelResultado.ForeColor = Color.Red;
            }
        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {


            string novoUsuario = textBoxUsuario.Text;
            string novaSenha = textBoxSenha.Text;

            
            if (string.IsNullOrWhiteSpace(novoUsuario))
            {
                labelResultado.Text = "Nome de usuário é obrigatório!";
                labelResultado.ForeColor = Color.Red;
                return;
            }

            if (string.IsNullOrWhiteSpace(novaSenha))
            {
                labelResultado.Text = "Senha é obrigatória!";
                labelResultado.ForeColor = Color.Red;
                return;
            }

            if (listaUsuarios.Contains(novoUsuario))
            {
                labelResultado.Text = "Esse nome de usuário já está em uso!";
                labelResultado.ForeColor = Color.Red;
                return;
            }

            if (novaSenha.Length < 8)
            {
                labelResultado.Text = "A senha deve ter pelo menos 8 caracteres!";
                labelResultado.ForeColor = Color.Red;
                return;
            }

            
            listaUsuarios.Add(novoUsuario);
            listaSenhas.Add(novaSenha);

            labelResultado.Text = "Cadastro realizado com sucesso!";
            labelResultado.ForeColor = Color.Green;
        }

        private void textBoxNovoUsuario_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

