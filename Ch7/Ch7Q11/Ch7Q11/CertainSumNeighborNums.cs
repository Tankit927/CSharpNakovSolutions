// Write a program to find a sequence of neighbor numbers in an array, 
// which has a sum of certain number S. Example: {4, 3, 1, 4, 2, 5, 8}, 
// S=11 -> {4, 2, 5}.

class CertainSumNeighborNums
{
    static void Main()
    {
        int len;
        long s;
        bool isInt, isLong;

        Console.WriteLine("Program to find a sequence of neighbor nums in an array " +
        "which has a sum of certain number S");

        // User inputs
        do
        {
            Console.Write("S = ");
            isLong = long.TryParse(Console.ReadLine(), out s);
            if(!isLong)
            {
                Console.WriteLine($"\nEnter a valid integer in range[{long.MinValue},{long.MaxValue}]");
            }
        }
        while(!isLong);

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
        Console.WriteLine();
        Console.WriteLine("Enter elements in the array");
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

        // Logic to find consecutive sequence of numbers with certain given sum
        int bestStartIndex, bestEndIndex;
        bestStartIndex = bestEndIndex = -1;
        for(int i = 0; i < len; i++)
        {
            long sum = 0;
            for(int j = i; j < len; j++)
            {
                sum += myArray[j];
                if(sum == s)
                {
                    bestStartIndex = i;
                    bestEndIndex = j;
                    break;
                }
            }

            if(sum == s)
            {
                break;
            }
        }

        // Print given array, consecutive nums with certain sum if found
        Console.WriteLine();
        Console.Write("myArray = ");
        foreach(int i in myArray)
        {
            Console.Write($"{i} ");
        }
        Console.WriteLine();

        if(bestStartIndex > -1)
        {
            Console.Write($"{s} -> ");
            for(int i = bestStartIndex; i <= bestEndIndex; i++)
            {
                Console.Write($"{myArray[i]} ");
            }
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine($"No consecutive sequence found with sum = {s}");
        }
    }
}