// Write a program that prints three numbers in three virtual columns
// on the console. Each column should have a width of 10 characters and 
// the numbers should be left aligned. The first number should be an 
// integer in hexadecimal; the second should be fractional positive; and 
// the third – a negative fraction. The last two numbers have to be 
// rounded to the second decimal place.

class NumInColumns
{
    static void Main()
    {
        int num1;
        double num2, num3;
        bool isInt, isDouble;

        Console.WriteLine("Program to print 3 numbers in 3 columns");
        Console.Write("Enter an integer: ");
        isInt = int.TryParse(Console.ReadLine(), out num1);
        Console.Write(isInt ? "" : "Invalid number\n");
        Console.Write("Enter a positive decimal number: ");
        isDouble = double.TryParse(Console.ReadLine(), out num2);
        Console.Write(isDouble ? "" : "Invalid number\n");
        Console.Write("Enter a negative decimal number: ");
        isDouble = double.TryParse(Console.ReadLine(), out num3);
        Console.Write(isDouble ? "" : "Invalid number\n");

        Console.WriteLine();
        Console.WriteLine($"{"Column 1",-10} | {"Column 2",-10} | Column 3");
        Console.WriteLine($"{num1,-10:x} | {num2,-10:f2} | {num3,-10:f2}");
    }
}