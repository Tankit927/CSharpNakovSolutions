// Write a method that prints the digits of a given decimal number in a 
// reversed order. For example 256, must be printed as 652.

using System.ComponentModel;

class ReversedOrder
{
    static void Main()
    {
        int n;

        Console.WriteLine("Program to print digits of given integer number in " +
        "reversed order.");
        n = GetInt("Num = ");
        PrintInReverseOrder(n);
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


    static void PrintInReverseOrder(int num)
    {
        // Method to print given integer in reverse order

        Console.Write(num < 0 ? "-" : "");
        num = Math.Abs(num);
        do
        {
            Console.Write(num % 10);
            num /= 10;
        }
        while(num != 0);

        Console.WriteLine();
    }
}