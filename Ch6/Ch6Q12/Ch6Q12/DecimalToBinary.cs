// Write a program that converts a given number from decimal to binary 
// notation (numeral system).

class DecimalToBinary
{
    static void Main()
    {
        int n;
        bool isInt;

        Console.WriteLine("Program to convert given number " +
        "from decimal to binary notation");
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

        int temp = n;
        string binary = "";
        while(temp > 0)
        {
            binary = binary.Insert(0, (temp % 2).ToString());
            temp /= 2;
        }

        Console.WriteLine(binary);
    }
}