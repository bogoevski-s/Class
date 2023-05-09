//primitive data types in c#
var ime = "slave";

string prezime = "Bogoevski";

Console.WriteLine(prezime);

int broj = 5;

float decimalen = 4.5F;

double broj2 = 1.4;

bool boolean = true;

char character = 'a';

//za ispisuvanje nesto vo konzola koristime Console.WriteLine
Console.WriteLine("Vnesete nesto:");

//za citanje na input od konzola koristime Console.ReadLine()
var input = Console.ReadLine();

//if, else if, else  uslovi 
int ocenka = 0;

if (ocenka == 5)
{
    Console.WriteLine("Odlicen");
}
else if (ocenka == 4)
{
    Console.WriteLine("Mnogu dobar");
}
else if (ocenka == 3)
{
    Console.WriteLine("Dobar");
}
else if (ocenka == 2)
{
    Console.WriteLine("Dovolen");
}
else if (ocenka == 1)
{
    Console.WriteLine("Nedovolen");
}
else if (ocenka > 5 || ocenka < 1)
{
    Console.WriteLine("worng input");
}
else
{
    Console.WriteLine("error");
}

//konverzija, parsiranje in input od konzola (string) vo intiger
//sekogas koga nesto vnesuvame od konzola toa e od tip string
string userInput = Console.ReadLine();

int num = Convert.ToInt16(userInput);

Console.WriteLine(num);

string vnes = Console.ReadLine();
int poeni;

//tryParse ni vrakja boolean koj ni kazuva dali konverzija e uspesna ili ne 
bool konverzija = int.TryParse(vnes, out poeni);

if (konverzija)
{
    if (poeni > 0 && poeni <= 10)
    {
        Console.WriteLine("Nedovolen 1");
    }
    else if (poeni > 10 && poeni <= 20)
    {
        Console.WriteLine("Dovolen 2");
    }
    else if (poeni > 20 && poeni <= 30)
    {
        Console.WriteLine("Dobar 3");
    }
    else if (poeni > 30 && poeni <= 40)
    {
        Console.WriteLine("Mnogu dobar 4");
    }
    else if (poeni > 40 && poeni <= 50)
    {
        Console.WriteLine("Odlicen 5");
    }
}
else
{
    Console.WriteLine("pogresen broj");
}

//switch case 
int dayOfTheWeek = 101;

switch (dayOfTheWeek)
{
    case 0:
        Console.WriteLine("Ponedelnik");
        break;
    case 1:
        Console.WriteLine("Vtornik");
        break;
    case 2:
        Console.WriteLine("Sreda");
        break;
    case 3:
        Console.WriteLine("Cetvrtok");
        break;
    case 5:
        Console.WriteLine("Petok");
        break;
    case 6:
        Console.WriteLine("Sabota");
        break;
    case 7:
        Console.WriteLine("Nedela");
        break;
    default:
        Console.WriteLine("Nevaliden den od nedelata");
        break;
}

//loop ciklusi ov C#
string consoleInput = Console.ReadLine();
int number;
bool conversion = int.TryParse(consoleInput, out number);

if (conversion)
{
    for (var i = 0; i < 10; i++)
    {
        Console.WriteLine("iteracija -> " + i);
    }
}

// for ciklus sto iterira od 10 do 0
for (int i = 10; i >= 0; i--)
{
    Console.WriteLine("iteracija -> " + i);
}