using MySql.Data.MySqlClient;

namespace GestaoRH.BancoDeDados
{
    internal class DataBase
    {
        public static MySqlConnection GetConnection()
        {
            return new MySqlConnection("server=localhost;user=root;password=;database=GestaoRH;");
        }
    }
}
