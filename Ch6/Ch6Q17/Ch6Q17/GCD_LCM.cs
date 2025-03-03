// Write a program that given two numbers finds their greatest common 
// divisor (GCD) and their least common multiple (LCM). You may use 
// the formula LCM(a, b) = |a*b| / GCD(a, b). 

class GCD_LCM
{
    static void Main()
    {
        int a, b;
        bool isInt;

        Console.WriteLine("Program to find greatest common divisor " +
        "(GCD) and least common multiple (LCM) of two given numbers.");
        do
        {
            Console.Write("num1 = ");
            isInt = int.TryParse(Console.ReadLine(), out a);
            if(!isInt)
            {
                Console.WriteLine($"\nEnter a valid integer in range [{int.MinValue},{int.MaxValue}]");
            }
        }
        while(!isInt);

        do
        {
            Console.Write("num2 = ");
            isInt = int.TryParse(Console.ReadLine(), out b);
            if(!isInt)
            {
                Console.WriteLine($"\nEnter a valid integer in range [{int.MinValue},{int.MaxValue}]");
            }
        }
        while(!isInt);

        int aTemp = Math.Abs(a);
        int bTemp = Math.Abs(b);
        int gcd = 1;
        int lcm = -1;
        
        for(int i = ((aTemp < bTemp) ? aTemp : bTemp); i > 0; i--)
        {
            if((aTemp % i == 0) && (bTemp % i == 0))
            {
                gcd = i;
                break;
            }
        }

        for(int i = ((aTemp > bTemp) ? aTemp : bTemp); i < int.MaxValue; i++)
        {
            if((i % aTemp == 0) && (i % bTemp == 0))
            {
                lcm = i;
                break;
            }
        }

        Console.WriteLine($"GCD = {gcd}");
        Console.WriteLine($"LCM = {lcm}");
    }
}
