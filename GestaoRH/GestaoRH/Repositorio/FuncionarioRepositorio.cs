using MySql.Data.MySqlClient;
using GestaoRH.BancoDeDados.Dominio; 
using System;
using System.Collections.Generic;
using GestaoRH.BancoDeDados.Dominio.GestaoRH.dominio;

namespace GestaoRH.Repositorio
{
    public class FuncionarioRepositorio
    {
        private string _conexao = "server=localhost;database=gestaorh;uid=root;pwd=;";

      
        public void Inserir(Funcionario funcionario)
        {
            using (var con = new MySqlConnection(_conexao))
            {
                con.Open();
                string sql = @"INSERT INTO Funcionario (NomeCompleto, Cpf, Rg, DataNascimento, Genero, EstadoCivil)
                               VALUES (@nome, @cpf, @rg, @dataNascimento, @genero, @estadoCivil)";

                using (var cmd = new MySqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@nome", funcionario.NomeCompleto);
                    cmd.Parameters.AddWithValue("@cpf", funcionario.CPF);
                    cmd.Parameters.AddWithValue("@rg", funcionario.RG);
                    cmd.Parameters.AddWithValue("@dataNascimento", funcionario.DataNascimento);
                    cmd.Parameters.AddWithValue("@genero", funcionario.Genero);
                    cmd.Parameters.AddWithValue("@estadoCivil", funcionario.EstadoCivil);
                    cmd.ExecuteNonQuery();
                }
            }
        }

      
        public List<Funcionario> ObterTodos()
        {
            var lista = new List<Funcionario>();

            using (var con = new MySqlConnection(_conexao))
            {
                con.Open();
                string sql = "SELECT * FROM Funcionario";

                using (var cmd = new MySqlCommand(sql, con))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var funcionario = new Funcionario
                        {
                            Id = Convert.ToInt32(reader["Id"]),
                            NomeCompleto = reader["NomeCompleto"].ToString(),
                            CPF = reader["Cpf"].ToString(),
                            RG = reader["Rg"].ToString(),
                            DataNascimento = Convert.ToDateTime(reader["DataNascimento"]),
                            Genero = reader["Genero"].ToString(),
                            EstadoCivil = reader["EstadoCivil"].ToString()
                        };
                        lista.Add(funcionario);
                    }
                }
            }

            return lista;
        }

        // Método para obter um funcionário por ID
        public Funcionario ObterPorId(int id)
        {
            using (var con = new MySqlConnection(_conexao))
            {
                con.Open();
                string sql = "SELECT * FROM Funcionario WHERE Id = @id";

                using (var cmd = new MySqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Funcionario
                            {
                                Id = Convert.ToInt32(reader["Id"]),
                                NomeCompleto = reader["NomeCompleto"].ToString(),
                                CPF = reader["Cpf"].ToString(),
                                RG = reader["Rg"].ToString(),
                                DataNascimento = Convert.ToDateTime(reader["DataNascimento"]),
                                Genero = reader["Genero"].ToString(),
                                EstadoCivil = reader["EstadoCivil"].ToString()
                            };
                        }
                    }
                }
            }

            return null;
        }
    }
}
