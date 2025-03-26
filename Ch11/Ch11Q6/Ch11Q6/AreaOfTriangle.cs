// Write a program which calculates the area of a triangle with the 
// following given: 
// - three sides; 
// - side and the altitude to it; 
// - two sides and the angle between them in degrees.

class AreaOfTriangle
{
    static void Main()
    {
        double area = 0;
        Console.WriteLine("Program to calculate area of triangle when:");
        Console.WriteLine("1. Three sides are given.");
        Console.WriteLine("2. Side and altitude are given.");
        Console.WriteLine("3. Two sides and angle between them is given.");
        int choice = GetInt("", 1, 3);
        Console.WriteLine();
        
        switch(choice)
        {
            case 1:
                {
                    double a, b, c;

                    a = GetDouble("Side 1: ", 0);
                    b = GetDouble("Side 2: ", 0);
                    c = GetDouble("Side 3: ", 0);
                    area = GetAreaOfTriangle(a, b, c);
                    break;
                }
            case 2:
                {
                    double b, h;

                    b = GetDouble("Base: ", 0);
                    h = GetDouble("Altitude: ", 0);
                    area = GetAreaOfTriangle(b, h);
                    break;
                }
            case 3:
                {
                    double a, b;
                    float theta;

                    a = GetDouble("Side 1: ", 0);
                    b = GetDouble("Side 2: ", 0);
                    theta = GetFloat($"Angle between {a:f2} and {b:f2}: ");
                    area = GetAreaOfTriangle(a, b, theta);
                    break;
                }
            default:
                {
                    Console.WriteLine("Error!");
                    break;
                }
        }

        Console.WriteLine($"Area of triangle: {area:f2}");
    }


    static int GetInt(string prompt, int? min=null, int? max=null)
    {
        // Method to user input integer

        int num;
        bool isInt;

        do
        {
            Console.Write(prompt);
            isInt = int.TryParse(Console.ReadLine(), out num);
            if(!isInt || (min != null && num < min) || (max != null && num > max))
            {
                Console.WriteLine($"\nEnter a valid integer in range[{(min == null ? int.MinValue : min)},{(max == null ? int.MaxValue : max)}]");
            }
        }
        while(!isInt || (min != null && num < min) || (max != null && num > max));
        
        return num;
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


    static float GetFloat(string prompt, float? min=null, float? max=null)
    {
        // Method to user input float
        // min <= float <= max

        float num;
        bool isFloat;

        do
        {
            Console.Write(prompt);
            isFloat = float.TryParse(Console.ReadLine(), out num);
            if(!isFloat || (min != null && num < min) || (max != null && num > max))
            {
                Console.WriteLine($"\nEnter a valid number in range[{(min == null ? float.MinValue : min)},{(max == null ? float.MaxValue : max)}]");
            }
        }
        while(!isFloat || (min != null && num < min) || (max != null && num > max));

        return num;
    }


    static double GetAreaOfTriangle(double a, double b, double c)
    {
        // Method to calculate area of triangle when 3 sides are given

        double s = (a + b + c) / 2;

        return Math.Sqrt(s * (s-a) * (s-b) * (s-c));
    }


    static double GetAreaOfTriangle(double b, double h)
    {
        // Method to calculate area of triangle when base and height are given

        return (b * h) / 2;
    }


    static double GetAreaOfTriangle(double a, double b, float theta)
    {
        // Method to calculate area of triangle when two sides and angle 
        // between them is given
        // theta is given in degrees
        // 0 <= theta <= 180

        theta *= (float)(Math.PI / 180);

        return (a * b * Math.Sin(theta)) / 2;
    }
}