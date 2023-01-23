using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ConsoleApp3
{
    class BaseConnection
    {
        //отсылаем данные для подключения
        public static MySqlConnection GetDBConnection()
        {
            string host = "localhost";
            int port = 81;
            string database = "catbd";
            string username = "root";
            string password = "mysql";

            return SqlConnection.GetDBConnection(host, port, database, username, password);
        }

    }
}
