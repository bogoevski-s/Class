namespace Cas_5.Classes
{
    public class Employee : User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public JobPosition Position { get; set; }
        public Car EmployeesCar { get; set; } 
    }
}
