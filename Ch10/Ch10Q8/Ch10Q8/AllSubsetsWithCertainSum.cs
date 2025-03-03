// You are given an array of integers and a number N. Write a recursive 
// program that finds all subsets of numbers in the array, which have a 
// sum N. For example, if we have the array {2, 3, 1, -1} and N=4, we can 
// obtain N=4 as a sum in the following two ways: 4=2+3-1; 4=3+1.

class AllSubsetsWithCertainSum
{
    static void Main()
    {
        int len;
        int requiredSum;

        Console.WriteLine("Program to find all subsets with sum N from the given array");
        len = GetInt("Length of array = ", 1);
        int[] myArray = new int[len];

        Console.WriteLine();
        Console.WriteLine("Enter elements in the array");
        InitArray(myArray);

        Console.WriteLine();
        requiredSum = GetInt("Sum N = ");

        Console.WriteLine();
        Console.WriteLine($"Given array:");
        PrintArray(myArray);
        Console.WriteLine();
        Console.WriteLine($"Subsets with sum {requiredSum}:");
        PrintAllSubsets(requiredSum, myArray);
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


    static void GenerateCombinationWithoutRepetition(int requiredSum, int[] set, int[] myArray, int n, int k=0, int counter=0)
    {
        // Method to generate combination of n elements taken k=myArray.Length at a time
        // without repetition
        // nPk = n! / k!(n-k)!

        if(k >= myArray.Length)
        {
            PrintSubsetIfSum(set, myArray, requiredSum);
            return;
        }

        for(int i = counter; i <= n; i++)
        {
            myArray[k] = i;
            GenerateCombinationWithoutRepetition(requiredSum, set, myArray, n, k+1, i+1);
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


    static void PrintSubset(int[] set, int[] indicies)
    {
        // Method to print subset

        for(int i = 0; i < indicies.Length; i++)
        {
            Console.Write($"{set[indicies[i]]} ");
        }

        Console.WriteLine();
    }


    static void PrintSubsetIfSum(int[] set, int[] indicies, int requiredSum)
    {
        // Method to print subset if sum == requiredSum

        int sum = 0;
        int len = indicies.Length;
        for(int i = 0; i < len; i++)
        {
            sum += set[indicies[i]];
        }

        if(sum != requiredSum)
        {
            return;
        }

        for(int i = 0; i < indicies.Length; i++)
        {
            Console.Write($"{set[indicies[i]]} ");
        }

        Console.WriteLine();
    }


    static void GenerateAllCombinationWithoutRepetition(int requiredSum, int[] set, int n)
    {
        // Method to generate all combination without repetition, nCk for k[1,n]
        // nCk = n! / k!(n-k)!

        for(int k = 1; k <= n; k++)
        {
            int[] myArray = new int[k];

            GenerateCombinationWithoutRepetition(requiredSum, set, myArray, n);
        }
    }


    static void PrintAllSubsets(int requiredSum, params int[] set)
    {
        // Method to print all subsets of given array

        int len =  set.Length;
        int n = len - 1;

        GenerateAllCombinationWithoutRepetition(requiredSum, set, n);
    }


    static void InitArray(int[] myArray)
    {
        // Method to initialise the array by user inputs

        for(int i = 0; i < myArray.Length; i++)
        {
            myArray[i] = GetInt($"myArray[{i}] = ");
        }
    }
}