using System;
using System.Collections.Generic;

class ToDoList
{
    static List<string> tasks = new List<string>();

    static void Main(String[] args)
    {

        Console.WriteLine("To-Do List App\n");
        Console.WriteLine("Welcome to To-Do List \n");
        while (true)
        {

            DisplayTasks();
            Console.WriteLine("\nPlease Select an option:");
            Console.WriteLine("1. Add Task");
            Console.WriteLine("2. Remove Task");
            Console.WriteLine("3. Exit");
            Console.Write("Enter your choice: ");

            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write("Enter task description: ");
                    string taskDescription = Console.ReadLine();

                    AddTask(taskDescription);
                    break;
                case 2:

                    Console.Write("Enter task number to remove: ");
                    int taskNumber = Convert.ToInt32(Console.ReadLine());

                    RemoveTask(taskNumber);
                    break;
                case 3:

                    Console.WriteLine("\nThank you for using To-Do List App!");
                    return;
                default:

                    Console.WriteLine("\nInvalid choice. Please try again.");
                    break;
            }
        }
    }
    static void AddTask(string taskDescription)
    {
        tasks.Add(taskDescription);
        Console.WriteLine("Task added successfully!");
    }
    static void RemoveTask(int taskNumber)
    {
        if (taskNumber >= 1 && taskNumber <= tasks.Count)
        {
            tasks.RemoveAt(taskNumber - 1);
            Console.WriteLine("Task removed successfully!");
        }
        else
        {
            Console.WriteLine("Invalid task number.Please try again.");
        }
    }
    static void DisplayTasks()
    {
        Console.WriteLine("\nMy Tasks:");


        for (int i = 0; i < tasks.Count; i++)
        {

            Console.WriteLine($"{i + 1}. {tasks[i]}");
        }
        Console.WriteLine("\n-------------------------");


        int totalTasks = tasks.Count;
        Console.WriteLine($"Total tasks: {totalTasks}");

        int index = 0;
        while (index < tasks.Count)
        {
            Console.WriteLine($"Task {index + 1}: {tasks[index]}");
            index++;
        }

        string taskSummary = string.Join(", ", tasks);
        Console.WriteLine($"Task Summary: {taskSummary}");
    }
}

