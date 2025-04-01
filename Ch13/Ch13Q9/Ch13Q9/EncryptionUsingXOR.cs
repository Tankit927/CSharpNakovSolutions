// Write a program that encrypts a text by applying XOR (excluding or) 
// operation between the given source characters and given cipher code. 
// The encryption should be done by applying XOR between the first letter 
// of the text and the first letter of the code, the second letter of the text 
// and the second letter of the code, etc. until the last letter of the code, 
// then goes back to the first letter of the code and the next letter of the 
// text. Print the result as a series of Unicode escape characters \xxxx. 
// Sample source text: "Test". Sample cipher code: "ab". The result should 
// be the following: "\u0035\u0007\u0012\u0016".

using System.Text;

class EncryptionUsingXOR
{
    static void Main()
    {
        Console.WriteLine("Program to encrypt given string with given cypher");
        string s = GetString("Enter string: ");

        Console.WriteLine();
        string cypher = GetString("Enter cypher: ");

        Console.WriteLine();
        Console.WriteLine("Given text in unicode:");
        PrintUnicodes(s);

        Console.WriteLine();
        Console.WriteLine("Encrypted text in unicode:");
        PrintUnicodes(Encrypt(s, cypher));
    }


    static void PrintUnicodes(string s)
    {
        // Method to print given string as unicode characters

        foreach(ushort c in s)
        {
            Console.Write($"\\u{c:x4}");
        }

        Console.WriteLine();
    }


    static string GetString(string prompt)
    {
        // Method to user input string

        string? s;

        do
        {
            Console.Write(prompt);
            s = Console.ReadLine();
            if(string.IsNullOrWhiteSpace(s))
            {
                Console.WriteLine("\nEnter something bruh!");
            }
        }
        while(string.IsNullOrWhiteSpace(s));

        return s;
    }


    static string Encrypt(string s, string cypher)
    {
        // Method to encrypt the given string by doing XOR with given cypher

        StringBuilder sb = new(s);

        for(int i = 0, j = 0; i < sb.Length; i++, j++)
        {
            if(j >= cypher.Length)
            {
                j = 0;
            }

            sb[i] = (char)(sb[i] ^ cypher[j]);
        }

        return sb.ToString();
    }
}