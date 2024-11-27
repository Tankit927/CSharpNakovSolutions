// Write a program that asks for a digit (0-9), and depending on the input, 
// shows the digit as a word (in English). Use a switch statement. 

class DigitToWordMap
{
    static void Main()
    {
        byte digit;
        bool isByte;

        Console.WriteLine("Program to show the given digit (0-9) as a word.");
        Console.Write("Enter a digit (0-9) = ");
        isByte = byte.TryParse(Console.ReadLine(), out digit);
        
        switch(digit)
        {
            case 0: Console.WriteLine("A"); break;
            case 1: Console.WriteLine("B"); break;
            case 2: Console.WriteLine("C"); break;
            case 3: Console.WriteLine("D"); break;
            case 4: Console.WriteLine("E"); break;
            case 5: Console.WriteLine("F"); break;
            case 6: Console.WriteLine("G"); break;
            case 7: Console.WriteLine("H"); break;
            case 8: Console.WriteLine("I"); break;
            case 9: Console.WriteLine("J"); break;
            default: Console.WriteLine("Invalid number"); break;
        }
    }
}