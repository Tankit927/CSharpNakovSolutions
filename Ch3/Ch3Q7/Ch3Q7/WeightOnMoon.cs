// The gravitational field of the Moon is approximately 17% of that on the 
// Earth. Write a program that calculates the weight of a man on the 
// moon by a given weight on the Earth.

class WeightOnMoon
{
    static void Main()
    {
        double weightOnEarth;

        Console.Write("Enter your weight on Earth(in kg): ");
        weightOnEarth = double.Parse(Console.ReadLine());

        double weightOnMoon = 0.17 * weightOnEarth;

        Console.WriteLine($"Your weight on moon = {weightOnMoon} kg");
    }
}