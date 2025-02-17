// Write a program that converts Arabic digits to Roman ones.

class ArabicToRoman
{
    static void Main()
    {
        int n;
        bool isInt;

        Console.WriteLine("Program to convert given Arabic number[1,3999] to Roman.");

        // User input
        do
        {
            Console.Write("Num = ");
            isInt = int.TryParse(Console.ReadLine(), out n);
            if(!isInt || n < 1 || n > 3999)
            {
                Console.WriteLine($"\nEnter a valid integer in range[1,3999]");
            }
        }
        while(!isInt || n < 1 || n > 3999);

        // Arabic to roman
        string roman = "";
        switch(n / 1000)
        {
            case 0:
                {
                    break;
                }
            case 1:
                {
                    roman += "M";
                    break;
                }
            case 2:
                {
                    roman += "MM";
                    break;
                }
            case 3:
                {
                    roman += "MMM";
                    break;
                }
            default:
                {
                    Console.WriteLine("Error");
                    break;
                }
        }

        switch((n / 100) % 10)
        {
            case 0:
                {
                    break;
                }
            case 1:
                {
                    roman += "C";
                    break;
                }
            case 2:
                {
                    roman += "CC";
                    break;
                }
            case 3:
                {
                    roman += "CCC";
                    break;
                }
            case 4:
                {
                    roman += "CD";
                    break;
                }
            case 5:
                {
                    roman += "D";
                    break;
                }
            case 6:
                {
                    roman += "DC";
                    break;
                }
            case 7:
                {
                    roman += "DCC";
                    break;
                }
            case 8:
                {
                    roman += "DCCC";
                    break;
                }
            case 9:
                {
                    roman += "CM";
                    break;
                }
            default:
                {
                    Console.WriteLine("Error");
                    break;
                }
        }

        switch((n / 10) % 10)
        {
            case 0:
                {
                    break;
                }
            case 1:
                {
                    roman += "X";
                    break;
                }
            case 2:
                {
                    roman += "XX";
                    break;
                }
            case 3:
                {
                    roman += "XXX";
                    break;
                }
            case 4:
                {
                    roman += "XL";
                    break;
                }
            case 5:
                {
                    roman += "L";
                    break;
                }
            case 6:
                {
                    roman += "LX";
                    break;
                }
            case 7:
                {
                    roman += "LXX";
                    break;
                }
            case 8:
                {
                    roman += "LXXX";
                    break;
                }
            case 9:
                {
                    roman += "XC";
                    break;
                }
            default:
                {
                    Console.WriteLine("Error");
                    break;
                }
        }

        switch(n % 10)
        {
            case 0:
                {
                    break;
                }
            case 1:
                {
                    roman += "I";
                    break;
                }
            case 2:
                {
                    roman += "II";
                    break;
                }
            case 3:
                {
                    roman += "III";
                    break;
                }
            case 4:
                {
                    roman += "IV";
                    break;
                }
            case 5:
                {
                    roman += "V";
                    break;
                }
            case 6:
                {
                    roman += "VI";
                    break;
                }
            case 7:
                {
                    roman += "VII";
                    break;
                }
            case 8:
                {
                    roman += "VIII";
                    break;
                }
            case 9:
                {
                    roman += "IX";
                    break;
                }
            default:
                {
                    Console.WriteLine("Error");
                    break;
                }
        }

        // Print result
        Console.WriteLine($"Roman: {roman}");
    }
}