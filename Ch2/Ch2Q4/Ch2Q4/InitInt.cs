// Initialize a variable of type int with a value of 256 in
// hexadecimal format (256 is 100 in a numeral system with base 16).

class InitInt
{
    static void Main()
    {
        int num = 0x100;

        Console.WriteLine($"num in decimal = {num}");
        Console.WriteLine($"num in hex = {num:X}");
    }
}