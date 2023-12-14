using System;

class JamesAngeloEstrella
{
    static void Main()
    {
        // This is the Program Structure
        Console.WriteLine("Welcome to James Height Identifier Program!");


        // This is the User Input
        Console.Write("\nEnter your name: ");
        string name = Console.ReadLine();

        Console.Write("\nEnter your age: ");
        string ageInput = Console.ReadLine();

        Console.Write("\nEnter your weight in kilograms: ");
        string weightInput = Console.ReadLine();

        Console.Write("\nEnter your height in centimeters: ");
        string heightInput = Console.ReadLine();

        // This are the Variables and Data Types
        int age, weight, height;

        // Basic Output

        // This is the User Input and Type Conversion
        if (int.TryParse(ageInput, out age) && int.TryParse(weightInput, out weight) && int.TryParse(heightInput, out height))
        {
            // Im doing Math in here as you can see
            // Height Identification
            string heightCategory;

            // This is Arithmetic Operators and Comparison Operators
            if (height < 150)
            {
                heightCategory = "Short";
            }
            else if (height >= 150 && height <= 180)
            {
                heightCategory = "Average";
            }
            else
            {
                heightCategory = "Tall";
            }

            // Output with User Details
            Console.WriteLine($"\nHello, {name}!");
            Console.WriteLine($"\nAge: {age} years | Weight: {weight} kg | Height Category: {heightCategory}");

            // This is more on Strings and Concatenation
            Console.WriteLine($"\nOrganized Output:\n\tHeight: {height} cm");

            // This is Concatenation and Interpolation
            string message = $"\n{name}, you are {heightCategory.ToLower()}.";

            // This is the Logical Operators
            if (height >= 160 && height <= 180 && height % 2 == 0)
            {
                message += " \nYour height is constant.";
            }

            Console.WriteLine(message);

            // This is the  Switch Statement
            switch (heightCategory)
            {
                case "Short":
                    Console.WriteLine("\nThink about donning high heels.");
                    break;
                case "Average":
                    Console.WriteLine("\nYou have a typical height.");
                    break;
                case "Tall":
                    Console.WriteLine("\nBe cautious around low door frames!");
                    break;
                default:
                    Console.WriteLine("\nSurprising height classification.");
                    break;
            }

            //  This is for Loop
            Console.WriteLine("\nCounting to your height:");

            for (int i = 0; i <= height; i++)
            {
                Console.Write($"{i} ");
            }

            // This is while Loop
            Console.WriteLine("\n\nCounting down from your height:");

            int counter = height;
            while (counter >= 0)
            {
                Console.Write($"{counter} ");
                counter--;
            }

            // This are  Methods, Parameters, and Arguments
            DisplayHeightDetails(name, age, weight, height, heightCategory);
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter valid numbers for age, weight, and height.");
        }
    }

    //  Particular Approach with Arguments and Parameters
    static void DisplayHeightDetails(string name, int age, int weight, int height, string category)
    {
        Console.WriteLine($"\n\nAdditional Details:\n\tName: {name}\n\tAge: {age} years\n\tWeight: {weight} kg\n\tHeight: {height} cm\n\tCategory: {category}");
    }
}
