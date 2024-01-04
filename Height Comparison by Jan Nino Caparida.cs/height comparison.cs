using System;

namespace height comparison program

class height comparison
{
    static void Main()
    {
        Console.WriteLine("Enter the height of the first person (in centimeters): ");
        int height1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the height of the second person (in centimeters): ");
        int height2 = int.Parse(Console.ReadLine());

        if (height1 > height2)
        {
            Console.WriteLine("The first person is taller.");
        }
        else if (height1 < height2)
        {
            Console.WriteLine("The second person is taller.");
        }
        else
        {
            Console.WriteLine("Both persons are of the same height.");
        }
    }
}