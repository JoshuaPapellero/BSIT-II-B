using System;
using System.Collections.Generic;

class BankAccount
{
    public string AccountNumber { get; }
    public string OwnerName { get; }
    public decimal Balance { get; private set; }

    public BankAccount(string accountNumber, string ownerName, decimal initialBalance)
    {
        AccountNumber = accountNumber;
        OwnerName = ownerName;
        Balance = initialBalance;
    }

    public void Deposit(decimal amount)
    {
        if (amount > 0)
        {
            Balance += amount;
            Console.WriteLine($"Deposited ${amount}. New balance: ${Balance}");
        }
        else
        {
            Console.WriteLine("Invalid deposit amount. Amount must be greater than 0.");
        }
    }

    public void Withdraw(decimal amount)
    {
        if (amount > 0 && amount <= Balance)
        {
            Balance -= amount;
            Console.WriteLine($"Withdrawn ${amount}. New balance: ${Balance}");
        }
        else
        {
            Console.WriteLine("Invalid withdrawal amount or insufficient funds.");
        }
    }

    public void DisplayBalance()
    {
        Console.WriteLine($"Account Number: {AccountNumber}");
        Console.WriteLine($"Owner: {OwnerName}");
        Console.WriteLine($"Current Balance: ${Balance}");
    }
}

class Program
{
    static void Main()
    {
        List<BankAccount> accounts = new List<BankAccount>();

        while (true)
        {
            Console.WriteLine("\nTROY CREDIT UNION");
            Console.WriteLine("1. Create Account");
            Console.WriteLine("2. Deposit");
            Console.WriteLine("3. Withdraw");
            Console.WriteLine("4. Check Balance");
            Console.WriteLine("5. Exit");

            Console.Write("Enter your choice (1-5): ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    CreateAccount(accounts);
                    break;
                case "2":
                    Deposit(accounts);
                    break;
                case "3":
                    Withdraw(accounts);
                    break;
                case "4":
                    CheckBalance(accounts);
                    break;
                case "5":
                    Console.WriteLine("Exiting the program. Goodbye!");
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please enter a number from 1 to 5.");
                    break;
            }
        }
    }

    static void CreateAccount(List<BankAccount> accounts)
    {
        Console.Write("Enter your name: ");
        string ownerName = Console.ReadLine();
        string accountNumber = Guid.NewGuid().ToString().Substring(0, 8); // Generate a random account number
        Console.Write("Enter initial deposit amount: $");
        decimal initialDeposit = decimal.Parse(Console.ReadLine());

        BankAccount newAccount = new BankAccount(accountNumber, ownerName, initialDeposit);
        accounts.Add(newAccount);

        Console.WriteLine($"Account created successfully. Account Number: {accountNumber}");
    }

    static void Deposit(List<BankAccount> accounts)
    {
        Console.Write("Enter your account number: ");
        string accountNumber = Console.ReadLine();

        BankAccount account = FindAccount(accounts, accountNumber);

        if (account != null)
        {
            Console.Write("Enter deposit amount: $");
            decimal depositAmount = decimal.Parse(Console.ReadLine());
            account.Deposit(depositAmount);
        }
        else
        {
            Console.WriteLine("Account not found. Please check your account number.");
        }
    }

    static void Withdraw(List<BankAccount> accounts)
    {
        Console.Write("Enter your account number: ");
        string accountNumber = Console.ReadLine();

        BankAccount account = FindAccount(accounts, accountNumber);

        if (account != null)
        {
            Console.Write("Enter withdrawal amount: $");
            decimal withdrawalAmount = decimal.Parse(Console.ReadLine());
            account.Withdraw(withdrawalAmount);
        }
        else
        {
            Console.WriteLine("Account not found. Please check your account number.");
        }
    }

    static void CheckBalance(List<BankAccount> accounts)
    {
        Console.Write("Enter your account number: ");
        string accountNumber = Console.ReadLine();

        BankAccount account = FindAccount(accounts, accountNumber);

        if (account != null)
        {
            account.DisplayBalance();
        }
        else
        {
            Console.WriteLine("Account not found. Please check your account number.");
        }
    }

    static BankAccount FindAccount(List<BankAccount> accounts, string accountNumber)
    {
        return accounts.Find(acc => acc.AccountNumber == accountNumber);
    }
}