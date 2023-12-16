using System;

class Program
{
    static void Main()
    {
        // Program Structure
        Console.WriteLine("Welcome to Jken's Coffee CornerShop!");

        // Variables and Data Types
        int CoffeeSold = 15;
        double pricePercoffee = 79.99;
        string Type_of_coffee = "Camericano";

        // Doing Math
        double totalRevenue = CoffeeSold * pricePercoffee;

        // More on Strings
        Console.WriteLine($"Type_of_coffee: {Type_of_coffee}\nCoffee Sold: {CoffeeSold}\nPrice per Coffee: ${pricePercoffee}");

        // Concatenation and Interpolation
        string greeting = "Thank you for choosing Jken's CornerShop!";
        Console.WriteLine(greeting);

        // Comparison Operators
        if (CoffeeSold > 0)
        {
            Console.WriteLine("Coffee's are available.");
        }
        else if (CoffeeSold == 0)
        {
            Console.WriteLine("Out of stock.");
        }
        else
        {
            Console.WriteLine("Invalid coffee quantity.");
        }

        // Logical Operators
        bool isDiscountAvailable = true;
        if (CoffeeSold > 10 && isDiscountAvailable)
        {
            Console.WriteLine("You qualify for a discount!");
        }

        // switch Statement
        string customerRating = "Excellent";
        switch (customerRating)
        {
            case "Excellent":
                Console.WriteLine("Thank you for your excellent rating!");
                break;
            case "Good":
                Console.WriteLine("We appreciate your positive feedback!");
                break;
            default:
                Console.WriteLine("We value your feedback!");
                break;
        }

        // Ternary Operator
        string status = (CoffeeSold > 0) ? "Available" : "Out of stock";
        Console.WriteLine($"Status: {status}");

        // for Loop
        for (int i = 1; i <= 6; i++)
        {
            Console.WriteLine($"Assisting customer {i}");
        }

        // while Loop
        int restockCount = 0;
        while (restockCount < 3)
        {
            Console.WriteLine($"Restocking Coffee inventory. Restock count: {restockCount + 1}");
            restockCount++;
        }

        // break and continue
        for (int i = 2; i <= 12; i++)
        {
            if (i % 2 == 0)
                continue; // Skip even Coffee
            Console.WriteLine($"Assisting with Coffee {i}");
        }

        // Methods, Parameters, and Returning from Methods
        double discountedTotalRevenue = CalculateDiscountedTotal(totalRevenue, 0.1);
        Console.WriteLine($"Discounted Total Revenue: ${discountedTotalRevenue}");
    }

    // Method with parameters and return statement
    static double CalculateDiscountedTotal(double total, double discountRate)
    {
        return total - (total * discountRate);
    }
}
