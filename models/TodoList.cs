namespace Exercise2
{
    namespace Models
    {
        public class TodoList
        {
            private int Id;
            private string Name;
            private List<TodoItem> TodoItem;

            public TodoList(int id, string name)
            {
                this.Id = id;
                this.Name = name;
                this.TodoItem = new List<TodoItem>();
            }

            public void AddTodoItem(TodoItem item)
            {
                this.TodoItem.Add(item);
            }

            public void RemoveTodoItem(int id)
            {
                this.TodoItem = this.TodoItem.Where(item => item.GetItemId() != id).ToList();
            }

            public void GetToDoItems()
            {
                foreach (TodoItem item in this.TodoItem)
                {
                    Console.WriteLine("=======================");
                    Console.WriteLine("Item id: " + item.GetItemId());
                    Console.WriteLine("Item content: " + item.GetItemContent());
                    Console.WriteLine("Item content: " + item.GetItemStatus());
                    Console.WriteLine("=======================");
                }
            }

            public bool CheckIfTodoListItemExistById(int id)
            {
                bool itemExist = false;

                if (this.GetTodoListItemById(id) != null)
                {
                    itemExist = true;
                }
                return itemExist;
            }

            public TodoItem GetTodoListItemById(int id)
            {
                return this.TodoItem.FirstOrDefault(item => item.GetItemId() == id);
            }

            public int GetTodoItemCount()
            {
                return this.TodoItem.Count();
            }

            public int GetTodoListId()
            {
                return this.Id;
            }

            public string GetTodoListName()
            {
                return this.Name;
            }
        }
    }
}