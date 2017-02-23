using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatosMYSQL;
using MySql.Data.MySqlClient;


namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            
           MySqlCommand cmd =  DBConexion.Connection.CreateCommand();
           cmd.CommandText = "select * from aeropuertos";
           MySqlDataReader data =  cmd.ExecuteReader();
           if (data.HasRows)
           {
               while (data.Read())
               {
                   Console.WriteLine("{0}\t{1}", data.GetInt32(0),
                      data.GetString(1));
               }
           }

           Console.ReadKey();
           
        }
    }
}
