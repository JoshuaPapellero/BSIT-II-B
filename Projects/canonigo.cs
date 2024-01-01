using System;

class CanonigoResto
{
    static void Main()
    {
        bool isOrdering = true;
        double totalAmount = 0;
        string itemsOrdered = "";

        while (isOrdering)
        {
            Console.WriteLine("Welcome to Fast Food Menu!\n\n");
            
            DisplayMenu();

            Console.Write("Enter your choice:");
            int choice = Convert.ToInt32(Console.ReadLine());

            if (choice >= 1 && choice <= 10)
            {
                Console.Write("Enter quantity: ");
                int quantity = GetQuantity();
                double price = CalculatePrice(choice, quantity);
                totalAmount += price;

                
                itemsOrdered += $"{GetItemName(choice)} - Quantity: {quantity}, Cost: P{price}\n";
            }

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Added Salad to your order.");
                    Console.WriteLine($"Price for Salad: P200");
                    break;
                case 2:
                    Console.WriteLine("Added Pork to your order.");
                    Console.WriteLine($"Price for Pork: P80");
                    break;
                case 3:
                    Console.WriteLine("Added Chicken to your order.");
                    Console.WriteLine($"Price for Chicken: P100");
                    break;
                case 4:
                    Console.WriteLine("Added Dinnogoan to your order.");
                    Console.WriteLine($"Price for Dinnogoan: P50");
                    break;
                case 5:
                    Console.WriteLine("Added Coke to your order.");
                    Console.WriteLine($"Price for Coke: P50");
                    break;
                case 6:
                    Console.WriteLine("Added Sprite to your order.");
                    Console.WriteLine($"Price for Sprite: P50");
                    break;
                case 7:
                    Console.WriteLine("Added Royal to your order.");
                    Console.WriteLine($"Price for Royal: P50");
                    break;
                case 8:
                    Console.WriteLine("Added Water to your order.");
                    Console.WriteLine($"Price for Water: P100");
                    break;
                case 9:
                    Console.WriteLine("Added Lechon to your order.");
                    Console.WriteLine($"Price for Lechon: P700");
                    break;
                case 10:
                    Console.WriteLine("Added Utan to your order.");
                    Console.WriteLine($"Price for Utan: P50");
                    break;
                case 11:
                    isOrdering = false;
                    break;
                case 12:
                    isOrdering = false;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please select again.");
                    break;
            }
        }

        
        if (totalAmount > 0)
        {
            // Receipt
            Console.WriteLine("Items Ordered:");
            Console.WriteLine(itemsOrdered);
            Console.WriteLine($"Your total amount is: P{totalAmount}");

            Console.WriteLine("Preparing your order:");
            string[] preparationSteps = { "Adding kisses", "iloveyouuuu", "Grilling", "Wrapping" };
            foreach (var step in preparationSteps)
            {
                Console.WriteLine(step);
            }

           
            Console.WriteLine("Cooking timer:");
            int cookingTime = 10; 

            while (cookingTime > 0)
            {
                Console.WriteLine(cookingTime);
                System.Threading.Thread.Sleep(1000); 
                cookingTime--;

                if (cookingTime == 2)
                {
                    Console.WriteLine("Cooking stopped early.");
                    break;
                }
            }

            Console.WriteLine("Order ready for pickup!");
        }
        else
        {
            Console.WriteLine("No items in the order. Thank you!");
        }
    }

    
    static void DisplayMenu()
    {
        Console.WriteLine("1. Salad - P200");
        Console.WriteLine("2. Pork - P80");
        Console.WriteLine("3. Chicken - P100");
        Console.WriteLine("4. Dinnogoan - P50");
        Console.WriteLine("5. Coke - P50");
        Console.WriteLine("6. Sprite - P50");
        Console.WriteLine("7. Royal - P50");
        Console.WriteLine("8. Water - P100");
        Console.WriteLine("9. Lechon - P700");
        Console.WriteLine("10. Utan - P50");
        Console.WriteLine("11. Checkout");
        Console.WriteLine("12. Exit\n");
    }

    
    static int GetQuantity()
    {
        return Convert.ToInt32(Console.ReadLine());
    }

    //calculating price
    static double CalculatePrice(int item, int quantity)
    {
        double price = 0;
        switch (item)
        {
            case 1:
                price = 200 * quantity;
                break;
            case 2:
                price = 80 * quantity;
                break;
            case 3:
                price = 700 * quantity;
                break;
            case 4:
                price = 1000 * quantity;
                break;
            case 5:
                price = 600 * quantity;
                break;
            case 6:
                price = 80 * quantity;
                break;
            case 7:
                price = 90 * quantity;
                break;
            case 8:
                price = 400 * quantity;
                break;
            case 9:
                price = 700 * quantity;
                break;
            case 10:
                price = 50 * quantity;
                break;
        }
        return price;
    }

    
    static string GetItemName(int choice)
    {
        switch (choice)
        {
            case 1:
                return "Salad";
            case 2:
                return "Pork";
            case 3:
                return "Chicken";
            case 4:
                return "Dinnogoan";
            case 5:
                return "Coke";
            case 6:
                return "Coke";
            case 7:
                return "Royal";
            case 8:
                return "Water";
            case 9:
                return "Lechon";
            case 10:
                return "Utan";
            default:
                return "Unknown";
        }
    }
}
