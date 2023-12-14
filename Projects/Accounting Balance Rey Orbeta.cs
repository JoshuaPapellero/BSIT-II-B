using System;

namespace AccountingIncomeStatementandBalancesheet
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(@"Welcome to Basic Accounting Program
----------------------------------------------
Enter Accountants Name: ");
            string name = Console.ReadLine();
            Console.WriteLine(@"Accountant: "+name+" " +
                "   ");
            Console.WriteLine(@"             Income Statement
");
            Console.WriteLine("Enter Business Name: ");
            string businessname = Console.ReadLine();
            Console.WriteLine("Enter Year");
            int year = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Month");
            string month = Console.ReadLine();
            Console.WriteLine("Enter total service income: ");
            double serviceincome = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter 1st expense:");
            string expense = Console.ReadLine();
            Console.WriteLine("Enter amount:");
            double amount = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter 2nd expense:");
            string expense1 = Console.ReadLine();
            Console.WriteLine("Enter amount:");
            double amount1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter 3rd expense:");
            string expense2 = Console.ReadLine();
            Console.WriteLine("Enter amount:");
            double amount2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter 4th expense:");
            string expense3 = Console.ReadLine();
            Console.WriteLine("Enter amount:");
            double amount3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter 5th expense:");
            string expense4 = Console.ReadLine();
            Console.WriteLine("Enter amount:");
            double amount4= Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\t      "+businessname+"\n                    Income Statement");
            Console.WriteLine("\t      "+month+" "+year);
            Console.WriteLine(@"______________________________________________________________
Revenues:");
            Console.WriteLine("\t                         P "+serviceincome);
            Console.WriteLine("Less: Operating Expenses\n" + expense + " P" + amount + "\n"+expense1+" "+amount1+"\n"+expense2+" "+amount2+"\n"+expense3+" "+amount3+"\n"+expense4+" "+amount4);
            double totalexpense=amount+amount1+amount2+amount3+amount4;
            Console.WriteLine("\t                           " + totalexpense+"\n-------------------------------------------");
            double netincome = serviceincome - totalexpense;
            Console.WriteLine(@"Net Income                         " + netincome+ "\n-------------------------------------------");
            if(netincome > 0)
            {
                Console.WriteLine("You Earned a  Profit");
            }
            else
            {
                Console.WriteLine("You Have Decreased a Profit");
            }
            Console.WriteLine("\t Balance Sheet "+ "\n-------------------------------------------");
            Console.WriteLine("Enter Assets:");
            string asset = Console.ReadLine();
            Console.WriteLine("Enter Amount: ");
            double assetamount = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Assets: ");
            string asset1 = Console.ReadLine();
            Console.WriteLine("Enter Amount: ");
            double assetamount1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Assets: ");
            string asset2 = Console.ReadLine();
            Console.WriteLine("Enter Amount: ");
            double assetamount2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Accounts payable: ");
            double accountspayable = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Total Capital: ");
            double capital = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Total Drawing: ");
            double drawing = Convert.ToDouble(Console.ReadLine());
            double netcapital = capital - drawing;
            double totalasset = assetamount+assetamount1+assetamount2;
            double totalproprietorship = netincome + netcapital;
            double totallp = totalproprietorship + accountspayable;
            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine("\t "+businessname);
            Console.WriteLine("\t Balance Sheet");
            Console.WriteLine("as of "+month+" "+year);
            Console.WriteLine("Assets                                                       Liabilities");
            Console.WriteLine("  "+asset+" "+assetamount+"                                     Accounts Payable:P"+accountspayable);
            Console.WriteLine("  "+asset1+" "+assetamount1+"                                 Total Liabilities  :                   P"+accountspayable);
            Console.WriteLine("  "+asset2+" "+assetamount2+"                                 Proprietorship");
            Console.WriteLine("                                                               "+name+",Capital P"+capital);
            Console.WriteLine("                                                           Less"+name+",Drawing  "+drawing);
            Console.WriteLine("                                                                                 _____________");
            Console.WriteLine("                                                              Net Capital:       "+netcapital);
            Console.WriteLine("                                                          Add:Net Income :       "+netincome);
            Console.WriteLine("                                                                                 _____________");
            Console.WriteLine("                                                               Total Proprietorship:                  " + totalproprietorship);
            Console.WriteLine("_________________                                                                                     ________________________");
            Console.WriteLine("Total Asset:"+totalasset+"                                    Total Liabilites and Proprietorship     "+totallp);
            if (totalasset == totallp)
            {
                Console.WriteLine("Balanced");
            }
            else
            {
                Console.WriteLine("Not Balanced");
            }
            Console.WriteLine(@"__________________________________________________________________
The Code is upgradable until the programmer has earned enough knowledge to continue!!
");
            Console.WriteLine("Rate my Program \n1. Very Satisfied \n2. Satisfied \n3. Neutral\n4. Not Satisfied\n5. No Answer");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch(choice)
            {
                case 1: Console.WriteLine("Very Satisfied");
                    break;
                    case 2: Console.WriteLine("Satisfied");
                    break;
                    case 3: Console.WriteLine("Neutral");
                    break;
                    case 4: Console.WriteLine("Not Satisfied");
                    break;
                default: Console.WriteLine("No Answer");
                    break;
            }
            string satisfaction = choice == 1 ? "Thank you" : "Thanks";
            string unsatisfied = choice > 2 ? "I'll do my best" : "Sorry :<";
            Console.WriteLine(satisfaction);
            Console.WriteLine(unsatisfied);     
        }
    }
}