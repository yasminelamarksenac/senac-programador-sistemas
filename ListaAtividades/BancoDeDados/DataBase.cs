﻿using MySql.Data.MySqlClient;

namespace ListaAtividades.BancoDeDados
{
    internal class DataBase
    {

        private static readonly string ConnectionString = "datasource=localhost;username=root;password=;database=senac;";

        public static MySqlConnection GetConnection()
        {
            return new MySqlConnection(ConnectionString);
        }
    }

}
