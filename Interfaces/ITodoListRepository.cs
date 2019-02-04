using System.Collections.Generic;
using TodoApp.AspNetCore.Models;

namespace TodoApp.AspNetCore.Repository
{
    public interface ITodoListRepository
    {
        IEnumerable<TodoList> GetAll();
    }
}
