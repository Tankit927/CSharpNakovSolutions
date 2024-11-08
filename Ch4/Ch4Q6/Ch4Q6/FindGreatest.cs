// Write a program that reads two numbers from the console and prints the 
// greater of them. Solve the problem without using conditional 
// statements.

class FindGreatest
{
    static void Main()
    {
        int a, b;
        bool isInt;

        Console.WriteLine("Program to find greatest no. from given " +
        "two nos.");
        Console.Write("Enter first no.: ");
        isInt = int.TryParse(Console.ReadLine(), out a);
        Console.Write("Enter second no.: ");
        isInt = int.TryParse(Console.ReadLine(), out b);

        Console.WriteLine();
        Console.WriteLine($"Greatest no. = {((a > b) ? a : b)}");
    }
}