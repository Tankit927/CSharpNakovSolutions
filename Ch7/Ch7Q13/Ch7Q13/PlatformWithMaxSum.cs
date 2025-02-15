// Write a program, which creates a rectangular array with size of n by m 
// elements. The dimensions and the elements should be read from the 
// console. Find a platform with size of (3, 3) with a maximal sum.

class PlatformWithMaxSum
{
    static void Main()
    {
        int n, m, s;
        bool isInt;

        Console.WriteLine("Program to find platform of given size with max sum " +
        "in given rectangular array");

        // User inputs
        do
        {
            Console.Write("Rows = ");
            isInt = int.TryParse(Console.ReadLine(), out n);
            if(!isInt || n < 3)
            {
                Console.WriteLine($"\nEnter a valid integer in range[3,{int.MaxValue}]");
            }
        }
        while(!isInt || n < 3);

        do
        {
            Console.Write("Columns = ");
            isInt = int.TryParse(Console.ReadLine(), out m);
            if(!isInt || m < 3)
            {
                Console.WriteLine($"\nEnter a valid integer in range[3,{int.MaxValue}]");
            }
        }
        while(!isInt || m < 3);

        int smaller = (n < m) ? n : m;
        do
        {
            Console.Write("Platform size = ");
            isInt = int.TryParse(Console.ReadLine(), out s);
            if(!isInt || s > smaller || s < 1)
            {
                Console.WriteLine($"\nEnter a valid integer in range[1,{smaller}]");
            }
        }
        while(!isInt || s > smaller || s < 1);

        Console.WriteLine();
        int[,] myArray = new int[n,m];
        Console.WriteLine("Enter the elements in the array");
        for(int r = 0; r < n; r++)
        {
            for(int c = 0; c < m; c++)
            {
                do
                {
                    Console.Write($"myArray[{r},{c}] = ");
                    isInt = int.TryParse(Console.ReadLine(), out myArray[r,c]);
                    if(!isInt)
                    {
                        Console.WriteLine($"\nEnter a valid integer in range[{int.MinValue},{int.MaxValue}]");
                    }
                }
                while(!isInt);
            }
        }

        // Logic to find platform of certain size with max sum
        int bestStartRow, bestStartCol;
        bestStartRow = bestStartCol = 0;
        long maxSum = 0;

        for(int r = 0; r <= n-s; r++)
        {
            for(int c = 0; c <= m-s; c++)
            {
                long sum = 0;
                for(int pr = r; pr < r+s; pr++)
                {
                    for(int pc = c; pc < c+s; pc++)
                    {
                        sum += myArray[pr,pc];
                    }
                }

                if(sum > maxSum)
                {
                    maxSum = sum;
                    bestStartRow = r;
                    bestStartCol = c;
                }
            }
        }

        // Print given matrix and platform with max sum
        Console.WriteLine();
        Console.WriteLine("Given matrix:");
        int largest = int.MinValue;
        foreach(int i in myArray)
        {
            if(i > largest)
            {
                largest = i;
            }
        }

        int pad = 2;
        int pow = 1;
        while(largest / (int)Math.Pow(10,pow) != 0)
        {
            pow += 1;
            pad = pow + 1;
        }

        for(int r = 0; r < n; r++)
        {
            for(int c = 0; c < m; c++)
            {
                Console.Write($"{myArray[r,c]}".PadLeft(pad));
            }

            Console.WriteLine();
        }

        Console.WriteLine();
        Console.WriteLine($"Sum of platform of size {s} with max sum = {maxSum}");
        for(int r = bestStartRow; r < bestStartRow+s; r++)
        {
            for(int c = bestStartCol; c < bestStartCol+s; c++)
            {
                Console.Write($"{myArray[r,c]}".PadLeft(pad));
            }

            Console.WriteLine();
        }
    }
}