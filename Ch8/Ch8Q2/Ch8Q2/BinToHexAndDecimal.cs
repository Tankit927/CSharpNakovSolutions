// Convert the number 1111010110011110(2) to hexadecimal and decimal 
// numeral systems.

class BinToHexAndDecimal
{
    static void Main()
    {
        string bin;
        bool isBin = true;

        Console.WriteLine("Program to convert given number from binary to " +
        "hexadecimal and decimal numeral system.");

        // User input
        do
        {
            isBin = true;
            Console.Write("Num = ");
            bin = Console.ReadLine();
            foreach(char c in bin)
            {
                if(c != '1' && c != '0')
                {
                    isBin = false;
                    break;
                }
            }

            if(bin == "" || !isBin)
            {
                Console.WriteLine($"\nEnter a valid binary number");
            }
        }
        while(bin == "" || !isBin);

        // Binary to decimal logic
        int num = 0;
        int len = bin.Length;
        for(int i = 0; i < len; i++)
        {
            num += (Convert.ToInt32(bin[i].ToString()) * (int)Math.Pow(2, len-1-i));
        }

        // Binary to hexadecimal logic
        int num2 = 0;
        string hex = "";
        int newLen = len;
        while(newLen % 4 != 0)
        {
            newLen += 1;
            bin = bin.Insert(0,"0");
        }
        for(int i = newLen - 1, count = 1, pow = 0; i >= 0; i--, count++)
        {
            num2 += (Convert.ToInt32(bin[i].ToString()) * (int)Math.Pow(2,pow));
            pow += 1;

            if(count % 4 == 0 && count != 0)
            {
                string c = "";
                switch(num2)
                {
                    case 0:
                    case 1:
                    case 2:
                    case 3:
                    case 4:
                    case 5:
                    case 6:
                    case 7:
                    case 8:
                    case 9:
                        {
                            c = num2.ToString();
                            break;
                        }
                    case 10:
                        {
                            c = "A";
                            break;
                        }
                    case 11:
                        {
                            c = "B";
                            break;
                        }
                    case 12:
                        {
                            c = "C";
                            break;
                        }
                    case 13:
                        {
                            c = "D";
                            break;
                        }
                    case 14:
                        {
                            c = "E";
                            break;
                        }
                    case 15:
                        {
                            c = "F";
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Error");
                            break;
                        }
                }

                if(count % 16 == 0 && count < newLen)
                {
                    hex = hex.Insert(0," " + c);
                }
                else
                {
                    hex = hex.Insert(0,c);
                }

                num2 = 0;
                pow = 0;
            }
        }

        // Printing result
        Console.WriteLine($"Decimal: {num:n0}");
        Console.WriteLine($"Hexadecimal: {hex}");
    }
}