using System;
using System.Collections.Generic;

class RestaurantMenu
{
    private Dictionary<string, double> menuItems;

    public RestaurantMenu()
    {
        // Initializing menu items and their prices
        menuItems = new Dictionary<string, double>
        {
            { "Burger", 5.99 },
            { "Pizza", 8.99 },
            { "Salad", 6.49 },
            { "Pasta", 9.99 },
            { "Drink", 1.99 }
        };
    }

    public void DisplayMenu()
    {
        Console.WriteLine("Welcome to Our Restaurant!");
        Console.WriteLine("MENU:");
        foreach (var item in menuItems)
        {
            Console.WriteLine($"{item.Key}: ${item.Value}");
        }
    }

    public Tuple<List<string>, double> TakeOrder()
    {
        double totalBill = 0;
        var order = new List<string>();

        while (true)
        {
            DisplayMenu();
            Console.Write("Enter the item you want to order (or 'done' to finish): ");
            string userChoice = Console.ReadLine().Trim();

            if (userChoice.ToLower() == "done")
            {
                break;
            }

            if (menuItems.ContainsKey(userChoice))
            {
                order.Add(userChoice);
                totalBill += menuItems[userChoice];
                Console.WriteLine($"{userChoice} added to your order.");
            }
            else
            {
                Console.WriteLine("Sorry, that item is not on the menu. Please select from the menu.");
            }
        }

        return Tuple.Create(order, totalBill);
    }

    public void ServeCustomer()
    {
        Console.WriteLine("Welcome to our restaurant! Let's take your order.");
        var orderInfo = TakeOrder();
        var order = orderInfo.Item1;
        var bill = orderInfo.Item2;

        Console.WriteLine("\nYour Order:");
        foreach (var item in order)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine($"\nTotal Bill: ${bill:f2}");
        Console.WriteLine("Thank you for dining with us!");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Using the RestaurantMenu class to simulate the restaurant operations
        RestaurantMenu restaurant = new RestaurantMenu();
        restaurant.ServeCustomer();
    }
}