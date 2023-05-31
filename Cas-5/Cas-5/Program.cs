using Cas_5.Classes;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

BankAccount bankAccount = new BankAccount
{
    AccountName = "Slave",
    AccountNumber = 123456,
    Balance = 0,
};

string withdrawReturn = bankAccount.Withdraw(100);

Console.WriteLine(withdrawReturn);

//while (true)
//{
//    Console.Clear();
//    WellcomeMessage();
//    Console.WriteLine("1.Check Balance\n2.Deposit money\n3.Withdraw money\n4.Exit");
//    string userInput = Console.ReadLine();

//    switch (userInput)
//    {
//        case "1":
//            Console.Clear();
//            Console.WriteLine($"Your bank balance is:{bankAccount.GetBalance()}$");
//            ReturnStatement();
//            Console.ReadLine();
//            break;

//        case "2":
//            Console.Clear();
//            Console.Write("Enter amount to deposit: ");
//            string depositInput = Console.ReadLine();
//            int depositAmount = 0;
//            bool conversion = int.TryParse(depositInput, out depositAmount);
//            if (!conversion || depositAmount <= 0)
//            {
//                Console.Clear();
//                RedMessage("Please enter numeric value or amount greater than 0");
//                ReturnStatement();
//                Console.ReadLine();
//                break;
//            }
//            bankAccount.Deposit(depositAmount);
//            Console.WriteLine($"\nYour new balance: {bankAccount.GetBalance()}$");
//            ReturnStatement();
//            Console.ReadLine();
//            break;

//        case "3":
//            Console.Clear();
//            Console.Write("Enter amount to withdraw: ");
//            string withdrawInput = Console.ReadLine();
//            int withdrawAmount = 0;
//            bool withdrawConversion = int.TryParse(withdrawInput, out withdrawAmount);
//            if (!withdrawConversion || withdrawAmount <= 0)
//            {
//                Console.Clear();
//                RedMessage("Please enter numeric value or amount greater than 0");
//                ReturnStatement();
//                Console.ReadLine();
//                break;
//            }
//            Console.WriteLine(bankAccount.Withdraw(withdrawAmount));
//            ReturnStatement();
//            Console.ReadLine();
//            break;

//        case "4":
//            return;

//        default:
//            Console.Clear();
//            RedMessage("Wrong input!!!");
//            ReturnStatement();
//            Console.ReadLine();
//            break;
//    }
//}

void WellcomeMessage()
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Wellcome\n");
    Console.ResetColor();
}

void ReturnStatement()
{
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("\n\nPress any key to return");
    Console.ResetColor();
}

void RedMessage(string message)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine(message);
    Console.ResetColor();
}

Dog dog = new Dog
{
    Id = 1,
    Name = "Barkey",
    Type = "Dog",
    Race = "PitBull"
};


Dog kuce = new Dog(2, "Dezki", "Vucjak");

Console.WriteLine(kuce.Bark());
Console.WriteLine(kuce.Eat());

Cat cat = new Cat(3, "Milo", 9);
Cat cat2 = new Cat
{
    Id = 4,
    Name = "Bob",
    NumberOfLives = 6,
};

Console.WriteLine(cat.GetInfo());
cat2.Type = "Cat";
Console.WriteLine(cat2.GetInfo());

List<Animal> animals = new List<Animal>
{
    new Dog(5, "Rex", "Sharplaninec"),
    new Cat
    {
        Id = 6,
        Name = "Sparky",
        NumberOfLives = 7,
        Type = "Cat"
    }
};

Console.WriteLine("\n\n");

foreach (var animal in animals)
{
    Console.WriteLine($"Name: {animal.Name} | Animal type: {animal.Type}");
    Console.WriteLine(animal.GetInfo());
}

//Vehicle
// properties: (int)Id, (string)Brand, (string)Model, (string)Color,
// (bool) IsElectric, (int)NumberOfWheels
// method: GetInfo -> print prop.

//Car sto ke nasleduva od Vehicle
//prop: (int) EngineSize, numberOdDoors, hasNavigation, topSpeed

//2konstruktori 1 default + 1 nas

//override na GetInfo metodata

Car car = new Car
{
    Id = 1,
    Brand = "BMW",
    Model = "330",
    Color = "Black",
    IsElectric = false,
    NumberOfWheels = 4,
    EngineSize = 3000,
    NumberOfDoors = 4,
    TopSpeed = 250
};

car.GetInfo();

// User, Human, Employee, Student  date of birth -> DateTime

DateTime date = DateTime.Now;
DateTime dateOfBirth = new DateTime(1991,01,25);

string shortDate = new DateTime(1991, 01, 25).ToShortDateString();

Console.WriteLine(shortDate);

Employee slave = new Employee
{
    Id = 1,
    UserName = "sbo",
    Email = "slave@mail.com",
    Password = "1234",
    FirstName = "Slave",
    LastName = "Bogoevski",
    DateOfBirth = new DateTime(1991,01,25),
    Address = "Partiznaska",
    PhoneNumber = "123456",
    Position = JobPosition.Developer,
    EmployeesCar = car
};

Console.WriteLine($"\n\nFirstName: {slave.FirstName}");
Console.WriteLine($"LastName: {slave.LastName}");
Console.WriteLine($"Email: {slave.Email}");
Console.WriteLine($"DateOfBirth: {slave.DateOfBirth}");
Console.WriteLine($"Address: {slave.Address}");
Console.WriteLine($"PhoneNumber: {slave.PhoneNumber}");
Console.WriteLine($"Position: {slave.Position}");
Console.WriteLine($"\n\nCar: {slave.EmployeesCar.Brand} | {slave.EmployeesCar.Model}");
