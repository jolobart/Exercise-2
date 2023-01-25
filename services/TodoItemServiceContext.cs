using Exercise2.Interfaces;
using Exercise2.Models;

namespace Exercise2.Services
{
    // Class needs to comply with the interface.
    // It has to implement all methods declared in the interface which assures us of expected method calls.
    public class TodoItemServiceContext : ITodoItemService
    {
        private TodoListServiceContext todoListServiceContext;
        public TodoItemServiceContext()
        {
            todoListServiceContext = new TodoListServiceContext();
        }

        public void Delete(int listId, TodoItem item)
        {
            var list = this.todoListServiceContext.FindById(listId);
            list.RemoveTodoItem(item.GetItemId());
        }

        public TodoItem FindById(int listId, int id)
        {
            var list = this.todoListServiceContext.FindById(listId);
            return list.GetTodoListItemById(id);
        }

        public List<TodoItem> GetAll(int listId)
        {
            var list = this.todoListServiceContext.FindById(listId);
            return list.GetToDoItems();
        }

        public TodoItem Save(int listId, TodoItem item)
        {
            var list = this.todoListServiceContext.FindById(listId);
            list.AddTodoItem(item);
            return item;
        }
    }
}