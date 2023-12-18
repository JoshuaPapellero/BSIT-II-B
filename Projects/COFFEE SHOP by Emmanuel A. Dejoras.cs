using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        CoffeeShop coffeeShop = new CoffeeShop();

        while (true)
        {
            Console.WriteLine("Welcome to Emman's Coffee Shop!");
            Console.WriteLine("1. View Menu");
            Console.WriteLine("2. Place Order");
            Console.WriteLine("3. Exit");
            Console.Write("Enter your choice: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    coffeeShop.DisplayMenu();
                    break;
                case "2":
                    coffeeShop.PlaceOrder();
                    break;
                case "3":
                    Console.WriteLine("Thank you for visiting. Goodbye!");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }
}

class CoffeeShop
{
    private Dictionary<string, double> menu;

    public CoffeeShop()
    {
        menu = new Dictionary<string, double>
        {
            {"Espresso", 2.5},
            {"Latte", 3.0},
            {"Cappuccino", 3.5},
            {"Americano", 2.0},
            {"Mocha", 4.0}
        };
    }

    public void DisplayMenu()
    {
        Console.WriteLine("Menu:");
        foreach (var item in menu)
        {
            Console.WriteLine($"{item.Key}: ${item.Value}");
        }
        Console.WriteLine();
    }

    public void PlaceOrder()
    {
        Console.WriteLine("Enter the name of the coffee you want to order:");
        string coffeeName = Console.ReadLine();

        if (menu.ContainsKey(coffeeName))
        {
            double price = menu[coffeeName];
            Console.WriteLine($"You ordered a {coffeeName}. That will be ${price}.");
        }
        else
        {
            Console.WriteLine("Sorry, we don't have that item on the menu.");
        }

        Console.WriteLine();
    }
}
