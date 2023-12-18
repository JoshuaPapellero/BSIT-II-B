using System;

class BankAccount
{
    private string accountHolder;
    private decimal balance;

    public BankAccount(string accountHolder, decimal initialBalance)
    {
        this.accountHolder = accountHolder;
        this.balance = initialBalance;
    }

    public void Deposit(decimal amount)
    {
        balance += amount;
        Console.WriteLine($"Deposited ${amount}. New balance: ${balance}");
    }

    public void Withdraw(decimal amount)
    {
        if (amount > 0 && amount <= balance)
        {
            balance -= amount;
            Console.WriteLine($"Withdrawn ${amount}. New balance: ${balance}");
        }
        else
        {
            Console.WriteLine("Invalid withdrawal amount or insufficient funds.");
        }
    }

    public void CheckBalance()
    {
        Console.WriteLine($"Account Holder: {accountHolder}");
        Console.WriteLine($"Current Balance: ${balance}");
    }
}

class Program
{
    static void Main()
    {
        Console.Write("Enter your name: ");
        string userName = Console.ReadLine();

        Console.Write("Enter initial balance: $");
        decimal initialBalance;
        if (decimal.TryParse(Console.ReadLine(), out initialBalance))
        {
            BankAccount userAccount = new BankAccount(userName, initialBalance);

            while (true)
            {
                Console.WriteLine("\nChoose an option:");
                Console.WriteLine("1. Deposit");
                Console.WriteLine("2. Withdraw");
                Console.WriteLine("3. Check Balance");
                Console.WriteLine("4. Exit");

                int choice;
                if (int.TryParse(Console.ReadLine(), out choice))
                {
                    switch (choice)
                    {
                        case 1:
                            Console.Write("Enter deposit amount: $");
                            decimal depositAmount;
                            if (decimal.TryParse(Console.ReadLine(), out depositAmount))
                            {
                                userAccount.Deposit(depositAmount);
                            }
                            else
                            {
                                Console.WriteLine("Invalid input for deposit amount.");
                            }
                            break;

                        case 2:
                            Console.Write("Enter withdrawal amount: $");
                            decimal withdrawalAmount;
                            if (decimal.TryParse(Console.ReadLine(), out withdrawalAmount))
                            {
                                userAccount.Withdraw(withdrawalAmount);
                            }
                            else
                            {
                                Console.WriteLine("Invalid input for withdrawal amount.");
                            }
                            break;

                        case 3:
                            userAccount.CheckBalance();
                            break;

                        case 4:
                            Console.WriteLine("Exiting the program. Thank you!");
                            return;

                        default:
                            Console.WriteLine("Invalid choice. Please enter a number between 1 and 4.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                }
            }
        }
        else
        {
            Console.WriteLine("Invalid input for initial balance. Exiting the program.");
        }
    }
}