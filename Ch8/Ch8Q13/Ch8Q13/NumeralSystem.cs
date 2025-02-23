// Write a program that by given N, S, D (2 ≤ S, D ≤ 16) converts the number 
// N from an S-based numeral system to a D based numeral system.

class NumeralSystem
{
    static void Main()
    {
        int s, d;
        string n1;

        Console.WriteLine("Program to convert given positive no. N from S based numeral " +
        "system to D based numeral system where 2 <= S, D <= 16");
        s = GetInt("S = ", 2, 16);
        n1 = GetNum($"{s} based = ", s);
        d = GetInt("D = ", 2, 16);

        if(s == d)
        {
            Console.WriteLine($"{d} base = {FormattedNumString(n1, d)}");
        }
        else if(d == 10)
        {
            // Convert to decimal
            // Print result
            Console.WriteLine($"Decimal = {ConvertToDecimal(n1, s):n0}");
        }
        else
        {
            // Convert to decimal
            // Convert decimal to d based numeral system
            // Print result
            Console.WriteLine($"{d} base = {FormattedNumString(ConvertDecimalTo(ConvertToDecimal(n1, s), d), d)}");
        }
    }


    static int GetInt(string prompt, int? min = null, int? max = null)
    {
        // Method to user input integer
        // min <= integer <= max

        int num;
        bool isInt;

        do
        {
            Console.Write(prompt);
            isInt = int.TryParse(Console.ReadLine(), out num);
            if(!isInt || (min != null && num < min) || (max != null && num > max))
            {
                Console.WriteLine($"\nEnter a valid integer in range[{(min == null ? int.MinValue : min)},{(max == null ? int.MaxValue : max)}]");
            }
        }
        while(!isInt || (min != null && num < min) || (max != null && num > max));

        return num;
    }


    static string GetNum(string prompt, int s)
    {
        // Method to user input number in s based numeral system
        // 2 <= s <= 16

        bool isValid;
        string num;

        do
        {
            Console.Write(prompt);
            num = Console.ReadLine().Replace(" ", "").ToUpper();
            switch(s)
            {
                case 2: isValid = isBinary(num); break;
                case 3: isValid = is3Based(num); break;
                case 4: isValid = is4Based(num); break;
                case 5: isValid = is5Based(num); break;
                case 6: isValid = is6Based(num); break;
                case 7: isValid = is7Based(num); break;
                case 8: isValid = isOctal(num); break;
                case 9: isValid = is9Based(num); break;
                case 10: isValid = isDecimal(num); break;
                case 11: isValid = is11Based(num); break;
                case 12: isValid = is12Based(num); break;
                case 13: isValid = is13Based(num); break;
                case 14: isValid = is14Based(num); break;
                case 15: isValid = is15Based(num); break;
                case 16: isValid = isHex(num); break;
                default: Console.WriteLine("Error!"); isValid = false; break;
            }

            if(!isValid || num == "")
            {
                Console.WriteLine("\nEnter a valid positive number");
            }
        }
        while(!isValid || num == "");

        return num;
    }


    static bool isBinary(string n)
    {
        // Method to check whether given string is in binary or not

        foreach(char c in n)
        {
            if(c != '0' && c != '1')
            {
                return false;
            }
        }

        return true;
    }


    static bool is3Based(string n)
    {
        // Method to check whether given string is in 3 based numeral system

        foreach(char c in n)
        {
            if(c != '0' && c != '1' && c != '2')
            {
                return false;
            }
        }

        return true;
    }


    static bool is4Based(string n)
    {
        // Method to check whether given string is in 4 based numeral system

        foreach(char c in n)
        {
            if(c != '0' && c != '1' && c != '2' && c != '3')
            {
                return false;
            }
        }

        return true;
    }


    static bool is5Based(string n)
    {
        // Method to check whether given string is in 5 based numeral system

        foreach(char c in n)
        {
            if(c != '0' && c != '1' && c != '2' && c != '3' && c != '4')
            {
                return false;
            }
        }

        return true;
    }


    static bool is6Based(string n)
    {
        // Method to check whether given string is in 6 based numeral system

        foreach(char c in n)
        {
            if(c != '0' && c != '1' && c != '2' && c != '3' && c != '4' && c != '5')
            {
                return false;
            }
        }

        return true;
    }


    static bool is7Based(string n)
    {
        // Method to check whether given string is in 7 based numeral system

        foreach(char c in n)
        {
            if(c != '0' && c != '1' && c != '2' && c != '3' && c != '4' && c != '5' && c != '6')
            {
                return false;
            }
        }

        return true;
    }


    static bool isOctal(string n)
    {
        // Method to check whether given string is octal

        foreach(char c in n)
        {
            if(c != '0' && c != '1' && c != '2' && c != '3' && c != '4' && c != '5' && c != '6' && c != '7')
            {
                return false;
            }
        }

        return true;
    }


    static bool is9Based(string n)
    {
        // Method to check whether given string is in 9 based numeral system

        foreach(char c in n)
        {
            if(c != '0' && c != '1' && c != '2' && c != '3' && c != '4' && c != '5' && c != '6' && c != '7' && c != '8')
            {
                return false;
            }
        }

        return true;
    }


