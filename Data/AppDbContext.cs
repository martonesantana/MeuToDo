using MeuToDo.Models;
using Microsoft.EntityFrameworkCore;

namespace MeuToDo.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Todo> Todos { get; set; }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlite("Data Source=todo.db;Cache=Shared");
        
    }
}