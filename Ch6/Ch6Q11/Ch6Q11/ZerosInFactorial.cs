// Write a program that calculates with how many zeroes the factorial of 
// a given number ends. Examples: 
// N = 10 -> N! = 3628800 -> 2 
// N = 20 -> N! = 2432902008176640000 -> 4

class ZerosInFactorial
{
    static void Main()
    {
        int n;
        bool isInt;

        Console.WriteLine("Program to calculate number of zeros " +
        "in the factorial of a given number");
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

        ulong nFac = 1;
        for(int i = 2; i <= n; i++)
        {
            nFac *= (ulong)i;
        }

        int noOfZeros = 0;
        ulong temp = nFac;
        while(temp % 10 == 0)
        {
            noOfZeros++;
            temp /= 10;
        }

        Console.WriteLine($"{n}! = {nFac} -> {noOfZeros}");
    }
}