// Write a program that checks if a given number n (1 < n < 100) is a 
// prime number (i.e. it is divisible without remainder only to itself and 1).

// Need to complete till Ch-6 Loops for this question.
class CheckPrime
{
    static void Main()
    {
        int n;
        bool isInt;

        Console.WriteLine("Program to check whether given number " +
        "n (1 < n < 100) is a prime number or not.");
        do
        {
            Console.Write("n = ");
            isInt = int.TryParse(Console.ReadLine(), out n);
            if(!isInt || n <= 1 || n >= 100)
            {
                Console.WriteLine($"\nEnter a valid integer in range (1,100)");
            }
        }
        while(!isInt || n <= 1 || n >= 100);

        bool isPrime = true;
        for(int i = (int)Math.Sqrt(n); i > 1; i--)
        {
            if(n % i == 0)
            {
                isPrime = false;
                break;
            }
        }

        Console.WriteLine($"Is Prime = {isPrime}");
    }
}