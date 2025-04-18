using ListaAtividades.banco_de_dados;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace CadastroProduto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CarregarProdutos()
        {
            using (var conexao = DataBase.GetConnection())
            {
                conexao.Open();

                string query = "SELECT Id, Nome, Preco FROM Produto";

                MySqlCommand comando = new MySqlCommand(query, conexao);
                MySqlDataAdapter adapter = new MySqlDataAdapter(comando);
                DataTable tabela = new DataTable();

                adapter.Fill(tabela);

                dataGridViewProduto.DataSource = tabela;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CarregarProdutos();
        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            string nome = textBoxProduto.Text;
            decimal preco = Convert.ToDecimal(textBoxPreco.Text);
            DateTime dataProduto = DateTime.Now;
            int quantidade = comboBoxQuantidade.SelectedIndex;


            using (var con = DataBase.GetConnection())
            {
                con.Open();

                string query = "INSERT INTO Produto (nome, data_produto, preco, quantidade) VALUES (@nome, @data_produto, @preco, @quantidade)";

                using (var cmd = new MySqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@nome", nome);
                    cmd.Parameters.AddWithValue("@data_produto", dataProduto);
                    cmd.Parameters.AddWithValue("@preco", preco);


                    cmd.ExecuteNonQuery();
                }
                using (var cmd = new MySqlCommand(query, con))
                {
                    string query2 = "INSERT INTO estoque (data_produto, quantidade) VALUES ( @data_produto, @quantidade)";
                    cmd.Parameters.AddWithValue("@quantidade", quantidade);
                   
                }

               ;
            } 

            MessageBox.Show("Produto cadastrado com sucesso!");
            CarregarProdutos();
            textBoxProduto.Clear();
            textBoxPreco.Clear();
        }

        private void buttonDeletar_Click(object sender, EventArgs e)
        {
            if (dataGridViewProduto.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dataGridViewProduto.SelectedRows[0].Cells["Id"].Value);

                using (var conexao = DataBase.GetConnection())
                {
                    conexao.Open();

                    DialogResult confirm = MessageBox.Show("Deseja realmente excluir este produto?", "Confirmação", MessageBoxButtons.YesNo);
                    if (confirm == DialogResult.Yes)
                    {
                        
                        var cmdEstoque = new MySqlCommand("SELECT COUNT(*) FROM Estoque WHERE id_produto = @id", conexao);
                        cmdEstoque.Parameters.AddWithValue("@id", id);
                        int estoqueCount = Convert.ToInt32(cmdEstoque.ExecuteScalar());

                        if (estoqueCount > 0)
                        {
                            MessageBox.Show("Este produto está vinculado ao estoque e não pode ser removido.");
                            return;
                        }

                       
                        var cmdProduto = new MySqlCommand("DELETE FROM Produto WHERE Id = @id", conexao);
                        cmdProduto.Parameters.AddWithValue("@id", id);
                        cmdProduto.ExecuteNonQuery();

                        MessageBox.Show("Produto removido com sucesso!");
                        CarregarProdutos();
                        textBoxProduto.Clear();
                        textBoxPreco.Clear();
                        comboBoxQuantidade.SelectedIndex = 0;
                    }
                }
            }
            else
            {
                MessageBox.Show("Selecione um produto para remover.");
            }
        }
    }
}
