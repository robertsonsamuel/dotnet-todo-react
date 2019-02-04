using System.Collections.Generic;
using TodoApp.Models;

namespace TodoApp.Interfaces
{
    public interface ITodoListRepository : IRepositoryBase<TodoList>
    {
        IEnumerable<TodoList> GetAllTodoLists();
    }
}
