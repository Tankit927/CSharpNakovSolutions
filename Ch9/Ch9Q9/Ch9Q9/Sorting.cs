// Write a method that finds the biggest element of an array. Use that 
// method to implement sorting in descending order.

class Sorting
{
    static void Main()
    {
        int len;

        Console.WriteLine("Program to sort given array in descending order.");
        len = GetInt("Length of array = ", 1);

        int[] myArray = new int[len];
        InitArray(myArray);

        Console.WriteLine();
        Console.WriteLine("Given array:");
        PrintArray(myArray);
        SortInDescendingOrder(myArray);
        Console.WriteLine();
        Console.WriteLine("Sorted array in descending order:");
        PrintArray(myArray);
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


    static void InitArray(int[] myArray)
    {
        // Method to initialise given array

        for(int i = 0; i < myArray.Length; i++)
        {
            myArray[i] = GetInt($"myArray[{i}] = ");
        }
    }


    static int IndexOfBiggestElement(int[] myArray, int startIndex = 0, int? lastIndex = null)
    {
        // Method to return index of biggest element in given array
        // from [startIndex, lastIndex]

        lastIndex = lastIndex == null ? myArray.Length-1 : lastIndex;
        int bestIndex = startIndex;

        for(int i = startIndex+1; i <= lastIndex; i++)
        {
            if(myArray[i] > myArray[bestIndex])
            {
                bestIndex = i;
            }
        }

        return bestIndex;
    }


    static void SortInDescendingOrder(params int[] myArray)
    {
        // Method to sort given array in descending order

        int len = myArray.Length;
        for(int i = 0; i < len-1; i++)
        {
            int biggestElementIndex = IndexOfBiggestElement(myArray, i);
            int temp = myArray[i];
            myArray[i] = myArray[biggestElementIndex];
            myArray[biggestElementIndex] = temp;
        }
    }


    static void PrintArray(params int[] myArray)
    {
        // Method to print given array

        int len = myArray.Length;

        Console.Write("{");
        for(int i = 0; i < len; i++)
        {
            if(i < len-1)
            {
                Console.Write($"{myArray[i]}, ");
            }
            else
            {
                Console.Write($"{myArray[i]}");
            }
        }

        Console.WriteLine("}");
    }
}