using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main()
    {
        Movies();
        Orders();

        /*Hello, I created a program that will display various movie recommendations based on the age entry. (An invalid entry of age will terminate the program.) 
        After the movie selection will be the food orders. I will display a menu and ask for the users orders.
        After that is the calculation of orders.
        Thank you and Merry Christmass!!*/

        static void Movies()
        {
            Console.WriteLine("********** Welcome to the MA Movie Marathon Hub ************");


            Console.WriteLine("\nThis program is the perfect place for you to pick a movie, includes the price of each movies.");


            Console.WriteLine("\nThis movie selector will recommend you a movie or show based on your age. \nRecommended ages for movie rating.");

            Console.WriteLine(" => Rated G (General Audience) = 5 to 12 years old");
            Console.WriteLine(" => Rated PG (Parental Guidance) = 13 to 17 years old");
            Console.WriteLine(" => Rated SPG (Strong Parental Guidance) = 18 years old and above.");

            bool validAge = false;

            while (!validAge)
            {
                Console.Write("\nPlease enter your age: ");
                int age;

                if (int.TryParse(Console.ReadLine(), out age) && age >= 5)
                {
                    validAge = true;
                    if (age >= 5 && age <= 12)
                    {
                        Console.WriteLine("\nThe available category is Rated G. Here are some movies recommended for you.");
                        Console.WriteLine("=====================================");
                        Console.WriteLine("FILMS: \n(1) Finding Nemo, \n(2) Finding Dory, \n(3) Minions, \n(4) Frozen, \n(5) Earnest and Celestine");
                        Console.WriteLine("FAMILY FILMS: \n(6) Paddington, \n(7) Muppets Most Wanted, \n(8) Dangal");
                        Console.WriteLine("=====================================");

                        Console.Write("\nPlease write the number of your chosen movie: ");
                        int choice = Convert.ToInt32(Console.ReadLine());

                        switch (choice)
                        {
                            case 1:
                                Console.WriteLine("You have chosen Finding Nemo. The price is P140.");
                                break;
                            case 2:
                                Console.WriteLine("You have chosen Finding Dory. The price is P140.");
                                break;
                            case 3:
                                Console.WriteLine("You have chosen Minions. The price is P150.");
                                break;
                            case 4:
                                Console.WriteLine("You have chosen Frozen. The price is P150.");
                                break;
                            case 5:
                                Console.WriteLine("You have chosen Earnest and Celestine. The price is P150.");
                                break;
                            case 6:
                                Console.WriteLine("You have chosen Paddington. The price is P170.");
                                break;
                            case 7:
                                Console.WriteLine("You have chosen Muppets Most Wanted. The price is P160.");
                                break;
                            case 8:
                                Console.WriteLine("You have chosen Dangal. The price is P150.");
                                break;
                        }
                    }
                    else if (age > 12 && age <= 17)
                    {
                        Console.WriteLine("\nThe available categories are Rated G and Rated PG. Here are some movies recommended for you.");
                        Console.WriteLine("Rated G Movies");
                        Console.WriteLine("=====================================");
                        Console.WriteLine("FILMS: \n(1) Finding Nemo, \n(2) Finding Dory, \n(3) Minions, \n(4) Frozen, \n(5) Earnest and Celestine");
                        Console.WriteLine("FAMILY FILMS: \n(6) Paddington, \n(7) Muppets Most Wanted, \n(8) Dangal");
                        Console.WriteLine("=====================================");

                        Console.WriteLine("\nRated PG Movies");
                        Console.WriteLine("=====================================");
                        Console.WriteLine("ACTIONS: \n(9) Captain America: Civil War, \n(10) Ghostbusters, \n(11) IP Man 3");
                        Console.WriteLine("COMEDIES: \n(12) Central Intelligence, \n(13) Dumb to Dumb to");
                        Console.WriteLine("DRAMAS: \n(14) Sully, \n(15) The Fault in our stars");
                        Console.WriteLine("=====================================");

                        Console.Write("\nPlease write the number of your chosen movie: ");
                        int choice = Convert.ToInt32(Console.ReadLine());

                        switch (choice)
                        {
                            case 1:
                                Console.WriteLine("You have chosen Finding Nemo. The price is P140.");
                                break;
                            case 2:
                                Console.WriteLine("You have chosen Finding Dory. The price is P140.");
                                break;
                            case 3:
                                Console.WriteLine("You have chosen Minions. The price is P150.");
                                break;
                            case 4:
                                Console.WriteLine("You have chosen Frozen. The price is P150.");
                                break;
                            case 5:
                                Console.WriteLine("You have chosen Earnest and Celestine. The price is P150.");
                                break;
                            case 6:
                                Console.WriteLine("You have chosen Paddington. The price is P170.");
                                break;
                            case 7:
                                Console.WriteLine("You have chosen Muppets Most Wanted. The price is P160.");
                                break;
                            case 8:
                                Console.WriteLine("You have chosen Dangal. The price is P150.");
                                break;
                            case 9:
                                Console.WriteLine("You have chosen Captain America: Civil War. The price is P280.");
                                break;
                            case 10:
                                Console.WriteLine("You have chosen Ghosbusters. The price is P230.");
                                break;
                            case 11:
                                Console.WriteLine("You have chosen Ip Man 3. The price is P230.");
                                break;
                            case 12:
                                Console.WriteLine("You have chosen Central Intelligence. The price is P230.");
                                break;
                            case 13:
                                Console.WriteLine("You have chosen Dumb to Dumb to. The price is P250.");
                                break;
                            case 14:
                                Console.WriteLine("You have chosen Sully. The price is P250.");
                                break;
                            case 15:
                                Console.WriteLine("You have chosen The Fault on our stars. The price is P260.");
                                break;
                        }


                    }
                    else if (age >= 18)
                    {
                        Console.WriteLine("\nThe available categories are Rated G, Rated PG and SPG. Here are some movies recommended for you.");
                        Console.WriteLine("Rated G Movies");
                        Console.WriteLine("=====================================");
                        Console.WriteLine("FILMS: \n(1) Finding Nemo, \n(2) Finding Dory, \n(3) Minions, \n(4) Frozen, \n(5) Earnest and Celestine");
                        Console.WriteLine("FAMILY FILMS: \n(6) Paddington, \n(7) Muppets Most Wanted, \n(8) Dangal");
                        Console.WriteLine("=====================================");

                        Console.WriteLine("\nRated PG Movies");
                        Console.WriteLine("=====================================");
                        Console.WriteLine("ACTIONS: \n(9) Captain America: Civil War, \n(10) Ghostbusters, \n(11) IP Man 3");
                        Console.WriteLine("COMEDIES: \n(12) Central Intelligence, \n(13) Dumb to Dumb to");
                        Console.WriteLine("DRAMAS: \n(14) Sully, \n(15) The Fault in our stars");
                        Console.WriteLine("=====================================");

                        Console.WriteLine("\nRated SPG Movies");
                        Console.WriteLine("=====================================");
                        Console.WriteLine("ACTIONS: \n(16) Mad Max 2, \n(17) Hardcore Henry, \n(18) The Hateful Eight");
                        Console.WriteLine("COMEDIES: \n(19) Sausage Party, \n(20) Trailor Park Boys \n(21) Spy");
                        Console.WriteLine("DRAMAS: \n(22) Fifty Shades of Grey, \n(23) Nymphomaniac \n(24) Elle \n(25) Blue is the warmest color.");
                        Console.WriteLine("HORROR: \n(26) 31, \n(27) The Green Inferno \n(28) The ABCs of Death \n(29) The Cabin in the Woods \n(30) Death Gasm");
                        Console.WriteLine("=====================================");

                        Console.Write("\nPlease write the number of your chosen movie: ");
                        int choice = Convert.ToInt32(Console.ReadLine());

                        switch (choice)
                        {
                            case 1:
                                Console.WriteLine("You have chosen Finding Nemo. The price is P140.");
                                break;
                            case 2:
                                Console.WriteLine("You have chosen Finding Dory. The price is P140.");
                                break;
                            case 3:
                                Console.WriteLine("You have chosen Minions. The price is P150.");
                                break;
                            case 4:
                                Console.WriteLine("You have chosen Frozen. The price is P150.");
                                break;
                            case 5:
                                Console.WriteLine("You have chosen Earnest and Celestine. The price is P150.");
                                break;
                            case 6:
                                Console.WriteLine("You have chosen Paddington. The price is P170.");
                                break;
                            case 7:
                                Console.WriteLine("You have chosen Muppets Most Wanted. The price is P160.");
                                break;
                            case 8:
                                Console.WriteLine("You have chosen Dangal. The price is P150.");
                                break;
                            case 9:
                                Console.WriteLine("You have chosen Captain America: Civil War. The price is P280.");
                                break;
                            case 10:
                                Console.WriteLine("You have chosen Ghosbusters. The price is P230.");
                                break;
                            case 11:
                                Console.WriteLine("You have chosen Ip Man 3. The price is P230.");
                                break;
                            case 12:
                                Console.WriteLine("You have chosen Central Intelligence. The price is P230.");
                                break;
                            case 13:
                                Console.WriteLine("You have chosen Dumb to Dumb to. The price is P250.");
                                break;
                            case 14:
                                Console.WriteLine("You have chosen Sully. The price is P250.");
                                break;
                            case 15:
                                Console.WriteLine("You have chosen The Fault on our stars. The price is P260.");
                                break;
                            case 16:
                                Console.WriteLine("You have chosen Mad Max 2. The price is P300.");
                                break;
                            case 17:
                                Console.WriteLine("You have chosen Hardcore Henry. The price is P300.");
                                break;
                            case 18:
                                Console.WriteLine("You have chosen The Hateful Eight. The price is P300.");
                                break;
                            case 19:
                                Console.WriteLine("You have chosen Sausage Party. The price is P320.");
                                break;
                            case 20:
                                Console.WriteLine("You have chosen Trailor Park Boys. The price is P320.");
                                break;
                            case 21:
                                Console.WriteLine("You have chosen Spy. The price is P320.");
                                break;
                            case 22:
                                Console.WriteLine("You have chosen Fifty Shades of Grey. The price is P360.");
                                break;
                            case 23:
                                Console.WriteLine("You have chosen Nymphomaniac. The price is P340.");
                                break;
                            case 24:
                                Console.WriteLine("You have chosen Elle. The price is P350.");
                                break;
                            case 25:
                                Console.WriteLine("You have chosen Blue is the warmest color. The price is P350.");
                                break;
                            case 26:
                                Console.WriteLine("You have chosen 31. The price is P360.");
                                break;
                            case 27:
                                Console.WriteLine("You have chosen The Green Inferno. The price is P360.");
                                break;
                            case 28:
                                Console.WriteLine("You have chosen The ABCs of Death. The price is P360.");
                                break;
                            case 29:
                                Console.WriteLine("You have chosen The Cabin in the Woods. The price is P360.");
                                break;
                            case 30:
                                Console.WriteLine("You have chosen Death Gasm. The price is P360.");
                                break;
                        }
                        break;
                    }

                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid age.");
                    Console.WriteLine("Exiting program due to invalid age input. Please restart the program.");
                    Environment.Exit(0);

                }
            }
        }

        static void Orders()
        {
            double foodPrice = 0;

            while (true)
            {
                Console.Write("\nThank you for choosing a movie. Would you like to order food and beverages in advance? (n/y): ");
                char dec = Convert.ToChar(Console.ReadLine());

                if (dec == 'n')
                {
                    break;
                }
                else if (dec == 'y')
                {
                    do
                    {
                        Console.WriteLine("\n==== Menu ====");
                        Console.WriteLine("1. Popcorn - Small: P60 | Medium: P80 | Large: P120");
                        Console.WriteLine("2. Chips - Small: P50 | Medium: P70 | Large: P100");
                        Console.WriteLine("3. CocaCola - Small: P20 | Medium: P50 | Large: P80");
                        Console.WriteLine("4. Nestea - Small: P15 | Medium: P35 | Large: P60");
                        Console.Write("\nPlease select an item by entering its number (1-4): ");

                        int foodChoice = Convert.ToInt32(Console.ReadLine());

                        switch (foodChoice)
                        {
                            case 1:
                                Console.Write("Enter the size (Small, Medium, Large): ");
                                string popcornSize = Console.ReadLine().ToLower();
                                foodPrice += CalculateFoodPrice(popcornSize, 60, 80, 120);
                                break;

                            case 2:
                                Console.Write("Enter the size (Small, Medium, Large): ");
                                string chipsSize = Console.ReadLine().ToLower();
                                foodPrice += CalculateFoodPrice(chipsSize, 50, 70, 100);
                                break;

                            case 3:
                                Console.Write("Enter the size (Small, Medium, Large): ");
                                string cokeSize = Console.ReadLine().ToLower();
                                foodPrice += CalculateFoodPrice(cokeSize, 20, 50, 80);
                                break;

                            case 4:
                                Console.Write("Enter the size (Small, Medium, Large): ");
                                string nesteaSize = Console.ReadLine().ToLower();
                                foodPrice += CalculateFoodPrice(nesteaSize, 15, 35, 60);
                                break;

                            default:
                                Console.WriteLine("Invalid selection. Please select a valid item number.");
                                break;
                        }

                        Console.Write("\nDo you want to order more items? (y/n): ");
                    } while (Convert.ToChar(Console.ReadLine()) == 'y');
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter 'n' for no or 'y' for yes.");
                }
            }

            Console.WriteLine($"\nTotal Amount to be Paid for Food: P{foodPrice}");
            Console.WriteLine("************************\nThank you for using MA Movie Selector Hub. Enjoy your movie!");
        }

        static double CalculateFoodPrice(string size, double smallPrice, double mediumPrice, double largePrice)
        {
            switch (size)
            {
                case "small":
                    return smallPrice;
                case "medium":
                    return mediumPrice;
                case "large":
                    return largePrice;
                default:
                    Console.WriteLine("Invalid size. Defaulting to small price.");
                    return smallPrice;
            }
        }
        }
    }