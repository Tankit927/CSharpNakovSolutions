// Define a class, which contains information about a mobile phone: 
// model, manufacturer, price, owner, features of the battery (model, idle 
// time and hours talk) and features of the screen (size and colors).

using System.Formats.Tar;

public class Mobile
{
    private string _model = string.Empty;
    private string _manufacturer = string.Empty;
    private decimal _price = 0.00m;
    private string _owner = string.Empty;
    private Battery _battery = new();
    private Screen _screen = new();


    public string Model {get => _model; set => _model = value;}
    public string Manufacturer {get => _manufacturer; set => _manufacturer = value;}
    public decimal Price {get => _price; set => _price = value;}
    public string Owner {get => _owner; set => _owner = value;}
    public Battery MyBattery {get => _battery; set => _battery = value;}
    public Screen MyScreen {get => _screen; set => _screen = value;}


    public Mobile(Battery bat, Screen screen, string model="", string manufacturer="", decimal price=0, string owner="")
    {
        Model = model;
        Manufacturer = manufacturer;
        Price = price;
        Owner = owner;
        MyBattery = bat;
        MyScreen = screen;
    }

    public Mobile(Battery bat, string model="", string manufacturer="", decimal price=0, string owner="")
        : this(bat, new Screen(), model, manufacturer, price, owner)
    {
    }

    public Mobile(Screen screen, string model="", string manufacturer="", decimal price=0, string owner="")
        : this(new Battery(), screen, model, manufacturer, price, owner)
    {
    }

    public override string ToString()
    {
        // Mobile info

        const int PAD = 15;

        string s = "Model:".PadRight(PAD) + $"{Model}\n" +
            "Manufacturer:".PadRight(PAD) + $"{Manufacturer}\n" +
            "Price:".PadRight(PAD) + $"{Price:c2}\n" +
            "Owner:".PadRight(PAD) + $"{Owner}\n" +
            "\n" +
            "Battery info\n" +
            "Model:".PadRight(PAD) + $"{MyBattery.Model}\n" +
            "Idle time:".PadRight(PAD) + $"{MyBattery.IdleTime}\n" +
            "Talking time:".PadRight(PAD) + $"{MyBattery.TalkingTime}\n" +
            "\n" +
            "Screen info\n" +
            "Size:".PadRight(PAD) + $"{MyScreen.Size}\n" +
            "Color:".PadRight(PAD) + $"{MyScreen.Color}\n";

        return s;
    }
}