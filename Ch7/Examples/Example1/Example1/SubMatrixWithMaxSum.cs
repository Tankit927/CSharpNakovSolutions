// we are given a 
// two-dimensional rectangular array (matrix) of integers and our task is 
// to find 
// the sub-matrix of size of 2 by 2 with maximum sum of its elements and 
// to print it to the console.

class SubMatrixWithMaxSum
{
    static void Main()
    {
        int row, col;
        bool isInt;

        Console.WriteLine("Program to find sub-matrix of size 2 by 2 " +
        "with maximum sum of its elements and to print it to the console.");
        Console.WriteLine("Enter rows and cols of matrix");
        do
        {
            Console.Write("row = ");
            isInt = int.TryParse(Console.ReadLine(), out row);
            if(!isInt || row < 2)
            {
                Console.WriteLine($"\nEnter a valid integer in range [2,{int.MaxValue}]");
            }
        }
        while(!isInt || row < 2);

        do
        {
            Console.Write("col = ");
            isInt = int.TryParse(Console.ReadLine(), out col);
            if(!isInt || col < 2)
            {
                Console.WriteLine($"\nEnter a valid integer in range [2,{int.MaxValue}]");
            }
        }
        while(!isInt || col < 2);

        // User input elements in matrix
        int[,] matrix = new int[row, col];
        Console.WriteLine("Enter elements in the matrix");
        for(int r = 0; r < row; r++)
        {
            for(int c = 0; c < col; c++)
            {
                do
                {
                    Console.Write($"matrix[{r},{c}] = ");
                    isInt = int.TryParse(Console.ReadLine(), out matrix[r,c]);
                    if(!isInt)
                    {
                        Console.WriteLine($"\nEnter a valid integer in range [{int.MinValue},{int.MaxValue}]");
                    }
                }
                while(!isInt);
            }
        }

        // Find starting row and starting col of sub matrix of size 2*2 
        // with max sum
        int[,] rMatrix = new int[2,2];
        long maxSum = long.MinValue;
        int rRow = 0, rCol = 0;
        for(int r = 0; r <= row - 2; r++)
        {
            for(int c = 0; c <= col - 2; c++)
            {
                long sum = 0;
                for(int sRow = r; sRow < r + 2; sRow++)
                {
                    for(int sCol = c; sCol < c + 2; sCol++)
                    {
                        sum += matrix[sRow,sCol];
                    }
                }

                if(sum >= maxSum)
                {
                    maxSum = sum;
                    rRow = r;
                    rCol = c;
                }
            }
        }

        // Initialise rMatrix
        for(int r = 0, R = rRow; r < rMatrix.GetLength(0); r++, R++)
        {
            for(int c = 0, C = rCol; c < rMatrix.GetLength(1); c++, C++)
            {
                rMatrix[r,c] = matrix[R,C];
            }
        }

        Console.WriteLine("Given matrix:");

        // Setting alignment to no. of digits in largest integer in matrix
        int alignment = 3;
        foreach(int e in matrix)
        {
            for(int i = 2; i < int.MaxValue; i++)
            {
                if(e / (long)Math.Pow(10, i) == 0)
                {
                    if(i > alignment-2)
                    {
                        alignment = i+2;
                    }

                    break;
                }
            }
        }

        // Print matrix
        for(int r = 0; r < row; r++)
        {
            for(int c = 0; c < col; c++)
            {
                Console.Write($"{matrix[r,c]}".PadLeft(alignment));
            }

            Console.WriteLine();
        }

        Console.WriteLine();
        Console.WriteLine($"Largest sum = {maxSum}");
        Console.WriteLine("Largest sum matrix:");

        // Setting alignment to no. of digits in largest integer in rMatrix
        alignment = 2;
        foreach(int e in rMatrix)
        {
            for(int i = 2; i < int.MaxValue; i++)
            {
                if(e / (long)Math.Pow(10, i) == 0)
                {
                    if(i > alignment-2)
                    {
                        alignment = i+2;
                    }

                    break;
                }
            }
        }

        // Print rMatrix
        for(int r = 0; r < rMatrix.GetLength(0); r++)
        {
            for(int c = 0; c < rMatrix.GetLength(1); c++)
            {
                Console.Write($"{rMatrix[r,c]}".PadLeft(alignment));
            }

            Console.WriteLine();
        }
    }
}