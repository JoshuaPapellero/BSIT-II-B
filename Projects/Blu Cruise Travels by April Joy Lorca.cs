using System;

namespace LORCA
{
    class Program
    {
        static double ticketPrice = 0;
        static int people;
        static void Main()
        {
            Console.WriteLine(" _____________________________________ ");
            Console.WriteLine("|                                     |");
            Console.WriteLine("|                                     |");
            Console.WriteLine("|    WELCOME TO BLU CRUISE TRAVELS    |");
            Console.WriteLine("|                                     |");
            Console.WriteLine("|_____________________________________|\n");

            Console.Write("Please enter your fullname: ");
            string fullname = Console.ReadLine();

            Console.WriteLine("\nGreetings! " + fullname + ". Here is the list of our travel options.");

            while (true)
            {
                Console.WriteLine(" ____________________________________________");
                Console.WriteLine("|                                            |");
                Console.WriteLine("|             BOOK YOUR TRIP NOW             |");
                Console.WriteLine("|                                            |");
                Console.WriteLine("| Where do you wanna travel?                 |");
                Console.WriteLine("|                                            |");
                Console.WriteLine("| 1. Domestic                                |");
                Console.WriteLine("| 2. International                           |");
                Console.WriteLine("| 3. Exit                                    |");
                Console.WriteLine("|____________________________________________|\n");

                Console.Write("Domestic or International Trip: ");
                int trip = Convert.ToInt32(Console.ReadLine());

                if(trip == 1)
                {
                    Console.WriteLine(" ____________________________________________");
                    Console.WriteLine("|                                            |");
                    Console.WriteLine("|           EXPLORE THE PHILIPPINES          |");
                    Console.WriteLine("|                                            |");
                    Console.WriteLine("| Where do you wanna go?                     |");
                    Console.WriteLine("|                                            |");
                    Console.WriteLine("| 1. Siargao                                 |");
                    Console.WriteLine("| 2. Palawan                                 |");
                    Console.WriteLine("| 3. Cebu                                    |");
                    Console.WriteLine("| 4. Cancel Booking                          |");
                    Console.WriteLine("|____________________________________________|\n");

                    Console.Write("Enter your destination: ");
                    int province = Convert.ToInt32(Console.ReadLine());

                    switch (province)
                    {
                        case 1:
                            Siargao();
                            break;
                        case 2:
                            Palawan();
                            break;
                        case 3:
                            Cebu();
                            break;
                        case 4:
                            Console.WriteLine($"Booking Cancelled. -_-");
                            Console.WriteLine($"Until next time.");
                            break;
                        default:
                            Console.WriteLine("\nInvalid Choice. Please enter 1 to 4 only.");
                            break;
                    }
                }
                else if(trip == 2)
                {
                    Console.WriteLine(" ____________________________________________");
                    Console.WriteLine("|                                            |");
                    Console.WriteLine("|           TRAVEL THE WORLD WITH US         |");
                    Console.WriteLine("|                                            |");
                    Console.WriteLine("| Where do you wanna go?                     |");
                    Console.WriteLine("|                                            |");
                    Console.WriteLine("| 1. Thailand                                |");
                    Console.WriteLine("| 2. Japan                                   |");
                    Console.WriteLine("| 3. Indonesia                               |");
                    Console.WriteLine("| 4. Italy                                   |");
                    Console.WriteLine("| 5. France                                  |");
                    Console.WriteLine("| 6. Greece                                  |");
                    Console.WriteLine("| 7. Fiji                                    |");
                    Console.WriteLine("| 8. Maldives                                |");
                    Console.WriteLine("| 9. Bermuda                                 |");
                    Console.WriteLine("| 10. Cancel Booking                         |");
                    Console.WriteLine("|____________________________________________|\n");

                    Console.Write("Enter your destination: ");
                    int country = Convert.ToInt32(Console.ReadLine());

                    switch (country)
                    {
                        case 1:
                            Thailand();
                            break;
                        case 2:
                            Japan();
                            break;
                        case 3:
                            Indonesia();
                            break;
                        case 4:
                            Italy();
                            break;
                        case 5:
                            France();
                            break;
                        case 6:
                            Greece();
                            break;
                        case 7:
                            Fiji();
                            break;
                        case 8:
                            Maldives();
                            break;
                        case 9:
                            Bermuda();
                            break;
                        case 10:
                            Console.WriteLine($"Booking Cancelled. -_-");
                            Console.WriteLine($"Until next time.");
                            break;
                        default:
                            Console.WriteLine("\nInvalid Choice. Please enter 1 to 4 only.");
                            break;
                    }
                }
                else if(trip == 3)
                {
                    break;
                }
                else 
                {
                    Console.WriteLine("\nService does not exist.\n" + "Enter a valid number.");
                    continue;
                }
            }
        }
        static void Siargao()
        {
            ticketPrice = 6499.0;

            Console.WriteLine("The price for a cruise trip to Siargao is P" + ticketPrice + "\n");

            Console.Write("\nEnter the number of people for the trip: ");
            people = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nEnter how many days it will be from today: ");
            int date = Convert.ToInt32(Console.ReadLine());

            double amountPayable = ticketPrice * people;

            if(people == 1 || people == 2) 
            {
                Console.WriteLine("\nYour trip is in " + date + " days.");
                Console.WriteLine("\nThe total price for your cruise trip to Siargao is: P" + amountPayable);

                Console.WriteLine(" ______________________________________________ ");
                Console.WriteLine("|                                              |");
                Console.WriteLine("|   Thank you for choosing to travel with us!  |");
                Console.WriteLine("|                                              |");
                Console.WriteLine("|                 See you soon. :)             |");
                Console.WriteLine("|______________________________________________|");
            }
            else if (people >= 3 && people <= 7)
            {
                Console.WriteLine("\nWow! You have book a trip with more than 2 people.");
                Console.WriteLine($"You are now eligible for our 7% off your total trip price.");

                double discounted = amountPayable * 0.93;

                Console.WriteLine("\nYour trip is in " + date + " days.");
                Console.WriteLine("\nThe total price for your cruise trip to Siargao is: P" + discounted);

                Console.WriteLine(" ______________________________________________ ");
                Console.WriteLine("|                                              |");
                Console.WriteLine("|   Thank you for choosing to travel with us!  |");
                Console.WriteLine("|                                              |");
                Console.WriteLine("|                 See you soon. :)             |");
                Console.WriteLine("|______________________________________________|");
            }
            else if (people >= 8)
            {
                Console.WriteLine("\nWow! You have book a trip with more than 7 people.");
                Console.WriteLine($"You are now eligible for our 15% off your total trip price.");

                double discounted = amountPayable * 0.85;

                Console.WriteLine("\nYour trip is in " + date + " days.");
                Console.WriteLine("\nThe total price for your cruise trip to Siargao is: P" + discounted);

                Console.WriteLine(" ______________________________________________ ");
                Console.WriteLine("|                                              |");
                Console.WriteLine("|   Thank you for choosing to travel with us!  |");
                Console.WriteLine("|                                              |");
                Console.WriteLine("|                 See you soon. :)             |");
                Console.WriteLine("|______________________________________________|");
            }
            else
            {
                Console.WriteLine("Invalid response. Please start over again.");

                Main();
                return;
            }

        }
        static void Cebu()
        {
            ticketPrice = 4799.0;

            Console.WriteLine("The price for a cruise trip to Cebu is P" + ticketPrice + "\n");

            Console.Write("\nEnter the number of people for the trip: ");
            people = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nEnter how many days it will be from today: ");
            int date = Convert.ToInt32(Console.ReadLine());

            double amountPayable = ticketPrice * people;

            if (people == 1 || people == 2)
            {
                Console.WriteLine("\nYour trip is in " + date + " days.");
                Console.WriteLine("\nThe total price for your cruise trip to Cebu is: P" + amountPayable);

                Console.WriteLine(" ______________________________________________ ");
                Console.WriteLine("|                                              |");
                Console.WriteLine("|   Thank you for choosing to travel with us!  |");
                Console.WriteLine("|                                              |");
                Console.WriteLine("|                 See you soon. :)             |");
                Console.WriteLine("|______________________________________________|\n");
            }
            else if (people >= 3 && people <= 7)
            {
                Console.WriteLine("\nWow! You have book a trip with more than 2 people.");
                Console.WriteLine($"You are now eligible for our 7% off your total trip price.");

                double discounted = amountPayable * 0.93;

                Console.WriteLine("\nYour trip is in " + date + " days.");
                Console.WriteLine("\nThe total price for your cruise trip to Cebu is: P" + discounted);

                Console.WriteLine(" ______________________________________________ ");
                Console.WriteLine("|                                              |");
                Console.WriteLine("|   Thank you for choosing to travel with us!  |");
                Console.WriteLine("|                                              |");
                Console.WriteLine("|                 See you soon. :)             |");
                Console.WriteLine("|______________________________________________|");
            }
            else if (people >= 8)
            {
                Console.WriteLine("\nWow! You have book a trip with more than 7 people.");
                Console.WriteLine($"You are now eligible for our 15% off your total trip price.");

                double discounted = amountPayable * 0.85;

                Console.WriteLine("\nYour trip is in " + date + " days.");
                Console.WriteLine("\nThe total price for your cruise trip to Cebu is: P" + discounted);

                Console.WriteLine(" ______________________________________________ ");
                Console.WriteLine("|                                              |");
                Console.WriteLine("|   Thank you for choosing to travel with us!  |");
                Console.WriteLine("|                                              |");
                Console.WriteLine("|                 See you soon. :)             |");
                Console.WriteLine("|______________________________________________|");
            }
            else
            {
                Console.WriteLine("Invalid response. Please start over again.");

                Main();
                return;
            }

        }
        static void Palawan()
        {
            ticketPrice = 10699.0;

            Console.WriteLine("The price for a cruise trip to Palawan is P" + ticketPrice + "\n");

            Console.Write("\nEnter the number of people for the trip: ");
            people = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nEnter how many days it will be from today: ");
            int date = Convert.ToInt32(Console.ReadLine());

            double amountPayable = ticketPrice * people;

            if (people == 1 || people == 2)
            {
                Console.WriteLine("\nYour trip is in " + date + " days.");
                Console.WriteLine("\nThe total price for your cruise trip to Palawan is: P" + amountPayable);

                Console.WriteLine(" ______________________________________________ ");
                Console.WriteLine("|                                              |");
                Console.WriteLine("|   Thank you for choosing to travel with us!  |");
                Console.WriteLine("|                                              |");
                Console.WriteLine("|                 See you soon. :)             |");
                Console.WriteLine("|______________________________________________|\n");
            }
            else if (people >= 3 && people <= 7)
            {
                Console.WriteLine("\nWow! You have book a trip with more than 2 people.");
                Console.WriteLine($"You are now eligible for our 7% off your total trip price.");

                double discounted = amountPayable * 0.93;

                Console.WriteLine("\nYour trip is in " + date + " days.");
                Console.WriteLine("\nThe total price for your cruise trip to Palawan is: P" + discounted);

                Console.WriteLine(" ______________________________________________ ");
                Console.WriteLine("|                                              |");
                Console.WriteLine("|   Thank you for choosing to travel with us!  |");
                Console.WriteLine("|                                              |");
                Console.WriteLine("|                 See you soon. :)             |");
                Console.WriteLine("|______________________________________________|");
            }
            else if (people >= 8)
            {
                Console.WriteLine("\nWow! You have book a trip with more than 7 people.");
                Console.WriteLine($"You are now eligible for our 15% off your total trip price.");

                double discounted = amountPayable * 0.85;

                Console.WriteLine("\nYour trip is in " + date + " days.");
                Console.WriteLine("\nThe total price for your cruise trip to Palawan is: P" + discounted);

                Console.WriteLine(" ______________________________________________ ");
                Console.WriteLine("|                                              |");
                Console.WriteLine("|   Thank you for choosing to travel with us!  |");
                Console.WriteLine("|                                              |");
                Console.WriteLine("|                 See you soon. :)             |");
                Console.WriteLine("|______________________________________________|");
            }
            else
            {
                Console.WriteLine("Invalid response. Please start over again.");

                Main();
                return;
            }

        }
        static void Thailand()
        {
            ticketPrice = 74599.0;

            Console.WriteLine("The price for a cruise trip to Thailand is P" + ticketPrice + "\n");

            Console.Write("\nEnter the number of people for the trip: ");
            people = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nEnter how many days it will be from today: ");
            int date = Convert.ToInt32(Console.ReadLine());

            double amountPayable = ticketPrice * people;

            if (people == 1 || people == 2)
            {
                Console.WriteLine("\nYour trip is in " + date + " days.");
                Console.WriteLine("\nThe total price for your cruise trip to Thailand is: P" + amountPayable);

                Console.WriteLine(" ______________________________________________ ");
                Console.WriteLine("|                                              |");
                Console.WriteLine("|   Thank you for choosing to travel with us!  |");
                Console.WriteLine("|                                              |");
                Console.WriteLine("|                 See you soon. :)             |");
                Console.WriteLine("|______________________________________________|");
            }
            else if (people >= 3 && people <= 7)
            {
                Console.WriteLine("\nWow! You have book a trip with more than 2 people.");
                Console.WriteLine($"You are now eligible for our 10% off your total trip price.");

                double discounted = amountPayable * 0.90;

                Console.WriteLine("\nYour trip is in " + date + " days.");
                Console.WriteLine("\nThe total price for your cruise trip to Thailand is: P" + discounted);

                Console.WriteLine(" ______________________________________________ ");
                Console.WriteLine("|                                              |");
                Console.WriteLine("|   Thank you for choosing to travel with us!  |");
                Console.WriteLine("|                                              |");
                Console.WriteLine("|                 See you soon. :)             |");
                Console.WriteLine("|______________________________________________|");
            }
            else if (people >= 8)
            {
                Console.WriteLine("\nWow! You have book a trip with more than 7 people.");
                Console.WriteLine($"You are now eligible for our 25% off your total trip price.");

                double discounted = amountPayable * 0.75;

                Console.WriteLine("\nYour trip is in " + date + " days.");
                Console.WriteLine("\nThe total price for your cruise trip to Thailand is: P" + discounted);

                Console.WriteLine(" ______________________________________________ ");
                Console.WriteLine("|                                              |");
                Console.WriteLine("|   Thank you for choosing to travel with us!  |");
                Console.WriteLine("|                                              |");
                Console.WriteLine("|                 See you soon. :)             |");
                Console.WriteLine("|______________________________________________|");
            }
            else
            {
                Console.WriteLine("Invalid response. Please start over again.");

                Main();
                return;
            }

        }
        static void Japan()
        {
            ticketPrice = 80299.0;

            Console.WriteLine("The price for a cruise trip to Japan is P" + ticketPrice + "\n");

            Console.Write("\nEnter the number of people for the trip: ");
            people = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nEnter how many days it will be from today: ");
            int date = Convert.ToInt32(Console.ReadLine());

            double amountPayable = ticketPrice * people;

            if (people == 1 || people == 2)
            {
                Console.WriteLine("\nYour trip is in " + date + " days.");
                Console.WriteLine("\nThe total price for your cruise trip to Japan is: P" + amountPayable);

                Console.WriteLine(" ______________________________________________ ");
                Console.WriteLine("|                                              |");
                Console.WriteLine("|   Thank you for choosing to travel with us!  |");
                Console.WriteLine("|                                              |");
                Console.WriteLine("|                 See you soon. :)             |");
                Console.WriteLine("|______________________________________________|");
            }
            else if (people >= 3 && people <= 7)
            {
                Console.WriteLine("\nWow! You have book a trip with more than 2 people.");
                Console.WriteLine($"You are now eligible for our 10% off your total trip price.");

                double discounted = amountPayable * 0.90;

                Console.WriteLine("\nYour trip is in " + date + " days.");
                Console.WriteLine("\nThe total price for your cruise trip to Japan is: P" + discounted);

                Console.WriteLine(" ______________________________________________ ");
                Console.WriteLine("|                                              |");
                Console.WriteLine("|   Thank you for choosing to travel with us!  |");
                Console.WriteLine("|                                              |");
                Console.WriteLine("|                 See you soon. :)             |");
                Console.WriteLine("|______________________________________________|");
            }
            else if (people >= 8)
            {
                Console.WriteLine("\nWow! You have book a trip with more than 7 people.");
                Console.WriteLine($"You are now eligible for our 25% off your total trip price.");

                double discounted = amountPayable * 0.75;

                Console.WriteLine("\nYour trip is in " + date + " days.");
                Console.WriteLine("\nThe total price for your cruise trip to Japan is: P" + discounted);

                Console.WriteLine(" ______________________________________________ ");
                Console.WriteLine("|                                              |");
                Console.WriteLine("|   Thank you for choosing to travel with us!  |");
                Console.WriteLine("|                                              |");
                Console.WriteLine("|                 See you soon. :)             |");
                Console.WriteLine("|______________________________________________|");
            }
            else
            {
                Console.WriteLine("Invalid response. Please start over again.");

                Main();
                return;
            }

        }
        static void Indonesia()
        {
            ticketPrice = 65199.0;

            Console.WriteLine("The price for a cruise trip to Indonesia is P" + ticketPrice + "\n");

            Console.Write("\nEnter the number of people for the trip: ");
            people = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nEnter how many days it will be from today: ");
            int date = Convert.ToInt32(Console.ReadLine());

            double amountPayable = ticketPrice * people;

            if (people == 1 || people == 2)
            {
                Console.WriteLine("\nYour trip is in " + date + " days.");
                Console.WriteLine("\nThe total price for your cruise trip to Indonesia is: P" + amountPayable);

                Console.WriteLine(" ______________________________________________ ");
                Console.WriteLine("|                                              |");
                Console.WriteLine("|   Thank you for choosing to travel with us!  |");
                Console.WriteLine("|                                              |");
                Console.WriteLine("|                 See you soon. :)             |");
                Console.WriteLine("|______________________________________________|");
            }
            else if (people >= 3 && people <= 7)
            {
                Console.WriteLine("\nWow! You have book a trip with more than 2 people.");
                Console.WriteLine($"You are now eligible for our 10% off your total trip price.");

                double discounted = amountPayable * 0.90;

                Console.WriteLine("\nYour trip is in " + date + " days.");
                Console.WriteLine("\nThe total price for your cruise trip to Indonesia is: P" + discounted);

                Console.WriteLine(" ______________________________________________ ");
                Console.WriteLine("|                                              |");
                Console.WriteLine("|   Thank you for choosing to travel with us!  |");
                Console.WriteLine("|                                              |");
                Console.WriteLine("|                 See you soon. :)             |");
                Console.WriteLine("|______________________________________________|");
            }
            else if (people >= 8)
            {
                Console.WriteLine("\nWow! You have book a trip with more than 7 people.");
                Console.WriteLine($"You are now eligible for our 25% off your total trip price.");

                double discounted = amountPayable * 0.75;

                Console.WriteLine("\nYour trip is in " + date + " days.");
                Console.WriteLine("\nThe total price for your cruise trip to Indonesia is: P" + discounted);

                Console.WriteLine(" ______________________________________________ ");
                Console.WriteLine("|                                              |");
                Console.WriteLine("|   Thank you for choosing to travel with us!  |");
                Console.WriteLine("|                                              |");
                Console.WriteLine("|                 See you soon. :)             |");
                Console.WriteLine("|______________________________________________|");
            }
            else
            {
                Console.WriteLine("Invalid response. Please start over again.");

                Main();
                return;
            }

        }
        static void Italy()
        {
            ticketPrice = 90799.0;

            Console.WriteLine("The price for a cruise trip to Italy is P" + ticketPrice + "\n");

            Console.Write("\nEnter the number of people for the trip: ");
            people = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nEnter how many days it will be from today: ");
            int date = Convert.ToInt32(Console.ReadLine());

            double amountPayable = ticketPrice * people;

            if (people == 1 || people == 2)
            {
                Console.WriteLine("\nYour trip is in " + date + " days.");
                Console.WriteLine("\nThe total price for your cruise trip to Italy is: P" + amountPayable);

                Console.WriteLine(" ______________________________________________ ");
                Console.WriteLine("|                                              |");
                Console.WriteLine("|   Thank you for choosing to travel with us!  |");
                Console.WriteLine("|                                              |");
                Console.WriteLine("|                 See you soon. :)             |");
                Console.WriteLine("|______________________________________________|");
            }
            else if (people >= 3 && people <= 7)
            {
                Console.WriteLine("\nWow! You have book a trip with more than 2 people.");
                Console.WriteLine($"You are now eligible for our 10% off your total trip price.");

                double discounted = amountPayable * 0.90;

                Console.WriteLine("\nYour trip is in " + date + " days.");
                Console.WriteLine("\nThe total price for your cruise trip to Italy is: P" + discounted);

                Console.WriteLine(" ______________________________________________ ");
                Console.WriteLine("|                                              |");
                Console.WriteLine("|   Thank you for choosing to travel with us!  |");
                Console.WriteLine("|                                              |");
                Console.WriteLine("|                 See you soon. :)             |");
                Console.WriteLine("|______________________________________________|");
            }
            else if (people >= 8)
            {
                Console.WriteLine("\nWow! You have book a trip with more than 7 people.");
                Console.WriteLine($"You are now eligible for our 25% off your total trip price.");

                double discounted = amountPayable * 0.75;

                Console.WriteLine("\nYour trip is in " + date + " days.");
                Console.WriteLine("\nThe total price for your cruise trip to Italy is: P" + discounted);

                Console.WriteLine(" ______________________________________________ ");
                Console.WriteLine("|                                              |");
                Console.WriteLine("|   Thank you for choosing to travel with us!  |");
                Console.WriteLine("|                                              |");
                Console.WriteLine("|                 See you soon. :)             |");
                Console.WriteLine("|______________________________________________|");
            }
            else
            {
                Console.WriteLine("Invalid response. Please start over again.");

                Main();
                return;
            }

        }
        static void France()
        {
            ticketPrice = 82279.0;

            Console.WriteLine("The price for a cruise trip to France is P" + ticketPrice + "\n");

            Console.Write("\nEnter the number of people for the trip: ");
            people = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nEnter how many days it will be from today: ");
            int date = Convert.ToInt32(Console.ReadLine());

            double amountPayable = ticketPrice * people;

            if (people == 1 || people == 2)
            {
                Console.WriteLine("\nYour trip is in " + date + " days.");
                Console.WriteLine("\nThe total price for your cruise trip to France is: P" + amountPayable);

                Console.WriteLine(" ______________________________________________ ");
                Console.WriteLine("|                                              |");
                Console.WriteLine("|   Thank you for choosing to travel with us!  |");
                Console.WriteLine("|                                              |");
                Console.WriteLine("|                 See you soon. :)             |");
                Console.WriteLine("|______________________________________________|");
            }
            else if (people >= 3 && people <= 7)
            {
                Console.WriteLine("\nWow! You have book a trip with more than 2 people.");
                Console.WriteLine($"You are now eligible for our 10% off your total trip price.");

                double discounted = amountPayable * 0.90;

                Console.WriteLine("\nYour trip is in " + date + " days.");
                Console.WriteLine("\nThe total price for your cruise trip to France is: P" + discounted);

                Console.WriteLine(" ______________________________________________ ");
                Console.WriteLine("|                                              |");
                Console.WriteLine("|   Thank you for choosing to travel with us!  |");
                Console.WriteLine("|                                              |");
                Console.WriteLine("|                 See you soon. :)             |");
                Console.WriteLine("|______________________________________________|");
            }
            else if (people >= 8)
            {
                Console.WriteLine("\nWow! You have book a trip with more than 7 people.");
                Console.WriteLine($"You are now eligible for our 25% off your total trip price.");

                double discounted = amountPayable * 0.75;

                Console.WriteLine("\nYour trip is in " + date + " days.");
                Console.WriteLine("\nThe total price for your cruise trip to France is: P" + discounted);

                Console.WriteLine(" ______________________________________________ ");
                Console.WriteLine("|                                              |");
                Console.WriteLine("|   Thank you for choosing to travel with us!  |");
                Console.WriteLine("|                                              |");
                Console.WriteLine("|                 See you soon. :)             |");
                Console.WriteLine("|______________________________________________|");
            }
            else
            {
                Console.WriteLine("Invalid response. Please start over again.");

                Main();
                return;
            }

        }
        static void Greece()
        {
            ticketPrice = 90999.0;

            Console.WriteLine("The price for a cruise trip to Greece is P" + ticketPrice + "\n");

            Console.Write("\nEnter the number of people for the trip: ");
            people = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nEnter how many days it will be from today: ");
            int date = Convert.ToInt32(Console.ReadLine());

            double amountPayable = ticketPrice * people;

            if (people == 1 || people == 2)
            {
                Console.WriteLine("\nYour trip is in " + date + " days.");
                Console.WriteLine("\nThe total price for your cruise trip to Greece is: P" + amountPayable);

                Console.WriteLine(" ______________________________________________ ");
                Console.WriteLine("|                                              |");
                Console.WriteLine("|   Thank you for choosing to travel with us!  |");
                Console.WriteLine("|                                              |");
                Console.WriteLine("|                 See you soon. :)             |");
                Console.WriteLine("|______________________________________________|");
            }
            else if (people >= 3 && people <= 7)
            {
                Console.WriteLine("\nWow! You have book a trip with more than 2 people.");
                Console.WriteLine($"You are now eligible for our 10% off your total trip price.");

                double discounted = amountPayable * 0.90;

                Console.WriteLine("\nYour trip is in " + date + " days.");
                Console.WriteLine("\nThe total price for your cruise trip to Greece is: P" + discounted);

                Console.WriteLine(" ______________________________________________ ");
                Console.WriteLine("|                                              |");
                Console.WriteLine("|   Thank you for choosing to travel with us!  |");
                Console.WriteLine("|                                              |");
                Console.WriteLine("|                 See you soon. :)             |");
                Console.WriteLine("|______________________________________________|");
            }
            else if (people >= 8)
            {
                Console.WriteLine("\nWow! You have book a trip with more than 7 people.");
                Console.WriteLine($"You are now eligible for our 25% off your total trip price.");

                double discounted = amountPayable * 0.75;

                Console.WriteLine("\nYour trip is in " + date + " days.");
                Console.WriteLine("\nThe total price for your cruise trip to Greece is: P" + discounted);

                Console.WriteLine(" ______________________________________________ ");
                Console.WriteLine("|                                              |");
                Console.WriteLine("|   Thank you for choosing to travel with us!  |");
                Console.WriteLine("|                                              |");
                Console.WriteLine("|                 See you soon. :)             |");
                Console.WriteLine("|______________________________________________|");
            }
            else
            {
                Console.WriteLine("Invalid response. Please start over again.");

                Main();
                return;
            }

        }
        static void Fiji()
        {
            ticketPrice = 91769.0;

            Console.WriteLine("The price for a cruise trip to Fiji is P" + ticketPrice + "\n");

            Console.Write("\nEnter the number of people for the trip: ");
            people = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nEnter how many days it will be from today: ");
            int date = Convert.ToInt32(Console.ReadLine());

            double amountPayable = ticketPrice * people;

            if (people == 1 || people == 2)
            {
                Console.WriteLine("\nYour trip is in " + date + " days.");
                Console.WriteLine("\nThe total price for your cruise trip to Fiji is: P" + amountPayable);

                Console.WriteLine(" ______________________________________________ ");
                Console.WriteLine("|                                              |");
                Console.WriteLine("|   Thank you for choosing to travel with us!  |");
                Console.WriteLine("|                                              |");
                Console.WriteLine("|                 See you soon. :)             |");
                Console.WriteLine("|______________________________________________|");
            }
            else if (people >= 3 && people <= 7)
            {
                Console.WriteLine("\nWow! You have book a trip with more than 2 people.");
                Console.WriteLine($"You are now eligible for our 10% off your total trip price.");

                double discounted = amountPayable * 0.90;

                Console.WriteLine("\nYour trip is in " + date + " days.");
                Console.WriteLine("\nThe total price for your cruise trip to Fiji is: P" + discounted);

                Console.WriteLine(" ______________________________________________ ");
                Console.WriteLine("|                                              |");
                Console.WriteLine("|   Thank you for choosing to travel with us!  |");
                Console.WriteLine("|                                              |");
                Console.WriteLine("|                 See you soon. :)             |");
                Console.WriteLine("|______________________________________________|");
            }
            else if (people >= 8)
            {
                Console.WriteLine("\nWow! You have book a trip with more than 7 people.");
                Console.WriteLine($"You are now eligible for our 25% off your total trip price.");

                double discounted = amountPayable * 0.75;

                Console.WriteLine("\nYour trip is in " + date + " days.");
                Console.WriteLine("\nThe total price for your cruise trip to Fiji is: P" + discounted);

                Console.WriteLine(" ______________________________________________ ");
                Console.WriteLine("|                                              |");
                Console.WriteLine("|   Thank you for choosing to travel with us!  |");
                Console.WriteLine("|                                              |");
                Console.WriteLine("|                 See you soon. :)             |");
                Console.WriteLine("|______________________________________________|");
            }
            else
            {
                Console.WriteLine("Invalid response. Please start over again.");

                Main();
                return;
            }

        }
        static void Maldives()
        {
            ticketPrice = 95888.0;

            Console.WriteLine("The price for a cruise trip to Maldives is P" + ticketPrice + "\n");

            Console.Write("\nEnter the number of people for the trip: ");
            people = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nEnter how many days it will be from today: ");
            int date = Convert.ToInt32(Console.ReadLine());

            double amountPayable = ticketPrice * people;

            if (people == 1 || people == 2)
            {
                Console.WriteLine("\nYour trip is in " + date + " days.");
                Console.WriteLine("\nThe total price for your cruise trip to Maldives is: P" + amountPayable);

                Console.WriteLine(" ______________________________________________ ");
                Console.WriteLine("|                                              |");
                Console.WriteLine("|   Thank you for choosing to travel with us!  |");
                Console.WriteLine("|                                              |");
                Console.WriteLine("|                 See you soon. :)             |");
                Console.WriteLine("|______________________________________________|");
            }
            else if (people >= 3 && people <= 7)
            {
                Console.WriteLine("\nWow! You have book a trip with more than 2 people.");
                Console.WriteLine($"You are now eligible for our 10% off your total trip price.");

                double discounted = amountPayable * 0.90;

                Console.WriteLine("\nYour trip is in " + date + " days.");
                Console.WriteLine("\nThe total price for your cruise trip to Maldives is: P" + discounted);

                Console.WriteLine(" ______________________________________________ ");
                Console.WriteLine("|                                              |");
                Console.WriteLine("|   Thank you for choosing to travel with us!  |");
                Console.WriteLine("|                                              |");
                Console.WriteLine("|                 See you soon. :)             |");
                Console.WriteLine("|______________________________________________|");
            }
            else if (people >= 8)
            {
                Console.WriteLine("\nWow! You have book a trip with more than 7 people.");
                Console.WriteLine($"You are now eligible for our 25% off your total trip price.");

                double discounted = amountPayable * 0.75;

                Console.WriteLine("\nYour trip is in " + date + " days.");
                Console.WriteLine("\nThe total price for your cruise trip to Maldives is: P" + discounted);

                Console.WriteLine(" ______________________________________________ ");
                Console.WriteLine("|                                              |");
                Console.WriteLine("|   Thank you for choosing to travel with us!  |");
                Console.WriteLine("|                                              |");
                Console.WriteLine("|                 See you soon. :)             |");
                Console.WriteLine("|______________________________________________|");
            }
            else
            {
                Console.WriteLine("Invalid response. Please start over again.");

                Main();
                return;
            }

        }
        static void Bermuda()
        {
            ticketPrice = 93899.0;

            Console.WriteLine("The price for a cruise trip to Bermuda is P" + ticketPrice + "\n");

            Console.Write("\nEnter the number of people for the trip: ");
            people = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nEnter how many days it will be from today: ");
            int date = Convert.ToInt32(Console.ReadLine());

            double amountPayable = ticketPrice * people;

            if (people == 1 || people == 2)
            {
                Console.WriteLine("\nYour trip is in " + date + " days.");
                Console.WriteLine("\nThe total price for your cruise trip to Bermuda is: P" + amountPayable);

                Console.WriteLine(" ______________________________________________ ");
                Console.WriteLine("|                                              |");
                Console.WriteLine("|   Thank you for choosing to travel with us!  |");
                Console.WriteLine("|                                              |");
                Console.WriteLine("|                 See you soon. :)             |");
                Console.WriteLine("|______________________________________________|");
            }
            else if (people >= 3 && people <= 7)
            {
                Console.WriteLine("\nWow! You have book a trip with more than 2 people.");
                Console.WriteLine($"You are now eligible for our 10% off your total trip price.");

                double discounted = amountPayable * 0.90;

                Console.WriteLine("\nYour trip is in " + date + " days.");
                Console.WriteLine("\nThe total price for your cruise trip to Bermuda is: P" + discounted);

                Console.WriteLine(" ______________________________________________ ");
                Console.WriteLine("|                                              |");
                Console.WriteLine("|   Thank you for choosing to travel with us!  |");
                Console.WriteLine("|                                              |");
                Console.WriteLine("|                 See you soon. :)             |");
                Console.WriteLine("|______________________________________________|");
            }
            else if (people >= 8)
            {
                Console.WriteLine("\nWow! You have book a trip with more than 7 people.");
                Console.WriteLine($"You are now eligible for our 25% off your total trip price.");

                double discounted = amountPayable * 0.75;

                Console.WriteLine("\nYour trip is in " + date + " days.");
                Console.WriteLine("\nThe total price for your cruise trip to Bermuda is: P" + discounted);

                Console.WriteLine(" ______________________________________________ ");
                Console.WriteLine("|                                              |");
                Console.WriteLine("|   Thank you for choosing to travel with us!  |");
                Console.WriteLine("|                                              |");
                Console.WriteLine("|                 See you soon. :)             |");
                Console.WriteLine("|______________________________________________|");
            }
            else
            {
                Console.WriteLine("Invalid response. Please start over again.");

                Main();
                return;
            }

        }
    }
}