// Write a program, which reads an integer number N from the console and 
// prints all combinations of K elements of numbers in range [1 … N].
// Example:N = 5, K = 2 -> {1, 2}, {1, 3}, {1, 4}, {1, 5}, {2, 3}, {2, 4}, 
// {2, 5}, {3, 4}, {3, 5}, {4, 5}.

class CombinationWithoutRepetition
{
    static void Main()
    {
        int n, k;

        Console.WriteLine("Program to print all combinations of n elements taken k at a " +
        "time without repetition.");
        n = GetInt("N = ", 1);
        k = GetInt("K = ", 1, n);
        int[] myArray = new int[k];

        Console.WriteLine();
        GenerateCombinationWithoutRepetition(myArray, n);
    }


    static int GetInt(string prompt, int? min=null, int? max=null)
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


    static void GenerateCombinationWithoutRepetition(int[] myArray, int n, int index=0, int counter=1)
    {
        // Method to generate combination of n elements taken myArray.Length at a time
        // without repetition

        if(index >= myArray.Length)
        {
            PrintArray(myArray);
            return;
        }

        for(int i = counter; i <= n; i++)
        {
            myArray[index] = i;
            GenerateCombinationWithoutRepetition(myArray, n, index+1, i+1);
        }
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
}