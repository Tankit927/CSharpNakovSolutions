// Write a program that reads an integer number n from the console and 
// prints all numbers in the range [1…n], each on a separate line.

// Need to complete till Ch-9 Methods
class PrintNums
{
    static void Main()
    {
        int n;

        Console.WriteLine("Program to print all integers in range[1,n]");
        n = GetInt("n = ", 1);
        Console.WriteLine();
        PrintOneToN(n);
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


    static void PrintOneToN(int n)
    {
        // Method to print integers form 1...n

        for(int i = 1; i <= n; i++)
        {
            Console.WriteLine(i);
        }
    }
}