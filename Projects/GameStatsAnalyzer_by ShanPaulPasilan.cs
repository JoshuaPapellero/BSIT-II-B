using System;

class OlayvarJohn
{
    static void Main()
    {
        Console.WriteLine("Game Stats Analyzer");

        // User Input
        string playerName = GetUserInput("Enter player name: ")!;
        int score = GetIntegerInput("Enter player score: ");
        int level = GetIntegerInput("Enter player level: ");

        // analyze game stats
        Console.WriteLine("\nAnalyzing Game Stats...");

        // Checks player lvl
        PrintPlayerLevel(playerName, level);

        // checks player score
        PrintPlayerScore(playerName, score);

        // display game stats
        DisplayGameStats(playerName, score, level);
    }

    static string GetUserInput(string message)
    {
        Console.Write(message);
        string? input = Console.ReadLine();
        return input ?? string.Empty;
    }

    static int GetIntegerInput(string message)
    {
        int result;
        bool isValidInput;

        do
        {
            Console.Write(message);
            string input = Console.ReadLine();
            isValidInput = int.TryParse(input, out result);

            if (!isValidInput)
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
            }

        } while (!isValidInput);

        return result;
    }

    static void PrintPlayerLevel(string playerName, int level)
    {
        if (level >= 1 && level <= 5)
        {
            Console.WriteLine($"{playerName} is a beginner.");
        }
        else if (level >= 6 && level <= 10)
        {
            Console.WriteLine($"{playerName} is an intermediate player.");
        }
        else
        {
            Console.WriteLine($"{playerName} is an advanced player.");
        }
    }

    static void PrintPlayerScore(string playerName, int score)
    {
        if (score < 0)
        {
            Console.WriteLine($"Invalid score for {playerName}. Please enter a positive score.");
        }
        else if (score < 100)
        {
            Console.WriteLine($"{playerName} needs improvement.");
        }
        else if (score < 500)
        {
            Console.WriteLine($"{playerName} is doing well.");
        }
        else
        {
            Console.WriteLine($"{playerName} is a pro!");
        }
    }

    static void DisplayGameStats(string playerName, int score, int level)
    {
        Console.WriteLine("\nGame Stats:");
        Console.WriteLine($"Player: {playerName}");
        Console.WriteLine($"Score: {score}");
        Console.WriteLine($"Level: {level}");
    }
}
