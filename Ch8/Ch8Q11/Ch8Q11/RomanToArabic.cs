// Write a program that converts Roman digits to Arabic ones.

class RomanToArabic
{
    static void Main()
    {
        string roman;
        bool isRoman;

        Console.WriteLine("Program to convert given roman number to decimal.");

        // User input
        do
        {
            isRoman = true;
            Console.Write("Roman number = ");
            roman = Console.ReadLine().ToUpper().Replace(" ", "");
            foreach(char c in roman)
            {
                if(c != 'I' && c != 'V' && c != 'X' && c != 'L' && c != 'C' && c != 'D' && c != 'M')
                {
                    isRoman = false;
                    break;
                }
            }

            if(roman == "" || !isRoman)
            {
                Console.WriteLine($"\nEnter a valid roman number");
            }
        }
        while(roman == "" || !isRoman);

        // Roman to arabic
        int sum = 0;
        int len = roman.Length;
        int prev = 0;
        for(int i = len - 1; i >= 0; i--)
        {
            int value = 0;
            switch(roman[i])
            {
                case 'I':
                    {
                        value = 1;
                        break;
                    }
                case 'V':
                    {
                        value = 5;
                        break;
                    }
                case 'X':
                    {
                        value = 10;
                        break;
                    }
                case 'L':
                    {
                        value = 50;
                        break;
                    }
                case 'C':
                    {
                        value = 100;
                        break;
                    }
                case 'D':
                    {
                        value = 500;
                        break;
                    }
                case 'M':
                    {
                        value = 1000;
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Error");
                        break;
                    }
            }

            if(value >= prev)
            {
                sum += value;
            }
            else
            {
                sum -= value;
            }

            prev = value;
        }

        // Print result
        Console.WriteLine($"Arabic: {sum:n0}");
    }
}