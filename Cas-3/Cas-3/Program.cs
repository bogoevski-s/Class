// LIST<T>

List<string> names = new List<string>();
names.Add("Slave");
names.Add("Goran");

List<string> students = new List<string>
{
    "John",
    "Bob",
    "Williams"
};

foreach (var student in students)
{
    Console.WriteLine(student);
}

students.Remove("Bob");

foreach (var student in students)
{
    Console.WriteLine(student);
}

bool hasStudent = students.Contains("John");
bool hasStudent1 = students.Any(student => student.Equals("Williams"));

//zadaca 1 za List
//napisete programa sto ke sortira lista od stringovi primer lista od iminja po azbucen redosled i ispecatete gi site iminja vo konzola
List<string> namesInClass = new List<string>() { "Williams", "Alice", "Bob", "Charlie", "Slave", "Dave", "Eve", "Bob" };
namesInClass.Sort();
foreach (var name in namesInClass)
{
    Console.WriteLine(name);
}

List<int> numbers = new List<int> { 5, 3, 9, 1, 7, 2 };
numbers.Sort();
numbers.Reverse();

foreach (var num in numbers)
{
    Console.WriteLine(num);
}

int min = numbers.Min();
int max = numbers.Max();

Console.WriteLine("testsegdfgfughbdf \n"); // \n dodava prazna linija pod console.wirteline

Console.WriteLine(min);
Console.WriteLine(max);


// napisete programa sto prima 2 listi od broevi i gi spojuva vo 1 sortirana lista 
// kreiraj 2 listi od broevi 
List<int> numbersList1 = new List<int> { 3, 1, 5 };
List<int> numbersList2 = new List<int> { 4, 2, 6 };

List<int> mergedList = new List<int>();

mergedList.AddRange(numbersList1);
mergedList.AddRange(numbersList2);

mergedList.Sort();

foreach (var num in mergedList)
{
    Console.WriteLine(num);
}

List<int> intList = new List<int> { 2, 9, 4, 3, 5, 1, 7, 11 };

List<int> filtered = intList.Where(x => x > 5).ToList();

foreach (var num in filtered)
{
    Console.WriteLine(num);
}

List<int> list2 = new List<int>();

int x = intList.SingleOrDefault(x => x == 2);

Console.WriteLine(x);


// Write a program that takes a list of strings as input
// and removes all items from the list that contain the letter "a".
List<string> words = new List<string>() { "apple", "banana", "carrot", "date", "elderberry" };

words.RemoveAll(x => x.Contains("a"));

foreach (var item in words)
{
    Console.WriteLine(item);
}

// invalid solution 
for (int i = 0; i < words.Count; i++)
{
    bool containsLetter = words[i].ToLower().Contains("a");
    if (containsLetter)
    {
        words.RemoveAt(i);
    }
}

// napisete programa koja sto ke zapisuva novi studenti vo lista i ke moze da se izlistaa site studenti
// programot ke ima 3 opcii
// 1.Add new student => kade ke moze da vneseme ime na nova student
// 2.All students => kade ke moze da gi izlistame site studenti
// 3.Exit => opcija za izlez od programata

List<string> studentsNames = new List<string>();

while (true)
{
    Console.Clear();
    Console.WriteLine("1. Add new student");
    Console.WriteLine("2. View all students");
    Console.WriteLine("3. Exit \n");
    string userInput = Console.ReadLine();

    switch (userInput)
    {
        case "1":
            Console.Clear();
            Console.WriteLine("Please enter student name or press '1' to return");
            string studentNameOrExit = Console.ReadLine();
            if (studentNameOrExit == "1")
            {
                break;
            }
            studentsNames.Add(studentNameOrExit);
            break;
        case "2":
            Console.Clear();
            if (studentsNames.Count == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("There is no students yet\n");
                Console.ResetColor();
                Console.WriteLine("Press any key to return");
                Console.ReadLine();
                break;
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("All students\n");
            Console.ResetColor();
            foreach (var name in studentsNames)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(name);
                Console.ResetColor();
            }
            Console.WriteLine("\n\nPress any key to return");
            Console.ReadLine();
            break;
        case "3":
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Good bye");
            Console.ResetColor();
            return;
        default:
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Wrong input!!!\n");
            Console.ResetColor();
            Console.WriteLine("Press any key to return");
            Console.ReadLine();
            break;
    }
}
