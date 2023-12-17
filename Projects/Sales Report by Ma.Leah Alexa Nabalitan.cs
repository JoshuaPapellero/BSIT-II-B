using System;

class SalesReport
{
    // Module 1 - Getting started
    static void Main()
    {
        // Program Structure
        Console.WriteLine("Welcome to the Monthly Sales Report Generator...");

        // Basic Concepts (Output)
        Console.WriteLine("This program calculates and displays the sales for the month.");

        // Variables
        int numberOfProducts = 3;
        double[] productPrices = { 20.5, 30.75, 15.99 };
        int[] productQuantities = { 100, 50, 75 };

        // Data Types
        string month = "December";

        // Doing Math
        double totalSales = CalculateTotalSales(productPrices, productQuantities);

        // Module 2 - Operators and Strings
        // Arithmetic Operators
        double expenses = 1500.0;

        // Assignment Operators
        expenses += 200.0; 

        // User Input
        Console.Write("Enter the tax rate (%): ");
        double taxRate = Convert.ToDouble(Console.ReadLine());

        // More on Strings (\n \t @)
        string reportHeader = $"Monthly Sales Report for {month}";
        string formattedExpenses = string.Format("Total Expenses: {0:C}", expenses);

        // Concatenation and Interpolation
        string summary = $"Total Sales: {totalSales:C}\nTax Rate: {taxRate}%\n{formattedExpenses}";

        // Module 3 - Decision Making
        // Comparison Operators
        if (totalSales > 10000)
        {
            Console.WriteLine("Fantastic sales performance!");
        }
        else if (totalSales > 1000)
        {
            Console.WriteLine("Great sales performance.");
        }
        else
        {
            Console.WriteLine("Improve your sales performance");
        }

        // Logical Operators
        bool isHighSales = totalSales > 10000;
        bool isLowExpenses = expenses < 1000;

        if (isHighSales && isLowExpenses)
        {
            Console.WriteLine("Fantastic financial performance!");
        }
        else if (isHighSales || isLowExpenses)
        {
            Console.WriteLine("Great financial performance.");
        }
        else
        {
            Console.WriteLine("Evaluate financial strategies.");
        }

        // switch Statement
        Console.Write("Enter a rating (1-5): ");
        int rating = Convert.ToInt32(Console.ReadLine());

        switch (rating)
        {
            case 1:
                Console.WriteLine("Poor rating");
                break;
            case 2:
                Console.WriteLine("Fair rating");
                break;
            case 3:
                Console.WriteLine("Average rating");
                break;
            case 4:
                Console.WriteLine("Good rating");
                break;
            case 5:
                Console.WriteLine("Excellent rating");
                break;
            default:
                Console.WriteLine("Invalid rating");
                break;
        }

        // Module 4 - Loops
        // while Loop
        int i = 0;
        while (i < 5)
        {
            Console.WriteLine($"Loop iteration {i + 1}");
            i++;
        }

        // break and continue
        for (int j = 0; j < 10; j++)
        {
            if (j == 5)
                break; 

            if (j % 2 == 0)
                continue; 

            Console.WriteLine($"Value: {j}");
        }

        // Module 5 - Methods
        // Parameters and Arguments
        DisplaySalesReport(reportHeader, summary);

        // Returning from Methods
        double netProfit = CalculateNetProfit(totalSales, expenses);
        Console.WriteLine($"Net Profit: {netProfit:C}");
    }

    // Module 5 - Methods
    static void DisplaySalesReport(string header, string content)
    {
        Console.WriteLine(header);
        Console.WriteLine(content);
    }

    static double CalculateNetProfit(double sales, double expenses)
    {
        return sales - expenses;
    }

    static double CalculateTotalSales(double[] prices, int[] quantities)
    {
        double total = 0;
        for (int i = 0; i < prices.Length; i++)
        {
            total += prices[i] * quantities[i];
        }
        return total;
    }
}

