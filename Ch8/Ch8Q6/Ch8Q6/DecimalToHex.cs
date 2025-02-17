// Write a program that converts a decimal number to hexadecimal one.

class DecimalToHex
{
    static void Main()
    {
        int num;
        bool isInt;

        Console.WriteLine("Program to convert given number from decimal " +
        "to hexadecimal");

        // User input
        do
        {
            Console.Write("Num = ");
            isInt = int.TryParse(Console.ReadLine(), out num);
            if(!isInt || num < 0)
            {
                Console.WriteLine($"\nEnter a valid integer in range[0,{int.MaxValue}]");
            }
        }
        while(!isInt || num < 0);

        // Decimal to hexadecimal
        string hex = "";
        int count = 0;
        do
        {
            int r = num % 16;
            string c = "";
            switch(r)
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
                        c = r.ToString();
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
            }

            if(count % 4 == 0)
            {
                hex = hex.Insert(0,c + " ");
            }
            else
            {
                hex = hex.Insert(0,c);
            }

            count += 1;
            num /= 16;
        }
        while(num > 0);

        // Print result
        Console.WriteLine($"Hex = {hex}");
    }
}