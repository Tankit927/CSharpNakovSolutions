// Write a program, which reads the integer numbers N and K from the 
// console and prints all variations of K elements of the numbers in the 
// interval [1…N]. Example: N = 3, K = 2 -> {1, 1}, {1, 2}, {1, 3}, {2, 1}, 
// {2, 2}, {2, 3}, {3, 1}, {3, 2}, {3, 3}.

class PermutationWithRepetition
{
    static void Main()
    {
        int n, k;

        Console.WriteLine("Program to print permutation of n elements taken k at a time.");
        n = GetInt("N = ", 1);
        k = GetInt("K = ", 1);
        int[] myArray = new int[k];

        Console.WriteLine();
        GeneratePermutationWithRepetition(myArray, n);
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


    static void GeneratePermutationWithRepetition(int[] myArray, int n, int index=0)
    {
        // Method to generate permutation of n elements taken myArray.Length at a time
        // with repetition.

        if(index >= myArray.Length)
        {
            PrintArray(myArray);
            return;
        }

        for(int i = 1; i <= n; i++)
        {
            myArray[index] = i;
            GeneratePermutationWithRepetition(myArray, n, index+1);
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