    static bool isDecimal(string n)
    {
        // Method to check whether given string is decimal

        foreach(char c in n)
        {
            if(c != '0' && c != '1' && c != '2' && c != '3' && c != '4' && c != '5' && c != '6' && c != '7' && c != '8' && c != 9)
            {
                return false;
            }
        }

        return true;
    }


    static bool is11Based(string n)
    {
        // Method to check whether given string is in 11 based numeral system

        foreach(char c in n)
        {
            if(c != '0' && c != '1' && c != '2' && c != '3' && c != '4' && c != '5' && c != '6' && c != '7' && c != '8' && c != '9' && c != 'A')
            {
                return false;
            }
        }

        return true;
    }


    static bool is12Based(string n)
    {
        // Method to check whether given string is in 12 based numeral system

        foreach(char c in n)
        {
            if(c != '0' && c != '1' && c != '2' && c != '3' && c != '4' && c != '5' && c != '6' && c != '7' && c != '8' && c != '9' && c != 'A' && c != 'B')
            {
                return false;
            }
        }

        return true;
    }


    static bool is13Based(string n)
    {
        // Method to check whether given string is in 13 based numeral system

        foreach(char c in n)
        {
            if(c != '0' && c != '1' && c != '2' && c != '3' && c != '4' && c != '5' && c != '6' && c != '7' && c != '8' && c != '9' && c != 'A' && c != 'B' && c != 'C')
            {
                return false;
            }
        }

        return true;
    }


    static bool is14Based(string n)
    {
        // Method to check whether given string is in 14 based numeral system

        foreach(char c in n)
        {
            if(c != '0' && c != '1' && c != '2' && c != '3' && c != '4' && c != '5' && c != '6' && c != '7' && c != '8' && c != '9' && c != 'A' && c != 'B' && c != 'C' && c != 'D')
            {
                return false;
            }
        }

        return true;
    }


    static bool is15Based(string n)
    {
        // Method to check whether given string is in 15 based numeral system
        
        foreach(char c in n)
        {
            if(c != '0' && c != '1' && c != '2' && c != '3' && c != '4' && c != '5' && c != '6' && c != '7' && c != '8' && c != '9' && c != 'A' && c != 'B' && c != 'C' && c != 'D' && c != 'E')
            {
                return false;
            }
        }

        return true;
    }


    static bool isHex(string n)
    {
        // Method to check whether given string is hexadecimal

        foreach(char c in n)
        {
            if(c != '0' && c != '1' && c != '2' && c != '3' && c != '4' && c != '5' && c != '6' && c != '7' && c != '8' && c != '9' && c != 'A' && c != 'B' && c != 'C' && c != 'D' && c != 'E' && c != 'F')
            {
                return false;
            }
        }

        return true;
    }


    static string FormattedNumString(string n, int d)
    {
        // Method to print d based number n

        int len = n.Length;

        if(d == 10)
        {
            for(int i = len-1, count = 1; i >= 0; i--, count++)
            {
                if(count % 4 == 0)
                {
                    n = n.Insert(i+1, ",");
                    count = 1;
                }
            }
        }
        else if(d == 8)
        {
            for(int i = len-1, count = 1; i >= 0; i--, count++)
            {
                if(count % 4 == 0)
                {
                    n = n.Insert(i+1, " ");
                    count = 1;
                }
            }
        }
        else
        {
            for(int i = len-1, count = 1; i >= 0; i--, count++)
            {
                if(count % 5 == 0)
                {
                    n = n.Insert(i+1, " ");
                    count = 1;
                }
            }
        }

        return n;
    }


    static ulong ConvertToDecimal(string n, int s)
    {
        // Method to convert number n from s based numeral system to decimal

        ulong sum = 0UL;

        for(int i = n.Length-1, j = 0; i >= 0; i--, j++)
        {
            sum += ((ulong)CharsToNumMap(n[i]) * (ulong)Math.Pow(s, j));
        }

        return sum;
    }


    static int CharsToNumMap(char c)
    {
        // Mapping between char and int

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
            case '9': return Convert.ToInt32(c.ToString());
            case 'A': return 10;
            case 'B': return 11;
            case 'C': return 12;
            case 'D': return 13;
            case 'E': return 14;
            case 'F': return 15;
            default: Console.WriteLine("Error!"); return -1;
        }
    }


    static string ConvertDecimalTo(ulong n, int d)
    {
        // Method to convert decimal to d base numeral system

        string num = "";
        int r;

        do
        {
            r = (int)(n % (ulong)d);
            num = num.Insert(0, NumToCharMap(r));
            n /= (ulong)d;
        }
        while(n != 0);

        return num;
    }


    static string NumToCharMap(int n)
    {
        // Mapping between numbers and chars

        switch(n)
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
            case 9: return n.ToString();
            case 10: return "A";
            case 11: return "B";
            case 12: return "C";
            case 13: return "D";
            case 14: return "E";
            case 15: return "F";
            default: Console.WriteLine("Error!"); return "-1";
        }
    }
}