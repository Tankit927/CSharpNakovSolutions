// Write a program that finds the biggest of three integers, using nested 
// if statements.

class BiggestOfThree
{
    static void Main()
    {
        int n1, n2, n3, biggest = 0;
        bool isInt;

        Console.WriteLine("Program to find biggest of three given integers.");
        Console.Write("Enter first number = ");
        isInt = int.TryParse(Console.ReadLine(), out n1);
        Console.WriteLine(isInt ? "" : "Invalid number");
        Console.Write("Enter second number = ");
        isInt = int.TryParse(Console.ReadLine(), out n2);
        Console.WriteLine(isInt ? "" : "Invalid number");
        Console.Write("Enter third number = ");
        isInt = int.TryParse(Console.ReadLine(), out n3);
        Console.WriteLine(isInt ? "" : "Invalid number");

        if(n1 >= n2)
        {
            if(n1 >= n3)
            {
                biggest = n1;
            }
            else
            {
                biggest = n3;
            }
        }
        else if(n2 >= n1)
        {
            if(n2 >= n3)
            {
                biggest = n2;
            }
            else
            {
                biggest = n3;
            }
        }
        else if(n3 >= n1)
        {
            if(n3 >= n2)
            {
                biggest = n3;
            }
            else
            {
                biggest = n2;
            }
        }

        Console.WriteLine($"Biggest of {n1}, {n2} and {n3} = {biggest}");
    }
}