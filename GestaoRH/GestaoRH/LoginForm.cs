using GestaoRH.BancoDeDados;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestaoRH
{
    public partial class LoginForm : Form
    {
        private string nomeUsuario;
        public LoginForm()
        {
            InitializeComponent();
        }
        private void CarregarFuncionarios()
        {
            try
            {
                using (var con = DataBase.GetConnection())
                {
                    con.Open();
                    string query = "SELECT * FROM Funcionario";
                    MySqlDataAdapter da = new MySqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridViewFuncionarios.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar os funcionários: " + ex.Message);
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            {
                this.nomeUsuario = nomeUsuario;
                labelBemVindo.Text = "Bem-vindo, " + nomeUsuario;
                CarregarFuncionarios();


            }
        }
    }

}
