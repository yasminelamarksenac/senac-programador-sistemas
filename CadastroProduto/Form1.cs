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

                string query = "SELECT Id, Nome, Preco, Quantidade FROM Produto";

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
            if (string.IsNullOrWhiteSpace(textBoxProduto.Text) ||
                string.IsNullOrWhiteSpace(textBoxPreco.Text) ||
                comboBoxQuantidade.SelectedItem == null)
            {
                MessageBox.Show("Preencha todos os campos antes de cadastrar.");
                return;
            }

            string nome = textBoxProduto.Text;
            decimal preco = Convert.ToDecimal(textBoxPreco.Text);
            DateTime dataProduto = DateTime.Now;
            int quantidade = Convert.ToInt32(comboBoxQuantidade.Text);

            using (var con = DataBase.GetConnection())
            {
                con.Open();

                // Inserir produto
                string queryProduto = "INSERT INTO Produto (nome, data_produto, preco, quantidade) VALUES (@nome, @data_produto, @preco, @quantidade)";
                using (var cmdProduto = new MySqlCommand(queryProduto, con))
                {
                    cmdProduto.Parameters.AddWithValue("@nome", nome);
                    cmdProduto.Parameters.AddWithValue("@data_produto", dataProduto);
                    cmdProduto.Parameters.AddWithValue("@preco", preco);
                    cmdProduto.Parameters.AddWithValue("@quantidade", quantidade);

                    cmdProduto.ExecuteNonQuery();
                }

                // Obter o ID do produto inserido
                long idProdutoInserido;
                using (var cmdLastId = new MySqlCommand("SELECT LAST_INSERT_ID();", con))
                {
                    object result = cmdLastId.ExecuteScalar();
                    idProdutoInserido = Convert.ToInt64(result); // conversão segura
                }

                // Inserir no estoque
                string queryEstoque = "INSERT INTO Estoque (id_produto, data_produto, quantidade) VALUES (@id_produto, @data_produto, @quantidade)";
                using (var cmdEstoque = new MySqlCommand(queryEstoque, con))
                {
                    cmdEstoque.Parameters.AddWithValue("@id_produto", idProdutoInserido);
                    cmdEstoque.Parameters.AddWithValue("@data_produto", dataProduto);
                    cmdEstoque.Parameters.AddWithValue("@quantidade", quantidade);

                    cmdEstoque.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Produto cadastrado com sucesso!");
            CarregarProdutos();
            textBoxProduto.Clear();
            textBoxPreco.Clear();
            comboBoxQuantidade.SelectedIndex = -1;
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
                        comboBoxQuantidade.SelectedIndex = -1;
                    }
                }
            }
            else
            {
                MessageBox.Show("Selecione um produto para remover.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CarregarProdutos();
        }
    }
}
