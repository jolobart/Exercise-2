using Exercise2.Models;

namespace Exercise2.Interfaces
{
    public interface ITodoItemService
    {
        List<TodoItem> GetAll(int listId);
        TodoItem FindById(int listId, int id);
        TodoItem Save(int listId, TodoItem item);
        void Delete(int listId, TodoItem item);
    }
}