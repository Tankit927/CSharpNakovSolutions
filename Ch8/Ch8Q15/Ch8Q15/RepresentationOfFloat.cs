// * Write a program that prints the value of the mantissa, the sign of the 
// mantissa and exponent in float numbers (32-bit numbers with a 
// floating-point according to the IEEE 754 standard). Example: for the 
// number -27.25 should be printed: sign = 1, exponent = 10000011, 
// mantissa = 10110100000000000000000.

// Need to complete till Ch-9 Methods


class RepresentationOfFloat
{
    static void Main()
    {
        float num;

        Console.WriteLine("Program to print value of mantissa, sign and exponent of " +
        "given 32-bit floating-point number according to the IEEE 754 standard.");
        num = GetFloat("Float = ");
        byte[] myArray = BitConverter.GetBytes(num);
        byte[] bitArray = ByteToBitArray(myArray);

        Console.WriteLine();
        for(int i = 0; i < bitArray.Length; i++)
        {
            if(i == 0)
            {
                Console.WriteLine($"Sign = {bitArray[i]}");
            }
            else if(i >= 1 && i <= 8)
            {
                if(i == 1)
                {
                    Console.Write($"Exponent = {bitArray[i]}");
                }
                else if(i < 8)
                {
                    Console.Write(bitArray[i]);
                }
                else
                {
                    Console.WriteLine(bitArray[i]);
                }
            }
            else
            {
                if(i == 9)
                {
                    Console.Write($"Mantissa = {bitArray[i]}");
                }
                else if(i < 31)
                {
                    Console.Write(bitArray[i]);
                }
                else
                {
                    Console.WriteLine(bitArray[i]);
                }
            }
        }
    }


    static float GetFloat(string prompt)
    {
        // Method to user input float

        float n;
        bool isFloat;

        do
        {
            Console.Write(prompt);
            isFloat = float.TryParse(Console.ReadLine(), out n);
            if(!isFloat)
            {
                Console.WriteLine($"\nEnter a valid float in range[{float.MinValue},{float.MaxValue}]");
            }
        }
        while(!isFloat);

        return n;
    }


    static void PrintArray(byte[] myArray)
    {
        // Method to print byte array

        int len = myArray.Length;

        Console.Write("{");
        for(int i = 0; i < len; i++)
        {
            if(i < len-1)
            {
                Console.Write($"{myArray[i]}, ");
            }
            else
            {
                Console.Write($"{myArray[i]}");
            }
        }

        Console.WriteLine("}");
    }


    static byte[] ByteToBitArray(byte[] byteArray)
    {
        // Method to convert byte array to bit array

        int byteArrayLen = byteArray.Length;
        int bitArrayLen = byteArrayLen * 8;
        byte[] bitArray = new byte[bitArrayLen];

        for(int i = bitArrayLen-1, j = 0; i >= 0 && j < byteArrayLen; j++)
        {
            int count = 1;
            int n = byteArray[j];
            do
            {
                int r = n % 2;
                bitArray[i] = (byte)r;
                n /= 2;
                i -= 1;
                count += 1;
            }
            while(count <= 8);
        }

        return bitArray;
    }
}