// Write a program to simulate n nested loops from 1 to n.

class NNestedLoops
{
    static void Main()
    {
        int n, k;

        Console.WriteLine("Program to simulate n nested loops from 1 to n.");
        n = GetInt("n = ", 1);
        k = GetInt("k = ", 1);
        int[] myArray = new int[n];
        Console.WriteLine();
        Console.WriteLine($"n = {n}, k = {k}");
        PrintPermutation(myArray, k);
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


    static void PrintPermutation(int[] myArray, int k, int n=0)
    {
        // Method to generate permutation with repetition of k elements taken
        // myArray.Length at a time

        if(n >= myArray.Length)
        {
            PrintArray(myArray);
            return;
        }

        for(int i = 1; i <= k; i++)
        {
            myArray[n] = i;
            PrintPermutation(myArray, k, n+1);
        }
    }


    static void PrintArray(int[] myArray)
    {
        // Method to print given array

        foreach(int i in myArray)
        {
            Console.Write($"{i} ");
        }

        Console.WriteLine();
    }
}