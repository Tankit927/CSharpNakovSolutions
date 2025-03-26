// Main program

using Ch11Q7.CreatingAndUsingObjects;

namespace Ch11Q7
{
    class Program
    {
        static void Main()
        {
            Cat Lessie = new Cat();
            Cat Messy = new Cat("Messy", "Red");

            Console.WriteLine("My two cats are:");
            Console.WriteLine(Lessie.Name);
            Console.WriteLine(Messy.Name);
            Console.WriteLine();
            Console.WriteLine($"{Lessie.Name}'s color is {Lessie.Color}");
            Console.WriteLine($"{Messy.Name}'s color is {Messy.Color}");
            Console.WriteLine();
            Lessie.SayMiau();
            Messy.SayMiau();
            Console.WriteLine();

            Console.WriteLine($"Value: {Sequence.NextValue()}");
            Console.WriteLine($"Value: {Sequence.NextValue()}");
            Console.WriteLine($"Value: {Sequence.NextValue()}");
            Console.WriteLine($"Value: {Sequence.NextValue()}");
            Console.WriteLine($"Value: {Sequence.NextValue()}");
            Console.WriteLine($"Value: {Sequence.NextValue()}");
            Console.WriteLine($"Value: {Sequence.NextValue()}");
            Console.WriteLine($"Value: {Sequence.NextValue()}");
        }
    }
}