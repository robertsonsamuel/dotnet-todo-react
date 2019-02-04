using Microsoft.EntityFrameworkCore;

namespace TodoApp.AspNetCore.Models

{
  public class TodoContext : DbContext
  {
    public TodoContext(DbContextOptions<TodoContext> options) : base(options)
    { }

    public DbSet<Todo> Todos { get; set; }

    public DbSet<TodoList> TodoLists {get; set;}

  }
}