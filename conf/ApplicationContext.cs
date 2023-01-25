using Exercise2.Models;

namespace Exercise2.Conf
{
    // Implemented as a singleton class
    // Singleton: Exactly one instance of this class exists
    public class ApplicationContext
    {
        private List<TodoList> TodoLists;

        private static ApplicationContext instance = null;

        public static ApplicationContext Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ApplicationContext();
                }
                return instance;
            }
        }

        public ApplicationContext()
        {
            this.TodoLists = new List<TodoList>();
        }

        public List<TodoList> GetTodoLists()
        {
            return this.TodoLists;
        }
    }
}