using System;
using TodoApp.Interfaces;
using TodoApp.Models;

namespace TodoApp.Repository
{
    public class TodoRepository: RepositoryBase<Todo>, ITodoRepository
    {
        public TodoRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
        }
    }
}
