using System;

class RestaurantProgram
{
    static void Main()
    {
        
        string restaurantName = "Van Delights";
        int numberOfTables = 150;
        double averageRating = 5;

        
        Console.WriteLine($"Welcome to {restaurantName}!");
        Console.WriteLine($"Number of Tables: {numberOfTables}");
        Console.WriteLine($"Average Rating: {averageRating}");

        
        Console.Write("Enter the number of guests: ");
        int numberOfGuests = Convert.ToInt32(Console.ReadLine());

        
        if (numberOfGuests <= numberOfTables)
        {
            Console.WriteLine($"Table for {numberOfGuests} guests is available.");
        }
        
        else if (numberOfGuests <= 2 * numberOfTables)
        {
            Console.WriteLine($"A larger table for {numberOfGuests} guests is available.");
        }
        
        else
        {
            Console.WriteLine("Sorry, we cannot accommodate that many guests at the moment.");
        }

        
        Console.Write("Enter the rating for the restaurant (1-5): ");
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

        
        Console.Write("Select a cuisine (1: Italian, 2: Mexican, 3: Asian): ");
        int cuisineChoice = Convert.ToInt32(Console.ReadLine());

        switch (cuisineChoice)
        {
            case 1:
                Console.WriteLine("Enjoy your Italian cuisine!");
                break;
            case 2:
                Console.WriteLine("Savor the flavors of Mexican cuisine!");
                break;
            case 3:
                Console.WriteLine("Experience the richness of Asian cuisine!");
                break;
            default:
                Console.WriteLine("Invalid cuisine choice.");
                break;
        }

        
        Console.WriteLine("Menu Items:");
        for (int i = 1; i <= 5; i++)
        {
            Console.WriteLine($"Item {i}: Dish {i}");
        }

        
        for (int i = 1; i <= 10; i++)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine("Skipping even-numbered items.");
                continue; // Skip even-numbered items
            }

            Console.WriteLine($"Processing Order for Item {i}");
        }
    }
}
