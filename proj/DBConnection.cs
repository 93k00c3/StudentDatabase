using MySql.Data.MySqlClient;

namespace StudentRegDatabase
{
    class DBConnection
    {
        private static MySqlConnection conn = null;

        public static MySqlConnection getConnection()
        {
            string connectionString = "server=127.0.0.1; port=3306;uid=root;database=student";
            conn = new MySqlConnection(connectionString);
            return conn;
        }
    }
}
