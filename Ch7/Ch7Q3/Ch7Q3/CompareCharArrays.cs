// Write a program, which compares two arrays of type char 
// lexicographically (character by character) and checks, which one is first 
// in the lexicographical order.

class CompareCharArrays
{
    static void Main()
    {
        int len1, len2;
        bool isInt, isChar;

        Console.WriteLine("Program to compare two given char arrays " +
        "lexicographically and tell which one is first");

        // User input length of both arrays
        do
        {
            Console.Write("Length of array1 = ");
            isInt = int.TryParse(Console.ReadLine(), out len1);
            if(!isInt || len1 < 1)
            {
                Console.WriteLine($"\nEnter a valid integer in range[1,{int.MaxValue}]");
            }
        }
        while(!isInt || len1 < 1);

        do
        {
            Console.Write("Length of array2 = ");
            isInt = int.TryParse(Console.ReadLine(), out len2);
            if(!isInt || len2 < 1)
            {
                Console.WriteLine($"\nEnter a valid integer in range[1,{int.MaxValue}]");
            }
        }
        while(!isInt || len2 < 1);

        // User input elements in both arrays
        char[] array1 = new char[len1];
        Console.WriteLine();
        Console.WriteLine("Enter elements in array1");
        for(int i = 0; i < len1; i++)
        {
            do
            {
                Console.Write($"array1[{i}] = ");
                isChar = char.TryParse(Console.ReadLine(), out array1[i]);
                if(!isChar)
                {
                    Console.WriteLine($"\nEnter a valid char value");
                }
            }
            while(!isChar);
        }

        char[] array2 = new char[len2];
        Console.WriteLine();
        Console.WriteLine("Enter elements in array2");
        for(int i = 0; i < len2; i++)
        {
            do
            {
                Console.Write($"array2[{i}] = ");
                isChar = char.TryParse(Console.ReadLine(), out array2[i]);
                if(!isChar)
                {
                    Console.WriteLine($"\nEnter a valid char value");
                }
            }
            while(!isChar);
        }

        // Logic to check which array is first in lexicographical order
        bool array2First = true;
        bool equalElements = true;
        for(int i = 0, j = 0; i < len1 && j < len2; i++, j++)
        {
            if(array1[i] == array2[j])
            {
                continue;
            }
            else if(array1[i] < array2[j])
            {
                array2First = false;
                equalElements = false;
                break;
            }
            else
            {
                equalElements = false;
                break;
            }
        }

        if(equalElements && len1 <= len2)
        {
            array2First = false;
        }

        // Print arrays in order
        Console.WriteLine();
        if(array2First)
        {
            Console.WriteLine("array2 is first");
            Console.Write("array2 = ");
            foreach(char i in array2)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();
            Console.Write("array1 = ");
            foreach(char i in array1)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine("array1 is first");
            Console.Write("array1 = ");
            foreach(char i in array1)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();
            Console.Write("array2 = ");
            foreach(char i in array2)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();
        }
    }
}