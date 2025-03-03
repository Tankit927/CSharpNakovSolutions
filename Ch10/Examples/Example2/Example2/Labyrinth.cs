// Program to find all paths in a labyrinth

class Labyrinth
{
    static void Main()
    {
        Console.WriteLine("Program to find all paths in a labyrinth");

        char[,] maze = 
        {
            {'S', '_', '_', '*', '_', '_', '_'},
            {'*', '*', '_', '*', '_', '*', '_'},
            {'_', '_', '_', '_', '_', '_', '_'},
            {'_', '*', '*', '*', '*', '*', '_'},
            {'_', '_', '_', '_', '_', '_', 'E'},
        };

        char[,] maze1 = 
        {
            {'S'},
        };

        char[,] maze2 = 
        {
            {'S', '_', '_'},
            {'_', '_', '_'},
            {'_', '_', 'E'},
        };

        char[,] maze3 = 
        {
            {'S', '*', '*', '_', '_'},
            {'_', '_', '_', '*', '_'},
            {'*', '_', '_', '*', 'E'},
        };

        char[,] maze4 = 
        {
            {'S', '*', '_', '_', '_', '_', '*', '_', '_', '_', '_', '*', '*', '_', '_'},
            {'_', '_', '*', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_'},
            {'_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_'},
            {'_', '_', '_', '_', '_', '_', '*', '_', '_', '_', '_', '_', '_', '_', '_'},
            {'_', '_', '_', '_', '_', '*', '_', '_', '_', '_', '_', '_', '_', '_', '_'},
            {'_', '_', '_', '_', '_', '*', '_', '_', '_', '_', '_', '_', '_', '_', '_'},
            {'_', '*', '*', '*', '_', '*', '_', '_', '_', '_', '_', '*', '*', '*', '*'},
            {'_', '_', '_', '_', '_', '*', '_', '_', '_', '_', '_', '_', '_', '_', '_'},
            {'_', '_', '_', '_', '_', '*', '_', '_', '_', '_', '_', '_', '_', '_', 'E'},
        };

        char[,] maze5 = 
        {
            {'S', '*', '_', '_', '_', '_', '*', '_', '_', '_', '_', '*', '*', '_', '_'},
            {'_', '_', '*', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_'},
            {'_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_', '_'},
            {'_', '_', '_', '_', '_', '_', '*', '_', '_', '_', '_', '_', '_', '_', '_'},
            {'_', '_', '_', '_', '_', '*', '_', '_', '_', '_', '_', '_', '_', '_', '_'},
            {'_', '_', '_', '_', '_', '*', '_', '_', '_', '_', '_', '_', '_', '_', '_'},
            {'_', '*', '*', '*', '_', '*', '_', '_', '_', '_', '_', '*', '*', '*', '*'},
            {'_', '_', '_', '_', '_', '*', '_', '_', '_', '_', '_', '*', '*', '_', '_'},
            {'_', '_', '_', '_', '_', '*', '_', '_', '_', '_', '_', '_', '_', '*', 'E'},
        };

        char start = 'S';
        char end = 'E';
        Console.WriteLine("Given maze:");
        PrintMatrix(maze);
        Console.WriteLine();
        Console.WriteLine("Possible paths:");
        FindAllPaths(maze, start, end);
    }


    static void FindAllPaths(char[,] maze, char start, char end, int r=-1, int c=-1, int fr=-1, int fc=-1, bool isStart = false)
    {
        // Method to find all path from start to end character

        if(r == -1 && c == -1) // Get coordinates of starting cell
        {
            r = GetRowOf(maze, start);
            c = GetColOf(maze, start);
        }

        if(fr == -1 && fc == -1) // Get coordinates of ending cell
        {
            fr = GetRowOf(maze, end);
            fc = GetColOf(maze, end);
            if(fr == -1 && fc == -1)
            {
                fr = r;
                fc = c;
            }
        }

        if(r < 0 || r >= maze.GetLength(0) || c < 0 || c >= maze.GetLength(1)) // Outside maze, so return
        {
            return;
        }

        if(r == fr && c == fc) // Found end, print matrix and return
        {
            PrintMatrix(maze);
            Console.WriteLine();
            return;
        }
        else if(maze[r,c] == start && isStart) // Found start more than once
        {
            return;
        }
        
        if(maze[r,c] == '_') // Found passable cell, mark it searched
        {
            maze[r,c] = 's';
        }
        else if(maze[r,c] == start && !isStart) // Found start cell for first time. Passable once 
        {
            isStart = true;
        }
        else
        {
            return; // return from already searched cell
        }

        FindAllPaths(maze, start, end, r, c+1, fr, fc, isStart); // Searching right
        FindAllPaths(maze, start, end, r+1, c, fr, fc, isStart); // Searching down
        FindAllPaths(maze, start, end, r, c-1, fr, fc, isStart); // Searching left
        FindAllPaths(maze, start, end, r-1, c, fr, fc, isStart); // Searching up

        if(maze[r,c] != start && !(r == fr && c == fc)) // Marking current cell as passable before returning
        {                                               // if its not start or end cell
            maze[r,c] = '_';
        }
    }


    static void PrintMatrix(char[,] mat)
    {
        // Method to print 2D matrix

        int rMax = mat.GetLength(0);
        int cMax = mat.GetLength(1);

        for(int r = 0; r < rMax; r++)
        {
            for(int c = 0; c < cMax; c++)
            {
                Console.Write($"{mat[r,c],2}");
            }

            Console.WriteLine();
        }
    }


    static int GetRowOf(char[,] mat, char v)
    {
        // Method to return row of given value in given matrix

        for(int r = 0; r < mat.GetLength(0); r++)
        {
            for(int c = 0; c < mat.GetLength(1); c++)
            {
                if(mat[r,c] == v)
                {
                    return r;
                }
            }
        }

        Console.WriteLine("Error!");
        return -1;
    }


    static int GetColOf(char[,] mat, char v)
    {
        // Method to return row of given value in given matrix

        for(int r = 0; r < mat.GetLength(0); r++)
        {
            for(int c = 0; c < mat.GetLength(1); c++)
            {
                if(mat[r,c] == v)
                {
                    return c;
                }
            }
        }

        Console.WriteLine("Error!");
        return -1;
    }
}