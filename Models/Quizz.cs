namespace Trivio.Models
{
    public class Quizz
    {
        public int id { get; set; }
        public required string QuizzName { get; set; }
        public string QuizzDescription { get; set; }
        public string QuizzAnswer { get; set;}
        public string QuizzType { get; set;}

        public Quizz()
        {
                
        }
    }

    
}
