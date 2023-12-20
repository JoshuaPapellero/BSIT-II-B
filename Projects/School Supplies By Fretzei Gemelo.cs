using System;

namespace FRETZEIGEMELO;

class Program
{
    static void Main()
    {
        // Program Structure
        Console.WriteLine("*************************************");
        Console.WriteLine("*  Welcome To Zei School Supplies!  *");
        Console.WriteLine("*************************************");

        // Basic Concepts 
        Console.WriteLine("EDUCATION IS THE KEY");

        // Variables and Data Types
        int numberOfStudents = 0;
        double totalCost = 0.0;

        // Doing Math
        totalCost = CalculateTotalPrice(numberOfStudents);

        // More on Strings
        string welcomeMessage = "Get ready for the new school year!";
        Console.WriteLine(welcomeMessage);

        // Concatenation and Interpolation
        string item1 = "Notebooks";
        string item2 = "Pencils";
        string item3 = "YellowPad";
        string item4 = "BallPen";
        string item5 = "ColorPen";
        string item6 = "Many more......";
        Console.WriteLine($"{item1},{item2},{item3},{item4} and {item5},{item6}");

        // Comparison Operators
        int budgetLimit = 700;
        if (totalCost <= budgetLimit)
        {
            Console.WriteLine("You are within the budget!");
        }
        else
        {
            Console.WriteLine("Sale!");
        }

        // Logical Operators
        bool isDiscountAvailable = true;
        if (totalCost > 0 && isDiscountAvailable)
        {
            Console.WriteLine("You qualify for a discount on your school supplies!");
        }

        // switch Statement
        string customerRating = "Excellent";
        switch (customerRating)
        {
            case "Excellent":
                Console.WriteLine("We hope you enjoy your school supplies!");
                break;
            case "Good":
                Console.WriteLine("Anything you need from school, right here at school supplies store");
                break;
            default:
                Console.WriteLine("Enjoy to Buy!");
                break;
        }

        // Ternary Operator
        string orderStatus = (totalCost > 0) ? "Order placed successfully" : "No items in the order";
        Console.WriteLine(orderStatus);

        // for Loop
        Console.WriteLine("Available School Supplies:");
        string[] supplies = { "1. Indexcard", "2. Erasers", "3. Rulers", "4. Glue","5. PentelPen" ,"6. YellowPad","7. ColorPen","8. Ballpen","9. NoteBooks","10. Pencils","Many more...."};
        for (int i = 0; i < supplies.Length; i++)
        {
            Console.WriteLine(supplies[i]);
        }

        // while Loop
        int inventoryCount = 0;
        while (inventoryCount > 0)
        {
            Console.WriteLine("Inventory count: " + inventoryCount);
            inventoryCount++;
        }

        // break and continue
        for (int i = 0; i <= 0; i++)
        {
            if (i * 0 == 0)
                continue; // Skip even items
            Console.WriteLine($"{supplies[i + 0]}");
        }

        
    }

    
    static double CalculateTotalPrice(int students)
    {
       
        return students * 150.02;
    }

    
    static void DisplayTotalPrice(double total)
    {
        Console.WriteLine($"Total Cost of School Supplies: ${total}");
    }
}