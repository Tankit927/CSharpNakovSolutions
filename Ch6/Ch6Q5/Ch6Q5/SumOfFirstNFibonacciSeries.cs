// Write a program that reads from the console number N and print the sum 
// of the first N members of the Fibonacci sequence: 0, 1, 1, 2, 3, 5, 8, 
// 13, 21, 34, 55, 89, 144, 233, 377, … 

class SumOfFirstNFibonacciSeries
{
    static void Main()
    {
        int n;
        bool isInt;

        Console.WriteLine("Program to print sum of first N numbers " +
        "of the fibonacci series.");
        do
        {
            Console.Write("Enter n = ");
            isInt = int.TryParse(Console.ReadLine(), out n);
            if(!isInt || n < 1)
            {
                Console.WriteLine($"\nEnter a valid integer in range [1,{int.MaxValue}]");
            }
        }
        while(!isInt || n < 1);

        ulong sum = 0;
        if(n >= 2)
        {
            ulong i1 = 0, i2 = 1, temp;
            sum = i1 + i2;
            for(int index = 3; index <= n; index++)
            {
                temp = i2;
                i2 = i1 + i2;
                i1 = temp;
                sum += i2;
            }
        }

        Console.WriteLine($"Sum of first {n} numbers of fibonacci series = {sum}");
    }
}