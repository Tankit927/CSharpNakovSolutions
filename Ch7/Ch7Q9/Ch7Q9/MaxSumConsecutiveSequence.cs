// Write a program, which finds a subsequence of numbers with 
// maximal sum. E.g.: {2, 3, -6, -1, 2, -1, 6, 4, -8, 8} -> 11

class MaxSumConsecutiveSequence
{
    static void Main()
    {
        int len;
        bool isInt;

        Console.WriteLine("Program to find consecutive sequence with max sum " +
        "in given array.");

        // User inputs
        do
        {
            Console.Write("Length of array = ");
            isInt = int.TryParse(Console.ReadLine(), out len);
            if(!isInt || len < 1)
            {
                Console.WriteLine($"\nEnter a valid integer in range[1,{int.MaxValue}]");
            }
        }
        while(!isInt || len < 1);

        int[] myArray = new int[len];
        Console.WriteLine("Enter the elements in the array");
        for(int i = 0; i < len; i++)
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

        // Logic to find Max Sum Consecutive Sequence
        long maxSum;
        int bestStartIndex, bestEndIndex;
        bestStartIndex = bestEndIndex = 0;
        maxSum = long.MinValue;
        for(int i = 0; i < len; i++)
        {
            long sum = 0;
            for(int j = i; j < len; j++)
            {
                sum += myArray[j];
                if(sum > maxSum)
                {
                    maxSum = sum;
                    bestStartIndex = i;
                    bestEndIndex = j;
                }
            }
        }

        // Print given array, max sum and max sum consecutive sequence
        Console.WriteLine();
        Console.Write("myArray = ");
        foreach(int i in myArray)
        {
            Console.Write($"{i} ");
        }
        Console.WriteLine();

        Console.WriteLine($"Max Sum = {maxSum}");
        Console.Write("Max sum consecutive sequence = ");
        for(int i = bestStartIndex; i <= bestEndIndex; i++)
        {
            Console.Write($"{myArray[i]} ");
        }
    }
}