namespace Trivio.Models
{
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
