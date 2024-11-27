// Write a program that reads from the console three numbers of type int
// and prints their sum.

class UserInputIntegers
{
    static void Main()
    {
        int x, y, z;
        bool isInt;

        Console.WriteLine("Program to add 3 integers.");
        Console.Write("Enter 1st num: ");
        isInt = int.TryParse(Console.ReadLine(), out x);
        Console.Write(isInt ? "" : "Invalid number\n");
        Console.Write("Enter 2nd num: ");
        isInt = int.TryParse(Console.ReadLine(), out y);
        Console.Write(isInt ? "" : "Invalid number\n");
        Console.Write("Enter 3rd num: ");
        isInt = int.TryParse(Console.ReadLine(), out z);
        Console.Write(isInt ? "" : "Invalid number\n");
        Console.WriteLine($"{x} + {y} + {z} = {x + y + z}");
    }
}