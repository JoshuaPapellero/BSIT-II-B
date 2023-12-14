using System;

class Bar
{

    private string barName = "Macaday Bar";
    private decimal[] drinkPrices = { 5.99m, 7.99m, 8.99m }; 
    private int[] drinkInventory = { 100, 400, 55, 200 };
    private decimal totalSales = 0m;


    public void TakeOrder(int drinkChoice, int quantity)
    {
        if (drinkChoice < 1 || drinkChoice > drinkPrices.Length || quantity <= 0)
        {
            Console.WriteLine("Invalid order. Please try again.");
            return;
        }

        if (drinkInventory[drinkChoice - 1] < quantity)
        {
            Console.WriteLine("Sorry, we don't have enough {0} in stock.", GetDrinkName(drinkChoice));
            return;
        }

        decimal orderTotal = drinkPrices[drinkChoice - 1] * quantity;
        totalSales += orderTotal;

        drinkInventory[drinkChoice - 1] -= quantity;
        Console.WriteLine("Order placed for {0} {1}s for a total of ${2:F2}.", quantity, GetDrinkName(drinkChoice), orderTotal);
    }

    public void PrintInventory()
    {
        Console.WriteLine("\nCurrent Inventory:");
        Console.WriteLine("\t1. Tanduay Select ({0} remaining)", drinkInventory[0]);
        Console.WriteLine("\t2. Tuba ({0} remaining)", drinkInventory[1]);
        Console.WriteLine("\t3. Kulafu ({0} remaining)", drinkInventory[2]);
        Console.WriteLine("\t4. Ginbilog ({0} remaining)", drinkInventory[3]);
    }

    private string GetDrinkName(int drinkChoice)
    {
        switch (drinkChoice)
        {
            case 1: return "Beer";
            case 2: return "Wine";
            case 3: return "Cocktail";
            default: return "Unknown";
        }
    }

    static void Main(string[] args)
    {
        Bar bar = new Bar();

        bool keepGoing = true;
        while (keepGoing)
        {
            bar.PrintInventory();

            Console.WriteLine("\nWhat would you like to order? (Enter drink number, quantity, or 'quit'):");
            string userInput = Console.ReadLine().ToLower();

            if (userInput == "quit")
            {
                keepGoing = false;
                Console.WriteLine("\nTotal sales for the night: ${0:F2}", bar.totalSales);
            }
            else
            {
                try
                {
                    string[] orderInfo = userInput.Split(' ');
                    int drinkChoice = int.Parse(orderInfo[0]);
                    int quantity = int.Parse(orderInfo[1]);
                    bar.TakeOrder(drinkChoice, quantity);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Invalid input. Please try again.");
                }
            }
        }

        Console.WriteLine("\nThanks for visiting The Tipsy Turtle!");
        Console.ReadKey();
    }
}