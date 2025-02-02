// Write a program that for a given integers n and x, calculates the sum:
// S = 0!/x^0 + 1!/x^1 + 2!/x^2 + ... + n!/x^n

class SumOfSeries
{
    static void Main()
    {
        int n, x;
        bool isInt;

        Console.WriteLine("Program to calculate sum of series for given n and x");
        Console.WriteLine("S = 0!/x^0 + 1!/x^1 + 2!/x^2 + ... + n!/x^n");
        do
        {
            Console.Write("n = ");
            isInt = int.TryParse(Console.ReadLine(), out n);
            if(!isInt || n < 0)
            {
                Console.WriteLine($"\nEnter a valid integer in range [0,{int.MaxValue}]");
            }
        }
        while(!isInt || n < 0);

        do
        {
            Console.Write("x = ");
            isInt = int.TryParse(Console.ReadLine(), out x);
            if(!isInt || x < 1)
            {
                Console.WriteLine($"\nEnter a valid integer in range [1,{int.MaxValue}]");
            }
        }
        while(!isInt || x < 1);

        double sum = 0, nFac = 1;

        for(int i = 0; i <= n; i++)
        {
            nFac = 1;
            for(int j = 2; j <= i; j++)
            {
                nFac *= j;
            }
            
            sum += (nFac / Math.Pow(x,i));
        }

        Console.WriteLine($"For n={n} and x={x}");
        Console.WriteLine($"S = {sum}");
    }
}