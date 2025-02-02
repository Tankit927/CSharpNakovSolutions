// Write a program that converts a given number from decimal to 
// hexadecimal notation.

class DecimalToHex
{
    static void Main()
    {
        int n;
        bool isInt;

        Console.WriteLine("Program to convert a given number from " +
        "decimal to hexadecimal notation.");
        do
        {
            Console.Write("n = ");
            isInt = int.TryParse(Console.ReadLine(), out n);
            if(!isInt || n < 0)
            {
                Console.WriteLine($"\nEnter a valid integer in range [0,{int.MaxValue}]");
            }
        }
        while(!isInt || n < 0);

        string hex = "";
        if(n == 0)
        {
            hex = "0";
        }
        else
        {
            string temp;
            while(n > 0)
            {
                int r = n % 16;
                switch(r)
                {
                    case 10:
                        {
                            temp = "A";
                            break;
                        }
                    case 11:
                        {
                            temp = "B";
                            break;
                        }
                    case 12:
                        {
                            temp = "C";
                            break;
                        }
                    case 13:
                        {
                            temp = "D";
                            break;
                        }
                    case 14:
                        {
                            temp = "E";
                            break;
                        }
                    case 15:
                        {
                            temp = "F";
                            break;
                        }
                    default:
                        {
                            temp = r.ToString();
                            break;
                        }
                }

                hex = hex.Insert(0, temp);
                n /= 16;
            }
        }
        
        Console.WriteLine(hex);
    }
}