// Convert the hexadecimal numbers FA, 2A3E, FFFF, 5A0E9 to binary and 
// decimal numeral systems.

class HexToBinAndDecimal
{
    static void Main()
    {
        string hex;
        bool isHex;

        Console.WriteLine("Program to convert given number from hexadecimal to " +
        "binary and decimal numeral system.");

        // User input
        do
        {
            isHex = true;
            Console.Write("Hex = ");
            hex = Console.ReadLine().ToUpper();
            foreach(char c in hex)
            {
                if(c != '0' && c != '1' && c != '2' && c != '3' && c != '4' && c != '5' && c != '6' && c != '7' && c != '8' && c != '9' && c != 'A' && c != 'B' && c != 'C' && c != 'D' && c != 'E' && c != 'F')
                {
                    isHex = false;
                    break;
                }
            }

            if(hex == "" || !isHex)
            {
                Console.WriteLine("Enter a valid hexadecimal number");
            }

        }
        while(hex == "" || !isHex);

        // Hex to binary logic
        string bin = "";
        foreach(char c in hex)
        {
            int num = 0;
            string bin4bit = "";
            switch(c)
            {
                case '0':
                case '1':
                case '2':
                case '3':
                case '4':
                case '5':
                case '6':
                case '7':
                case '8':
                case '9':
                    {
                        num = Convert.ToInt32(c.ToString());
                        break;
                    }
                case 'A':
                    {
                        num = 10;
                        break;
                    }
                case 'B':
                    {
                        num = 11;
                        break;
                    }
                case 'C':
                    {
                        num = 12;
                        break;
                    }
                case 'D':
                    {
                        num = 13;
                        break;
                    }
                case 'E':
                    {
                        num = 14;
                        break;
                    }
                case 'F':
                    {
                        num = 15;
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Error");
                        break;
                    }
            }

            do
            {
                int r = num % 2;
                bin4bit = bin4bit.Insert(0,r.ToString());
                num /= 2;
            }
            while(num > 0);

            while(bin4bit.Length < 4)
            {
                bin4bit = bin4bit.Insert(0,"0");
            }

            bin += (bin4bit + " ");
        }

        // Hex to decimal
        int n = 0;
        int len = hex.Length;
        for(int i = 0, pow = len - 1; i < len; i++, pow--)
        {
            int value = 0;
            switch(hex[i])
            {
                case '0':
                case '1':
                case '2':
                case '3':
                case '4':
                case '5':
                case '6':
                case '7':
                case '8':
                case '9':
                    {
                        value = Convert.ToInt32(hex[i].ToString());
                        break;
                    }
                case 'A':
                    {
                        value = 10;
                        break;
                    }
                case 'B':
                    {
                        value = 11;
                        break;
                    }
                case 'C':
                    {
                        value = 12;
                        break;
                    }
                case 'D':
                    {
                        value = 13;
                        break;
                    }
                case 'E':
                    {
                        value = 14;
                        break;
                    }
                case 'F':
                    {
                        value = 15;
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Error");
                        break;
                    }
            }

            n += (value * (int)Math.Pow(16,pow));
        }

        // Printing result
        Console.WriteLine($"Binary: {bin}");
        Console.WriteLine($"Decimal: {n:n0}");
    }
}