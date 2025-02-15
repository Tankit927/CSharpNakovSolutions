// Write a program, which finds the most frequently occurring element in 
// an array. Example: {4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3} -> 4 (5 times).

class MostFrequentElement
{
    static void Main()
    {
        int len;
        bool isInt;

        Console.WriteLine("Program to find the most frequently occuring " +
        "element in an array.");

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
        int[] uniqueElements = new int[len];
        for(int i = 0; i < len; i++)
        {
            uniqueElements[i] = int.MinValue;
        }
        Console.WriteLine("Enter elements in the array");
        for(int i = 0; i < len; i++)
        {
            do
            {
                Console.Write($"myArray[{i}] = ");
                isInt = int.TryParse(Console.ReadLine(), out myArray[i]);
                if(!isInt)
                {
                    Console.WriteLine($"\nEnter a valid integer in range[{int.MinValue+1},{int.MaxValue}]");
                }
            }
            while(!isInt);
        }

        // Logic to find most frequent element
        int maxCount = 1, bestElement = int.MinValue;
        for(int i = 0; i < len-1; i++)
        {
            int count = 1;
            if(uniqueElements.Contains(myArray[i]))
            {
                continue;
            }
            uniqueElements[i] = myArray[i];
            for(int j = i+1; j < len; j++)
            {
                if(myArray[j] == myArray[i])
                {
                    count += 1;
                }
            }

            if(count > maxCount)
            {
                maxCount = count;
                bestElement = myArray[i];
            }
        }

        // Print given array and most frequent element
        Console.WriteLine();
        Console.Write("myArray = ");
        foreach(int i in myArray)
        {
            Console.Write($"{i} ");
        }
        Console.WriteLine();
        Console.WriteLine($"Most frequent element = {bestElement} ({maxCount} times)");
    }
}