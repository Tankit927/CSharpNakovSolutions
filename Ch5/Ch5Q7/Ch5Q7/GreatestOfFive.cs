// Write a program that finds the greatest of given 5 numbers.

class GreatestOfFive
{
    static void Main()
    {
        double n1, n2, n3, n4, n5;
        bool isDouble;

        Console.WriteLine("Program to find the greatest of 5 given numbers");
        Console.Write("Num1 = ");
        isDouble = double.TryParse(Console.ReadLine(), out n1);
        Console.WriteLine(isDouble ? "" : "Invalid number");
        Console.Write("Num2 = ");
        isDouble = double.TryParse(Console.ReadLine(), out n2);
        Console.WriteLine(isDouble ? "" : "Invalid number");
        Console.Write("Num3 = ");
        isDouble = double.TryParse(Console.ReadLine(), out n3);
        Console.WriteLine(isDouble ? "" : "Invalid number");
        Console.Write("Num4 = ");
        isDouble = double.TryParse(Console.ReadLine(), out n4);
        Console.WriteLine(isDouble ? "" : "Invalid number");
        Console.Write("Num5 = ");
        isDouble = double.TryParse(Console.ReadLine(), out n5);
        Console.WriteLine(isDouble ? "" : "Invalid number");

        Console.Write("Greatest number = ");
        if(n1 >= n2 && n1 >= n3 && n1 >= n4 && n1 >= n5)
        {
            Console.WriteLine(n1);
        }
        else if(n2 >= n1 && n2 >= n3 && n2 >= n4 && n2 >= n5)
        {
            Console.WriteLine(n2);
        }
        else if(n3 >= n1 && n3 >= n2 && n3 >= n4 && n3 >= n5)
        {
            Console.WriteLine(n3);
        }
        else if(n4 >= n1 && n4 >= n2 && n4 >= n3 && n4 >= n5)
        {
            Console.WriteLine(n4);
        }
        else
        {
            Console.WriteLine(n5);
        }
    }
}