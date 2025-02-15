// Write a program, which finds the maximal sequence of consecutively 
// placed increasing integers. Example: {3, 2, 3, 4, 2, 2, 4} -> {2, 3, 4}.

class MaxSequenceOfConsecutivelyIncreasingNums
{
    static void Main()
    {
        int len;
        bool isInt;

        Console.WriteLine("Program to find max sequence of consecutively " +
        "placed increasing integers in given array");

        // User inputs
        do
        {
            Console.Write("Lenght of array = ");
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

        // Logic to find bestStartIndex and maxCount of consecutively increasing nums
        int currentStartIndex, bestStartIndex, index, currentCount, maxCount, temp;
        currentStartIndex = bestStartIndex = 0;
        index = currentCount = maxCount = temp = 1;
        while(index < len)
        {
            if(myArray[index] == myArray[currentStartIndex] + temp)
            {
                currentCount += 1;
                temp += 1;
            }
            else
            {
                temp = 1;
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

        Console.Write("Max sequence of increasing nums = ");
        for(int i = bestStartIndex; i < bestStartIndex + maxCount; i++)
        {
            Console.Write($"{myArray[i]} ");
        }
        Console.WriteLine();
    }
}