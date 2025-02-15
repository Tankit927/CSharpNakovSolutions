// Write a program, which finds the maximal sequence of increasing 
// elements in an array arr[n]. It is not necessary the elements to be 
// consecutively placed. E.g.: {9, 6, 2, 7, 4, 7, 6, 5, 8, 4} -> {2, 4, 6, 8}.

class MaxSequenceOfIncreasingElements
{
    static void Main()
    {
        int len;
        bool isInt;

        Console.WriteLine("Program to find max sequence of increasing elements " +
        "in given array");

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

        // Logic to find longest increasing sequence
        int[] lis = new int[len];
        for(int i = 0; i < len; i++)
        {
            lis[i] = 1;
        }

        for(int i = 1; i < len; i++)
        {
            for(int j = 0; j < i; j++)
            {
                if(myArray[j] < myArray[i])
                {
                    lis[i] = Math.Max(lis[i], lis[j]+1);
                }
            }
        }

        // Printing myArray and lis
        Console.WriteLine();
        Console.Write("myArray = ");
        foreach(int i in myArray)
        {
            Console.Write($"{i} ");
        }
        Console.WriteLine();
        Console.Write("lis lengths = ");
        foreach(int i in lis)
        {
            Console.Write($"{i} ");
        }
        Console.WriteLine();

        // Logic to print the actual LIS sequence
        int lisIndex = 0;
        int lisCount = 1;
        for(int i = 0; i < len; i++)
        {
            if(lis[i] > lis[lisIndex])
            {
                lisIndex = i;
                lisCount = lis[i];
            }
        }

        string myLis = "";
        for(int i = lisIndex, count = lisCount, prev = myArray[lisIndex]; i >= 0 && count > 0; i--)
        {
            if(lis[i] == count && (i == lisIndex || (myArray[i] < myArray[prev])))
            {
                myLis = myLis.Insert(0, myArray[i].ToString() + " ");
                prev = i;
                count -= 1;
            }
        }

        Console.WriteLine($"LIS = {myLis}");
    }
}