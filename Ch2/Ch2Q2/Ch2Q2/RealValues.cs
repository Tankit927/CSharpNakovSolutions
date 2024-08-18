// Which of the following values can be assigned to variables of type float, 
// double and decimal: 5, -5.01, 34.567839023; 12.345; 8923.1234857;
// 3456.091124875956542151256683467?

class RealValues
{
    static void Main()
    {
        float num1 = 5f, num2 = -5.01f, num3 = 12.345f;
        double num4 = 34.567839023, num5 = 8923.1234857;
        decimal num6 = 3456.091124875956542151256683467m;

        Console.WriteLine("float\n" +
        $"num1 = {num1}, num2 = {num2}, num3 = {num3}\n" +
        "double\n" +
        $"num4 = {num4}, num5 = {num5}\n" +
        "decimal\n" +
        $"num6 = {num6}");
    }
}