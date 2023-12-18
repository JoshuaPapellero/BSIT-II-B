using System;

class RestaurantMenu
{
    // Variable to store the total bill
    static double totalBill = 0;

    static void Main()
    {
        // Display the menu
        DisplayMenu();

        // Get user input for menu selection
        int userChoice = GetUserChoice();

        // Process user choice
        ProcessUserChoice(userChoice);

        Console.ReadLine(); // Keep console window open
    }

    // Display the restaurant menu
    static void DisplayMenu()
    {
        Console.WriteLine("Welcome to Johnray_raf Restaurant!");
        Console.WriteLine("1. Burger - $5.99");
        Console.WriteLine("2. Pizza - $8.99");
        Console.WriteLine("3. Salad - $4.99");
        Console.WriteLine("4. Exit");
    }

    // Get user's menu choice
    static int GetUserChoice()
    {
        Console.Write("Enter your choice (1-4): ");
        int choice;
        while (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > 4)
        {
            Console.WriteLine("Invalid input. Please enter a number between 1 and 4.");
            Console.Write("Enter your choice (1-4): ");
        }
        return choice;
    }

    // Process user's menu choice
    static void ProcessUserChoice(int choice)
    {
        switch (choice)
        {
            case 1:
                OrderItem("Burger", 5.99);
                break;
            case 2:
                OrderItem("Pizza", 8.99);
                break;
            case 3:
                OrderItem("Salad", 4.99);
                break;
            case 4:
                // Display the total bill before exiting
                Console.WriteLine($"Your total bill is: ${totalBill:C}");
                Console.WriteLine("Thank you for visiting!");
                break;
        }
    }

    // Place an order for a menu item
    static void OrderItem(string itemName, double price)
    {
        Console.WriteLine($"You ordered {itemName} for ${price}.");

        // Get quantity from the user with error handling
        int quantity;
        while (true)
        {
            Console.Write("Enter quantity: ");
            if (int.TryParse(Console.ReadLine(), out quantity) && quantity > 0)
                break;
            else
                Console.WriteLine("Invalid input. Please enter a positive integer.");
        }

        // Calculate total cost
        double totalCost = quantity * price;

        // Update the total bill
        totalBill += totalCost;

        Console.WriteLine($"Total cost: ${totalCost:C}");
        Console.WriteLine($"Your current total bill is: ${totalBill:C}");

        // Check if the user wants to add more items
        Console.Write("Do you want to order more items? (yes/no): ");
        string answer = Console.ReadLine().ToLower();

        if (answer == "yes")
        {
            // Display the menu again for additional orders
            DisplayMenu();
            // Get user input for additional orders
            int additionalChoice = GetUserChoice();
            // Process additional orders
            ProcessUserChoice(additionalChoice);
        }
        else
        {
            // Display the final total bill
            Console.WriteLine($"Your final total bill is: ${totalBill:C}");
            Console.WriteLine("Thank you for your order!");
        }
    }
}
