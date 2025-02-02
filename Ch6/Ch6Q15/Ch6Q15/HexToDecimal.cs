// Write a program that converts a given number from hexadecimal to 
// decimal notation.

class HexToDecimal
{
    static void Main()
    {
        string hex;
        bool invalidHex = false;

        Console.WriteLine("Program to convert a given number from " +
        "hexadecimal to decimal notation");
        do
        {
            invalidHex = false;
            Console.Write("Hex = ");
            hex = Console.ReadLine();
            hex = hex.ToUpper();
            hex = hex.Replace(" ", "");
            foreach(char e in hex)
            {
                if(e != '0' && e != '1' && e != '2' && e != '3' && e != '4' && e != '5' && e != '6' && e != '7' && e != '8' && e != '9' && e != 'A' && e != 'B' && e != 'C' && e != 'D' && e != 'E' && e != 'F')
                {
                    invalidHex = true;
                    break;
                }
            }

            if(hex == "")
            {
                Console.WriteLine("\nEnter something bruh!");
            }
            else if(invalidHex)
            {
                Console.WriteLine("\nEnter a valid hexadecimal number");
            }
        }
        while(hex == "" || invalidHex);

        ulong n = 0;
        for(int i = 0, pow = hex.Length - 1, temp; i < hex.Length; i++, pow--)
        {
            switch(hex[i])
            {
                case 'A':
                    {
                        temp = 10;
                        break;
                    }
                case 'B':
                    {
                        temp = 11;
                        break;
                    }
                case 'C':
                    {
                        temp = 12;
                        break;
                    }
                case 'D':
                    {
                        temp = 13;
                        break;
                    }
                case 'E':
                    {
                        temp = 14;
                        break;
                    }
                case 'F':
                    {
                        temp = 15;
                        break;
                    }
                default:
                    {
                        temp = Convert.ToInt32(hex[i].ToString());
                        break;
                    }
            }
            n += ((ulong)Math.Pow(16, pow) * (ulong)temp);
        }

        Console.WriteLine($"{n:n0}");
    }
}