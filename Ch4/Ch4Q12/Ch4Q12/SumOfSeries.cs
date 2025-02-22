// Write a program that calculates the sum (with precision of 0.001) of 
// the following sequence: 1 + 1/2 - 1/3 + 1/4 - 1/5 + … 

// Need to complete till Ch-9 Methods

class SumOfSeries
{
    static void Main()
    {
        int n;

        Console.WriteLine("Program to calculate sum of series");
        Console.WriteLine("1 + 1/2 - 1/3 + 1/4 - 1/5 + ... upto n terms");
        n = GetInt("n = ", 1);
        double sum = GetSum(n);

        Console.WriteLine($"Sum = {sum:f3}");
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


    static double GetSum(int n)
    {
        // Method to find sum of series 1 + 1/2 - 1/3 + 1/4 - 1/5 + ... upto n terms

        double s = 1.0;

        for(int i = 2; i <= n; i++)
        {
            if(i % 2 == 0)
            {
                s += (1.0/i);
            }
            else
            {
                s -= (1.0/i);
            }
        }

        return s;
    }
}