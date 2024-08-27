// Write a program that exchanges the values of the bits on positions 
// 3, 4 and 5 with bits on positions 24, 25 and 26 of a given 32-bit unsigned 
// integer.

class ExchangeSomeBits
{
    static void Main()
    {
        uint num;

        Console.WriteLine("Program to exchange the values of the bits " +
        "on positions 3, 4 and 5 with bits on positions 24, 25 and 26 of a " +
        "given 32-bit unsigned integer.");
        Console.Write("Enter num: ");
        num = uint.Parse(Console.ReadLine());

        uint bit3 = (num >> 3) & 1;
        uint bit24 = (num >> 24) & 1;
        num = (num & (~(1U << 3))) | (bit24 << 3);
        num = (num & (~(1U << 24))) | (bit3 << 24);

        uint bit4 = (num >> 4) & 1;
        uint bit25 = (num >> 25) & 1;
        num = (num & (~(1U << 4))) | (bit25 << 4);
        num = (num & (~(1U << 25))) | (bit4 << 25);

        uint bit5 = (num >> 5) & 1;
        uint bit26 = (num >> 26) & 1;
        num = (num & (~(1U << 5))) | (bit26 << 5);
        num = (num & (~(1U << 26))) | (bit5 << 26);

        Console.WriteLine(num);
    }
}