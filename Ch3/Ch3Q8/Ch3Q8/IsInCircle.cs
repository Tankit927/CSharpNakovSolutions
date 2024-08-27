// Write an expression that checks for a given point {x, y} if it is within 
// the circle K({0, 0}, R=5). Explanation: the point {0, 0} is the center of 
// the circle and 5 is the radius.

class IsInCircle
{
    static void Main()
    {
        int x, y;

        Console.WriteLine("Program to check whether a given point is within " +
        "the circle K({0, 0}, R=5)");
        Console.Write("Enter x coordinate: ");
        x = int.Parse(Console.ReadLine());
        Console.Write("Enter y coordinate: ");
        y = int.Parse(Console.ReadLine());

        int r = (int)(Math.Sqrt(Math.Pow((x - 0), 2) + Math.Pow((y - 0), 2)));

        Console.WriteLine(r <= 5 ? $"Point {{{x}, {y}}} is within circle" : $"Point {{{x}, {y}}} is outside circle");
    }
}