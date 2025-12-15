using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
List<string> tasks = new List<string>();
List<bool> done = new List<bool>();
while (true)
{
    Console.WriteLine("\n1-Add Task");
    Console.WriteLine("2- Show tasks ");
    Console.Write("Choose:");
    string choice = Console.ReadLine();
    if (choice == "1")
    { Console.Write("Enter task:");
        string task = Console.ReadLine();
        tasks.Add(task);
        done.Add(false);
        Console.WriteLine("Task Added "); }
    else if (choice == "2")
    {
        for (int i = 0; i < tasks.Count; i++)
        {
            string status = done[i] ? "Done" : "Not Done";
            Console.WriteLine($"{i + 1}-{tasks[i]} [{status}]");
        }
    }
    else if (choice == "3")
    {
        break;
    }
    else { Console.WriteLine("Invalid Choice"); } }
