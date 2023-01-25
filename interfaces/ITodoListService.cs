using Exercise2.Models;

namespace Exercise2.Interfaces
{
    public interface ITodoListService
    {
        List<TodoList> GetAll();
        TodoList FindById(int id);
        TodoList Save(TodoList list);
        void Delete(int id);
    }
}