using MySql.Data.MySqlClient;

namespace SQL_APP_001
{
    class DB
    {
        private string dbName;
        private string dbUser;
        private string dbPassword;
        private int dbPort;
        private string dbServer;

        //private string dbConnectionString = "";
        internal MySqlConnection conn;


        public DB()
        {
            dbName = "ME_traffic_cop";
            dbUser = "ME_traffic_cop";
            dbPassword = "Password1";
            dbPort = 3306;
            dbServer = "localhost";

            string dbConnectionString = $"server={dbServer}; user={dbUser}; database={dbName}; port={dbPort}; password={dbPassword}";
            conn = new MySqlConnection(dbConnectionString);
        }

        //public void OpenConnection()
        //{
        //    conn.Open();
        //}

        //public void CloseConnection()
        //{
        //    conn.Close();
        //}
    }
}
