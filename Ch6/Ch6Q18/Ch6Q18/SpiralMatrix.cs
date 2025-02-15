// * Write a program that for a given number n, outputs a matrix in the 
// form of a spiral:
// For n = 4
//
//  1  2  3  4
//  12 13 14 5
//  11 16 15 6
//  10 9  8  7

// Need to complete Ch-7 Arrays

class SpiralMatrix
{
    static void Main()
    {
        int n;
        bool isInt;

        Console.WriteLine("Program to print a spiral matrix of size n");

        // User input
        do
        {
            Console.Write("n = ");
            isInt = int.TryParse(Console.ReadLine(), out n);
            if(!isInt || n < 1)
            {
                Console.WriteLine($"\nEnter a valid integer in range[1,{int.MaxValue}]");
            }
        }
        while(!isInt || n < 1);

        int[,] mat = new int[n,n];

        // Spiral matrix logic
        int rMin, rMax, cMin, cMax, num;
        rMin = cMin = 0;
        rMax = cMax = n - 1;
        num = 1;

        while(true)
        {
            if(rMin > rMax || cMin > cMax)
            {
                break;
            }
            for(int c = cMin, r = rMin; c <= cMax; c++) // Traversing col++
            {
                mat[r,c] = num;
                num += 1;
            }

            rMin += 1;
            if(rMin > rMax || cMin > cMax)
            {
                break;
            }
            for(int r = rMin, c = cMax; r <= rMax; r++) // Traversing row++
            {
                mat[r,c] = num;
                num += 1;
            }

            cMax -= 1;
            if(rMin > rMax || cMin > cMax)
            {
                break;
            }
            for(int c = cMax, r = rMax; c >= cMin; c--) // Traversing col--
            {
                mat[r,c] = num;
                num += 1;
            }

            rMax -= 1;
            if(rMin > rMax || cMin > cMax)
            {
                break;
            }
            for(int r = rMax, c = cMin; r >= rMin; r--) // Traversing row--
            {
                mat[r,c] = num;
                num += 1;
            }

            cMin += 1;
        }

        // Printing matrix
        int pad = 2;
        int pow = 1;
        while(num / (int)Math.Pow(10,pow) != 0)
        {
            pow += 1;
            pad = pow + 1;
        }

        Console.WriteLine();
        for(int r = 0; r < n; r++)
        {
            for(int c = 0; c < n; c++)
            {
                Console.Write($"{mat[r,c]}".PadLeft(pad));
            }

            Console.WriteLine();
        }
    }
}