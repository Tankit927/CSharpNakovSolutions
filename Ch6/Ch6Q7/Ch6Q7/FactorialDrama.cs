// Write a program that calculates N!*K!/(N-K)! for given N and K 
// (1<K<N).

class FactorialDrama
{
    static void Main()
    {
        int n, k;
        bool isInt;

        Console.WriteLine("Program to calculate N!*K!/(N-K)!");
        do
        {
            Console.Write("n = ");
            isInt = int.TryParse(Console.ReadLine(), out n);
            if(!isInt || n < 3)
            {
                Console.WriteLine($"\nEnter a valid number in range [3,{int.MaxValue}]");
            }
        }
        while(!isInt || n < 3);

        do
        {
            Console.Write("k = ");
            isInt = int.TryParse(Console.ReadLine(), out k);
            if(!isInt || k < 2 || k >= n)
            {
                Console.WriteLine($"\nEnter a valid number in range [2,{n-1}]");
            }
        }
        while(!isInt || k < 2 || k >= n);

        int nMinusK = n-k;
        ulong nFac, kFac, nMinusKFac;
        nFac = kFac = nMinusKFac = 1;

        for(int i = 2; i <= n; i++)
        {
            nFac *= (ulong)i;
        }

        for(int i = 2; i <= k; i++)
        {
            kFac *= (ulong)i;
        }

        for(int i = 2; i <= nMinusK; i++)
        {
            nMinusKFac *= (ulong)i;
        }

        double result = (nFac * kFac) / nMinusKFac;

        Console.WriteLine($"{n}!*{k}!/({n}-{k})! = {result:f2}");
    }
}