using System;

class BankAccountProgram
{
    static void Main()
    {
        // Basic Concepts and Output
        Console.WriteLine("Welcome to the Bank Account Program!");

        // Variables and Data Types
        int accountNumber = 123456;
        decimal balance = 1000.50m;

        // Output using Concatenation
        Console.WriteLine("Account Number: " + accountNumber);
        Console.WriteLine("Balance: $" + balance);

        // Doing Math and Arithmetic Operators
        decimal depositAmount = 500.75m;
        balance = balance + depositAmount;

        Console.WriteLine("After deposit, new balance: $" + balance);

        // User Input
        Console.Write("Enter withdrawal amount: ");
        decimal withdrawalAmount = Convert.ToDecimal(Console.ReadLine());
        balance = balance - withdrawalAmount;

        Console.WriteLine("After withdrawal, new balance: $" + balance);

        // More on Strings (\n \t @) and Concatenation
        string message = "Thank you for using our services!\n";
        message += "\t Have a great day!";
        Console.WriteLine(message);

        // Comparison Operators and if Statement
        if (balance > 0)
        {
            Console.WriteLine("You have a positive balance.");
        }
        else if (balance == 0)
        {
            Console.WriteLine("Your balance is zero.");
        }
        else
        {
            Console.WriteLine("Your account is overdrawn.");
        }

        // Logical Operators
        bool isVIPCustomer = true;
        int transactionCount = 10;

        if (isVIPCustomer && transactionCount > 5)
        {
            Console.WriteLine("You are a valued customer with frequent transactions.");
        }

        // Switch Statement
        Console.Write("Enter the transaction type (deposit/withdrawal): ");
        string transactionType = Console.ReadLine();

        switch (transactionType.ToLower())
        {
            case "deposit":
                Console.WriteLine("You selected a deposit transaction.");
                break;

            case "withdrawal":
                Console.WriteLine("You selected a withdrawal transaction.");
                break;

            default:
                Console.WriteLine("Invalid transaction type.");
                break;
        }

        // Ternary Operator
        string accountStatus = (balance > 0) ? "Active" : "Inactive";
        Console.WriteLine("Account Status: " + accountStatus);

        // for Loop
        Console.WriteLine("Printing numbers from 1 to 5 using a for loop:");
        for (int i = 1; i <= 5; i++)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine();

        // while Loop
        int counter = 0;
        Console.WriteLine("Printing numbers from 5 to 1 using a while loop:");
        while (counter < 5)
        {
            Console.Write((5 - counter) + " ");
            counter++;
        }
        Console.WriteLine();

        // break and continue
        for (int i = 1; i <= 10; i++)
        {
            if (i % 2 == 0)
                continue;

            Console.Write(i + " ");

            if (i == 5)
                break;
        }
        Console.WriteLine();

        // Methods, Parameters, and Arguments
        decimal newBalance = ProcessTransaction(balance, 200.25m, "withdrawal");
        Console.WriteLine("New Balance after method call: $" + newBalance);

        // Returning from Methods
        string greeting = GenerateGreeting("John");
        Console.WriteLine(greeting);
    }

    // Method with Parameters and Returning a Value
    static decimal ProcessTransaction(decimal currentBalance, decimal transactionAmount, string transactionType)
    {
        if (transactionType.ToLower() == "deposit")
            return currentBalance + transactionAmount;
        else if (transactionType.ToLower() == "withdrawal")
            return currentBalance - transactionAmount;
        else
            return currentBalance;
    }

    // Method with Parameters and Returning a Value
    static string GenerateGreeting(string name)
    {
        return "Hello, " + name + "! Welcome to our bank.";
    }
}
