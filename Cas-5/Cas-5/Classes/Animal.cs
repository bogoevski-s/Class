namespace Cas_5.Classes
{
    public class Animal
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }

        public Animal() { }

        public Animal(int id, string name, string type)
        {
            Id = id;
            Name = name;
            Type = type;
        }

        public virtual string Eat()
        {
            return $"The {Type} named {Name} is eating";
        }

        public string GetInfo()
        {
            return $"{Id} {Name} {Type}";
        }
    }
}
