// Simulation of N nested for loops from 1...K using recursion and iteration
// Equivalent to permutation with repetition

class PermutationWithRepetition
{
    static void Main()
    {
        int n, k;

        Console.WriteLine("Program to simulate N nested for loops from 1...K");
        Console.WriteLine("using recursion and iteration");
        Console.WriteLine("Equivalent to permutation with repetition");
        n = GetInt("N = ", 1);
        k = GetInt("K = ", 1);
        int[] myArray = new int[n];

        Console.WriteLine();
        Console.WriteLine($"Recursive implementation for N = {n} & K = {k}");
        PrintPermutations(myArray, k);

        Console.WriteLine();
        Console.WriteLine($"Iterative implementation for N = {n} & K = {k}");
        PrintPermutationsIteratively(myArray, k);
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


    static void PrintPermutations(int[] myArray, int k, int n=0)
    {
        // Method to recursively generate permutations with repetition
        // of k elements taken n+1 at a time

        if(n == myArray.Length)
        {
            PrintArray(myArray);
            return;
        }

        for(int i = 1; i <= k; i++)
        {
            myArray[n] = i;
            PrintPermutations(myArray, k, n+1);
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


    static void PrintPermutationsIteratively(int[] myArray, int k)
    {
        // Method to generate permutations of k elements taken n at time with 
        // repetition iteratively where
        // n = myArray.Length
        // k >= 1

        InitArray(myArray);
        PrintArray(myArray);

        int n = myArray.Length - 1;
        int i = n;
        while(i >= 0)
        {
            if(myArray[i] + 1 <= k)
            {
                myArray[i] += 1;
                PrintArray(myArray);
                i = n;
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
}