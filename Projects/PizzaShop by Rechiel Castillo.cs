using System;

namespace Castillo
{
    class PizzaShopProgram
    {
        static void Main()
        {

            Console.WriteLine("Welcome to PizzaShop!");

            int quantity = 2;
            double price = 10.99;

            string pizzaName = "Hawaiian";
            bool isAvailable = true;

            double totalCost = quantity * price;

            totalCost += 5.00;

            int discount = 2;
            totalCost -= discount;

            Console.Write("Enter your name: ");
            string userName = Console.ReadLine();

            Console.WriteLine($"Hello, {userName}! Your {pizzaName} pizza costs ${totalCost:F2}");

            string orderSummary = $"You ordered {quantity} {pizzaName} pizzas.";
            Console.WriteLine(orderSummary);


            if (totalCost > 10)
            {
                Console.WriteLine("You qualify for a discount!");
            }
            else
            {
                Console.WriteLine("No discount available.");
            }

            if (isAvailable)
            {
                Console.WriteLine("Your pizza is ready!");
            }
            else if (!isAvailable)
            {
                Console.WriteLine("Sorry, the selected pizza is not available.");
            }
            else
            {
                Console.WriteLine("Invalid input.");
            }

            bool isLargePizza = true;
            bool hasDiscount = true;

            if (isLargePizza && hasDiscount)
            {
                Console.WriteLine("You have a discount on a large pizza!");
            }

            int rating = 3;

            switch (rating)
            {
                case 1:
                    Console.WriteLine("Poor");
                    break;
                case 2:
                    Console.WriteLine("Fair");
                    break;
                case 3:
                    Console.WriteLine("Good");
                    break;
                default:
                    Console.WriteLine("Invalid rating");
                    break;
            }

            int count = 0;
            while (count < 3)
            {
                Console.WriteLine("Preparing pizza...");
                count++;
            }

            for (int i = 0; i < 5; i++)
            {
                if (i == 2)
                    break;
                Console.WriteLine("Iteration: " + i);
            }

            DisplayGreeting();

            double discountedTotal = ApplyDiscount(totalCost);
            Console.WriteLine($"Your discounted total is: ${discountedTotal:F2}");

        }

        static void DisplayGreeting()
        {
            Console.WriteLine("Thank you for choosing PizzaShop!");
        }

        static double ApplyDiscount(double total)
        {
            double discountPercentage = 0.1; //10%
            return total - (total * discountPercentage);
        }
    }
}
 