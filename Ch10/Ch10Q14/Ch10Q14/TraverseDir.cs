// Write a recursive program that traverses the whole hard disk C:\ 
// recursively and prints all folders and files.

class TraverseDir
{
    static void Main()
    {
        Console.WriteLine("Program to list all directories and files under given path.");
        DirectoryInfo dir = GetPath("Enter directory path: ");
        Console.WriteLine();
        
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
                    DrawLinesVerticalAndHorizontal(depth, i);
                    DirectoryInfo dir = (DirectoryInfo)i;
                    ListEverything(dir, depth+1);
                    DrawLinesVerticalOnly(depth, i); // Comment out this line for compact output
                }
                else if (i is FileInfo)
                {
                    DrawLinesVerticalAndHorizontal(depth, i);
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


    static void DrawLines(int depth, FileSystemInfo info, bool verticalOnly=false)
    {
        // Method to draw lines for tree like formatting

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

            // Get child at depth i and its parent info depth is depth
            // For example:
            // For i = 0, depth = 0
            // child = info
            //
            // For i = 0, depth = 1
            // child = info
            // child = child.Parent (loop 1 time)
            //
            // For i = 1, depth = 1
            // child = info
            //
            // For i = 0, depth = 2
            // child = info
            // child = child.Parent (loop 2 times)
            //
            // For i = 1, depth = 2
            // child = info
            // child = child.Parent (loop 1 time)
            //
            // For i = 2, depth = 2
            // child = info
            DirectoryInfo childDir;
            FileInfo childFile = null;
            DirectoryInfo parent;
            FileSystemInfo child;
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

            // When verticalOnly == false
            // Print "|" if child is not the last element in parent directory
            // when i(current depth) < depth
            // Or
            // when i(current depth == depth)
            //
            // else when verticalOnly == true
            // Print "|" if child is not the last element in parent directory
            // irrespective of i and depth
            int indexOfChild = GetIndexOf(child, infos);
            if(!verticalOnly)
            {
                if((i < depth && indexOfChild < infos.Length-1) || i == depth)
                {
                    Console.Write("|");
                }
                else
                {
                    Console.Write(" ");
                }
            }
            else
            {
                if(indexOfChild < infos.Length-1)
                {
                    Console.Write("|");
                }
                else
                {
                    Console.Write(" ");
                }
            }
        }
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


    static void DrawLinesVerticalAndHorizontal(int depth, FileSystemInfo info)
    {
        // Method to draw vertical and horizontal lines
        // Vertical lines are drawn by DrawLines() method

        DrawLines(depth, info);
        Console.Write("__");
    }


    static void DrawLinesVerticalOnly(int depth, FileSystemInfo info)
    {
        // Method to draw vertical lines only
        // Vertical lines are drawn by DrawLines() method

        DrawLines(depth, info, verticalOnly:true);
        Console.WriteLine();
    }
}