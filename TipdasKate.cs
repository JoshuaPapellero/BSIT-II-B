using System;

class Tipdas
{
    static void Main()
    {

        Console.WriteLine("Welcome to Yuki's Drawing Supplies *^____^*");


        static void SupplyList()
        {
            Console.WriteLine("\n**************************************************");
            Console.WriteLine("\n*       Drawing Supply List                      *");
            Console.WriteLine("\n*       1 - Sketchbook                           *");
            Console.WriteLine("\n*       2 - White Charcoal                       *");
            Console.WriteLine("\n*       3 - Ebony Pencil                         *");
            Console.WriteLine("\n*       4 - Pencil Sharpener                     *");
            Console.WriteLine("\n*       5 - Ruler or Straight edge triangle set  *");
            Console.WriteLine("\n*       6 - White Eraser                         *");
            Console.WriteLine("\n*       7 - Faber-Castell Pitt Graphite Pencil   *");
            Console.WriteLine("\n*       8 - Conti                                *");
            Console.WriteLine("\n*       9 - Blending Stump                       *");
            Console.WriteLine("\n*       10 - Pay Your Bill                       *");
            Console.WriteLine("\n**************************************************");
        }

        double totalAmount = 0;
        string purchased = "";
        bool placeanOrder = true;

        while (placeanOrder)
        {

            SupplyList();

            Console.Write("Please enter your choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            if (choice >= 1 && choice <= 9)
            {
                Console.Write("How much do you want?: ");
                int quantity = GetQuantity();
                double price = CalculatePrice(choice, quantity);
                totalAmount += price;


                purchased += $"{itemName(choice)} \n Quantity: {quantity} \n Cost: P{price}\n";
            }

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Sketchbook is placed in your order.");
                    break;
                case 2:
                    Console.WriteLine("White Charcoal is placed in your order.");
                    break;
                case 3:
                    Console.WriteLine("Ebony Pencil is placed in your order.");
                    break;
                case 4:
                    Console.WriteLine("Pencil Sharpener is placed in your order.");
                    break;
                case 5:
                    Console.WriteLine("Ruler or Straight edge triangle set is placed in your order.");
                    break;
                case 6:
                    Console.WriteLine("White Eraser is placed in your order.");
                    break;
                case 7:
                    Console.WriteLine("Faber-Castell Pitt Graphite Pencil is placed in your order.");
                    break;
                case 8:
                    Console.WriteLine("Conti is placed in your order.");
                    break;
                case 9:
                    Console.WriteLine("Blending Stump is placed in your order.");
                    break;
                case 10:
                    placeanOrder = false;
                    break;
                default:
                    Console.WriteLine("Invalid! Please select again.");
                    break;
            }
        }


        if (totalAmount > 0)
        {
            Console.WriteLine("Your ordered items: ");
            Console.WriteLine(purchased);
            Console.WriteLine($"Total Amount: P{totalAmount}");

            Console.WriteLine("Please wait...");
            int packaging = 5;

            while (packaging > 0)
            {
                Console.WriteLine(packaging);
                System.Threading.Thread.Sleep(1000);
                packaging--;

                if (packaging == 0)
                {
                    Console.WriteLine("Packaging finished.");
                    break;
                }
            }

            Console.WriteLine("Here's your order, Ma'am/Sir.");
        }
        else
        {
            Console.WriteLine("Sorry, you didn't place any order.");
        }
    }

    static int GetQuantity()
    {
        return Convert.ToInt32(Console.ReadLine());
    }

    static double CalculatePrice(int item, int quantity)
    {
        double price = 0;
        switch (item)
        {
            case 1:
                price = 145 * quantity;
                break;
            case 2:
                price = 170 * quantity;
                break;
            case 3:
                price = 100 * quantity;
                break;
            case 4:
                price = 180 * quantity;
                break;
            case 5:
                price = 400 * quantity;
                break;
            case 6:
                price = 50 * quantity;
                break;
            case 7:
                price = 500 * quantity;
                break;
            case 8:
                price = 800 * quantity;
                break;
            case 9:
                price = 390 * quantity;
                break;

        }
        return price;
    }


    static string itemName(int choice)
    {
        switch (choice)
        {
            case 1:
                return "Sketchbook";
            case 2:
                return "White Charcoal";
            case 3:
                return "Ebony Pencil";
            case 4:
                return "Pencil Sharpener";
            case 5:
                return "Ruler or Straight edge triangle set";
            case 6:
                return "White Eraser";
            case 7:
                return "Faber-Castell Pitt Graphite Pencil";
            case 8:
                return "Conti";
            case 9:
                return "Blending Stump";
            default:
                return "Unknown";
        }
    }
}
