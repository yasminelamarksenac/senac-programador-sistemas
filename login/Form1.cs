<<<<<<< HEAD
=======
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

>>>>>>> 2602750860fa9895c8be5ddb014b518380978897
namespace Login
{
    public partial class FormLogin : Form
    {
<<<<<<< HEAD

        List<string> listaUsuarios = new List<string>() { "neymar.jr", "pablo.vitar", "sukuna.silva" };
        List<string> listaSenhas = new List<string>() { "bruna", "12345", "777" };

=======
        List<string> listaUsuarios = new List<string>() { "neymar.jr", "pablo.vitar", "sukuna.silva" };
        List<string> listaSenhas = new List<string>() { "bruna", "12345", "777" };

>>>>>>> 2602750860fa9895c8be5ddb014b518380978897
        public FormLogin()
        {
            InitializeComponent();
        }

        private void buttonEntrar_Click(object sender, EventArgs e)
        {
            string usuarioBuscado = textBoxUsuario.Text;
            string senha = textBoxSenha.Text;

<<<<<<< HEAD
            if (string.IsNullOrWhiteSpace(usuarioBuscado))
            {
                labelResultado.Text = "Usuario eh obrigatorio!!!";
=======

            if (string.IsNullOrWhiteSpace(usuarioBuscado))
            {
                labelResultado.Text = "Usuário é obrigatório!";
>>>>>>> 2602750860fa9895c8be5ddb014b518380978897
                labelResultado.ForeColor = Color.Red;
                return;
            }

<<<<<<< HEAD
=======

>>>>>>> 2602750860fa9895c8be5ddb014b518380978897
            if (string.IsNullOrWhiteSpace(senha))
            {
                labelResultado.Text = "Senha eh obrigatoria!!!";
                labelResultado.ForeColor = Color.Red;
                return;
            }

<<<<<<< HEAD
            int posicaoUsuarioEncontrado = -1;
            for (int i = 0; i < listaUsuarios.Count; i++)
            {
                if (usuarioBuscado == listaUsuarios[i])
                {
                    posicaoUsuarioEncontrado = i;
                }
            }

            if (posicaoUsuarioEncontrado > -1 && senha == listaSenhas[posicaoUsuarioEncontrado])
            {
                labelResultado.Text = "Autenticado com sucesso!";
                labelResultado.ForeColor = Color.Green;
=======
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
>>>>>>> 2602750860fa9895c8be5ddb014b518380978897
            }

            if (posicaoUsuarioEncontrado > -1 && senha == listaSenhas[posicaoUsuarioEncontrado])
            {
                labelResultado.Text = "Autenticado com sucesso!";
                labelResultado.ForeColor = Color.Green;
            }
            else
            {
<<<<<<< HEAD
                labelResultado.Text = "Usuario ou Senha incorretos...";
=======
                labelResultado.Text = "Usuário ou senha incorretos...";
>>>>>>> 2602750860fa9895c8be5ddb014b518380978897
                labelResultado.ForeColor = Color.Red;
            }
        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            string novoUsuario = textBoxNovoUsuario.Text;
            string novaSenha = textBoxNovaSenha.Text;

            if (string.IsNullOrWhiteSpace(novoUsuario))
            {
                labelNovoUsuario.Text = "Usuario eh obrigatorio!!!";
=======


            string novoUsuario = textBoxUsuario.Text;
            string novaSenha = textBoxSenha.Text;

            
            if (string.IsNullOrWhiteSpace(novoUsuario))
            {
                labelResultado.Text = "Nome de usuário é obrigatório!";
                labelResultado.ForeColor = Color.Red;
>>>>>>> 2602750860fa9895c8be5ddb014b518380978897
                return;
            }

            if (string.IsNullOrWhiteSpace(novaSenha))
            {
<<<<<<< HEAD
                labelNovoUsuario.Text = "Senha eh obrigatoria!!!";
                return;
            }

            bool usuarioEncontrado = false;
            for (int i = 0; i < listaUsuarios.Count; i++)
            {
                if (novoUsuario == listaUsuarios[i])
                {
                    usuarioEncontrado = true;
                }
            }

            if (!usuarioEncontrado)
            {
                listaUsuarios.Add(novoUsuario);
                listaSenhas.Add(novaSenha);
                labelNovoUsuario.Text = "Usu?rio cadastrado com sucesso!";
            }
            else
            {
                labelNovoUsuario.Text = "J? existe um usu?rio cadastrado";
            }
        }
    }
}
=======
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

>>>>>>> 2602750860fa9895c8be5ddb014b518380978897
