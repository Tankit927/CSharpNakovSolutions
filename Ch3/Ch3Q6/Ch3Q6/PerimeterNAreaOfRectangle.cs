// Write a program that prints on the console the perimeter and the area 
// of a rectangle by given side and height entered by the user.

class PerimeterNAreaOfRectangle
{
    static void Main()
    {
        double a, b;

        Console.Write("Enter first side of rectangle: ");
        a = double.Parse(Console.ReadLine());
        Console.Write("Enter second side of rectangle: ");
        b = double.Parse(Console.ReadLine());

        double perimeter = 2 * (a + b);
        double area = a * b;

        Console.WriteLine($"Rectangle with side {a} * {b}\n" +
        $"Perimeter = {perimeter} units\n" +
        $"Area = {area} square units");
    }
}