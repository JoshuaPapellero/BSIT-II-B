using System;

namespace Kent
{
    class Program
    {
        static double balance = 0;

        static void Main()
        {
            while (true)
            {
                Console.WriteLine("\n#########################");
                Console.WriteLine("#                         #");
                Console.WriteLine("#     WORLD BANK          #");
                Console.WriteLine("# 1. Check Balance        #");
                Console.WriteLine("# 2. Deposit              #");
                Console.WriteLine("# 3. Withdraw             #");
                Console.WriteLine("# 4. Exit                 #");
                Console.WriteLine("#                         #");
                Console.WriteLine("###########################");

                Console.Write("Enter your choice: ");
                int choice;
                if (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                    continue;
                }

                switch (choice)
                {
                    case 1:
                        DisplayBalance();
                        break;

                    case 2:
                        Deposit();
                        break;

                    case 3:
                        Withdraw();
                        break;

                    case 4:
                        Console.WriteLine("Exiting the banking system. Goodbye!");
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Please enter a number between 1 and 4.");
                        break;
                }

                if (choice == 4)
                    break;
            }
        }

        static void DisplayBalance()
        {
            Console.WriteLine($"Current Balance: ${balance}");
        }

        static void Deposit()
        {
            Console.Write("Enter deposit amount: $");
            double depositAmount;
            if (double.TryParse(Console.ReadLine(), out depositAmount) && depositAmount > 0)
            {
                balance += depositAmount;
                Console.WriteLine($"Deposited ${depositAmount}. Current Balance: ${balance}");
            }
            else
            {
                Console.WriteLine("Invalid deposit amount. Please enter a positive number.");
            }
        }

        static void Withdraw()
        {
            Console.Write("Enter withdrawal amount: $");
            double withdrawAmount;
            if (double.TryParse(Console.ReadLine(), out withdrawAmount) && withdrawAmount > 0)
            {
                balance = (withdrawAmount <= balance) ? (balance - withdrawAmount) : balance;
                Console.WriteLine($"Withdrawn ${withdrawAmount}. Current Balance: ${balance}");
            }
            else
            {
                Console.WriteLine("Invalid withdrawal amount. Please enter a positive number.");
            }
        }
    }
}