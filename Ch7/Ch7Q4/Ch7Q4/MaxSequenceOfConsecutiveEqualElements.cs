// Write a program, which finds the maximal sequence of consecutive 
// equal elements in an array. E.g.: {1, 1, 2, 3, 2, 2, 2, 1} -> {2, 2, 2}.

class MaxSequenceOfConsecutiveEqualElements
{
    static void Main()
    {
        int len;
        bool isInt;

        Console.WriteLine("Program to find the max sequence of consecutive " +
        "equal elements in given array.");
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

        // Logic to find bestStartIndex and maxCount of max sequence of consecutive equal elements
        int currentStartIndex, bestStartIndex, maxCount, currentCount, index;
        currentStartIndex = bestStartIndex = 0;
        currentCount = maxCount = index = 1;
        while(index < len)
        {
            if(myArray[index] == myArray[currentStartIndex])
            {
                currentCount += 1;
            }
            else
            {
                currentCount = 1;
                currentStartIndex = index;
            }

            if(currentCount > maxCount)
            {
                maxCount = currentCount;
                bestStartIndex = currentStartIndex;
            }

            index += 1;
        }

        // Printing on console
        Console.WriteLine();
        Console.Write("myArray = ");
        foreach(int i in myArray)
        {
            Console.Write($"{i} ");
        }
        Console.WriteLine();

        Console.Write("Max consecutive sequence of equal elements = ");
        for(int i = bestStartIndex; i < bestStartIndex + maxCount; i++)
        {
            Console.Write($"{myArray[i]} ");
        }
        Console.WriteLine();
    }
}