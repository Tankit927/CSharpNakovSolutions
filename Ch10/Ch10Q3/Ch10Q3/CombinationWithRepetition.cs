// Write a program to generate and print all combinations with 
// duplicates of k elements from a set with n elements. Sample input:
// n = 3 
// k = 2 
// Sample output: 
// (1 1), (1 2), (1 3), (2 2), (2 3), (3 3) 
// Think about and implement an iterative algorithm for the same task.

class CombinationWithRepetition
{
    static void Main()
    {
        int n, k;

        Console.WriteLine("Program to find combination of n elements taken k at a time " +
        "with repetition.");
        n = GetInt("n = ", 1);
        k = GetInt("k = ", 1);
        int[] myArray = new int[k];

        Console.WriteLine();
        Console.WriteLine($"nCk recursively, n = {n}, k = {k}");
        PrintCombinationRecursively(myArray, n);

        Console.WriteLine();
        Console.WriteLine($"nCk iteratively, n = {n}, k = {k}");
        PrintCombinationIteratively(myArray, n);
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


    static void PrintCombinationRecursively(int[] myArray, int n, int k=0, int counter=1)
    {
        // Method to generate combination of n elements taken k at a time recursively
        // nCk = (n+k-1)! / k!(n-1)!

        if(k >= myArray.Length)
        {
            PrintArray(myArray);
            return;
        }

        for(int i = counter; i <= n; i++)
        {
            myArray[k] = i;
            PrintCombinationRecursively(myArray, n, k+1, i);
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


    static void PrintCombinationIteratively(int[] myArray, int n)
    {
        // Method to generate combination of n elements taken k=myArray.Lenght times
        // with repetition
        // nCk = (n+k-1)! / k!(n-1)!

        InitArray(myArray);
        PrintArray(myArray);

        int len = myArray.Length;
        int i = len - 1;

        while(i >= 0)
        {
            i = len - 1;
            if(myArray[i]+1 <= n)
            {
                myArray[i] += 1;
                PrintArray(myArray);
            }
            else
            {
                while(i >= 0)
                {
                    if(myArray[i]+1 <= n)
                    {
                        myArray[i] += 1;
                        for(int j = i+1; j < len; j++)
                        {
                            myArray[j] = myArray[i];
                        }

                        PrintArray(myArray);
                        break;
                    }
                    else
                    {
                        i -= 1;
                    }
                }
            }
        }
    }


    static void InitArray(int[] myArray)
    {
        // Method to initialise the given array

        for(int i = 0; i < myArray.Length; i++)
        {
            myArray[i] = 1;
        }
    }
}