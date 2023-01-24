﻿using Exercise2.Models;

namespace Exercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<TodoList> myLists = new List<TodoList>();
            bool isMainMenu = true;
            int listId = 1;

            do
            {
                bool isSelection = true;
                Console.WriteLine("Welcome to the Main Menu");
                Console.WriteLine("=======================");
                Console.WriteLine("1 - Display All Lists");
                Console.WriteLine("2 - Show Items");
                Console.WriteLine("3 - Create New List");
                Console.WriteLine("4 - Select List");
                Console.WriteLine("5 - Quit");
                Console.WriteLine("=======================");

                Console.Write("Enter choice: ");
                int choice = int.Parse(Console.ReadLine());

                do
                {
                    // Displays all the list inside myLists
                    if (choice == 1)
                    {
                        Console.WriteLine("=======================");
                        Console.WriteLine("Selected option: Display All Lists");

                        if (myLists.Count > 0)
                        {
                            Console.WriteLine("=======================");
                            Console.WriteLine("All Lists");

                            foreach (TodoList list in myLists)
                            {
                                Console.WriteLine("Id: " + list.GetTodoListId());
                                Console.WriteLine("Name: " + list.GetTodoListName());
                                Console.WriteLine("=======================");
                            }
                        }
                        else
                        {
                            Console.WriteLine("You have an empty list. Please select 3 on the Main Menu to create a new list. Redirecting back to Main Menu...");
                        }

                        isSelection = false;
                    }
                    else if (choice == 2)
                    {
                        Console.WriteLine("=======================");
                        Console.WriteLine("Selected option: Show Items");

                        Console.Write("Enter an id of a list: ");
                        int id = int.Parse(Console.ReadLine());

                        Console.WriteLine("=======================");

                        var list = myLists.FirstOrDefault(list => list.GetTodoListId() == id);

                        if (list != null)
                        {
                            if (list.GetTodoItemCount() > 0)
                            {
                                list.GetToDoItems();
                            }
                            else
                            {
                                Console.WriteLine("No items found for list " + list.GetTodoListName());
                            }
                        }
                        else
                        {
                            Console.WriteLine("List not found!");
                        }

                        isSelection = false;
                    }
                    else if (choice == 3)
                    {
                        Console.WriteLine("=======================");
                        Console.WriteLine("Selected option: Create New List");

                        Console.Write("Enter name of the list: ");
                        string name = Console.ReadLine();
                        myLists.Add(new TodoList(listId, name));
                        listId++;
                        isSelection = false;
                    }
                    else if (choice == 4)
                    {
                        Console.WriteLine("=======================");
                        Console.WriteLine("Selected option: Select List");

                        Console.Write("Enter the id of the list: ");
                        int id = int.Parse(Console.ReadLine());

                        var selectedList = myLists.FirstOrDefault(list => list.GetTodoListId() == id);
                        int itemId = 1;
                        if (selectedList != null)
                        {
                            bool isItemMenu = true;
                            do
                            {
                                bool isItemMenuSelection = true;

                                Console.WriteLine("Welcome to the Item Menu");
                                Console.WriteLine("=======================");
                                Console.WriteLine("1 - Display all Items");
                                Console.WriteLine("2 - Create New Item");
                                Console.WriteLine("3 - Delete Item");
                                Console.WriteLine("4 - Update Item");
                                Console.WriteLine("5 - Go back");
                                Console.WriteLine("=======================");

                                Console.Write("Enter choice: ");
                                int itemMenuChoice = int.Parse(Console.ReadLine());

                                do
                                {
                                    if (itemMenuChoice == 1)
                                    {
                                        if (selectedList.GetTodoItemCount() > 0)
                                        {
                                            Console.WriteLine(selectedList.GetTodoListName() + " all items: ");
                                            selectedList.GetToDoItems();
                                        }
                                        else
                                        {
                                            Console.WriteLine(selectedList.GetTodoListName() + " is empty.");
                                        }

                                        isItemMenuSelection = false;
                                    }
                                    else if (itemMenuChoice == 2)
                                    {
                                        Console.Write("Enter content of the item: ");
                                        string content = Console.ReadLine();
                                        selectedList.AddTodoItem(new TodoItem(itemId, content));
                                        itemId++;
                                        isItemMenuSelection = false;
                                    }
                                    else if (itemMenuChoice == 3)
                                    {
                                        Console.Write("Enter the id of the item to be removed: ");
                                        int selectedItemId = int.Parse(Console.ReadLine());

                                        if (selectedList.CheckIfTodoListItemExistById(selectedItemId))
                                        {
                                            selectedList.RemoveTodoItem(selectedItemId);
                                            Console.WriteLine("Item successfully removed. Redirecting to Item Menu...");
                                        }
                                        else
                                        {
                                            Console.WriteLine("Invalid item Id. Redirecting to Item Menu...");
                                        }

                                        isItemMenuSelection = false;
                                    }
                                    else if (itemMenuChoice == 4)
                                    {
                                        Console.Write("Enter the id of the item to be updated: ");
                                        int selectedItemId = int.Parse(Console.ReadLine());

                                        if (selectedList.CheckIfTodoListItemExistById(selectedItemId))
                                        {
                                            var item = selectedList.GetTodoListItemById(selectedItemId);
                                            item.Update();
                                            Console.WriteLine("Item successfully updated. Redirecting to Item Menu...");
                                        }
                                        else
                                        {
                                            Console.WriteLine("Invalid item Id. Redirecting to Item Menu...");
                                        }

                                        isItemMenuSelection = false;
                                    }
                                    else if (itemMenuChoice == 5)
                                    {
                                        Console.WriteLine("Redirecting to Main Menu...");
                                        isItemMenuSelection = false;
                                        isItemMenu = false;
                                        isSelection = false;
                                    }
                                } while (isItemMenuSelection);

                            } while (isItemMenu);
                        }
                        else
                        {
                            Console.WriteLine("Selected list is not found! Redirecting to main menu...");
                            isSelection = false;
                        }
                    }
                    else if (choice == 5)
                    {
                        Console.WriteLine("=======================");
                        Console.WriteLine("Selected option: Quit");
                        Console.WriteLine("Program is shutting down...");
                        Console.WriteLine("Goodbye!");
                        isSelection = false;
                        isMainMenu = false;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input!");
                        isSelection = false;
                    }
                } while (isSelection);

            } while (isMainMenu);
        }
    }
}