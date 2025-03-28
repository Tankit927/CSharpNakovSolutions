// Exploring:
// 1. string initialization
// 2. string comparison
// 3. string operations
// 4. StringBuilder
//    - Initialization
//    - Operations
// 5. Regular Expressions

class Program
{
    static void Main()
    {
        const int PAD = 30;
        const int S_NO_PAD = 6;
        int count = 1;

        // Declaring and initializing string
        string s1 = "Ankit"; // Initializing with literal value
        string s2 = new('a', 4); // "aaaa" equivalent to {new string('a', 4);}

        Console.WriteLine("Ways to initialize string variable:");
        Console.Write("S.No.".PadRight(S_NO_PAD)); Console.Write("Value of string variable".PadRight(PAD)); Console.WriteLine("How its initialized");
        Console.WriteLine(new string('-',60));
        Console.Write($"{count++}".PadRight(S_NO_PAD)); Console.Write(s1.PadRight(PAD)); Console.WriteLine($"string s = \"{s1}\";");
        Console.Write($"{count++}".PadRight(S_NO_PAD)); Console.Write(s2.PadRight(PAD)); Console.WriteLine($"string s = new('a', 4);");
    }
}