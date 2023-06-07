using cas_6.Models;

Actor actor1 = new Actor
{
    Name = "Vin diesel",
    DateOfBirth = new DateTime(1982,10,11)
};

Movie movie = new Movie
{
    Name = "Fast and furious",
    Date = new DateTime(2012, 05, 22),
    Rating = 7.5,
    Genre = MovieGenre.Action,
    //Actors = new List<Actor> { actor1 }
    Actors = new List<Actor>
    {
        new Actor
        {
            Name = "Vin diesel",
            DateOfBirth = new DateTime(1982,10,11)
        },
        new Actor
        {
            Name = "Tom Hanks",
            DateOfBirth = new DateTime(1975,01,19)
        },
        new Actor
        {
            Name = "Denzel Washington",
            DateOfBirth = new DateTime(1990,09,30)
        }
    }
};

movie.GetMoviesDetails();


// int, string, bool, DateTime, double, List, Array true-false
// Class ->

// Animal - base class
// IsMamal - bool
// IsWaterAnimal - bool
// NumberOfLegs - int

// Dog : Animal
// da
// ne
// 4
// race -> enum
// ime -> string
// godini -> int pr. 9 // datum na ragjanje - DateTime
// tezina -> double
// zdravstvena kniska -> Class ZdravstvenaKniska
// ime
// rasa
// godini
// pregledi -> lista<Pregled> -> Pregled
// vreme -> DateTime // den mesec godina, cas
// opis -> string 


Dog dog = new Dog
{
    IsMamal = true,
    IsWaterAnimal = false,
    NumberOfLegs = 4,
    Name = "Rex",
    Race = DogRace.Bulldog,
    Years = 3,
    Weight = 12.5,
    HealthBook = new HealthBook
    {
        Name = "Rex",
        Race = DogRace.Bulldog,
        Years = 3,
        HealthRecords = new List<Record>
        {
            new Record
            {
                Date = new DateTime(2023,02,15,12,23,00),
                Description = "All good"
            },
            new Record
            {
                Date = new DateTime(2022,09,10,16,03,00),
                Description = "Everthing's fine"
            }
        }
    }
};

dog.GetInfo();
