using System;

class VerdeflorsUtanon
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
                    Console.WriteLine("Added SPAGHETTI to your order.");
                    Console.WriteLine($"Price for SPAGHETTI: P200");
                    break;
                case 2:
                    Console.WriteLine("Added UTAN to your order.");
                    Console.WriteLine($"Price for UTAN: P80");
                    break;
                case 3:
                    Console.WriteLine("Added BULAD to your order.");
                    Console.WriteLine($"Price for BULAD: P700");
                    break;
                case 4:
                    Console.WriteLine("Added CAKE to your order.");
                    Console.WriteLine($"Price for CAKE: P1000");
                    break;
                case 5:
                    Console.WriteLine("Added MAGIC WATER to your order.");
                    Console.WriteLine($"Price for MAGIC WATER: P600");
                    break;
                case 6:
                    Console.WriteLine("Added PAN to your order.");
                    Console.WriteLine($"Price for PAN: P80");
                    break;
                case 7:
                    Console.WriteLine("Added BINGCHILLING to your order.");
                    Console.WriteLine($"Price for BINGCHILLING: P90");
                    break;
                case 8:
                    Console.WriteLine("Added Ice Water to your order.");
                    Console.WriteLine($"Price for Ice WATER: P400");
                    break;
                case 9:
                    Console.WriteLine("Added RAT POISON to your order.");
                    Console.WriteLine($"Price for RAT POISON: P700");
                    break;
                case 10:
                    Console.WriteLine("Added GATAS to your order.");
                    Console.WriteLine($"Price for GATAS: P50");
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
        Console.WriteLine("1. SPAGHETTI - P200");
        Console.WriteLine("2. UTAN - P80");
        Console.WriteLine("3. BULAD - P700");
        Console.WriteLine("4. CAKE - P1000");
        Console.WriteLine("5. MAGIC WATER - P600");
        Console.WriteLine("6. PAN - P80");
        Console.WriteLine("7. BINGCHILLING - P90");
        Console.WriteLine("8. Ice WATER - P400");
        Console.WriteLine("9. RAT POISON - P700");
        Console.WriteLine("10. GATAS - P50");
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
                return "SPAGHETTI";
            case 2:
                return "UTAN";
            case 3:
                return "BULAD";
            case 4:
                return "CAKE";
            case 5:
                return "MAGIC WATER";
            case 6:
                return "PAN";
            case 7:
                return "BINGCHILLING";
            case 8:
                return "Ice Water";
            case 9:
                return "RAT POISON";
            case 10:
                return "GATAS";
            default:
                return "Unknown";
        }
    }
}
