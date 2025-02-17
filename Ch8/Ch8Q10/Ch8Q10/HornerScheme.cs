// Write a program that converts a binary number to decimal using the 
// Horner scheme.

class HornerScheme
{
    static void Main()
    {
        string bin;
        bool isBin;

        Console.WriteLine("Program to convert given binary number to decimal " +
        "using Horner scheme.");

        // User input
        do
        {
            isBin = true;
            Console.Write("Binary = ");
            bin = Console.ReadLine();
            bin = bin.Replace(" ", "");
            foreach(char c in bin)
            {
                if(c != '0' && c != '1')
                {
                    isBin = false;
                    break;
                }
            }
        }
        while(bin == "" || !isBin);

        // Horner scheme
        int sum = 0;
        int len = bin.Length;
        for(int i = 0; i < len; i++)
        {
            if(i != len - 1)
            {
                sum = (sum + Convert.ToInt32(bin[i].ToString())) * 2;
            }
            else
            {
                sum = sum + Convert.ToInt32(bin[i].ToString());
            }
        }

        // Print result
        Console.WriteLine($"Decimal: {sum:n0}");
    }
}