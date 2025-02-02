// Write a program that calculates N!/K! for given N and K (1<K<N).

class NFactorialByKFactorial
{
    static void Main()
    {
        int n, k;
        ulong nFac, kFac;
        nFac = kFac = 1;
        bool isInt;

        Console.WriteLine("Program to calculate N!/K!");
        do
        {
            Console.Write("n = ");
            isInt = int.TryParse(Console.ReadLine(), out n);
            if(!isInt || n < 3)
            {
                Console.WriteLine($"\nEnter a valid interger in range [3,{int.MaxValue}]");
            }
        }
        while(!isInt || n < 3);

        do
        {
            Console.Write("k = ");
            isInt = int.TryParse(Console.ReadLine(), out k);
            if(!isInt || k <= 1 || k >= n)
            {
                Console.WriteLine($"\nEnter a valid interger in range [2,{n-1}]");
            }
        }
        while(!isInt || k <= 1 || k >= n);

        for(int i = 2; i <= n; i++)
        {
            nFac *= (ulong)i;
        }

        for(int i = 2; i <= k; i++)
        {
            kFac *= (ulong)i;
        }

        double nFacBykFac  = nFac / kFac;
        Console.WriteLine($"\n{n}!/{k}! = {nFacBykFac:f2}");
    }
}