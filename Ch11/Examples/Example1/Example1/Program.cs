// This is where Main() method is

class Program
{
    static void Main()
    {
        Cat firstCat = new Cat();
        firstCat.Name = "Tony";
        firstCat.SayMiau();

        Cat secondCat = new Cat("Pepy", "Red");
        secondCat.SayMiau();
        Console.WriteLine($"Cat {secondCat.Name} is {secondCat.Color}");
    }
}