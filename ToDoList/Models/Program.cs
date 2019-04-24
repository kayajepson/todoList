using System;
using System.Collections.Generic;

namespace ToDoList.Models
{
  public class UserInterface
  {
    static void Main()
    {
      int x = 0;
      for (int i = 0; x == 0; i++)
      {
        Console.WriteLine("Would you like to add an item or view an item? (a/v/q)");
        string startProgram = Console.ReadLine();
        bool add = startProgram == "a";
        bool view = startProgram == "v";
        bool quit = startProgram == "q";
        if (add)
        {
          Console.WriteLine("Please enter a todo item: ");
          string userInput = Console.ReadLine();
          Item newItem = new Item(userInput);
          string printOutDescription = newItem.GetDescription();
          List<string> todoList = new List<string>();
          todoList.Add(printOutDescription);
        }
        else if (view)
        {
          foreach (Item task in Item.GetAll())
          Console.WriteLine(task.GetDescription());
        }
        else if (quit)
        {
          x = 1;
          break;
        }
      };

    }



  }
}
