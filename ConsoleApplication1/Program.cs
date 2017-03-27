using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatosMYSQL;
using MySql.Data.MySqlClient;
using System.Reflection;
using System.Data;
using System.Data.Odbc;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
           
            string ConnStr = "Server=127.0.0.1;Database=aerolinea;uid=root;pwd=admin";
            OdbcConnection connection = new OdbcConnection(ConnStr);
            connection.Open();
            Console.WriteLine(connection.Database);
            Console.ReadKey();
        }

    }
  }
