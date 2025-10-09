using Characters;

public class EntryPoint
{
    static void Main()
    {
        Warrior theGoodGuy = new Warrior(200, 60, "Luca");

        Warrior theBadGuy = new Warrior(200, 50, "Maria");

        Console.WriteLine(theBadGuy.Height);
        Console.WriteLine(theBadGuy.Weight);

        theBadGuy.Greetings(theGoodGuy);
    }
}