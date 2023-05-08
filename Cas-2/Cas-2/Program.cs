
//int number = 5;

//for (int i = 0; i < 10; i++)
//{
//    Console.WriteLine(i);

//    if (number == i)
//    {
//        break;
//    }
//}

//Console.WriteLine(number);

//try
//{
//    string numberInput = Console.ReadLine();
//    int result = Int32.Parse(numberInput);
//}
//catch (Exception e)
//{
//    Console.WriteLine("you enter wrong input!!!");
//    Console.WriteLine(e.Message);
//}


//array


//string name = "slave";

//string[] stringArray = new string[4] { name, "petar", "igor", "john" };

//for (int i = 0; i < stringArray.Length; i++)
//{
//    Console.WriteLine(stringArray[i]);
//}

//try
//{
//    int[] numbersArray;
//    numbersArray = new int[5];
//    numbersArray[0] = 10;
//    numbersArray[1] = 25;
//    numbersArray[2] = 34;
//    numbersArray[3] = 66;
//    numbersArray[4] = 9;
//    numbersArray[5] = 101;

//    for (int i = 0; i < numbersArray.Length; i++)
//    {
//        Console.WriteLine(numbersArray[i]);
//    }
//}
//catch(Exception e)
//{
//    Console.WriteLine(e.Message);
//}

//  напишете програма која што ке иницијализира арреј од стрингови со имиња на 5 овошја, ++
//  и user да внесе име на овошје. ++
//  Ако името на овошјето е во низата тогаш испишете на конзола
//  "Yes, we have that fruit!" а доколку го нема овошјето во низата испишете "Sorry, we don't have that fruit."


//string[] fruits = new string[5] { "apple", "banana", "orange", "kiwi", "Mango" };
//bool fruitFound = false;

//Console.WriteLine("Please input fruit:");
//string userInput = Console.ReadLine();

//for (int i = 0; i < fruits.Length; i++)
//{
//    if (userInput.ToLower() == fruits[i].ToLower())
//    {
//        fruitFound = true;
//        break;
//    }
//}

//if (fruitFound)
//{
//    Console.WriteLine("Yes, we have that fruit!");
//}
//else
//{
//    Console.WriteLine("Sorry, we don't have that fruit.");
//}

//----------------------------------------------------------------------------------------
//  napisi programa koja ke inizijalizira array od int so 10 random broevi pomegju 1 i 100
//  i isprintaj gi najmaliot i najgolemiot broj vo konzola 
//  pr "The largest number is: 99"  "The smallest number is: 1"

int[] numbers = new int[10];
Random randomNumber = new Random();

for (int i = 0; i < numbers.Length; i++)
{
    numbers[i] = randomNumber.Next(1, 100);
}

int largest = numbers[0];
int smallest = numbers[0];


foreach (var number in numbers)
{
    if (number > largest)
    {
        largest = number;
    }
    if (number < smallest)
    {
        smallest = number;
    }
}

Console.WriteLine("The largest number is:" + largest);
Console.WriteLine("The smalles number is:" + smallest);

List<int> listInt = new List<int> { largest, 8, 99, 0, 11 };

Console.WriteLine("test");
