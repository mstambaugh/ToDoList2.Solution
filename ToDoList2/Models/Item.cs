using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace ToDoList2.Models
{
    public class Item
    {
        public int ItemId { get; set; }
        public string Description { get; set; }
    }
}