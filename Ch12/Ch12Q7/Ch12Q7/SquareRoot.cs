// Write a program that takes a positive integer from the console and prints 
// the square root of this integer. If the input is negative or invalid print 
// "Invalid Number" in the console. In all cases print "Good Bye".

class SquareRoot
{
    static void Main()
    {
        int num = 0;

        Console.WriteLine("Program to print square root of given integer " +
        "and print \"Invalid Number\" if integer is invalid or negative " +
        "and print \"Good Bye in all cases\"");

        while(true)
        {
            try
            {
                num = GetInt("Num = ");
                Console.WriteLine();
                PrintSquareRootOf(num);
                break;
            }
            catch (Exception e) when (e is ArgumentNullException || e is FormatException || e is OverflowException)
            {
                Console.WriteLine();
                Console.WriteLine($"Error: {e.Message}");
                // Console.WriteLine(e.InnerException);
            }
            catch (Exception e)
            {
                Console.WriteLine();
                Console.WriteLine($"Error: {e.Message}");
                // Console.WriteLine(e.InnerException);
            }
            finally
            {
                Console.WriteLine();
                Console.WriteLine("Good Bye.");
            }
        }
    }


    static int GetInt(string prompt)
    {
        // Method to user input integer 
        // Throw "Invalid Number" exception if integer is invalid or negative

        int num;
        
        while(true)
        {
            Console.Write(prompt);
            try
            {
                num = int.Parse(Console.ReadLine());
                if(num < 0)
                {
                    Console.WriteLine($"\nEnter a valid positive integer in range[0,{int.MaxValue}]");
                    continue;
                }

                return num;
            }
            catch(Exception e)
            {
                throw new Exception($"{e.Message}\nEnter a valid positive integer in range[0,{int.MaxValue}]");
            }
        }
    }


    static void PrintSquareRootOf(int num)
    {
        // Method to print square root of given integer

        Console.WriteLine($"Square root: {Math.Sqrt(num):f2}");
    }
}