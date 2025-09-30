// Public classes can be accessed anywhere and it's exposed
// An "normal" class can just be accessed by your own project
public class Warrior
{
    // Fields are for internal uses only
    private int height; // Not a variable, it's called field
    private int weight; // Fields should be private
    private string? name;

    // Propreties are mainly for external uses
    public int Height { get; set; } // This is a proprety
    public int Weight { get; set; }
    public string? Name { get; set; }

    public void Greetings(Warrior warrior)
    {
        Console.WriteLine($@"Greetings, {warrior.Name}!");
    }

    public Warrior(int height, int weight, string name) // This is a constructor
    {
        Height = height;
        Weight = weight;
        Name = name;
    }
}

public class EntryPoint
{
    static void Main()
    {
        Warrior theGoodGuy = new Warrior(200, 60, "Luca");

        Warrior theBadGuy = new Warrior(100, 50, "Maria");

        Console.WriteLine(theBadGuy.Height);
        Console.WriteLine(theBadGuy.Weight);

        theBadGuy.Greetings(theGoodGuy);
    }
}