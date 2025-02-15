// Write a program, which reads from the console two integer numbers N 
// and K (K<N) and array of N integers. Find those K consecutive 
// elements in the array, which have maximal sum.

class MaxSumOfKConsecutiveElements
{
    static void Main()
    {
        int n, k;
        bool isInt;

        Console.WriteLine("Program to find K consecutive elements in the " +
        "given array which has max sum.");

        // User inputs
        do
        {
            Console.Write("Length of array = ");
            isInt = int.TryParse(Console.ReadLine(), out n);
            if(!isInt || n < 1)
            {
                Console.WriteLine($"\nEnter a valid integer in range[1, {int.MaxValue}]");
            }
        }
        while(!isInt || n < 1);

        do
        {
            Console.Write($"k(k<{n}) = ");
            isInt = int.TryParse(Console.ReadLine(), out k);
            if(!isInt || k >= n)
            {
                Console.WriteLine($"\nEnter a valid integer in range[1,{n-1}]");
            }
        }
        while(!isInt || k >= n);

        int[] myArray = new int[n];
        Console.WriteLine("Enter the elements in the array");
        for(int i = 0; i < n; i++)
        {
            do
            {
                Console.Write($"myArray[{i}] = ");
                isInt = int.TryParse(Console.ReadLine(), out myArray[i]);
                if(!isInt)
                {
                    Console.WriteLine($"\nEnter a valid integer in range[{int.MinValue},{int.MaxValue}]");
                }
            }
            while(!isInt);
        }

        // Logic to find bestStartIndex of k consecutive elements with max sum
        long maxSum = 0;
        int bestStartIndex = 0;
        for(int i = 0; i < n; i++)
        {
            long sum = 0;
            for(int j = i; j < i+k && j < n; j++)
            {
                sum += myArray[j];
                if(sum > maxSum)
                {
                    maxSum = sum;
                    bestStartIndex = i;
                }
            }
        }

        // Print given array, max sum of k consecutive elements and k consecutive elements
        Console.WriteLine();
        Console.Write("myArray = ");
        foreach(int i in myArray)
        {
            Console.Write($"{i} ");
        }
        Console.WriteLine();

        Console.WriteLine($"Max sum of {k} consecutive elements = {maxSum}");
        Console.Write($"{k} consecutive elements = ");
        for(int i = bestStartIndex; i < bestStartIndex+k; i++)
        {
            Console.Write($"{myArray[i]} ");
        }
    }
}