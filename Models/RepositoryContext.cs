using TodoApp.Models;
using Microsoft.EntityFrameworkCore;

namespace TodoApp
{
    public class RepositoryContext : DbContext
    {
        public RepositoryContext(DbContextOptions options)
            : base(options)
        {
        }

        public DbSet<Todo> Todos { get; set; }
        public DbSet<TodoList> TodoLists{ get; set; }
    }
}