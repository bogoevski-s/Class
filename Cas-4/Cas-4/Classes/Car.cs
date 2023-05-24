namespace Cas_4.Classes
{
    public class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public int Kilometers { get; set; }

        public Car()
        {

        }

        public Car(string brand, string model, int year, int kilometers)
        {
            Brand = brand;
            Model = model;
            Year = year;
            Kilometers = kilometers;
        }

        public int CheckKilometers()
        {
            return Kilometers;
        }

        public string GetAge()
        {
            int currentYear = DateTime.Now.Year;
            return $"car is { currentYear - Year} years old";
        }
    }
}
