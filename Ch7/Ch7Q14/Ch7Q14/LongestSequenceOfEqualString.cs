// Write a program, which finds the longest sequence of equal string 
// elements in a matrix. A sequence in a matrix we define as a set of 
// neighbor elements on the same row, column or diagonal.

using System.Security.Cryptography;

class LongestSequenceOfEqualString
{
    static void Main()
    {
        int rows, cols;
        bool isInt;

        Console.WriteLine("Program to find longest sequence of equal string " +
        "in given matrix");

        // User inputs
        do
        {
            Console.Write("Rows = ");
            isInt = int.TryParse(Console.ReadLine(), out rows);
            if(!isInt || rows < 1)
            {
                Console.WriteLine($"\nEnter a valid integer in range[1,{int.MaxValue}]");
            }
        }
        while(!isInt || rows < 1);

        do
        {
            Console.Write("Cols = ");
            isInt = int.TryParse(Console.ReadLine(), out cols);
            if(!isInt || cols < 1)
            {
                Console.WriteLine($"\nEnter a valid integer in range[1,{int.MaxValue}]");
            }
        }
        while(!isInt || cols < 1);

        string[,] mat = new string[rows,cols];
        Console.WriteLine();
        Console.WriteLine("Enter elements in the matrix");
        for(int r = 0; r < rows; r++)
        {
            for(int c = 0; c < cols; c++)
            {
                do
                {
                    Console.Write($"mat[{r},{c}] = ");
                    mat[r,c] = Console.ReadLine();
                    if(mat[r,c] == "")
                    {
                        Console.WriteLine("\nEnter something bruh!");
                    }
                }
                while(mat[r,c] == "");
            }
        }

        // Logic to find longest sequence of equal string
        int longest = 1;
        int bestStartRow, bestStartCol;
        bestStartRow = bestStartCol = 0;
        char direction = 'r';
        for(int r = 0; r < rows; r++)
        {
            for(int c = 0; c < cols; c++)
            {
                int cLength = 1;
                for(int tr = r+1; tr < rows; tr++) // Traversing row
                {
                    if(mat[tr,c] == mat[r,c])
                    {
                        cLength += 1;
                    }
                    else
                    {
                        break;
                    }

                    if(cLength > longest)
                    {
                        longest = cLength;
                        bestStartRow = r;
                        bestStartCol = c;
                        direction = 'r';
                    }
                }

                cLength = 1;
                for(int tc = c+1; tc < cols; tc++) // Traversing col
                {
                    if(mat[r,tc] == mat[r,c])
                    {
                        cLength += 1;
                    }
                    else
                    {
                        break;
                    }

                    if(cLength > longest)
                    {
                        longest = cLength;
                        bestStartRow = r;
                        bestStartCol = c;
                        direction = 'c';
                    }
                }

                cLength = 1;
                for(int tr = r+1, tc = c+1; tr < rows && tc < cols; tr++, tc++) // Traversing diagonal
                {
                    if(mat[tr,tc] == mat[r,c])
                    {
                        cLength += 1;
                    }
                    else
                    {
                        break;
                    }

                    if(cLength > longest)
                    {
                        longest = cLength;
                        bestStartRow = r;
                        bestStartCol = c;
                        direction = 'd';
                    }
                }
            }
        }

        // Building longest sequence in another 2D array
        string[,] lis = new string[rows, cols];
        int lStringLength = 1;
        for(int r = 0; r < rows; r++)
        {
            for(int c = 0; c < cols; c++)
            {
                lis[r,c] = "";
                if(mat[r,c].Length > lStringLength)
                {
                    lStringLength = mat[r,c].Length;
                }
            }
        }

        switch(direction)
        {
            case 'r':
                {
                    for(int r = bestStartRow, c = bestStartCol; r < bestStartRow+longest; r++)
                    {
                        lis[r,c] = mat[r,c];
                    }

                    break;
                }
            case 'c':
                {
                    for(int c = bestStartCol, r = bestStartRow; c < bestStartCol+longest; c++)
                    {
                        lis[r,c] = mat[r,c];
                    }

                    break;
                }
            case 'd':
                {
                    for(int r = bestStartRow, c = bestStartCol; r < bestStartRow+longest && c < bestStartCol+longest; r++, c++)
                    {
                        lis[r,c] = mat[r,c];
                    }

                    break;
                }
            default:
                {
                    Console.WriteLine("Error");
                    break;
                }
        }

        // Printing given array and longest sequence of equal string
        Console.WriteLine();
        int pad = lStringLength + 1;

        Console.WriteLine("Given matrix:");
        for(int r = 0; r < rows; r++)
        {
            for(int c = 0; c < cols; c++)
            {
                Console.Write($"{mat[r,c]}".PadLeft(pad));
            }

            Console.WriteLine();
        }

        Console.WriteLine();
        Console.WriteLine("Longest sequence of equal strings:");
        for(int r = 0; r < rows; r++)
        {
            for(int c = 0; c < cols; c++)
            {
                Console.Write($"{lis[r,c]}".PadLeft(pad));
            }

            Console.WriteLine();
        }
    }
}