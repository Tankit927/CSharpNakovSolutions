// You are given an array of positive integers. Write a program that checks 
// whether there is one or more numbers in the array (subset), whose 
// sum is equal to S. Can you solve the task efficiently for large arrays?

// YouTube videos for understanding dynamic programming
// https://youtu.be/s6FhG--P7z0?si=HEvbMCp16XorcidT
// https://youtu.be/34l1kTIQCIA?si=B8WddoCJSf5KBVu1


class CheckIfSomeSubsetWithCertainSumExist
{
    static bool[,] DP;
    static void Main()
    {
        Console.WriteLine("Program to find whether there is a subset with given sum in " +
        "the given array");
        int[] set = {1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30,31,32,33,34,35,36,37,38,39,40,41,42,43,44,45,46,47,48,49,50,51,52,53,54,55,56,57,58,59,60,61,62,63,64,65,66,67,68,69,70,71,72,73,74,75,76,77,78,79,80,81,82,83,84,85,86,87,88,89,90,91,92,93,94,95,96,97,98,99,100};
        long sum = 820;

        int[] set2 = {3, 34, 4, 12, 5, 2};
        long sum2 = 9;

        Console.WriteLine();
        Console.WriteLine("Given array:");
        PrintArray(set2);
        Console.WriteLine();

        Console.WriteLine("Using dynamic programming");
        Console.WriteLine($"Is subset with sum {sum2} possible: {IsSubsetWithSumPossible(sum2, set2)}");
        PrintSubsetWithSum(sum2, set2);
        Console.WriteLine();
        Console.WriteLine($"All subsets with sum {sum2}:");
        PrintAllSubsetsWithSum(sum2, set2);
        Console.WriteLine();

        // Will take awful lot of time for any set greater than 30 elements
        Console.WriteLine("By checking all possible combinations");
        Console.WriteLine($"Is subset with sum {sum2} possible: {DoSubsetWithSumExist(sum2, set2)}");
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


    static bool IsSubsetWithSumPossible(long sum, params int[] myArray)
    {
        // Method to check whether there is a subset in given array with given sum
        // Using dynamic programming

        // 2D array where [r, c] is true if sum c is possible by either
        // excluding or including it in subset myArray[0...r]
        // dp[r,c] = dp[r-1, c] || dp[r-1, c-myArray[r-1]]

        // All elements of column 0 are true because sum 0 is possible from any subset
        // as empty set is subset of all sets.

        // All elements from dp[0,1] to dp[0,sum] is false because any sum > 0 is not
        // possible form empty set

        int len = myArray.Length;
        bool[,] dp = new bool[len + 1, sum + 1];

        for (int r = 0, c = 0; r <= len; r++)
        {
            dp[r, c] = true;
        }

        for (int r = 1; r <= len; r++)
        {
            for (long c = 1; c <= sum; c++)
            {
                if (myArray[r-1] <= c)
                {
                    dp[r, c] = dp[r - 1, c] || dp[r - 1, c - myArray[r - 1]];
                }
                else
                {
                    dp[r, c] = dp[r - 1, c];
                }
            }
        }

        DP = dp;
        return dp[len, sum];
    }


    static void PrintSubsetWithSum(long sum, params int[] myArray)
    {
        // Method to print one subset with given sum
        // Can only be used after generating dp

        long rows = DP.GetLongLength(0);
        long cols = DP.GetLongLength(1);
        long r = rows-1;
        long c = cols-1;

        if(!DP[r,c])
        {
            return;
        }

        while(sum > 0)
        {
            if(DP[r-1, c])
            {
                r -= 1;
            }
            else
            {
                sum -= myArray[r-1];
                Console.Write($"{myArray[r-1]} ");
                c -= myArray[r-1];
                r -= 1;
            }
        }

        Console.WriteLine();
    }


    static void PrintAllSubsetsWithSum(long sum, params int[] myArray)
    {
        // Method to print all subsets with given sum
        // Call another method to recursively find subsets
        // Need to generate dp first

        int[] subset = new int[myArray.Length];
        long r = DP.GetLongLength(0) - 1;
        long c = DP.GetLongLength(1) - 1;

        PrintSubsetWithSum(myArray, sum, subset, r, c);
    }


    static void PrintSubsetWithSum(int[] myArray, long sum, int[] subset, long r, long c)
    {
        // Method to recursively print all subsets with given sum
        // Need to generate dp first

        if(r < 0 || c < 0 || r >= DP.GetLength(0) || c >= DP.GetLength(1) || !DP[r,c])
        {
            return;
        }

        if(sum == 0)
        {
            PrintThisArray(subset);
            return;
        }

        if(DP[r-1, c])
        {
            PrintSubsetWithSum(myArray, sum, subset, r-1, c);
        }

        if(c - myArray[r-1] >= 0 && DP[r-1, c-myArray[r-1]])
        {
            sum -= myArray[r-1];
            subset[r-1] = myArray[r-1];
            PrintSubsetWithSum(myArray, sum, subset, r-1, c-myArray[r-1]);
            subset[r-1] = 0;
        }
    }


    static void PrintThisArray(int[] myArray)
    {
        // Method to print non-zero values of given array

        int len = myArray.Length;

        foreach(int i in myArray)
        {
            if(i != 0)
            {
                Console.Write($"{i} ");
            }
        }

        Console.WriteLine();
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