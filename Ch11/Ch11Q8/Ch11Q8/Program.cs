// Main Program

using Ch11Q8.CreatingAndUsingObjects;

namespace Ch11Q8
{
    class Program
    {
        static void Main()
        {
            Cat cat1 = new Cat();
            Cat cat3 = new Cat();
            Cat cat5 = new Cat();
            Cat cat7 = new Cat();
            Cat cat9 = new Cat();
            Cat cat2 = new Cat("Pink");
            Cat cat4 = new Cat("Red");
            Cat cat6 = new Cat("Black");
            Cat cat8 = new Cat("White");
            Cat cat10 = new Cat("Orange");

            Console.WriteLine($"{cat1.Name} is {cat1.Color}");
            Console.WriteLine($"{cat2.Name} is {cat2.Color}");
            Console.WriteLine($"{cat3.Name} is {cat3.Color}");
            Console.WriteLine($"{cat4.Name} is {cat4.Color}");
            Console.WriteLine($"{cat5.Name} is {cat5.Color}");
            Console.WriteLine($"{cat6.Name} is {cat6.Color}");
            Console.WriteLine($"{cat7.Name} is {cat7.Color}");
            Console.WriteLine($"{cat8.Name} is {cat8.Color}");
            Console.WriteLine($"{cat9.Name} is {cat9.Color}");
            Console.WriteLine($"{cat10.Name} is {cat10.Color}");
            Console.WriteLine();

            cat1.SayMiau();
            cat2.SayMiau();
            cat3.SayMiau();
            cat4.SayMiau();
            cat5.SayMiau();
            cat6.SayMiau();
            cat7.SayMiau();
            cat8.SayMiau();
            cat9.SayMiau();
            cat10.SayMiau();
        }
    }
}