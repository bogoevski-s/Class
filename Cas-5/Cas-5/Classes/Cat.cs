namespace Cas_5.Classes
{
    public class Cat : Animal
    {
        public int NumberOfLives { get; set; }
        
        public Cat() { }

        public Cat(int id, string name, int lives) : base(id, name, "Cat")
        {
            NumberOfLives = lives;
        }
    }
}
