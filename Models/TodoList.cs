using System.Collections.Generic;
namespace TodoApp.Models
{
    public class TodoList
    {
        public int TodoListId { get; set; }
        public string TodoListName { get; set; }
        public List<Todo> Todos { get; set; }
    }
}
