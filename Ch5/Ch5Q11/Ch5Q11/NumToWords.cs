// * Write a program that converts a number in the range [0…999] to 
// words, corresponding to the English pronunciation. Examples:
// - 0 --> "Zero"
// - 12 --> "Twelve"
// - 98 --> "Ninety eight"
// - 273 --> "Two hundred seventy three"
// - 400 --> "Four hundred"
// - 501 --> "Five hundred and one"
// - 711 --> "Seven hundred and eleven"

class NumToWords
{
    static void Main()
    {
        int num;
        bool isInt;

        Console.WriteLine("Program to convert given number in range[0-999] to words.");
        Console.Write("Enter a number in range[0-999] = ");
        isInt = int.TryParse(Console.ReadLine(), out num);
        Console.WriteLine(isInt ? "" : "Invalid number");
        num = Math.Abs(num);

        bool specialCase2 = num == 0;
        switch(num/100)
        {
            case 1: Console.Write("one hundred "); break;
            case 2: Console.Write("two hundred "); break;
            case 3: Console.Write("three hundred "); break;
            case 4: Console.Write("four hundred "); break;
            case 5: Console.Write("five hundred "); break;
            case 6: Console.Write("six hundred "); break;
            case 7: Console.Write("seven hundred "); break;
            case 8: Console.Write("eight hundred "); break;
            case 9: Console.Write("nine hundred "); break;
            default: break;
        }

        num %= 100;
        bool specialCase = true;
        switch(num)
        {
            case 10: Console.Write("ten "); break;
            case 11: Console.Write("eleven "); break;
            case 12: Console.Write("twelve "); break;
            case 13: Console.Write("thirteen "); break;
            case 14: Console.Write("fourteen "); break;
            case 15: Console.Write("fifteen "); break;
            case 16: Console.Write("sixteen "); break;
            case 17: Console.Write("seventeen "); break;
            case 18: Console.Write("eighteen "); break;
            case 19: Console.Write("nineteen "); break;
            case 20: Console.Write("twenty "); break;
            case 30: Console.Write("thirty "); break;
            case 40: Console.Write("fourty "); break;
            case 50: Console.Write("fifty "); break;
            case 60: Console.Write("sixty "); break;
            case 70: Console.Write("seventy "); break;
            case 80: Console.Write("eighty "); break;
            case 90: Console.Write("ninety "); break;
            default: specialCase = false; break;
        }

        if(!specialCase)
        {
            switch(num/10)
            {
                case 2: Console.Write("twenty "); break;
                case 3: Console.Write("thirty "); break;
                case 4: Console.Write("fourty "); break;
                case 5: Console.Write("fifty "); break;
                case 6: Console.Write("sixty "); break;
                case 7: Console.Write("seventy "); break;
                case 8: Console.Write("eighty "); break;
                case 9: Console.Write("ninety "); break;
                default: break;
            }

            num %= 10;
            switch(num)
            {
                case 1: Console.Write("one"); break;
                case 2: Console.Write("two"); break;
                case 3: Console.Write("three"); break;
                case 4: Console.Write("four"); break;
                case 5: Console.Write("five"); break;
                case 6: Console.Write("six"); break;
                case 7: Console.Write("seven"); break;
                case 8: Console.Write("eight"); break;
                case 9: Console.Write("nine"); break;
                default: break;
            }

            if(specialCase2)
            {
                Console.WriteLine("zero");
            }
        }
    }
}