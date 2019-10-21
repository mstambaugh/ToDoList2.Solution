using System;
using MySql.Data.MySqlClient;
using ToDoList2;

namespace ToDoList2.Models
{
    public class DB
    {
        public static MySqlConnection Connection()
        {
        MySqlConnection conn = new MySqlConnection(DBConfiguration.ConnectionString);
        return conn;
        }
    }
}