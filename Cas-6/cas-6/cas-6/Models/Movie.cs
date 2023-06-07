namespace cas_6.Models
{
    public class Movie
    {
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public double Rating { get; set; }
        public MovieGenre Genre { get; set; }
        public List<Actor> Actors { get; set; }

        public void GetMoviesDetails()
        {
            Console.WriteLine($"Title: {Name}");
            Console.WriteLine($"Genre: {Genre}");
            Console.WriteLine($"Realse date: {Date.ToShortDateString()}");
            Console.WriteLine($"Rating: {Rating}");
            Console.WriteLine("Actors:");
            foreach (var actor in Actors)
            {
                Console.WriteLine(actor.Name);
            }
        }
    }
}
