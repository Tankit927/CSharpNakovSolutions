// Create a method GetMax() with two integer (int) parameters, that 
// returns maximal of the two numbers. Write a program that reads three 
// numbers from the console and prints the biggest of them. Use the 
// GetMax() method you just created. Write a test program that validates 
// that the methods works correctly.

class GreatestOfThree
{
    static void Main()
    {
        int a, b, c;

        Console.WriteLine("Program to find biggest of 3 given integers.");
        a = GetInt("num1 = ");
        b = GetInt("num2 = ");
        c = GetInt("num3 = ");

        Console.WriteLine();
        Console.WriteLine($"Greatest num = {GetMax(GetMax(a,b),c)}");
    }


    static int GetInt(string prompt)
    {
        // Method to user input integer

        int num;
        bool isInt;

        do
        {
            Console.Write(prompt);
            isInt = int.TryParse(Console.ReadLine(), out num);
            if(!isInt)
            {
                Console.WriteLine($"\nEnter a valid integer in range[{int.MinValue},{int.MaxValue}]");
            }
        }
        while(!isInt);

        return num;
    }


    static int GetMax(int a, int b)
    {
        // Method to return larger integer

        return a > b ? a : b;
    }
}