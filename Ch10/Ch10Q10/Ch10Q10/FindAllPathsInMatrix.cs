// You are given a matrix with passable and impassable cells. Write a 
// recursive program that finds all paths between two cells in the matrix.

class FindAllPathsInMatrix
{
    static void Main()
    {
        int sr, sc, er, ec;
        sr = 0;
        sc = 0;
        er = 4;
        ec = 6;

        char[,] mat1 = 
        {
            {'_','_','_'},
            {'_','_','_'},
            {'_','_','_'},
        };

        char[,] mat2 = {{'_'}};

        char[,] mat3 = 
        {
            {'_','_','_','_'},
            {'_','_','*','*'},
            {'_','_','*','_'},
        };

        char[,] mat4 = 
        {
            {'_','_','_','*','_','_','_'},
            {'*','*','_','*','_','*','_'},
            {'_','_','_','_','_','_','_'},
            {'_','*','*','*','*','*','_'},
            {'_','_','_','_','_','_','_'},
        };

        Console.WriteLine("Original matrix:");
        PrintMatrix(mat4);
        Console.WriteLine();
        Console.WriteLine($"Paths in matrix between cell[{sr},{sc}] & cell[{er},{ec}]");
        PrintAllPaths(sr, sc, er, ec, mat4, '_', 's', '*');
    }


    static void PrintAllPaths(int r, int c, int endR, int endC, char[,] mat, char p, char s, char w)
    {
        // Method to find all paths between start cell and end cell 
        // in a given matrix

        if(r < 0 || c < 0 || r >= mat.GetLength(0) || c >= mat.GetLength(1) || mat[r,c] != p)
        {
            return;
        }

        mat[r,c] = s; // Mark current cell as searched

        if(r == endR && c == endC)
        {
            PrintMatrix(mat);
            Console.WriteLine();
            mat[r,c] = p; // Unmark current cell making it available to be searched again
            return;
        }

        PrintAllPaths(r, c+1, endR, endC, mat, p, s, w); // search right
        PrintAllPaths(r+1, c, endR, endC, mat, p, s, w); // search down
        PrintAllPaths(r, c-1, endR, endC, mat, p, s, w); // search left
        PrintAllPaths(r-1, c, endR, endC, mat, p, s, w); // search up

        mat[r,c] = p; // Unmark current cell making it available to be searched again
    }


    static void PrintMatrix(char[,] mat)
    {
        // Method to print given matrix

        for(int r = 0; r < mat.GetLength(0); r++)
        {
            for(int c = 0; c < mat.GetLength(1); c++)
            {
                Console.Write(mat[r,c]);
            }

            Console.WriteLine();
        }
    }
}