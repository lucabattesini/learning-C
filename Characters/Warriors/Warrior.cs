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

        // Properties are mainly for external uses
        public int Height
        {
            get
            {
                return height;
            }
            set // Possible to use "private set" to just set field inside the class
            {
                if (value <= 300 && value >= 175) // This is a validation
                {
                    height = value; // value key word means the value of the property       
                }
                else
                {
                    throw new ArgumentOutOfRangeException(string.Empty, "The height must be between 1,75 & 3 meters");
                    // Console.WriteLine("The height must be between 1,75 & 3 meters");
                }
            }
        } // It's possible to make a property read only, or write only, by deleting get or set
        
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