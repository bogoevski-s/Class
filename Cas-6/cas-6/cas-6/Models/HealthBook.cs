namespace cas_6.Models
{
    public class HealthBook
    {
        public string Name { get; set; }
        public DogRace Race { get; set; }
        public int Years { get; set; }
        public List<Record> HealthRecords { get; set; }
    }
}
