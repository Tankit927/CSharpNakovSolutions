// Write a program, which reads an array of integer numbers from the 
// console and removes a minimal number of elements in such a way 
// that the remaining array is sorted in an increasing order. 
// Example: {6, 1, 4, 3, 0, 3, 6, 4, 5} -> {1, 3, 3, 4, 5}

// Need to complete Ch-10 Recursion not because recursion is 
// used but because the solution is not straight forward and
// you'll need to learn a bit of dynamic programming for this

class DiscoverHiddenLongestIncreasingSequence
{
    static void Main()
    {
        int[] array1 = {6, 1, 4, 3, 0, 3, 6, 4, 5};

        Console.WriteLine("Given array:");
        PrintArray(array1);
        Console.WriteLine();

        RemoveMinimumElementsToSortArray(array1);
        Console.WriteLine("Array after removing minimum no. of elements to sort it:");
        PrintArray(array1);
        Console.WriteLine();
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


    static void RemoveMinimumElementsToSortArray(int[] myArray)
    {
        // Method to remove minimum no. of elements such that the remaining 
        // array is sorted in increasing order
        // lis[i] is the greatest length of increasing sequence ending at index i

        int len = myArray.Length;
        int[] lis = new int[len];

        for(int i = 0; i < len; i++)
        {
            lis[i] = 1; // All increasing sequences have at least 1 element
        }

        for(int i = 1; i < len; i++)
        {
            for(int j = 0; j < i; j++)
            {
                if(myArray[j] <= myArray[i])
                {
                    lis[i] = MaxOf(lis[i], lis[j]+1);
                }
            }
        }

        int lisIndex = 0;
        int lisCount = 1;

        for(int i = 0; i < len; i++)
        {
            if(lis[i] > lis[lisIndex])
            {
                lisIndex = i;
                lisCount = lis[lisIndex];
            }
        }

        int[] maskLis = new int[len];
        maskLis[lisIndex] = 1;

        for(int i = lisIndex-1, c = lisCount-1, prevLisIndex = lisIndex; i >= 0 && c >= 1; i--)
        {
            if(lis[i] == c && myArray[i] <= myArray[prevLisIndex])
            {
                maskLis[i] = 1;
                c -= 1;
                prevLisIndex = i;
            }
        }

        for(int i = 0; i < len; i++)
        {
            if(maskLis[i] == 0)
            {
                myArray[i] = -1;
            }
        }
    }


    static int MaxOf(int i, int j)
    {
        // Method to return maximum of two given integers

        return i > j ? i : j;
    }
}