namespace Cas_5.Classes
{
    public class Dog : Animal
    {
        public string Race { get; set; }

        public Dog()
        {

        }

        public Dog(int id, string name, string race) : base(id, name, "Dog")
        {
            Race = race;
        }
        public string Bark()
        {
            return $"{GetInfo()} aw aw";
        }
        
        public override string Eat()
        {
            return $"Eating";
        }
    }
}
