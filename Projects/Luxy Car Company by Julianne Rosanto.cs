using System;

class Program 
{
    static void Main()
    {
        // Program Structure
        Console.WriteLine("Welcome to Luxy Car Company!");

        // Variables
        int carPerprice = 600000;
        double carsprice= 1000000;
        int carprice = 800000000;

        // Data Types
        int orderNumber = 401;
        double totalPrice;

        // Doing Math
        int numberOfCars = 3;
        int numberOfPerCars = 2;

        // Arithmetic Operators
        int carCost = numberOfCars * carPerprice;  
        double totalCost = carCost + (numberOfPerCars * carPerprice);

        // Assignment Operators
        totalPrice = totalCost;

        // User Input
        Console.Write("Enter your preferred color of your car (Red/black/white): ");
        string carType = Console.ReadLine();

        // More on Strings (\n \t @)
        string receipt = $"Order Number: {orderNumber}\n\tCars: {numberOfCars}\n\tCars: {numberOfCars}\n\tcar Type: {carType}";

        // Concatenation and Interpolation
        string orderSummary = $"Your order includes {numberOfCars} cars, {numberOfCars} cars, and a {carType} car.";

        // Comparison Operators
        if (totalCost > 15)
        {
            Console.WriteLine("You qualify for a discount on your next purchase!");
        }
        else if (totalCost > 10)
        {
            Console.WriteLine("choose a particular color to your order for a discount!");
        }
        else
        {
            Console.WriteLine("Enjoy your time at Luxy Car Company!");
        }

        // Logical Operators
        bool isCarType = (carType.ToLower() == "Mercedes");
        if (isCarType && numberOfCars >= 2)
        {
            Console.WriteLine("Luxy Car complements well with our car selection. Enjoy!");
        }

        // switch Statement
        Console.Write("Enter your preferred car model (BMW/Lamborghini/MercedesBenz): ");
        string carModel = Console.ReadLine();
        switch (carModel.ToLower())
        {
            case "BMW":
                Console.WriteLine("Indulge in the rich BMW engine.");
                break;
            case "Lamborghini":
                Console.WriteLine("Savor the sweet style of our Lamborghini car.");
                break;
            case "MercedesBenz":
                Console.WriteLine("Experience the high quality of our car-model cars.");
                break;
            default:
                Console.WriteLine("Invalid car model choice. Please select BMW, Lamborghini, or MercedesBenz.");
                break;
        }

        // Ternary Operator
        string discountMessage = (totalCost > 15) ? "You've earned a discount for your loyalty!" : "No discount with this order.";
        Console.WriteLine(discountMessage);

        // for Loop
        Console.WriteLine("Counting from  to 4:");
        for (int i = 1; i <= 4; i++)
        {
            Console.WriteLine(i);
        }

        // while Loop
        Console.WriteLine("Counting down from 7:");
        int countdown = 7;
        while (countdown > 0)
        {
            Console.WriteLine(countdown);
            countdown--;
        }

        // break and continue
        Console.WriteLine("Skipping 3 in a loop:");
        for (int i = 1; i <= 5; i++)
        {
            if (i == 3)
            {
                continue;
            }
            Console.WriteLine(i);
        }

        // Methods
        DisplayOrderReceipt(receipt);

        // Parameters and Arguments
        DisplayThankYouMessage("Thank you for choosing Luxy Car Company!");

        // Returning from Methods
        double change = ProcessPayment(10, totalCost);
        Console.WriteLine($"Your change: {change:C}");
    }

    static void DisplayOrderReceipt(string orderDetails)
    {
        Console.WriteLine("Order Receipt:");
        Console.WriteLine(orderDetails);
    }

    static void DisplayThankYouMessage(string message)
    {
        Console.WriteLine(message);
    }

    static double ProcessPayment(double amountPaid, double totalAmount)
    {
        double change = amountPaid - totalAmount;
        return change;
    }
}

