using Exercise2.Interfaces;
using Exercise2.Models;
using Exercise2.Conf;

namespace Exercise2.Services
{
    // Class needs to comply with the interface.
    // It has to implement all methods declared in the interface which assures us of expected method calls.
    public class TodoListServiceContext : ITodoListService
    {
        private ApplicationContext Context;
        private List<TodoList> TodoLists;

        public TodoListServiceContext()
        {
            Context = ApplicationContext.Instance;
            TodoLists = Context.GetTodoLists();
        }
        public void Delete(int id)
        {
            this.TodoLists = this.TodoLists.Where(list => list.GetTodoListId() != id).ToList();
        }

        public TodoList FindById(int id)
        {
            return this.TodoLists.FirstOrDefault(list => list.GetTodoListId() == id);
        }

        public List<TodoList> GetAll()
        {
            return this.TodoLists;
        }

        public TodoList Save(TodoList list)
        {
            this.TodoLists.Add(list);
            return list;
        }
    }
}