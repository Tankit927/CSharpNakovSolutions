// Write a program that gets the coefficients a, b and c of a quadratic 
// equation: ax2 + bx + c, calculates and prints its real roots (if they exist). 
// Quadratic equations may have 0, 1 or 2 real roots.

class QuadraticEquation
{
    static void Main()
    {
        double a, b, c;
        bool isDouble;

        Console.WriteLine("Program to calculate roots of quadratic equation ax^2 + bx + c");
        Console.Write("a = ");
        isDouble = double.TryParse(Console.ReadLine(), out a);
        Console.WriteLine(isDouble ? "" : "Invalid number");
        Console.Write("b = ");
        isDouble = double.TryParse(Console.ReadLine(), out b);
        Console.WriteLine(isDouble ? "" : "Invalid number");
        Console.Write("c = ");
        isDouble = double.TryParse(Console.ReadLine(), out c);
        Console.WriteLine(isDouble ? "" : "Invalid number");

        double D = Math.Sqrt((b * b) - (4 * a * c));

        if(D >= 0d)
        {
            double root1 = (-b+D)/(2*a);
            double root2 = (-b-D)/(2*a);
            Console.WriteLine($"Roots of the given equation {a}x^2{b:+0;-0}x{c:+0;-0} are:");
            Console.WriteLine($"Root1 = {root1}");
            Console.WriteLine($"Root2 = {root2}");
        }
        else
        {
            Console.WriteLine($"Discrement ({D}) is negative, so there are no " +
            "real roots");
        }
    }
}