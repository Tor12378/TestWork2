
namespace TestWork2
{
    public class Person
    {
        public int Rank { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public string Country { get; set; }
        public int Rating { get; set; }
        public int Games { get; set; }
        public int B_Year { get; set; }

        public override string? ToString()
        {
            return string.Format("Rank:{0} Name:{1} Title:{2} Country: {3} Rating: {4} Games: {5} B_Year: {6}", Rank, Name, Title, Country, Rating, Games, B_Year);
        }

    }
    

}
