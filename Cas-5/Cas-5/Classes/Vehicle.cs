namespace Cas_5.Classes
{
    public class Vehicle
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public bool IsElectric { get; set; }
        public int NumberOfWheels { get; set; }

        public Vehicle()
        {

        }

        public Vehicle(
            int id,
            string brand,
            string model,
            string color,
            bool isElectric,
            int wheels)
        {
            Id = id;
            Brand = brand;
            Model = model;
            Color = color;
            IsElectric = isElectric;
            NumberOfWheels = wheels;
        }

        public virtual void GetInfo()
        {
            Console.WriteLine($"ID: {Id}\nBrand: {Brand}\nModel: {Model}\nColor: {Color}\nElectric vehcile: {IsElectric}\nWheels: {NumberOfWheels}");
        }
    }
}
