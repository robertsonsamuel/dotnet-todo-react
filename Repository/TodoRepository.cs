using System.Collections.Generic;
using TodoApp.AspNetCore.Models;

namespace TodoApp.AspNetCore.Repository
{
    public class TodoRepository: ITodoListRepository
    {
        public IEnumerable<TodoList> GetAll()
        {
            throw new System.NotImplementedException();
        }
    }
}
