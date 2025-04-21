public class Screen
{
    public string Size {get; set;}
    public string Color {get; set;}

    public Screen(string size, string color)
    {
        Size = size;
        Color = color;
    }

    public Screen(string size) : this(size, string.Empty)
    {
    }

    public Screen() : this(string.Empty, string.Empty)
    {
    }
}