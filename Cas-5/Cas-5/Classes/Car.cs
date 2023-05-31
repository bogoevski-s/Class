namespace Cas_5.Classes
{
    public class Car : Vehicle
    {
        public int EngineSize { get; set; }
        public int NumberOfDoors { get; set; }
        public bool HasNavigation { get; set; }
        public int TopSpeed { get; set; }

        public Car()
        {

        }

        public Car(
            int id,
            string brand, 
            string model, 
            string color, 
            bool isElectric, 
            int numberOfWheels,
            int engineSize,
            int numberOfDoors,
            bool hasNavigation,
            int topSpeed) : base(id, brand, model, color, isElectric, numberOfWheels)
        {
            EngineSize = engineSize;
            NumberOfDoors = numberOfDoors;
            HasNavigation = hasNavigation;
            TopSpeed = topSpeed;
        }

        public override void GetInfo()
        {
            Console.WriteLine($"Car has {NumberOfDoors} doors and it is {EngineSize}cc");
        }
    }
}
