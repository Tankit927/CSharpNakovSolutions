// Write an expression that checks for given point {x, y} if it is within the 
// circle K({0, 0}, R=5) and out of the rectangle [{-1, 1}, {5, 5}]. 
// Clarification: for the rectangle the lower left and the upper right corners 
// are given.

class IsInCircleNOutOfRectangle
{
    static void Main()
    {
        int x, y;

        Console.WriteLine("Program to check whether given point in within the " +
        "circle K({0,0}, R=5) and out of the rectangle[{-1, 1}, {5, 5}].");
        Console.Write("Enter x: ");
        x = int.Parse(Console.ReadLine());
        Console.Write("Enter y: ");
        y = int.Parse(Console.ReadLine());

        int r = (int)(Math.Sqrt(Math.Pow((x - 0), 2) + Math.Pow((y - 0), 2)));

        Console.WriteLine((r <= 5) && ((x < -1) || (x > 5) || (y < 1) || (y > 5)));
    }
}