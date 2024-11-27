// Write a program that applies bonus points to given scores in the range 
// [1…9] by the following rules:
// - If the score is between 1 and 3, the program multiplies it by 10.
// - If the score is between 4 and 6, the program multiplies it by 100.
// - If the score is between 7 and 9, the program multiplies it by 1000.
// - If the score is 0 or more than 9, the program prints an error 
// message. 

class BonusPoints
{
    static void Main()
    {
        int score;
        bool isInt;

        Console.WriteLine("Program to give bonus points to given score " +
        "in the range[0-9].");
        Console.Write("Enter score = ");
        isInt = int.TryParse(Console.ReadLine(), out score);
        Console.WriteLine(isInt ? "" : "Invalid number");

        switch(score)
        {
            case 1:
            case 2:
            case 3:
            {
                Console.WriteLine($"Final score = {score*10}");
                break;
            }
            case 4:
            case 5:
            case 6:
            {
                Console.WriteLine($"Final score = {score*100}");
                break;
            }
            case 7:
            case 8:
            case 9:
            {
                Console.WriteLine($"Final score = {score*1000}");
                break;
            }
            default:
            {
                Console.WriteLine("Invalid input");
                break;
            }
        }
    }
}