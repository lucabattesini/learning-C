// Public classes can be accessed anywhere and it's exposed
// An "normal" class can just be accessed by your own project
public class Warrior
{
    // Fields are for internal uses only
    private int height; // Not a variable, it's called field
    private int weight; // Fields should be private

    // Propreties are mainly for external uses
    public int Height { get; set; } // This is a proprety
    public int Weight { get; set; }
    public string? Name { get; set; }

    public void Greetings(Warrior warrior)
    {
        Console.WriteLine($@"Greetings, {warrior.Name}!");
    }
}

public class EntryPoint
{
    static void Main()
    {
        Warrior theGoodGuy = new Warrior();
        theGoodGuy.Height = 100;
        theGoodGuy.Weight = 70;
        theGoodGuy.Name = "Luca";

        Warrior theBadGuy = new Warrior();
        theBadGuy.Height = 300;
        theBadGuy.Weight = 200;

        Console.WriteLine(theBadGuy.Height);
        Console.WriteLine(theBadGuy.Weight);

        theBadGuy.Greetings(theGoodGuy);
    }
}