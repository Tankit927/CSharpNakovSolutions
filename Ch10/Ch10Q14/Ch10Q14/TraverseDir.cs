// Write a recursive program that traverses the whole hard disk C:\ 
// recursively and prints all folders and files.

class TraverseDir
{
    static void Main()
    {
        Console.WriteLine("Program to list all directories and files under given path.");
        DirectoryInfo dir = GetPath("Enter directory path: ");
        Console.WriteLine();

        // Console.WriteLine($"Full name: {dir.FullName}");
        // Console.WriteLine($"Name: {dir.Name}");
        // Console.WriteLine($"Parent dir: {dir.Parent}");
        // Console.WriteLine($"Root: {dir.Root}");
        
        ListEverything(dir);
    }


    static DirectoryInfo GetPath(string prompt)
    {
        // Method to user input directory path
        
        while(true)
        {
            try
            {
                Console.Write(prompt);
                DirectoryInfo dir = new DirectoryInfo(Console.ReadLine());
                if(!dir.Exists)
                {
                    Console.WriteLine("\nPlease enter a valid directory path");
                    continue;
                }

                return dir;
            }
            catch(Exception e)
            {
                Console.WriteLine($"Error: {e.Message}");
            }
        }
    }


    static void ListEverything(DirectoryInfo currentDir, int depth=0)
    {
        // Method to recursively list all directories and files under given path

        ConsoleColor dirColor = ConsoleColor.Blue;
        ConsoleColor fileColor = ConsoleColor.Green;
        ConsoleColor errorColor = ConsoleColor.Red;

        try
        {
            FileSystemInfo[] infos = currentDir.GetFileSystemInfos();
            Console.ForegroundColor = dirColor;
            Console.WriteLine(currentDir.Name);

            if(depth == 0)
            {
                Console.ResetColor();
                Console.WriteLine("|");
            }

            foreach (FileSystemInfo i in infos)
            {   
                if (i is DirectoryInfo)
                {
                    DrawLines(depth, i);
                    DirectoryInfo dir = (DirectoryInfo)i;
                    ListEverything(dir, depth+1);
                }
                else if (i is FileInfo)
                {
                    DrawLines(depth, i);
                    Console.ForegroundColor = fileColor;
                    FileInfo file = (FileInfo)i;
                    Console.WriteLine(file.Name);
                }
            }

            Console.ResetColor();
        }
        catch(Exception e)
        {
            Console.ForegroundColor = errorColor;
            Console.WriteLine($"Error: {e.Message}");
            Console.ResetColor();
        }
    }


    static void DrawLines(int depth, FileSystemInfo info)
    {
        // Method to draw lines for tree like formatting
        //
        // Loop from depth 0 to current depth and
        // For every depth greater than 0
        // Print 2 space
        // Print "|" if child is not the last element of parent at i < depth
        // After ending loop print "\b|__"

        Console.ResetColor();
        if(info == null)
        {
            return;
        }

        for(int i = 0; i <= depth; i++)
        {
            if(i > 0)
            {
                Console.Write(" " + " ");
            }

            DirectoryInfo childDir = null;
            FileInfo childFile = null;
            DirectoryInfo parent = null;
            FileSystemInfo child = null;
            if(info is DirectoryInfo)
            {
                childDir = (DirectoryInfo)info;
                for(int j = depth-i; j >= 1; j--)
                {
                    childDir = childDir.Parent;
                }
            }
            else
            {
                childFile = (FileInfo)info;
                childDir = childFile.Directory;
                for(int j = depth-i; j > 1; j--)
                {
                    childDir = childDir.Parent;
                }
            }

            child = childDir == null ? childFile : childDir;
            parent = childDir.Parent;

            // Get an array of all childrens(files/directories) of parent directory
            FileSystemInfo[] infos = parent.GetFileSystemInfos();

            // Print "|" if child is not the last element but present in parent directory
            // and i(current depth) < depth
            int indexOfChild = GetIndexOf(child, infos);
            if(i < depth && indexOfChild < infos.Length-1)
            {
                Console.Write("|");
            }
            else
            {
                Console.Write(" ");
            }
        }

        Console.Write("\b|__");
    }


    static int GetIndexOf(FileSystemInfo info, FileSystemInfo[] infos)
    {
        // Method to return index of info if found otherwise return -1

        for(int i = 0; i < infos.Length; i++)
        {
            if(info.FullName == infos[i].FullName)
            {
                return i;
            }
        }

        return -1;
    }
}