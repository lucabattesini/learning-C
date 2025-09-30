// Public classes can be accessed anywhere and it's exposed
// An "normal" class can just be accessed by your own project
namespace Characters
{
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
}