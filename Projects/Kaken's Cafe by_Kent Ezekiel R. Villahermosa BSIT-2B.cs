using System;

class CafeShopProgram
{
    static void Main()
    {
        string cafeName = "Welcome to Kaken's Cafe";
        int numberOfTables = 150;
        double averageRating = 5;

        Console.WriteLine($"Welcome to {cafeName}!");
        Console.WriteLine($"Number of Tables: {numberOfTables}");
        Console.WriteLine($"Average Rating: {averageRating}");

        Console.Write("Enter the number of customers: ");
        int numberOfCustomers = Convert.ToInt32(Console.ReadLine());

        if (numberOfCustomers <= numberOfTables)
        {
            Console.WriteLine($"Table for {numberOfCustomers} customers is available.");
        }
        else if (numberOfCustomers <= 2 * numberOfTables)
        {
            Console.WriteLine($"A larger table for {numberOfCustomers} customers is available.");
        }
        else
        {
            Console.WriteLine("Sorry, we cannot accommodate that many customers at the moment.");
        }

        Console.Write("Enter the rating for the cafe (1-5): ");
        double userRating = Convert.ToDouble(Console.ReadLine());

        if (userRating > averageRating)
        {
            Console.WriteLine("Thank you for the positive feedback!");
        }
        else if (userRating < averageRating)
        {
            Console.WriteLine("We appreciate your feedback and will strive to improve.");
        }
        else
        {
            Console.WriteLine("Thanks for your feedback!");
        }

        Console.Write("Select a beverage (1: Coffee, 2: Tea, 3: Smoothie): ");
        int beverageChoice = Convert.ToInt32(Console.ReadLine());

        switch (beverageChoice)
        {
            case 1:
                Console.WriteLine("Enjoy your cup of coffee!");
                break;
            case 2:
                Console.WriteLine("Sip on a soothing cup of tea!");
                break;
            case 3:
                Console.WriteLine("Indulge in a refreshing smoothie!");
                break;
            default:
                Console.WriteLine("Invalid beverage choice.");
                break;
        }

        Console.WriteLine("Menu Items:");
        for (int i = 1; i <= 5; i++)
        {
            Console.WriteLine($"Item {i}: {GetMenuItem(i)}");
        }
        for (int i = 1; i <= 10; i++)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine("Skipping even-numbered items.");
                continue; 
            }

            Console.WriteLine($"Processing Order for Item {i}");
        }
    }

    static string GetMenuItem(int itemNumber)
    {
        switch (itemNumber)
        {
            case 1:
                return "Espresso";
            case 2:
                return "Cappuccino";
            case 3:
                return "Chai Latte";
            case 4:
                return "Fruit Smoothie";
            case 5:
                return "Iced Coffee";
            default:
                return "Unknown Item";
        }
    }
}