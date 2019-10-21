using Microsoft.EntityFrameworkCore;

namespace ToDoList2.Models
{
    public class ToDoList2Context : DbContext
    {
        public DbSet<Item> Items { get; set; }

        public ToDoList2Context(DbContextOptions options) : base(options) { }
    }
}