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
