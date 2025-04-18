using ListaAtividades.banco_de_dados;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;

namespace ListaAtividades.repositorios
{
    internal class ProdutoRepositorio
    {
        public void CadastrarProduto(string nome, decimal preco, DateTime dataProduto)
        {
            using (var con = DataBase.GetConnection())
            {
                con.Open();

                var query = "INSERT INTO Produto (Nome, Preco, Data_Produto) VALUES (@nome, @preco, @data)";

                using (var cmd = new MySqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@nome", nome);
                    cmd.Parameters.AddWithValue("@preco", preco);
                    cmd.Parameters.AddWithValue("@data", dataProduto);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public DataTable ListarProdutos()
        {
            using (var con = DataBase.GetConnection())
            {
                con.Open();

                var query = "SELECT Id, Nome, Preco FROM Produto";
                using (var cmd = new MySqlCommand(query, con))
                using (var adapter = new MySqlDataAdapter(cmd))
                {
                    var tabela = new DataTable();
                    adapter.Fill(tabela);
                    return tabela;
                }
            }
        }

        public bool ProdutoTemVenda(int produtoId)
        {
            using (var con = DataBase.GetConnection())
            {
                con.Open();

                var query = @"
                    SELECT V.Id 
                    FROM Produto P
                    INNER JOIN Venda V ON P.Id = V.ProdutoId
                    WHERE P.Id = @id";

                using (var cmd = new MySqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@id", produtoId);
                    using (var reader = cmd.ExecuteReader())
                    {
                        return reader.HasRows;
                    }
                }
            }
        }

        public void RemoverProduto(int produtoId)
        {
            using (var con = DataBase.GetConnection())
            {
                con.Open();

               
                var cmdEstoque = new MySqlCommand("DELETE FROM Estoque WHERE ProdutoId = @id", con);
                cmdEstoque.Parameters.AddWithValue("@id", produtoId);
                cmdEstoque.ExecuteNonQuery();

               
                var cmdProduto = new MySqlCommand("DELETE FROM Produto WHERE Id = @id", con);
                cmdProduto.Parameters.AddWithValue("@id", produtoId);
                cmdProduto.ExecuteNonQuery();
            }
        }
    }
}
