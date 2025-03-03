// Write a program to generate all variations with duplicates of n 
// elements class k. Sample input: 
// n = 3 
// k = 2 
// Sample output: 
// (1 1), (1 2), (1 3), (2 1), (2 2), (2 3), (3 1), (3 2), (3 3) 
// Think about and implement an iterative algorithm for the same task.

class PermutationWithIteration
{
    static void Main()
    {
        int n, k;

        Console.WriteLine("Program to generate permutation of n elements taken " +
        "k at a time.");
        n = GetInt("n = ", 1);
        k = GetInt("k = ", 1);
        int[] myArray = new int[k];

        Console.WriteLine();
        Console.WriteLine($"nPk, n = {n}, k = {k}");
        PrintPermutationIteratively(myArray, n);
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


    static void PrintPermutationIteratively(int[] myArray, int n)
    {
        // Method to generate permutation of n elements taken
        // myArray.Length at a time

        InitArray(myArray);
        PrintArray(myArray);

        int len = myArray.Length;
        int i = len - 1;

        while(i >= 0)
        {
            if(myArray[i]+1 <= n)
            {
                myArray[i] += 1;
                PrintArray(myArray);
                i = len - 1;
            }
            else
            {
                myArray[i] = 1;
                i -= 1;
            }
        }
    }


    static void InitArray(int[] myArray)
    {
        // Method to initialise given array

        for(int i = 0; i < myArray.Length; i++)
        {
            myArray[i] = 1;
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