// Write an expression that calculates the area of a trapezoid by given 
// sides a, b and height h.

class AreaOfTrapezoid
{
    static void Main()
    {
        double a, b, h;

        a = 4;
        b = 6;
        h = 10;
        double area = ((a + b) / 2) * h;

        Console.WriteLine($"Area of trapezoid of sides {a}, {b} and height {h} = {area}");
    }
}