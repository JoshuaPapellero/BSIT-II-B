using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<double> expenses = new List<double>();

        while (true)
        {
            Console.WriteLine("Welcome to the Accounting System!");
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1. Add an Expense");
            Console.WriteLine("2. View Expenses Summary");
            Console.WriteLine("3. Calculate Total Expenses");
            Console.WriteLine("4. Exit");

            int choice;
            while (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > 4)
            {
                Console.WriteLine("Invalid input. Please enter a number between 1 and 4.");
            }

            switch (choice)
            {
                case 1:
                    AddExpense(expenses);
                    break;
                case 2:
                    ViewExpensesSummary(expenses);
                    break;
                case 3:
                    CalculateTotalExpenses(expenses);
                    break;
                case 4:
                    Console.WriteLine("Exiting the Accounting System. Goodbye!");
                    return;
            }
        }
    }

    static void AddExpense(List<double> expenses)
    {
        Console.WriteLine("Enter the expense amount:");
        double expenseAmount;
        while (!double.TryParse(Console.ReadLine(), out expenseAmount) || expenseAmount < 0)
        {
            Console.WriteLine("Invalid input. Please enter a valid positive number for the expense.");
        }

        expenses.Add(expenseAmount);
        Console.WriteLine($"Expense of ${expenseAmount} added successfully!");
    }

    static void ViewExpensesSummary(List<double> expenses)
    {
        Console.WriteLine("Expenses Summary:");
        if (expenses.Count == 0)
        {
            Console.WriteLine("No expenses recorded yet.");
        }
        else
        {
            for (int i = 0; i < expenses.Count; i++)
            {
                Console.WriteLine($"Expense {i + 1}: ${expenses[i]}");
            }
        }
    }

    static void CalculateTotalExpenses(List<double> expenses)
    {
        double totalExpenses = 0;
        foreach (var expense in expenses)
        {
            totalExpenses += expense;
        }
        Console.WriteLine($"Total Expenses: ${totalExpenses}");
    }
}