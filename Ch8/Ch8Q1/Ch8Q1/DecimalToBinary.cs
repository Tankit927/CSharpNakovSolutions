// Convert the numbers 151, 35, 43, 251, 1023 and 1024 to the binary 
// numeral system.

class DecimalToBinary
{
    static void Main()
    {
        int num;
        bool isInt;

        Console.WriteLine("Program to convert given numbers from decimal " +
        "numeral system to binary numeral system.");

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

        // Decimal to binary logic
        string bin = "";
        int temp = num;
        int count = 0;
        do
        {
            int r = temp % 2;
            if(count % 4 == 0 && count != 0)
            {
                bin = bin.Insert(0,r.ToString() + " ");
            }
            else
            {
                bin = bin.Insert(0,r.ToString());
            }
            
            temp /= 2;
            count += 1;
        }
        while(temp > 0);

        // Print result
        Console.WriteLine();
        Console.WriteLine(bin);
    }
}