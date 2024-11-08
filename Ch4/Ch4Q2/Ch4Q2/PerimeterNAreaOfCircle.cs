// Write a program that reads from the console the radius "r" of a circle 
// and prints its perimeter and area.

class PerimeterNAreaOfCircle
{
    static void Main()
    {
        double r;
        bool isDouble;

        Console.WriteLine("Program to print perimeter and area of " +
        "given circle of radius \"r\"");
        Console.Write("Enter r: ");
        isDouble = double.TryParse(Console.ReadLine(), out r);
        Console.Write(isDouble ? "" : "Invalid number\n");
        double perimeter = 2 * Math.PI * r;
        double area = r * r;
        Console.WriteLine($"{"Perimeter",9} = {perimeter:f2}");
        Console.WriteLine($"{"Area",9} = {area:f2}");
    }
}