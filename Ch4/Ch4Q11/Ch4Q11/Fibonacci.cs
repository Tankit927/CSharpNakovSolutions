// Write a program that prints on the console the first 100 numbers in the 
// Fibonacci sequence: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, …

// Need to complete till Ch-9 Methods

using System.Numerics;

class Fibonacci
{
    static void Main()
    {
        int n;

        Console.WriteLine("Program to print first n numbers of fibonacci sequence");
        n = GetInt("n = ", 1);

        Console.WriteLine();
        PrintFirstNFibonacciSequence(n);
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
                Console.WriteLine($"\nEnter a valid integer in range[{(min == null ? int.MinValue : min)}, {(max == null ? int.MaxValue : max)}]");
            }
        }
        while(!isInt || (min != null && num < min) || (max != null && num > max));

        return num;
    }


    static void PrintFirstNFibonacciSequence(int n)
    {
        // Method to print first n numbers of fibonacci sequence

        BigInteger i = 0;
        BigInteger j = 1;

        if(n > 0)
        {
            Console.Write($"{i} ");

            for(int c = 2; c <= n; c++)
            {
                Console.WriteLine($"{j:n0}");
                BigInteger temp = j;
                j += i;
                i = temp;
            }

            Console.WriteLine();
        }
    }
}