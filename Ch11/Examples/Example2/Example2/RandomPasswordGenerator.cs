// Random password generator

using System.Text;

class RandomPasswordGenerator
{
    private const string Nums = "1234567890";
    private const string SmallLetters = "abcdefghijklmnopqrstuvwxyz";
    private const string CapitalLetters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
    private const string Symbols = " `~!@#$%^&*()-_=+[]{}\\|;:'\",<.>/?";
    private const string AllChars = Nums + SmallLetters + CapitalLetters + Symbols;
    private static Random rng = new Random();


    static void Main()
    {
        while(true)
        {
            Console.WriteLine(GetNewPassword()); // Print new password
            Console.ReadLine();
        }
    }


    static string GetNewPassword()
    {
        // Method to generate password

        // Determine the length of password
        // 8 <= password length <= 15
        const int BaseLen = 8;
        int extraLen = rng.Next(8);
        int len = BaseLen + extraLen;
        StringBuilder sb = new StringBuilder();

        // Insert 2 Capital letters at random position
        for(int i = 1; i <= 2; i++)
        {
            sb.Insert(rng.Next(sb.Length+1), CapitalLetters[rng.Next(CapitalLetters.Length)]);
        }

        // Insert 2 small letters at random position
        for(int i = 1; i <= 2; i++)
        {
            sb.Insert(rng.Next(sb.Length+1), SmallLetters[rng.Next(SmallLetters.Length)]);
        }

        // Insert 2 numbers at random position
        for(int i = 1; i <= 2; i++)
        {
            sb.Insert(rng.Next(sb.Length+1), Nums[rng.Next(Nums.Length)]);
        }

        // Insert 3 symbols at random position
        for(int i = 1; i <= 2; i++)
        {
            sb.Insert(rng.Next(sb.Length+1), Symbols[rng.Next(Symbols.Length)]);
        }

        // Insert extraLen AllChars at random position
        for(int i = 1; i <= extraLen; i++)
        {
            sb.Insert(rng.Next(sb.Length+1), AllChars[rng.Next(AllChars.Length)]);
        }

        return sb.ToString();
    }
}