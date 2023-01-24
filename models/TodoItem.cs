namespace Exercise2
{
    namespace Models
    {
        public class TodoItem
        {
            private int Id;
            private string Content;
            private string Status;

            public TodoItem(int id, string content)
            {
                this.Id = id;
                this.Content = content;
                this.Status = "pending";
            }

            public bool Update()
            {
                bool status = false;
                if (this.Status == "pending")
                {
                    this.Status = "active";
                    status = true;
                }
                else if (this.Status == "active")
                {
                    this.Status = "done";
                    status = true;
                }

                return status;
            }

            public int GetItemId()
            {
                return this.Id;
            }

            public string GetItemContent()
            {
                return this.Content;
            }

            public string GetItemStatus()
            {
                return this.Status;
            }
        }
    }
}