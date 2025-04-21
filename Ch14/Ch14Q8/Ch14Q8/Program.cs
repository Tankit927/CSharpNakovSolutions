public class Program
{
    static void Main()
    {
        Battery bat1 = new(Battery.BatteryType.NiMH, 72, 24);
        Battery bat2 = new();

        Screen sc1 = new("small", "red");
        Screen sc2 = new();

        Mobile m1 = new(bat1, sc1, "Idk", "meeee", 23.456m, "Crab");
        Mobile m2 = new(bat2);
        Mobile m3 = new(sc2);

        Console.WriteLine(m1);
        Console.WriteLine();
        Console.WriteLine(m2);
        Console.WriteLine();
        Console.WriteLine(m3);
    }
}