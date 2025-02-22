// Write a program that calculates and prints the n! for any n in the range 
// [1…100].

using System.Numerics;

class Factorial
{
    static void Main()
    {
        int n;

        Console.WriteLine("Program to find factorial of a given number in " +
        "range[1,100]");
        n = GetInt("Num = ", 0, 100);
        Console.WriteLine($"{n}! = {Fac(n):n0}");
    }


    static int GetInt(string prompt, int? min = null, int? max = null)
    {
        // Method to user input integer
        // min <= integer <= max

        int num;
        bool isInt;

        do
        {
            Console.Write(prompt);
            isInt = int.TryParse(Console.ReadLine(), out num);
            if(!isInt || (min != null && num < min) || (max != null && num > max))
            {
                Console.WriteLine($"\nEnter a valid integer in range[{(min == null ? int.MinValue : min)},{(max == null ? int.MaxValue : max)}]");
            }
        }
        while(!isInt || (min != null && num < min) || (max != null && num > max));

        return num;
    }


    static BigInteger Fac(int num)
    {
        // Method to find factorial of given integer

        BigInteger fac = 1;

        for(int i = 2; i <= num; i++)
        {
            fac *= i;
        }

        return fac;
    }
}