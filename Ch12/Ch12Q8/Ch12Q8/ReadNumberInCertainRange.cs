// Write a method ReadNumber(int start, int end) that reads an integer 
// from the console in the range [start…end]. In case the input integer is 
// not valid or it is not in the required range throw appropriate exception. 
// Using this method, write a program that takes 10 integers a1, a2, …, a10 
// such that 1 < a1 < … < a10 < 100.

class ReadNumberInCertainRange
{
    static void Main()
    {
        int len = 10;
        int start = 1; // inclusive
        int end = 100; // inclusive
        int[] myArray = new int[len];

        Console.WriteLine("Program to enter 10 integers");
        for(int i = 0; i < len; i++)
        {
            myArray[i] = ReadNumber($"myArray[{i}]: ",i > 0 ? myArray[i-1]+1 : start, end - (len-i) + 1);
        }

        Console.WriteLine();
        PrintArray(myArray);
    }


    static void PrintArray(params int[] myArray)
    {
        // Method to print given array

        foreach(int i in myArray)
        {
            Console.Write($"{i} ");
        }

        Console.WriteLine();
    }


    static int ReadNumber(string prompt, int start=1, int end=100)
    {
        // Method to read integer in range[start, end]

        int num;

        while(true)
        {
            Console.Write(prompt);
            try
            {
                num = int.Parse(Console.ReadLine());
                if(num < start || num > end)
                {
                    Console.WriteLine($"Enter integer in range[{start},{end}]");
                    continue;
                }

                return num;
            }
            catch(Exception e)
            {
                Console.WriteLine();
                Console.WriteLine($"Error: {e.Message}");
                Console.WriteLine($"Enter integer in range[{start},{end}]");
            }
        }
    }
}