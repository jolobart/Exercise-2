using Exercise2.Models;
using Exercise2.Interfaces;
using Exercise2.Services;
using Exercise2.Conf;
using System;
using System.Collections.Generic;

namespace Exercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            // ITodoListService todoListService = new TodoListServiceContext();
            // ITodoItemService todoItemService = new TodoItemServiceContext();

            // var myLists = todoListService.GetAll();
            // // List<TodoList> myLists = new List<TodoList>();
            // bool isMainMenu = true;

            // do
            // {
            //     bool isSelection = true;
            //     Console.WriteLine("Welcome to the Main Menu");
            //     Console.WriteLine("=======================");
            //     Console.WriteLine("1 - Display All Lists");
            //     Console.WriteLine("2 - Show Items");
            //     Console.WriteLine("3 - Create New List");
            //     Console.WriteLine("4 - Select List");
            //     Console.WriteLine("5 - Quit");
            //     Console.WriteLine("=======================");

            //     Console.Write("Enter choice: ");
            //     int choice = int.Parse(Console.ReadLine());

            //     do
            //     {
            //         // Displays all the list inside myLists
            //         if (choice == 1)
            //         {
            //             Console.WriteLine("=======================");
            //             Console.WriteLine("Selected option: Display All Lists");

            //             if (myLists.Count > 0)
            //             {
            //                 Console.WriteLine("=======================");
            //                 Console.WriteLine("All Lists");

            //                 foreach (TodoList list in myLists)
            //                 {
            //                     Console.WriteLine("Id: " + list.GetTodoListId());
            //                     Console.WriteLine("Name: " + list.GetTodoListName());
            //                     Console.WriteLine("=======================");
            //                 }
            //             }
            //             else
            //             {
            //                 Console.WriteLine("You have an empty list. Please select 3 on the Main Menu to create a new list. Redirecting back to Main Menu...");
            //             }

            //             isSelection = false;
            //         }
            //         else if (choice == 2)
            //         {
            //             Console.WriteLine("=======================");
            //             Console.WriteLine("Selected option: Show Items");

            //             Console.Write("Enter the id of the list: ");
            //             int id = int.Parse(Console.ReadLine());

            //             Console.WriteLine("=======================");

            //             // var list = myLists.FirstOrDefault(list => list.GetTodoListId() == id);
            //             var list = todoListService.FindById(id);

            //             if (list != null)
            //             {
            //                 if (list.GetTodoItemCount() > 0)
            //                 {
            //                     list.GetToDoItems();
            //                 }
            //                 else
            //                 {
            //                     Console.WriteLine("No items found for list " + list.GetTodoListName());
            //                 }
            //             }
            //             else
            //             {
            //                 Console.WriteLine("List not found!");
            //             }

            //             isSelection = false;
            //         }
            //         else if (choice == 3)
            //         {
            //             Console.WriteLine("Selected option: Create New List");
            //             Console.Write("Enter name of the list: ");
            //             string name = Console.ReadLine();
            //             var createdList = todoListService.Save(new TodoList(myLists.Count + 1, name));
            //             Console.WriteLine("List Added: ");
            //             Console.WriteLine("Id: " + createdList.GetTodoListId());
            //             Console.WriteLine("Name: " + createdList.GetTodoListName());
            //             Console.WriteLine("=======================");
            //             isSelection = false;
            //         }
            //         else if (choice == 4)
            //         {
            //             Console.WriteLine("=======================");
            //             Console.WriteLine("Selected option: Select List");
            //             Console.Write("Enter the id of the list: ");
            //             int id = int.Parse(Console.ReadLine());
            //             var selectedList = todoListService.FindById(id);

            //             if (selectedList != null)
            //             {
            //                 bool isItemMenu = true;
            //                 do
            //                 {
            //                     bool isItemMenuSelection = true;

            //                     Console.WriteLine("Welcome to the Item Menu");
            //                     Console.WriteLine("=======================");
            //                     Console.WriteLine("1 - Display all Items");
            //                     Console.WriteLine("2 - Create New Item");
            //                     Console.WriteLine("3 - Delete Item");
            //                     Console.WriteLine("4 - Update Item");
            //                     Console.WriteLine("5 - Go back");
            //                     Console.WriteLine("=======================");

            //                     Console.Write("Enter choice: ");
            //                     int itemMenuChoice = int.Parse(Console.ReadLine());

            //                     do
            //                     {
            //                         if (itemMenuChoice == 1)
            //                         {
            //                             if (selectedList.GetTodoItemCount() > 0)
            //                             {
            //                                 Console.WriteLine(selectedList.GetTodoListName() + " all items: ");
            //                                 var items = selectedList.GetToDoItems();

            //                                 foreach (TodoItem item in items)
            //                                 {
            //                                     Console.WriteLine("Item id: " + item.GetItemId());
            //                                     Console.WriteLine("Item content: " + item.GetItemContent());
            //                                 }
            //                             }
            //                             else
            //                             {
            //                                 Console.WriteLine(selectedList.GetTodoListName() + " is empty.");
            //                             }

            //                             isItemMenuSelection = false;
            //                         }
            //                         else if (itemMenuChoice == 2)
            //                         {
            //                             Console.Write("Enter content of the item: ");
            //                             string content = Console.ReadLine();
            //                             var newItem = todoItemService.Save(selectedList.GetTodoListId(), new TodoItem(selectedList.GetTodoItemCount() + 1, content));
            //                             Console.WriteLine("Item added for: " + selectedList.GetTodoListName());
            //                             Console.WriteLine("Item id: " + newItem.GetItemId());
            //                             Console.WriteLine("Item content: " + newItem.GetItemContent());
            //                             isItemMenuSelection = false;
            //                         }
            //                         else if (itemMenuChoice == 3)
            //                         {
            //                             Console.Write("Enter the id of the item to be removed: ");
            //                             int selectedItemId = int.Parse(Console.ReadLine());

            //                             // var item = selectedList.GetTodoListItemById(selectedItemId);
            //                             var item = todoItemService.FindById(selectedItemId, selectedItemId);
            //                             if (item != null)
            //                             {
            //                                 todoItemService.Delete(selectedList.GetTodoListId(), item);
            //                                 Console.WriteLine("Item successfully removed. Redirecting to Item Menu...");
            //                             }
            //                             else
            //                             {
            //                                 Console.WriteLine("Invalid item Id. Redirecting to Item Menu...");
            //                             }

            //                             isItemMenuSelection = false;
            //                         }
            //                         else if (itemMenuChoice == 4)
            //                         {
            //                             Console.Write("Enter the id of the item to be updated: ");
            //                             int selectedItemId = int.Parse(Console.ReadLine());

            //                             var item = todoItemService.FindById(selectedItemId, selectedItemId);

            //                             if (item != null)
            //                             {
            //                                 item.Update();
            //                                 Console.WriteLine("Item successfully updated. Redirecting to Item Menu...");
            //                             }
            //                             else
            //                             {
            //                                 Console.WriteLine("Invalid item Id. Redirecting to Item Menu...");
            //                             }

            //                             isItemMenuSelection = false;
            //                         }
            //                         else if (itemMenuChoice == 5)
            //                         {
            //                             Console.WriteLine("Redirecting to Main Menu...");
            //                             isItemMenuSelection = false;
            //                             isItemMenu = false;
            //                             isSelection = false;
            //                         }
            //                     } while (isItemMenuSelection);

            //                 } while (isItemMenu);
            //             }
            //             else
            //             {
            //                 Console.WriteLine("Selected list is not found! Redirecting to main menu...");
            //                 isSelection = false;
            //             }
            //         }
            //         else if (choice == 5)
            //         {
            //             Console.WriteLine("=======================");
            //             Console.WriteLine("Selected option: Quit");
            //             Console.WriteLine("Program is shutting down...");
            //             Console.WriteLine("Goodbye!");
            //             isSelection = false;
            //             isMainMenu = false;
            //         }
            //         else
            //         {
            //             Console.WriteLine("Invalid input!");
            //             isSelection = false;
            //         }
            //     } while (isSelection);

            // } while (isMainMenu);


            // {
            // 	“stations”: [
            // 		{
            // 			“name”: “Buendia”,
            // 			“type”: “LRT”
            // 		},
            // 		{
            // 			“name”: “Trinoma”,
            // 			“type”: “MRT”
            // 		},
            // 		{
            // 			“name”: “Katipunan”,
            // 			“type”: “LRT”
            // 		}
            // 	]
            // }


            // Convert JSON to dictionary object
            // Dictionary<string, List<Dictionary<string, string>>> stations = new Dictionary<string, List<Dictionary<string, string>>>();
            // List<Dictionary<string, string>> stationList = new List<Dictionary<string, string>>();
            // Dictionary<string, string> station1 = new Dictionary<string, string>();
            // station1.Add("name", "Buendia");
            // station1.Add("type", "LRT");
            // stationList.Add(station1);

            // Dictionary<string, string> station2 = new Dictionary<string, string>();
            // station2.Add("name", "Trinoma");
            // station2.Add("type", "MRT");
            // stationList.Add(station2);

            // Dictionary<string, string> station3 = new Dictionary<string, string>();
            // station3.Add("name", "Katipunan");
            // station3.Add("type", "LRT");
            // stationList.Add(station3);

            // // Add the stationList to stations
            // stations.Add("stations", stationList);

            // // Output value "Trinoma"
            // Console.WriteLine(stations["stations"][1]["name"]);

            // // Display all stations whose type is LRT
            // foreach (Dictionary<string, string> station in stations["stations"])
            // {
            //     if (station["type"] == "LRT")
            //     {
            //         Console.WriteLine(station["name"]);
            //     }
            // }


            // {
            // 	“groceryList”: [
            // 		{
            // 			“name”: “Milk”,
            // 			“price”: “100.00”
            // 		},
            // 		{
            // 			“name”: “Chips”,
            // 			“price”: “200.00”
            // 		}
            // 	]
            // }

            // Dictionary<string, List<Dictionary<string, string>>> groceryLists = new Dictionary<string, List<Dictionary<string, string>>>();
            // List<Dictionary<string, string>> list = new List<Dictionary<string, string>>();
            // Dictionary<string, string> list1 = new Dictionary<string, string>();
            // list1.Add("name", "Milk");
            // list1.Add("price", "100.00");
            // list.Add(list1);
            // Dictionary<string, string> list2 = new Dictionary<string, string>();
            // list2.Add("name", "Chips");
            // list2.Add("price", "200.00");
            // list.Add(list2);

            // groceryLists.Add("groceryList", list);
            // float sum = 0;

            // foreach (Dictionary<string, string> groceryList in groceryLists["groceryList"])
            // {
            //     sum += float.Parse(groceryList["price"]);
            // }

            // Console.WriteLine("Total price of groceries: " + sum);

            // Dictionary<string, object> pObj = new Dictionary<string, object>();

            // List<object> pObjItems = new List<object>();

            // Dictionary<string, object> pObjItem1 = new Dictionary<string, object>();

            // pObjItem1.Add("name", "Hello");

            Dictionary<string, object> pokemonDictionary = new Dictionary<string, object>();
            List<object> pokemonList = new List<object>();

            Dictionary<string, object> pikachu = new Dictionary<string, object>();
            List<object> moveListPikachu = new List<object>();
            Dictionary<string, object> move1 = new Dictionary<string, object>();
            Dictionary<string, object> move2 = new Dictionary<string, object>();

            Dictionary<string, object> charmander = new Dictionary<string, object>();
            List<object> moveListCharmander = new List<object>();
            Dictionary<string, object> move3 = new Dictionary<string, object>();
            Dictionary<string, object> move4 = new Dictionary<string, object>();

            // Pikachu move list
            move1.Add("name", "Quick Attack");
            move1.Add("power", 20);
            move2.Add("name", "Thundershock");
            move2.Add("power", 40);

            // Charmander move list
            move3.Add("name", "Fly");
            move3.Add("power", 10);
            move4.Add("name", "Fireball");
            move4.Add("power", 50);

            // Add the moves in pokemon's move list
            moveListPikachu.Add(move1);
            moveListPikachu.Add(move2);
            moveListCharmander.Add(move3);
            moveListCharmander.Add(move4);

            // Pikachu dictionary
            pikachu.Add("name", "Pikachu");
            pikachu.Add("type", "Lightning");
            pikachu.Add("moves", moveListPikachu);

            // Charmander dictionary
            charmander.Add("name", "Charmander");
            charmander.Add("type", "Fire");
            charmander.Add("moves", moveListCharmander);

            // Add the pokemon to the list
            pokemonList.Add(pikachu);
            pokemonList.Add(charmander);
            pokemonDictionary.Add("pokemon", pokemonList);

            List<object> pokemon = (List<object>)pokemonDictionary["pokemon"];
            foreach (Dictionary<string, object> p in pokemon)
            {
                Console.WriteLine("Name: " + p["name"]);
                Console.WriteLine("Type: " + p["type"]);
                Console.WriteLine("Moves:");
                List<object> moves = (List<object>)p["moves"];
                foreach (Dictionary<string, object> m in moves)
                {
                    Console.WriteLine(" Name: " + m["name"]);
                    Console.WriteLine(" Power: " + m["power"]);
                }
            }

            Dictionary<string, object> projectDictionary = new Dictionary<string, object>();
            List<object> dependencyList = new List<object>();

            Dictionary<string, object> esbuild = new Dictionary<string, object>();
            List<object> esbuildVersionList = new List<object>();
            Dictionary<string, string> esbuildVersion = new Dictionary<string, string>();

            Dictionary<string, object> react = new Dictionary<string, object>();
            List<object> reactVersionList = new List<object>();
            Dictionary<string, string> reactVersion = new Dictionary<string, string>();


            esbuildVersion.Add("version", "beta");
            esbuildVersionList.Add("1a");
            esbuildVersionList.Add("1b");
            esbuildVersionList.Add("1c");
            esbuildVersionList.Add(esbuildVersion);

            esbuild.Add("name", "esbuild");
            esbuild.Add("versions", esbuildVersionList);

            reactVersionList.Add("2a");
            reactVersionList.Add("2b");
            reactVersionList.Add("2c");
            reactVersion.Add("version", "aplha");
            reactVersionList.Add(reactVersion);
            reactVersionList.Add("2d");

            react.Add("name", "react");
            react.Add("versions", reactVersionList);

            dependencyList.Add(esbuild);
            dependencyList.Add(react);

            projectDictionary.Add("name", "Project X");
            projectDictionary.Add("dependencies", dependencyList);

            Console.WriteLine("Project name: " + projectDictionary["name"]);
            Console.WriteLine("Dependencies:");

            List<object> dependencies = (List<object>)projectDictionary["dependencies"];
            foreach (Dictionary<string, object> d in dependencies)
            {
                Console.WriteLine("Name: " + d["name"]);
                Console.WriteLine("Versions:");
                List<object> versions = (List<object>)d["versions"];
                foreach (object v in versions)
                {
                    if (v is Dictionary<string, string>)
                    {
                        var versionDictionary = (Dictionary<string, string>)v;
                        foreach (var key in versionDictionary.Keys)
                        {
                            Console.WriteLine("Version: " + versionDictionary[key]);
                        }
                    }
                    else if (v is string)
                    {
                        Console.WriteLine(v);
                    }
                }
            }
        }
    }
}