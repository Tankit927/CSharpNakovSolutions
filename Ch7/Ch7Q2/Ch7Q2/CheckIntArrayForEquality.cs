// Write a program, which reads two arrays from the console and checks 
// whether they are equal (two arrays are equal when they are of equal 
// length and all of their elements, which have the same index, are equal).

class CheckIntArrayForEquality
{
    static void Main()
    {
        int len1, len2;
        bool isInt;

        Console.WriteLine("Program to check whether two given integer arrays " +
        "are equal or not.");

        // User input length of both arrays
        do
        {
            Console.Write("Length of array1 = ");
            isInt = int.TryParse(Console.ReadLine(), out len1);
            if(!isInt || len1 < 1)
            {
                Console.WriteLine($"\nEnter a valid integer in range [1,{int.MaxValue}]");
            }
        }
        while(!isInt || len1 < 1);

        int[] array1 = new int[len1];
        Console.WriteLine("\nEnter elements in array1");
        for(int i = 0; i < len1; i++)
        {
            do
            {
                Console.Write($"array1[{i}] = ");
                isInt = int.TryParse(Console.ReadLine(), out array1[i]);
                if(!isInt)
                {
                    Console.WriteLine($"\nEnter a valid integer in range[{int.MinValue},{int.MaxValue}]");
                }
            }
            while(!isInt);
        }

        // User input elements of both arrays
        Console.WriteLine();
        do
        {
            Console.Write("Length of array2 = ");
            isInt = int.TryParse(Console.ReadLine(), out len2);
            if(!isInt || len2 < 1)
            {
                Console.WriteLine($"\nEnter a valid integer in range [1,{int.MaxValue}]");
            }
        }
        while(!isInt || len2 < 1);

        int[] array2 = new int[len2];
        Console.WriteLine("\nEnter elements in array1");
        for(int i = 0; i < len2; i++)
        {
            do
            {
                Console.Write($"array1[{i}] = ");
                isInt = int.TryParse(Console.ReadLine(), out array2[i]);
                if(!isInt)
                {
                    Console.WriteLine($"\nEnter a valid integer in range[{int.MinValue},{int.MaxValue}]");
                }
            }
            while(!isInt);
        }

        // Print both arrays
        Console.WriteLine();
        Console.Write("array1 = ");
        foreach(int i in array1)
        {
            Console.Write($"{i} ");
        }
        Console.WriteLine();
        Console.Write("array2 = ");
        foreach(int i in array2)
        {
            Console.Write($"{i} ");
        }
        Console.WriteLine();

        // Check whether two arrays are equal or not
        Console.WriteLine();
        bool areArraysEqual = true;
        if(len1 != len2)
        {
            areArraysEqual = false;
        }
        else
        {
            for(int i = 0; i < len1; i++)
            {
                if(array1[i] != array2[i])
                {
                    areArraysEqual = false;
                    break;
                }
            }
        }

        Console.WriteLine($"array1 and array2 are {(areArraysEqual ? "equal" : "not equal")}");
    }
}