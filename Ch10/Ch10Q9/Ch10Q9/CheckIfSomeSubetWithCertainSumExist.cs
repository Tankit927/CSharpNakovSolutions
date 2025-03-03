// You are given an array of positive integers. Write a program that checks 
// whether there is one or more numbers in the array (subset), whose 
// sum is equal to S. Can you solve the task efficiently for large arrays?

class CheckIfSomeSubsetWithCertainSumExist
{
    static void Main()
    {
        Console.WriteLine("Program to find whether there is a subset with given sum in " +
        "the given array");
        int[] set = {1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30,31,32,33,34,35,36,37,38,39,40,41,42,43,44,45,46,47,48,49,50,51,52,53,54,55,56,57,58,59,60,61,62,63,64,65,66,67,68,69,70,71,72,73,74,75,76,77,78,79,80,81,82,83,84,85,86,87,88,89,90,91,92,93,94,95,96,97,98,99,100};
        long requiredSum = 820;

        Console.WriteLine();
        Console.WriteLine("Given array:");
        PrintArray(set);

        Console.WriteLine();
        if(DoSubsetWithSumExist(requiredSum, set)) // Will take awful lot of time for
        {                                          // any set greater than 30 elements
            Console.WriteLine($"Subset with sum {requiredSum} found");
        }
        else
        {
            Console.WriteLine($"No subset with sum {requiredSum} found");
        }
    }


    static int GetInt(string prompt, int? min=null, int? max=null)
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


    static void GenerateCombinationWithoutRepetition(int[] set, int[] myArray, int n, int k=0, int counter=0)
    {
        // Method to generate combination without repetition of n elements taken
        // k=myArray.Length no. at a time
        // nCk = n! / k!(n-k)!

        if(k >= myArray.Length)
        {
            PrintSubset(set, myArray);
            return;
        }

        for(int i = counter; i <= n; i++)
        {
            myArray[k] = i;
            GenerateCombinationWithoutRepetition(set, myArray, n, k+1, i+1);
        }
    }


    static bool DoSubsetHasSum(long requiredSum, int[] set, int[] myArray, int n, int k=0, int counter=0)
    {
        // Method to generate combination without repetition of n elements taken
        // k=myArray.Length no. at a time
        // nCk = n! / k!(n-k)!

        if(k >= myArray.Length)
        {
            if(requiredSum == GetSumOfSubset(set, myArray))
            {
                return true;
            }

            return false;
        }

        bool sumFound = false;
        for(int i = counter; i <= n; i++)
        {
            myArray[k] = i;
            sumFound = DoSubsetHasSum(requiredSum, set, myArray, n, k+1, i+1);
            if(sumFound)
            {
                return sumFound;
            }
        }

        return sumFound;
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


    static void PrintSubset(int[] set, int[] subsetIndices)
    {
        // Method to print subset

        for(int i = 0; i < subsetIndices.Length; i++)
        {
            Console.Write($"{set[subsetIndices[i]]} ");
        }

        Console.WriteLine();
    }


    static long GetSumOfSubset(int[] set, int[] subsetIndices)
    {
        // Method to print subset

        long sum = 0L;

        for(int i = 0; i < subsetIndices.Length; i++)
        {
            sum += set[subsetIndices[i]];
        }

        return sum;
    }


    static void GenerateAllSubsets(int[] set)
    {
        // Method to generate all subsets of given set

        int len = set.Length;
        int n = len - 1;
        for(int k = 1; k <= len; k++)
        {
            int[] subsetIndices = new int[k];
            GenerateCombinationWithoutRepetition(set, subsetIndices, n);
        }
    }


    static bool DoSubsetWithSumExist(long requiredSum, params int[] set)
    {
        // Method to generate all subsets of given set

        int len = set.Length;
        int n = len - 1;
        bool sumFound = false;

        for(int k = 1; k <= len; k++)
        {
            int[] subsetIndices = new int[k];
            sumFound = DoSubsetHasSum(requiredSum, set, subsetIndices, n);
            if(sumFound)
            {
                return sumFound;
            }
        }

        return sumFound;
    }
}