// Declare several variables by selecting for each one of them the most 
// appropriate of the types sbyte, byte, short, ushort, int, uint, long
// and ulong in order to assign them the following values: 52,130; -115; 
// 4825932; 97; -10000; 20000; 224; 970,700,000; 112; -44; -1,000,000; 
// 1990; 123456789123456789.

class DeclaringVariables
{
    static void Main()
    {
        byte num1 = 52, num2 = 130, num3 = 97, num4 = 224, num5 = 112;
        sbyte num6 = -115, num7 = -44;
        short num8 = -10000, num9 = 20000, num10 = 1990;
        int num11 = 4825932, num12 = 4825932, num13 = 970700000, num14 = -1000000;
        long num15 = 123456789123456789;

        Console.WriteLine($"Byte\n" +
        $"num1 = {num1}, num2 = {num2}, num3 = {num3}, num4 = {num4}, num5 = {num5}\n" +
        $"sbyte\n" +
        $"num6 = {num6}, num7 = {num7}\n" +
        $"short\n" +
        $"num8 = {num8}, num9 = {num9}, num10 = {num10}\n" +
        $"int\n" +
        $"num11 = {num11}, num12 = {num12}, num13 = {num13}, num14 = {num14}\n" +
        $"long\n" +
        $"num15 = {num15}");
    }
}