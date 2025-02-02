// In combinatorics, the Catalan numbers are calculated by the following 
// formula: (2n)! / ((n+1)! * n!) for n ≥ 0. Write a program that 
// calculates the nth Catalan number by given n.

class NthCatalanNum
{
    static void Main()
    {
        int n;
        bool isInt;

        Console.WriteLine("Program to calculate nth Catalan num.");
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

        int twoN = 2*n;
        int nPlus1 = n+1;
        ulong nFac, twoNFac, nPlus1Fac;
        nFac = twoNFac = nPlus1Fac = 1;

        for(int i = 2; i <= n; i++)
        {
            nFac *= (ulong)i;
        }

        for(int i = 2; i <= twoN; i++)
        {
            twoNFac *= (ulong)i;
        }

        for(int i = 2; i <= nPlus1; i++)
        {
            nPlus1Fac *= (ulong)i;
        }

        double result = twoNFac / (nPlus1Fac * nFac);

        Console.WriteLine($"{n}th Catalan num = {result:f2}");
    }
}