// Write a program that converts a given number from binary to decimal 
// notation.

class BinaryToDecimal
{
    static void Main()
    {
        string binary;
        bool invalidChar = false;

        Console.WriteLine("Program to convert given number from " +
        "binary to decimal notation.");
        do
        {
            invalidChar = false;
            Console.Write("binary = ");
            binary = Console.ReadLine();
            foreach(char element in binary)
            {
                if(element != '0' && element != '1')
                {
                    invalidChar = true;
                    break;
                }
            }

            if(binary == "")
            {
                Console.WriteLine("\nEnter something bruh!");
            }
            else if(invalidChar)
            {
                Console.WriteLine("\nEnter a valid binary number");
            }
            
        }
        while(binary == "" || invalidChar);

        ulong num = 0;
        for(int i = 0, pow = binary.Length-1; i < binary.Length; i++, pow--)
        {
            num += (Convert.ToUInt64(binary[i].ToString()) * (ulong)Math.Pow(2, pow));
        }

        Console.WriteLine($"{num:n0}");
    }
}