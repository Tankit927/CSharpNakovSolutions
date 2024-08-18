// Declare a variable of type char and assign it as a value the character, 
// which has Unicode code, 72 (use the Windows calculator in order to find 
// hexadecimal representation of 72).

class InitChar
{
    static void Main()
    {
        char myChar = '\u0048';

        Console.WriteLine($"myChar = {myChar}");
    }
}