using System;

namespace Quennie
{

    class Yongco
    {
        static void Main()
        {
            Console.WriteLine("WELCOME TO QUENNS RESTAURANT\n");
            Console.WriteLine("*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*\n" +
                              " Quennie Restaurant Main Menu    \n" +
                              " 1   -     Maindish              \n" +
                              " 2   -     Seafoods              \n" +
                              " 3   -     Beverages             \n" +
                              " 4   -     Desserts              \n" +
                              "/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/*/");
       

            int tableNumber = 1;
            double totalBill = 0.0;


            double taxRate = 0.1; // 10%
            double tipRate = 0.15; // 15%

            Console.WriteLine();

            double ChickenCordonprice = 80.99;
            double BufaloPrice = 70.99;
            double FriedRicePrice = 40.99;
            double CrossRibRoastPrice = 90.99;


            Console.WriteLine("Menu: ");
            Console.WriteLine($"1. Chicken Cordon ${ChickenCordonprice}");
            Console.WriteLine($"2. Bufalo - ${BufaloPrice}");
            Console.WriteLine($"3. Fried Rice - ${FriedRicePrice}");
            Console.WriteLine($"4. Cross Rib Roast - ${CrossRibRoastPrice}");


            Console.Write("Enter the number of the item you want to order: ");
            int userChoice = Convert.ToInt32(Console.ReadLine());

            double itemPrice = 0.0;
            string itemName = "";


            switch (userChoice)
            {
                case 1:
                    itemName = "Chicken Cordon";
                    itemPrice = ChickenCordonprice;
                    break;
                case 2:
                    itemName = "Bufalo";
                    itemPrice = BufaloPrice;
                    break;
                case 3:
                    itemName = "Fried Rice";
                    itemPrice = FriedRicePrice;
                    break;
                case 4:
                    itemName = "Cross Rib Roast";
                    itemPrice = CrossRibRoastPrice;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please choose a valid item.");
                    return;
            }

            Console.WriteLine($"You ordered: {itemName}");

            Console.WriteLine(); // Blank line for separation


            Console.WriteLine("dditional Options:");


            Console.Write("Add extra cheese? (Y/N): ");
            char extraCheeseChoice = Console.ReadLine()[0];
            bool addExtraCheese = (extraCheeseChoice == 'Y' || extraCheeseChoice == 'y');


            if (addExtraCheese)
            {
                itemPrice += 1.50;
                Console.WriteLine("Added extra cheese. Additional $1.80.");
            }

            Console.WriteLine();


            Console.WriteLine("Order Summary:");


            Console.WriteLine($"Table: {tableNumber}");
            Console.WriteLine($"Item: {itemName}");
            Console.WriteLine($"Price: ${itemPrice}");


            Console.Write("Enter the quantity: ");
            int quantity = Convert.ToInt32(Console.ReadLine());

            double subtotal = itemPrice * quantity;

            Console.WriteLine($"Subtotal: ${subtotal}");


            double tax = 0.0;
            double tip = 0.0;

            int retryCount = 0;
            while (retryCount < 3)
            {
                Console.Write("Do you want to apply a discount? (Y/N): ");
                char discountChoice = Console.ReadLine()[0];

                if (discountChoice == 'Y' || discountChoice == 'y')
                {
                    Console.Write("Enter the discount percentage: ");
                    double discountPercentage = Convert.ToDouble(Console.ReadLine());
                    double discountFactor = 1.0 - (discountPercentage / 100);
                    totalBill = subtotal * discountFactor;
                    break;
                }
                else if (discountChoice == 'N' || discountChoice == 'n')
                {
                    totalBill = subtotal;
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid choice. Please enter Y or N.");
                    retryCount++;
                }
            }


            Console.WriteLine("Calculating tax and tip...");


            tax = totalBill * taxRate;


            tip = totalBill * tipRate;

            Console.WriteLine($"Tax: ${tax}");
            Console.WriteLine($"Tip: ${tip}");


            double grandTotal = totalBill + tax + tip;
            Console.WriteLine($"Total Bill: ${grandTotal}");

            Console.WriteLine(); // Blank line for separation


            Console.WriteLine("Thank you!");


            DisplayThankYouMessage(tableNumber);


            PrintReceipt(itemName, quantity, subtotal, tax, tip, grandTotal);


            double discountAmount = CalculateDiscount(subtotal, 10); // Assuming a 10% discount
            Console.WriteLine($"Discount applied: ${discountAmount}");
        }


        static void DisplayThankYouMessage(int tableNumber)
        {
            Console.WriteLine($"Thank you for dining with us at Table {tableNumber}!");
        }


        static void PrintReceipt(string itemName, int quantity, double subtotal, double tax, double tip, double grandTotal)
        {
            Console.WriteLine("Receipt:");
            Console.WriteLine($"Item: {itemName}");
            Console.WriteLine($"Quantity: {quantity}");
            Console.WriteLine($"Subtotal: ${subtotal}");
            Console.WriteLine($"Tax: ${tax}");
            Console.WriteLine($"Tip: ${tip}");
            Console.WriteLine($"Grand Total: ${grandTotal}");
        }


        static double CalculateDiscount(double amount, double discountPercentage)
        {
            double discountAmount = amount * (discountPercentage / 100);
            return discountAmount;
        }
    }
}