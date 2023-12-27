using System;

class TShirtShop
{
    static void Main()
    {
        // Basic Concepts (Output)
        Console.WriteLine("Welcome to the T-Shirt Shop!");

        // Variables and Data Types
        string shirtBrand = "Adidas";
        string shirtSize = "M";
        double shirtPrice = 24.99;

        // Doing Math, Arithmetic Operators
        int quantity = 2;
        double totalCost = quantity * shirtPrice;

        // Assignment Operators
        totalCost += 5.00;

        // User Input
        Console.Write("Enter your name: ");
        string? customerName = Console.ReadLine();

        // More on Strings (\n \t @), Concatenation and Interpolation
        string receipt = $@"\n\tReceipt
        Customer: {customerName}
        Item: {shirtBrand} (Size {shirtSize})
        Quantity: {quantity}
        Total Cost: ${totalCost:F2}";

        Console.WriteLine(receipt);

        // if Statement, else if Statement, else Statement, Logical Operators
        if (totalCost > 100)
        {
            Console.WriteLine("You qualify for a 10% discount!");
            totalCost *= 0.9;
        }
        else if (totalCost > 50)
        {
            Console.WriteLine("You qualify for a 5% discount!");
            totalCost *= 0.95;
        }
        else
        {
            Console.WriteLine("No discount applied.");
        }

        // switch Statement
        switch (shirtBrand)
        {
            case "Nike":
                Console.WriteLine("You chose a popular brand!");
                break;
            case "Adidas":
                Console.WriteLine("Great choice with Adidas!");
                break;
            default:
                Console.WriteLine("We have various brands available.");
                break;
        }

        // Ternary Operator
        string discountMessage = totalCost < 80 ? "Enjoy your T-shirts!" : "Thank you for shopping with us!";

        Console.WriteLine(discountMessage);

        // for Loop
        Console.WriteLine("T-Shirt sizes available:");

        for (char size = 'S'; size <= 'X'; size++)
        {
            Console.Write(size + " ");
        }


        // while Loop
        Console.WriteLine("\nPopular T-shirt brands:");

        string[] popularBrands = { "Nike", "Adidas", "Puma", "Reebok" };
        int i = 0;

        while (i < popularBrands.Length)
        {
            Console.Write(popularBrands[i] + " ");
            i++;
        }

        // Methods, Returning from Methods
        double finalPrice = ApplyTax(totalCost);
        Console.WriteLine($"Final Price after tax: ${finalPrice:F2}");
    }

    static double ApplyTax(double amount)
    {
        double taxRate = 0.08;
        return amount * (1 + taxRate);
    }
}
