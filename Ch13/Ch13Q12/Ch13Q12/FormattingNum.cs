// Write a program that reads a number from console and prints it in 15
// character field, aligned right in several ways: as a decimal number, 
// hexadecimal number, percentage, currency and exponential (scientific) 
// notation.

class FormattingNum
{
    static void Main()
    {
        const int PAD = 15;
        const int MARGIN = 5;

        Console.WriteLine("Program to print given number in many formats");
        double n = GetDouble("Number: ");

        Console.WriteLine();
        Console.Write("|".PadLeft(MARGIN)); Console.Write("Number".PadLeft((3*PAD)/4).PadRight(PAD)); Console.WriteLine(" |");
        Console.Write("|".PadLeft(MARGIN)); Console.Write($"{n:f2}".PadLeft(PAD)); Console.WriteLine(" |");
        // Console.Write("|".PadLeft(MARGIN)); Console.Write($"{n:x}".PadLeft(PAD)); Console.WriteLine(" |"); // Can't convert double to hex
        Console.Write("|".PadLeft(MARGIN)); Console.Write($"{n:p2}".PadLeft(PAD)); Console.WriteLine(" |");
        Console.Write("|".PadLeft(MARGIN)); Console.Write($"{n:c2}".PadLeft(PAD)); Console.WriteLine(" |");
        Console.Write("|".PadLeft(MARGIN)); Console.Write($"{n:e2}".PadLeft(PAD)); Console.WriteLine(" |");
    }


    static double GetDouble(string prompt, int? min=null, int? max=null)
    {
        // Method to user input integer
        // min <= integer <= max

        double num;
        bool isDouble;

        do
        {
            Console.Write(prompt);
            isDouble = double.TryParse(Console.ReadLine(), out num);
            if(!isDouble || (min != null && num < min) || (max != null && num > max))
            {
                Console.WriteLine($"\nEnter a valid integer in range[{(min == null ? double.MinValue : min)},{(max == null ? double.MaxValue : max)}]");
            }
        }
        while(!isDouble || (min != null && num < min) || (max != null && num > max));

        return num;
    }
}