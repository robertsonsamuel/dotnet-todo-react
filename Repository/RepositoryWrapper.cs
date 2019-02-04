using TodoApp.Interfaces;

namespace TodoApp.Repository
{

    public class RepositoryWrapper : IRepositoryWrapper
    {
        private readonly RepositoryContext _repoContext;
        private ITodoListRepository _todoList;
        private ITodoRepository _todo;

        public ITodoListRepository TodoList
        {
            get
            {
                if (_todoList == null)
                {
                    _todoList = new TodoListRepository(_repoContext);
                }

                return _todoList;

            }
        }

        public ITodoRepository Todo
        {
            get
            {
                if(_todo == null)
                {
                    _todo = new TodoRepository(_repoContext);
                }
                return _todo;
            }
        }

        public RepositoryWrapper(RepositoryContext repositoryContext)
        {
            _repoContext = repositoryContext;
        }
    }

}
