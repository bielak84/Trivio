//prop
//ctor
namespace Trivio.Models
{
    public class Quizz
    {
        public int Id { get; set; }
        public string IdAspNetUsers { get; set; }
        public int Iloscpytan { get; set; }
        public string CreateDateTime { get; set; }
        public Quizz()
        {
         
        }
    }
    public class Pytanie
    {
        public int Id { get; set; }
        public int IdQuizz { get; set; }
        public string TrescPytanie { get; set; }

        public Pytanie()
        {

        }
    }
    public class Odpowiedz
    {
        public int Id { get; set; }
        public int IdPytanie { get; set; }
        public string TrescOdpowiedz { get; set; }
        public bool poprawna { get; set; }

        public Odpowiedz()
        {

        }
    }

}
