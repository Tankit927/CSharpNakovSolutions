// Write a program that reads from the console a positive integer number 
// N (N < 20) and prints a matrix of numbers as on the figures below:
// For N = 3
// 1 2 3
// 2 3 4
// 3 4 5

class Matrix
{
    static void Main()
    {
        int n;
        bool isInt;

        Console.WriteLine("Program to read a positive integer n (n < 20) " +
        "from console and prints a matrix of numbers.");
        do
        {
            Console.Write("n = ");
            isInt = int.TryParse(Console.ReadLine(), out n);
            if(!isInt || n < 1 || n >= 20)
            {
                Console.WriteLine($"\nEnter a valid integer in range [1,19]");
            }
        }
        while(!isInt || n < 1 || n >= 20);

        for(int row = 1; row <= n; row++)
        {
            for(int col = row, times = 1; times <= n; col++, times++)
            {
                Console.Write($"{col,2} ");
            }

            Console.WriteLine();
        }
    }
}