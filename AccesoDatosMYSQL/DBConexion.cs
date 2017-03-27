using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace AccesoDatosMYSQL
{
    public sealed class DBConexion
    {
        private static string server = "127.0.0.1";
        private static string database = "aerolinea";
        private static string id = "root";
        private static string password = "admin";

        private static string parametros = "Server=" + server + ";Database=" + database + ";Uid=" + id + ";Pwd=" + password;

        private static MySqlConnection connection;

        public static MySqlConnection Connection {
            get {
                    if (connection == null)
                    {
                        LazyInitializer.EnsureInitialized(ref connection, CreateConnection);
                    }
                    return connection;
            }

        }

        public static MySqlConnection CreateConnection()
        {
            var con = new MySqlConnection(parametros);
            con.Open();
            return con;
        }

        public static void CloseConnection() {
            if (connection != null) {

                connection.Close();
                connection.Dispose();
                connection = null;
            
            }
        }
 
    }
}
