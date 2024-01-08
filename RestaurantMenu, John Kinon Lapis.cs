using System;
using System.Collections.Generic;

// MenuItem class to represent items on the restaurant menu
class MenuItem
{
    public string Name { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }

    public MenuItem(string name, string description, decimal price)
    {
        Name = name;
        Description = description;
        Price = price;
    }
}

// RestaurantMenu class to manage the restaurant menu
class RestaurantMenu
{
    public List<MenuItem> Items { get; } = new List<MenuItem>();

    public void AddMenuItem(string name, string description, decimal price)
    {
        Items.Add(new MenuItem(name, description, price));
    }

    public void DisplayMenu()
    {
        Console.WriteLine("Restaurant Menu:");
        foreach (var item in Items)
        {
            Console.WriteLine($"{item.Name} - {item.Description} - ${item.Price}");
        }
    }
}

// Order class to represent customer orders
class Order
{
    public List<MenuItem> Items { get; } = new List<MenuItem>();

    public void AddToOrder(MenuItem item)
    {
        Items.Add(item);
        Console.WriteLine($"Added {item.Name} to the order.");
    }

    public void DisplayOrder()
    {
        Console.WriteLine("Order:");
        foreach (var item in Items)
        {
            Console.WriteLine($"{item.Name} - {item.Description} - ${item.Price}");
        }
    }
}

// Restaurant class to coordinate the restaurant operations
class Restaurant
{
    static void Main()
    {
        // Create a restaurant menu
        RestaurantMenu restaurantMenu = new RestaurantMenu();
        restaurantMenu.AddMenuItem("Spaghetti Bolognese", "Pasta with meat sauce", 12.99m);
        restaurantMenu.AddMenuItem("Chicken Caesar Salad", "Grilled chicken with Caesar dressing", 9.99m);
        restaurantMenu.AddMenuItem("Cheesecake", "New York style cheesecake", 5.99m);

        // Display the menu
        restaurantMenu.DisplayMenu();

        // Create a customer order
        Order customerOrder = new Order();

        // Customer adds items to the order
        MenuItem selectedMenuItem = restaurantMenu.Items[0]; // Assuming the first item is selected
        customerOrder.AddToOrder(selectedMenuItem);

        // Display the customer's order
        customerOrder.DisplayOrder();
    }
}