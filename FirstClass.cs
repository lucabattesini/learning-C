// Public classes can be accessed anywhere and it's exposed
// An "normal" class can just be accessed by your own project
public class Warrior
{
    public int height;
    public int weight;
}

public class EntryPoint
{
    static void Main()
    {
        Warrior theGoodGuy = new Warrior();
        theGoodGuy.height = 100;
        theGoodGuy.weight = 70;

        Warrior theBadGuy = new Warrior();
        theBadGuy.height = 300;
        theBadGuy.weight = 200;

        Console.WriteLine(theBadGuy.height);
        Console.WriteLine(theBadGuy.weight);
    }
}