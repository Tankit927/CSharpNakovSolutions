// Write a program that reads five numbers from the console and prints the 
// greatest of them.

// Need to complete till Ch-9 Methods

class FindGreatest
{
    static void Main()
    {
        int len;

        Console.WriteLine("Program to find greatest of given integers");
        len = GetInt("No. of integers you'll enter = ", 1);
        int[] myArray = new int[len];
        InitArray(myArray);

        Console.WriteLine();
        Console.WriteLine($"Greatest integer = {MaxInArray(myArray)}");
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
        // Method to initialise the given array

        for(int i = 0; i < myArray.Length; i++)
        {
            myArray[i] = GetInt($"Num{i} = ");
        }
    }


    static int MaxInArray(params int[] myArray)
    {
        // Method to return max value from given array

        int bestIndex = 0;

        for(int i = 1; i < myArray.Length; i++)
        {
            if(myArray[i] > myArray[bestIndex])
            {
                bestIndex = i;
            }
        }

        return myArray[bestIndex];
    }
}