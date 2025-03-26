// Write a program which by given two sides finds the hypotenuse of a 
// right triangle. Implement entering of the lengths of the sides from the 
// standard input, and for the calculation of the hypotenuse use methods of 
// the class Math.

class PythagorasTheorem
{
    static void Main()
    {
        double p, b;

        Console.WriteLine("Program to calculate hypotenuse of right angled triangle " +
        "when perpendicular and base is given.");
        p = GetDouble("Perpendicular: ", 0);
        b = GetDouble("Base: ", 0);

        Console.WriteLine();
        Console.WriteLine($"Hypotenuse: {GetHypotenuse(p, b):f2}");
    }


    static double GetDouble(string prompt, double? min=null, double? max=null)
    {
        // Method to user input double
        // min <= double <= max

        double num;
        bool isDouble;

        do
        {
            Console.Write(prompt);
            isDouble = double.TryParse(Console.ReadLine(), out num);
            if(!isDouble || (min != null && num < min) || (max != null && num > max))
            {
                Console.WriteLine($"\nEnter a valid number in range[{(min == null ? double.MinValue : min)},{(max == null ? double.MaxValue : max)}]");
            }
        }
        while(!isDouble || (min != null && num < min) || (max != null && num > max));

        return num;
    }


    static double GetHypotenuse(double p, double b)
    {
        // Method to calculate hypotenuse of a right angled triangle when
        // base and perpendicular are given

        return Math.Sqrt(Math.Pow(p,2) + Math.Pow(b,2));
    }
}