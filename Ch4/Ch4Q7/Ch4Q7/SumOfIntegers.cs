// Write a program that reads five integer numbers and prints their 
// sum. If an invalid number is entered the program should prompt the user 
// to enter another number.

// Need to complete till Ch-9 Methods

class SumOfIntegers
{
    static void Main()
    {
        int len;

        Console.WriteLine("Program to find sum of given integers");
        len = GetInt("No. of integers you'll enter = ", 1);
        int[] myArray = new int[len];
        InitArray(myArray);
        long sum = SumOf(myArray);

        Console.WriteLine();
        Console.WriteLine($"Sum = {sum:n0}");
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
            if(!isInt || (min != null && num < min) || (min != null && num > max))
            {
                Console.WriteLine($"\nEnter a valid integer in range[{(min == null ? int.MinValue : min)},{(max == null ? int.MaxValue : max)}]");
            }
        }
        while(!isInt || (min != null && num < min) || (min != null && num > max));

        return num;
    }


    static void InitArray(int[] myArray)
    {
        // Method to initialise given array

        for(int i = 0; i < myArray.Length; i++)
        {
            myArray[i] = GetInt($"Num{i} = ");
        }
    }


    static long SumOf(params int[] myArray)
    {
        // Method to return sum of the elements of the given array

        long sum = 0L;

        foreach(int i in myArray)
        {
            sum += i;
        }

        return sum;
    }
}