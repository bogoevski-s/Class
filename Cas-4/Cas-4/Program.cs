using Cas_4.Classes;

// instantiating a new object from Human class
Human covek = new Human();
covek.Age = 10;
covek.Name = "Bob";

Console.WriteLine(covek.Name);
Console.WriteLine(covek.Age);


Student student1 = new Student
{
    FirstName = "Slave",
    LastName = "Bogoevski",
    Email = "slave.bogoevski@yahoo.com",
    Grades = new List<Grade>() // property Grades is List of type Grade (we use the class Grade as a type)
    {  
        new Grade { ClassName = "Matematika", ClassGrade = 3 },
        new Grade { ClassName = "Fizika", ClassGrade = 4 },
        new Grade { ClassName = "Likovno", ClassGrade = 5 }
    },
    Car = new Car
    {
        Brand = "Opel",
        Model = "Astra",
        Year = 2010,
        Kilometers = 250000
    }
};

// another way to instantiate new object
Student student2 = new Student
{
    FirstName = "John",
    LastName = "Bobsky",
    Email = "bob@mail.com"
};

Console.WriteLine($"student {student1.FirstName} is driving {student1.Car.Brand}");

Console.WriteLine($"Student {student1.FirstName}\nAvgerage grade: {student1.CalculateGrades()}");

foreach (var grade in student1.Grades)
{
    Console.WriteLine($"Class: {grade.ClassName} | Grade: {grade.ClassGrade}");
}

// ctrl+k+c = comment | ctrl+k+u uncomment


List<Student> students = new List<Student>() { student1, student2 };

foreach (var student in students)
{
    Console.WriteLine($"First name: {student.FirstName} | LastName: {student.LastName} | Email: {student.Email}");
}

Console.WriteLine(student1.FirstName);
Console.WriteLine(student1.LastName);
Console.WriteLine(student1.Email);
Console.WriteLine($"First name: {student1.FirstName} | LastName: {student1.LastName} | Email: {student1.Email}");
Console.WriteLine($"First name: {student2.FirstName} | LastName: {student2.LastName} | Email: {student2.Email}");


// napravi klasa Car so slednive properties: Brand, Model, Year, Kilometers
// inicijaliziraj objekt od Car klasata so input-i od konzola
// pr vnesi make: 
// i isprintaj go obj na konzola so site properties

Console.WriteLine("Vnesete brand:");
string brandInput = Console.ReadLine();

Console.WriteLine("Vnesete model:");
string modelInput = Console.ReadLine();

Console.WriteLine("Vnesete godina:");
string yearInput = Console.ReadLine();
int yearInt = int.Parse(yearInput);

Console.WriteLine("Vnesete Km:");
string kilometerInput = Console.ReadLine();
int kiloterInt = int.Parse(kilometerInput);

Car kola = new Car
{
    Brand = brandInput,
    Model = modelInput,
    Year = yearInt,
    Kilometers = kiloterInt
};

Car car2 = new Car("BWM", "3", 2015, 225000);


Console.WriteLine($"Brand: {car2.Brand}\nModel: {car2.Model}\nYear: {car2.Year}\nKilometers: {car2.Kilometers}\n\n");

int km = car2.CheckKilometers();
Console.WriteLine(km);

Console.WriteLine(car2.GetAge());



//Napavi klasa Rectangle so prop width i height i napravi metoda sto ke presmetuva plostina na pravoagolnikot
//i na kraj ke isprinta plostinata na pravoagolnikot e 15

Rectange pravoagolnik = new Rectange
{
    Width = 5, 
    Height = 5,
};

double area = pravoagolnik.CalculateArea();
Console.WriteLine(area);

// Note* all classes should be in separate folder in project (ex. Classes)
// this is not a good pratice to put classes inside Program.cs
//----------------------------------------
class Human
{
    public string Name { get; set; }
    
    public int Age { get; set; }

    public Human()
    {

    }
}
