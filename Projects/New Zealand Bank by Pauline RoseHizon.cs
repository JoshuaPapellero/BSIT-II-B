using System;

class Hizon
{
    static void Main()
    {
        // Module 1 - Getting started
        Console.WriteLine("Welcome to the New Zealand Bank");

        // Module 2 - Operators and Strings
        double accountBalance = 1000.0;
        Console.WriteLine($"Your current account balance: ${accountBalance}");

        Console.Write("Enter the amount to deposit: ");
        double depositAmount = Convert.ToDouble(Console.ReadLine());
        accountBalance += depositAmount;
        Console.WriteLine($"After deposit, your new balance: ${accountBalance}");

        Console.Write("Enter the amount to withdraw: ");
        double withdrawAmount = Convert.ToDouble(Console.ReadLine());

        if (withdrawAmount <= accountBalance)
        {
            accountBalance -= withdrawAmount;
            Console.WriteLine($"After withdrawal, your new balance: ${accountBalance}");
        }
        else
        {
            Console.WriteLine("Insufficient funds. Withdrawal canceled.");
        }

        // Module 3 - Decision Making
        Console.Write("Do you want to see your transaction history? (yes/no): ");
        string userChoice = Console.ReadLine().ToLower();

        switch (userChoice)
        {
            case "yes":
                Console.WriteLine("Transaction History: [Deposit, Withdrawal]");
                break;

            case "no":
                Console.WriteLine("Thank you for using the New Zealand Bank!");
                break;

            default:
                Console.WriteLine("Invalid choice. Please enter 'yes' or 'no'.");
                break;
        }

        // Module 4 - Loops
        Console.WriteLine("Printing numbers from 1 to 5 using a for loop:");
        for (int i = 1; i <= 5; i++)
        {
            Console.WriteLine(i);
        }

        // Module 5 - Methods
        double CalculateInterest(double amount, double interestRate)
        {
            return amount * interestRate / 100;
        }

        double totalInterest = CalculateInterest(accountBalance, 5.0);
        Console.WriteLine($"Total interest earned on your balance: ${totalInterest}");

        // End of program
        Console.WriteLine("Thank you for using the New Zealand Bank!");
    }
}