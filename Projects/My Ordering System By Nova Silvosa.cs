using System;

class program
{
    // Methods with parameters and return value
    static double CalculateItemTotal(int quantity, double pricePerItem)
    {
        return quantity * pricePerItem;
    }

    static void Main()
    {
        // Basic concept output
        Console.WriteLine("Welcome to my Ordering System!");

        // Variables and data types
        string customerName;
        int numberOfItems;
        double totalPrice = 0;

        // User input
        Console.Write("Enter your name: ");
        customerName = Console.ReadLine();

        // Strings, Concatenation, and Interpolation
        Console.WriteLine($"Hello, {customerName}! May  I Help You?\n");

        // For loop to take multiple orders
        Console.Write("Please Enter the number of items you want to order: ");
        numberOfItems = int.Parse(Console.ReadLine());

        for (int i = 0; i < numberOfItems; i++)
        {
            Console.WriteLine($"\nOrder {i + 1}:");

            // User input and data types
            Console.Write("Enter item name: ");
            string itemName = Console.ReadLine();

            Console.Write("Enter quantity: ");
            int quantity = int.Parse(Console.ReadLine());

            Console.Write("Enter price per item: $");
            double pricePerItem = double.Parse(Console.ReadLine());

            // Doing math - Method call
            double itemTotal = CalculateItemTotal(quantity, pricePerItem);
            totalPrice += itemTotal;

            Console.WriteLine($"Added {quantity} {itemName}(s) to your order. Total: ${itemTotal}\n");
        }

        // Output the total price
        Console.WriteLine($"Total Price for {numberOfItems} item(s): ${totalPrice}");

        // Logical operators and if-else statements
        if (totalPrice > 50)
        {
            totalPrice *= 0.9; // 10% discount for orders over $50
            Console.WriteLine("You qualify for a 10% discount! New total: $" + totalPrice);
        }
        else
        {
            Console.WriteLine("No discount applied. Total: $" + totalPrice);
        }

        // Payment confirmation using a ternary operator
        Console.Write("\nDo you want to confirm your order? (yes/no): ");
        string confirmation = Console.ReadLine().ToLower();

        string paymentStatus = confirmation == "yes" ? "successful" : "canceled";

        // Switch statement for payment confirmation
        switch (confirmation)
        {
            case "yes":
                Console.WriteLine($"Thank you for your order! Your payment of ${totalPrice} was {paymentStatus}.");
                break;
            case "no":
                Console.WriteLine("Order canceled. No payment processed.");
                break;
            default:
                Console.WriteLine("Invalid input. Order canceled.");
                break;
        }

        // End of program
        Console.WriteLine("\nPress any key to exit.");
        Console.ReadKey();
    }
}
