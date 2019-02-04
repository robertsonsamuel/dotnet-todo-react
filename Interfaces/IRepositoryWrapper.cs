namespace TodoApp.Interfaces
{
    public interface IRepositoryWrapper
    {
        ITodoListRepository TodoList{ get; }

        ITodoRepository Todo { get; }
    }
}
