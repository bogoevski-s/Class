using System.Xml.Linq;

namespace cas_6.Models
{
    public class Dog : Animal
    {
        public string Name { get; set; }
        public DogRace Race { get; set; }
        public int Years { get; set; }
        public double Weight { get; set; }
        public HealthBook HealthBook { get; set; }

        public void GetInfo()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Race: {Race}");
            Console.WriteLine($"Years: {Years}");
            Console.WriteLine($"Weight: {Weight}");
            Console.WriteLine("Health book:\n");
            foreach (var record in HealthBook.HealthRecords)
            {
                Console.WriteLine($"Date: {record.Date}\nDescription: {record.Description}\n\n");
            }
        }
    }
}
