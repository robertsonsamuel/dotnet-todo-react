using System.Collections.Generic;
using TodoApp.Interfaces;
using TodoApp.Models;

namespace TodoApp.Repository
{
    public class TodoListRepository: RepositoryBase<TodoList>, ITodoListRepository
    {
        // TODO: Find out how this works IE: public Thing(Type variable) : base(something else?)
        public TodoListRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {

        }

        public IEnumerable<TodoList> GetAllTodoLists()
        {
            throw new System.NotImplementedException();
        }
    }
}
