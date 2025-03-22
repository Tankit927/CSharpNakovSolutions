// Write a recursive program that traverses the whole hard disk C:\ 
// recursively and prints all folders and files.

class TraverseDir
{
    static void Main()
    {
        string path = "";

        Console.WriteLine("Program to list all directories and files under given path.");
        path = GetPath("Enter directory path: ");
        Console.WriteLine();
        ListEverything(path);
    }


    static string GetPath(string prompt)
    {
        // Method to user input path

        string path = "";

        do
        {
            Console.Write(prompt);
            path = Console.ReadLine();
            if(!Path.IsPathFullyQualified(path) || !Path.IsPathRooted(path))
            {
                Console.WriteLine($"\nEnter valid absolute directory path which does not end with {Path.DirectorySeparatorChar} or {Path.AltDirectorySeparatorChar}");
            }
            else if(!Directory.Exists(path + @"\"))
            {
                Console.WriteLine("Given directory not found");
            }
        }
        while(!Path.IsPathFullyQualified(path) || !Path.IsPathRooted(path) || !Directory.Exists(path + @"\"));

        return path;
    }


    static void ListEverything(string path)
    {
        // Method to list all directories and files under given path

        int[] entries = new int[1000];
        ListEverything(path, entries);
    }


    static int[] ListEverything(string path, int[] entries, int depth=0)
    {
        // Method to recursively list all directories and files under given path
        // entries[depth] contains no. of paths(files/directories) in current depth
        // For example: entries[0] = 3 
        // Means 3 paths(files/directories) at 0 depth

        ConsoleColor dirColor = ConsoleColor.Blue;
        ConsoleColor fileColor = ConsoleColor.Green;
        ConsoleColor errorColor = ConsoleColor.Red;

        try
        {
            IEnumerable<string> paths = Directory.EnumerateFileSystemEntries(path);
            entries[depth] = paths.Count();
            DirectoryInfo dir = new DirectoryInfo(path);

            Console.ForegroundColor = dirColor;
            Console.WriteLine(dir.Name);
            if(depth == 0)
            {
                Console.ResetColor();
                Console.WriteLine("|");
            }

            foreach (string sPath in paths)
            {   
                if (Directory.Exists(sPath + @"\"))
                {
                    DrawLines(depth, entries);
                    entries[depth] -= 1;
                    entries = ListEverything(sPath, entries, depth+1);
                    DrawVerticalLinesOnly(depth, entries);
                }
                else if (File.Exists(sPath))
                {
                    DrawLines(depth, entries);
                    entries[depth] -= 1;
                    Console.ForegroundColor = fileColor;
                    Console.WriteLine(Path.GetFileName(sPath));
                }
            }

            Console.ResetColor();
            return entries;
        }
        catch(Exception e)
        {
            Console.ForegroundColor = errorColor;
            Console.WriteLine($"Error: {e.Message}");
            Console.ResetColor();
            return entries;
        }
    }


    static void DrawLines(int depth, int[] entries)
    {
        // Method to draw lines for tree like formatting
        //
        // Loop from depth 0 to current depth and
        // For every depth greater than 0
        // Print 2 space
        // Followed by "|" if there are remaining entries at that depth
        // After ending loop print "__"

        Console.ResetColor();

        for(int i = 0; i <= depth && i < entries.Length; i++)
        {
            if(i > 0)
            {
                Console.Write(" " + " ");
            }

            if(entries[i] > 0)
            {
                Console.Write("|");
            }
            else
            {
                Console.Write(" ");
            }
        }

        Console.Write("__");
    }


    static void DrawVerticalLinesOnly(int depth, int[] entries)
    {
        // Method to draw lines for tree like formatting
        //
        // Same as DrawLines method
        // But don't print "__" after ending loop

        Console.ResetColor();

        for(int i = 0; i <= depth && i < entries.Length; i++)
        {
            if(i > 0)
            {
                Console.Write(" " + " ");
            }

            if(entries[i] > 0)
            {
                Console.Write("|");
            }
            else
            {
                Console.Write(" ");
            }
        }

        Console.WriteLine();
    }
}