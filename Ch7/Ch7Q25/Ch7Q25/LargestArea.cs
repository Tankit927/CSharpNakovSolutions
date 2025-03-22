// *Write a program, which finds in a given matrix the largest area of 
// equal numbers. We define an area in the matrix as a set of neighbor 
// cells (by row and column). Here is one example with an area containing 
// 13 elements with equal value of 3:
//
//         1 3 2 2 2 4 
//         3 3 3 2 4 4
//         4 3 1 2 3 3
//         4 3 1 3 3 1
//         4 3 3 3 1 1
//
// Need to complete till Ch-10 Recursion

class LargestArea
{
    static void Main()
    {
        int[,] mat1 = 
        {
            {1, 3, 2, 2, 2, 4},
            {3, 3, 3, 2, 4, 4},
            {4, 3, 1, 2, 3, 3},
            {4, 3, 1, 3, 3, 1},
            {4, 3, 3, 3, 1, 1},
        };

        Console.WriteLine("Given matrix:");
        PrintMatrix(mat1);
        Console.WriteLine();

        FindLargestArea(mat1);
    }


    static void FindLargestArea(int[,] mat)
    {
        // Method to find largest area of equal elements in given matrix

        int rows = mat.GetLength(0);
        int cols = mat.GetLength(1);
        bool[,] master = new bool[rows, cols];
        bool[,] current = new bool[rows, cols];
        bool[,] best = new bool[rows, cols];
        int count, maxCount;

        maxCount = -1;

        for(int r = 0; r < rows; r++)
        {
            for(int c = 0; c < cols; c++)
            {
                if(!master[r,c])
                {
                    count = GetArea(mat, current, master, mat[r,c], r, c);

                    if(count > maxCount)
                    {
                        maxCount = count;
                        CopyTo(best, current);
                    }

                    ResetAllElementsToFalse(current);
                }
            }
        }

        Console.WriteLine($"Max area: {maxCount}");
        PrintMaskedArea(mat, best);
    }


    static void ResetAllElementsToFalse(bool[,] current)
    {
        // Reset all elements of given matrix to false

        for(int r = 0; r < current.GetLength(0); r++)
        {
            for(int c = 0; c < current.GetLength(1); c++)
            {
                current[r,c] = false;
            }
        }
    }


    static int GetArea(int[,] mat, bool[,] current, bool[,] master, int p, int r, int c, int count=0)
    {
        // Method to count area of neighbouring cells of same elements recursively

        if(r < 0 || c < 0 || r >= mat.GetLength(0) || c >= mat.GetLength(1) || mat[r,c] != p || current[r,c])
        {
            return count;
        }

        current[r,c] = master[r,c] = true; // mark the current cell as searched
        count += 1;
        
        count = GetArea(mat, current, master, p, r, c+1, count); // search right
        count = GetArea(mat, current, master, p, r+1, c, count); // search down
        count = GetArea(mat, current, master, p, r, c-1, count); // search left
        count = GetArea(mat, current, master, p, r-1, c, count); // serarch up

        return count;
    }


    static void PrintMaskedArea(int[,] mat, bool[,] mask)
    {
        // Method to print cells which are true in mask
        // mat should contain only +ve integers

        int largest = -1;

        for(int r = 0; r < mat.GetLength(0); r++)
        {
            for(int c = 0; c < mat.GetLength(1); c++)
            {
                if(mask[r,c] && mat[r,c] > largest)
                {
                    largest = mat[r,c];
                }
            }
        }

        int pad = 0;

        while(largest > 0)
        {
            largest /= 10;
            pad += 1;
        }

        pad += 2;

        for(int r = 0; r < mat.GetLength(0); r++)
        {
            for(int c = 0; c < mat.GetLength(1); c++)
            {
                if(mask[r,c])
                {
                    Console.Write($"{mat[r,c]}".PadLeft(pad));
                }
                else
                {
                    Console.Write("_".PadLeft(pad));
                }
            }

            Console.WriteLine();
        }
    }


    static void CopyTo(bool[,] A, bool[,] B)
    {
        // Method to copy matrix B to A

        for(int r = 0; r < A.GetLength(0); r++)
        {
            for(int c = 0; c < B.GetLength(1); c++)
            {
                A[r,c] = B[r,c];
            }
        }
    }


    static void PrintMatrix(int[,] mat)
    {
        // Method to print given matrix
        // mat should contain only +ve integers

        int largest = -1;

        for(int r = 0; r < mat.GetLength(0); r++)
        {
            for(int c = 0; c < mat.GetLength(1); c++)
            {
                if(mat[r,c] > largest)
                {
                    largest = mat[r,c];
                }
            }
        }

        int pad = 0;

        while(largest > 0)
        {
            largest /= 10;
            pad += 1;
        }

        pad += 2;

        for(int r = 0; r < mat.GetLength(0); r++)
        {
            for(int c = 0; c < mat.GetLength(1); c++)
            {
                Console.Write($"{mat[r,c]}".PadLeft(pad));
            }

            Console.WriteLine();
        }        
    }
}