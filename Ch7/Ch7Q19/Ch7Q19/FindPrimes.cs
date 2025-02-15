// Write a program, which finds all prime numbers in the range 
// [1…10,000,000].

class FindPrimes
{
    static void Main()
    {
        Console.WriteLine("Program to find all prime numbers in range[1...10,000,000]");

        int len = 10_000_000;
        int[] myArray = new int[len];
        for(int i = 0; i < len; i++)
        {
            myArray[i] = i+2;
        }

        Console.WriteLine("Prime numbers:");
        
        // Sieve of earthosthenes logic
        int[] marked = new int[len];

        for(int i = 0; i < len; i++)
        {
            if(marked[i] == 1)
            {
                continue;
            }

            Console.Write($"{myArray[i]:n0} ");
            for(int j = (myArray[i]*myArray[i])-2; j < len && j >= 0; j += myArray[i])
            {
                marked[j] = 1;
            }
        }
    }
}