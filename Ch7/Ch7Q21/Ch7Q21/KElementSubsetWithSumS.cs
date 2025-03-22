// Write a program which by given N numbers, K and S, finds K elements out 
// of the N numbers, the sum of which is exactly S or says it is not possible. 
// Example: {3, 1, 2, 4, 9, 6}, S = 14, K = 3 -> yes (1 + 2 + 4 = 14)

// Need to complete till Ch-10 Recursion

class KElementSubsetWithSumS
{
    static bool[,] DP;
    static bool isKElementSubsetSumFound = false;

    static void Main()
    {
        int len;

        Console.WriteLine("Program to print all subsets of K elements with sum S from " +
        "the given set");
        len = GetInt("Enter length of set: ", 1);

        Console.WriteLine();
        int[] myArray = new int[len];
        InitArray(myArray);
        Console.WriteLine();

        int s = GetInt("Enter S: ", 1);
        Console.WriteLine();

        int k = GetInt("Enter K: ", 1);
        Console.WriteLine();

        Console.WriteLine("Given array:");
        PrintArray(myArray);
        Console.WriteLine();

        IsSubsetSum(myArray, s);
        Console.WriteLine($"All subsets of {k} elements with sum {s}:");
        PrintAllSubsetWithRequiredSum(myArray, s, k);
        if(!isKElementSubsetSumFound)
        {
            Console.WriteLine($"No subset of {k} elements with sum {s} found.");
        }
    }


    static void InitArray(int[] myArray)
    {
        // Method to initialize given array with user inputs

        for(int i = 0; i < myArray.Length; i++)
        {
            myArray[i] = GetInt($"myArray[{i}]: ", 1);
        }
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


    static bool IsSubsetSum(int[] myArray, long sum)
    {
        // Method to determine whether there is a subset whose sum is sum
        // using dynamic programming
        // DP[myArray.Length+1, sum+1]
        // myArray elements along row
        // sum along column
        // row index represent max elements taken to make subset
        // And cell value represent whether it is possible to make sum 
        // c(column index) by including or excluding that element r(myArray[r-1])
        //
        // DP[r,0] = true because empty set is subset of every set
        // DP[0,1..sum] = false because no sum is possible from empty set except 0
        // DP[r,c] = DP[r-1, c] || (myArray[r-1] <= c && DP[r-1, c-myArray[r-1]])
        // That is DP[r,c] = cell value right above it or cell value above
        // and left by current column value minus myArray value at current
        // row which is myArray[r-1]

        int len = myArray.Length;
        DP = new bool[len+1, sum+1];

        for(int r = 0; r <= len; r++)
        {
            DP[r,0] = true;
        }

        for(int r = 1; r <= len; r++)
        {
            for(int c = 1; c <= sum; c++)
            {
                DP[r,c] = DP[r-1, c] || (myArray[r-1] <= c && DP[r-1, c-myArray[r-1]]);
            }
        }

        return DP[len, sum];
    }


    static void PrintArray(params int[] myArray)
    {
        // Method to print given array

        foreach(int i in myArray)
        {
            Console.Write($"{i} ");
        }

        Console.WriteLine();
    }


    static void PrintAllSubsetWithRequiredSum(int[] myArray, long sum, int k)
    {
        // Method to print all subsets of k elements with given sum
        // DP needs to be filled first

        int len = myArray.Length;
        int[] subset = new int[len];

        PrintAllSubsets(myArray, subset, k, sum, len, sum);
    }


    static void PrintAllSubsets(int[] myArray, int[] subset, int k, long sum, int r, long c, int terms=0)
    {
        // Method to recursively print all subsets of k elements with given sum
        // DP needs to be filled first

        if(terms == k && sum == 0)
        {
            PrintSubset(subset);
            isKElementSubsetSumFound = true;
            return;
        }
        else if(terms > k)
        {
            return;
        }

        if(DP[r-1, c]) // if exclusion of myArray[r-1] is possible
        {
            PrintAllSubsets(myArray, subset, k, sum, r-1, c, terms);
        }

        if(myArray[r-1] <= c && DP[r-1, c-myArray[r-1]]) // if inclusion on myArray[r-1] is possible
        {
            subset[r-1] = myArray[r-1];
            sum -= myArray[r-1];
            PrintAllSubsets(myArray, subset, k, sum, r-1, c-myArray[r-1], terms+1);
            subset[r-1] = 0;
        }
    }


    static void PrintSubset(int[] myArray)
    {
        // Method to print +ve non-zero values of given array

        foreach(int i in myArray)
        {
            if(i > 0)
            {
                Console.Write($"{i} ");
            }
        }

        Console.WriteLine();
    }
}