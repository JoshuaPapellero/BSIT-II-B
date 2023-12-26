using System;
namespace OOP_FinalProject
{
    class Program
    {
        static int option;
        static void Main(string[] args)
        {
            Console.Write("Enter name: ");
            string name = Console.ReadLine();

            string textToPrint = $"\nHello, {name}! Welcome to my Calculator Program!\n";
            for (int i = 0; i < textToPrint.Length; i++)
            {
                Console.Write(textToPrint[i]);
                Thread.Sleep(200);
            }

            while (true)
            {
                Console.WriteLine("\n---------------------------------------\n" +
                                  "-          1 - Addition               -\n" +
                                  "-          2 - Subtraction            -\n" +
                                  "-          3 - Multiplication         -\n" +
                                  "-          4 - Division               -\n" +
                                  "-          5 - Remainder              -\n" +
                                  "-          0 - Exit                   -\n" +
                                  "---------------------------------------");

                Console.Write("\nPlease choose operation:");
                int operation = Convert.ToInt32(Console.ReadLine());

                if (operation == 0)
                {
                    Console.WriteLine("Exiting the program...goodbyyee!");
                    Environment.Exit(0);
                }

                Console.Write("\nEnter number: ");
                int num1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("\nEnter number: ");
                int num2 = Convert.ToInt32(Console.ReadLine());

                switch (operation)
                {
                    case 1:
                        Addition(num1, num2);
                        break;
                    case 2:
                        Subtraction(num1, num2);
                        break;
                    case 3:
                        Multiplication(num1, num2);
                        break;
                    case 4:
                        Division(num1, num2);
                        break;
                    case 5:
                        Remainder(num1, num2);
                        break;
                    default:
                        Console.WriteLine("\nInvalid Input");
                        break;
                }

        static void Addition(int num1, int num2)
        {
            Console.WriteLine($"\nResult: {num1 + num2}\n");
            Console.Write($"\nResult: {num1 - num2}\n");

            Console.Write("\n1 - yes\n" + "2 - no\n" + "Do you want to operate again?: ");
            option = Convert.ToInt32(Console.ReadLine());

            if (option == 1)
            {
                Console.WriteLine();
            }
            else if (option == 2)
            {
                 Console.WriteLine("\nThank you for using the calculator");
                 Environment.Exit(0);
            }
            else
            {
                 Console.WriteLine("Invalid Input");
            }
        }
    }
}
        static void Subtraction(int num1, int num2)
        {
            Console.Write($"\nResult: {num1 - num2}\n");

            Console.Write("\n1 - yes\n" + "2 - no\n" + "Do you want to operate again?: ");
            option = Convert.ToInt32(Console.ReadLine());

            if (option == 1)
            {
                Console.WriteLine();
            }
            else if (option == 2)
            {
                Console.WriteLine("\nThank you for using the calculator");
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("Invalid Input");
            }
        }

        static void Multiplication(int num1, int num2)
        {
            Console.Write($"\nResult: {num1 * num2}\n");

            Console.Write("\n1 - yes\n" + "2 - no\n" + "Do you want to operate again?: ");
            option = Convert.ToInt32(Console.ReadLine());

            if (option == 1)
            {
                Console.WriteLine();
            }
            else if (option == 2)
            {
                Console.WriteLine("\nThank you for using the calculator");
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("Invalid Input");
            }
        }

        static void Division(int num1, int num2)
        {
            if (num2 != 0)
            {
                Console.WriteLine($"\nResult: {num1 / num2}\n");
            }
            else
            {
                Console.WriteLine("\nCannot divide by zero.");
            }

            Console.Write("\n1 - yes\n" + "2 - no\n" + "Do you want to operate again?: ");
            option = Convert.ToInt32(Console.ReadLine());

            if (option == 1)
            {
                Console.WriteLine();
            }
            else if (option == 2)
            {
                Console.WriteLine("\nThank you for using the calculator");
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("Invalid Input");
            }
        }

        static void Remainder(int num1, int num2)
        {
            if (num2 != 0)
            {
                Console.WriteLine($"\nResult: {num1 % num2}\n");
            }
            else
            {
                Console.WriteLine("\nCannot compute remainder with zero.");
            }

            Console.Write("\n1 - yes\n" + "2 - no\n" + "Do you want to operate again?: ");
            option = Convert.ToInt32(Console.ReadLine());

            if (option == 1)
            {
                Console.WriteLine();
            }
            else if (option == 2)
            {
                Console.WriteLine("\nThank you for using the calculator");
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("Invalid Input");
            }
        }
    }
}
