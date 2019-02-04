namespace TodoApp.Models
{
  public class Todo
  {
    public int TodoId {get; set;}
    public string TodoBody {get; set;}

    public int TodoListId {get; set;}
    public TodoList TodoList {get; set;}
  }
}