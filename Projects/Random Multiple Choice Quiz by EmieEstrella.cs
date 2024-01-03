using System;

namespace Example
{
    class Program
    {
        static void Main(string[] args)
        {
            Welcome("Contestant");  
        }
        static void Welcome(string name)
        {
            Console.WriteLine("Welcome to the Random Multiple Choice Quiz " + name + "!\n");

            int score = 0;

            // Question 1
            Console.WriteLine("Question 1: What type of flower are the demons weakness in KNY");
            Console.WriteLine("a) Wisteria");
            Console.WriteLine("b) Roses");
            Console.WriteLine("c) Sakura");
            Console.WriteLine("d) Prairifire Crabapple Tree");

            Console.Write("Enter Answer: ");
            char answer1 = Convert.ToChar(Console.ReadLine());
            if (answer1 == 'a')
            {
                Console.WriteLine("Correct!\n");
                score++;
            }
            else if (answer1 == 'b' || answer1 == 'c' || answer1 == 'd')
            {
                Console.WriteLine("Incorrect. The correct answer is (a) Wisteria.\n");
            }
            else
            {
                Console.WriteLine("Invalid Answer\n");
            }

            // Question 2
            Console.WriteLine("Question 2: Which programming language is this quiz written in?");
            Console.WriteLine("a) Java");
            Console.WriteLine("b) C++");
            Console.WriteLine("c) C#");
            Console.WriteLine("d) Python");

            Console.Write("Enter Answer: ");
            char answer2 = Convert.ToChar(Console.ReadLine());
            if (answer2 == 'c')
            {
                Console.WriteLine("Correct!\n");
                score++;
            }
            else if (answer2 == 'a' || answer2 == 'b' || answer2 == 'd')
            {
                Console.WriteLine("Incorrect. The correct answer is (c) C#.\n");
            }
            else
            {
                Console.WriteLine("Invalid Answer\n");
            }

            // Question 3
            Console.WriteLine("Question 3: What is " + (1 + 0) + " plus " + (1+0));
            Console.WriteLine("a) 1");
            Console.WriteLine("b) 1000");
            Console.WriteLine("c) 3");
            Console.WriteLine("d) 2");   

            Console.Write("Enter Answer: ");
            char answer3 = Convert.ToChar(Console.ReadLine());
            if (answer3 == 'd')
            {
                Console.WriteLine("Correct!\n");
                score++;
            }
            else if (answer3 == 'a' || answer3 == 'b' || answer3 == 'c')
            {
                Console.WriteLine("Incorrect. The correct answer is (d) 2.\n"); 
            }
            else
            {
                Console.WriteLine("Invalid Answer\n");
            }

            // Question 4
            Console.WriteLine("Question 4: What is Eren?");
            Console.WriteLine("a) Cart Titan");
            Console.WriteLine("b) Beast Titan");
            Console.WriteLine("c) Attack Titan");
            Console.WriteLine("d) Founding Titan");

            Console.Write("Enter Answer: ");
            char answer4 = Convert.ToChar(Console.ReadLine());
            if (answer4 == 'c' || answer4 == 'd')
            {
                Console.WriteLine("Correct!\n");
                score++;
            }
            else if (answer4 == 'a' || answer4 == 'b')
            {
                Console.WriteLine("Incorrect. The correct answer is both (c) Attack Titan and (d) Founding Titan.\n"); 
            }
            else
            {
                Console.WriteLine("Invalid Answer\n");
            }

            // Question 5
            Console.WriteLine("Question 5: How do you survive the Coil head in Lethal Company?");
            Console.WriteLine("a) Flash it with a flashlight.");  
            Console.WriteLine("b) Shoot it with a shotgun.");
            Console.WriteLine("c) Hit it with a shovel or a stop sign.");  
            Console.WriteLine("d) Never turn your back on it and always look at it.");
            
            Console.Write("Enter Answer: ");
            char answer5 = Convert.ToChar(Console.ReadLine());
            if (answer5 == 'd')
            {
                Console.WriteLine("Correct!\n");
                score++;
            }
            else if (answer5 == 'a' || answer5 == 'b' || answer5 == 'c')
            {
                Console.WriteLine("Incorrect. The correct answer is (d) Never turn your back on it and always look at it.\n");
            }
            else
            {
                Console.WriteLine("Invalid Answer\n");
            }

            // Bonus Question
            Console.WriteLine("Bonus Question: What do you think the one piece is?");
            Console.WriteLine("a) The friends they made along the the way");
            Console.WriteLine("b) Boa's Bathwater"); 
            Console.WriteLine("c) Roger's Strawhat");  
            Console.WriteLine("d) A literal pile of gold");

            Console.Write("Enter Answer: ");
            char answer6 = Convert.ToChar(Console.ReadLine());
            if (answer6 == 'a' || answer6 == 'b' || answer6 == 'c' || answer6 == 'd')
            {
                Console.WriteLine("There is no incorrect answer ;)!\n"); 
                score++;                     
            }
            else
            {
                Console.WriteLine("Invalid Answer\n");
            }

            // Display final score
            Console.WriteLine($"Your final score is: {score} out of 5");

            if(score >= 3 && score >=5)
            {
                Console.WriteLine("Passed\n");
            }
            else
            {
                Console.WriteLine("Failed\n");
            }

            Console.Write("Enter score to determine grade: ");
            int grade = Convert.ToInt32(Console.ReadLine());
            

            //your code goes here
            switch (grade)
            {
                case 1:
                    Console.WriteLine("F - Fail");
                    break;
                case 2:
                    Console.WriteLine("D - More room for improvement");
                    break;
                case 3:
                    Console.WriteLine("C - Average");
                    break;
                case 4:
                    Console.WriteLine("B - Very Good");
                    break;
                case 5:
                    Console.WriteLine("A - Excellent");
                    break;
                case 6:
                    Console.WriteLine("S - Marvelous! Truly Marvelous!");  
                    break;
                default:
                    Console.WriteLine("Invalid Output");
                    break;
            }
            
        }

    }
}
