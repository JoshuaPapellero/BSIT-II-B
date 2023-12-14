using System;

class BankAccountProgram
{
    static void Main()
    {
        
        string accountHolderName = "Parts Gaw";
        double accountBalance = 1000.0;

        Console.Write("Enter the amount to deposit: ");
        double depositAmount = Convert.ToDouble(Console.ReadLine());

        
        accountBalance += depositAmount;

        
        Console.WriteLine($"Account Holder: {accountHolderName}");
        Console.WriteLine($"Account Balance: ${accountBalance}");

        
        if (accountBalance > 500)
        {
            Console.WriteLine("Your account is in good standing.");
        }
        
        else if (accountBalance >= 0)
        {
            Console.WriteLine("Your account balance is low.");
        }
        
        else
        {
            Console.WriteLine("Your account is overdrawn. Please deposit funds.");
        }

        
        Console.Write("Enter the amount to withdraw: ");
        double withdrawAmount = Convert.ToDouble(Console.ReadLine());

        
        accountBalance -= withdrawAmount;

        
        Console.WriteLine($"Updated Account Balance: ${accountBalance}");

        
        if (accountBalance <= 0 || accountBalance < 100)
        {
            Console.WriteLine("Warning: Low account balance.");
        }

        
        Console.Write("Select a transaction type (1: Deposit, 2: Withdraw): ");
        int transactionType = Convert.ToInt32(Console.ReadLine());

        switch (transactionType)
        {
            case 1:
                Console.Write("Enter the amount to deposit: ");
                double deposit = Convert.ToDouble(Console.ReadLine());
                accountBalance += deposit;
                Console.WriteLine($"Updated Account Balance: ${accountBalance}");
                break;
            case 2:
                Console.Write("Enter the amount to withdraw: ");
                double withdrawal = Convert.ToDouble(Console.ReadLine());
                accountBalance -= withdrawal;
                Console.WriteLine($"Updated Account Balance: ${accountBalance}");
                break;
            default:
                Console.WriteLine("Invalid transaction type.");
                break;
        }

        
        string accountStatus = (accountBalance > 0) ? "Active" : "Inactive";
        Console.WriteLine($"Account Status: {accountStatus}");

        
        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine($"Transaction {i + 1}: Completed");
        }

       
        for (int i = 0; i < 5; i++)
        {
            if (i == 3)
            {
                Console.WriteLine("Transaction limit reached. Exiting loop.");
                break; // Exit the loop when i is 3
            }

            Console.WriteLine($"Processing Transaction {i + 1}");
            if (i % 2 == 0)
            {
                continue; // Skip even-numbered transactions
            }
            Console.WriteLine("Transaction successful.");
        }
    }
}
