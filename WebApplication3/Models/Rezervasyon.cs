namespace WebApplication3.Models
{
    public class Rezervasyon
    {
        public int Id { get; set; }
        public bool RezervasyonYapilabilir { get; set; }
        public int VagonId { get; set; }
        public int TrenId { get; set; }
        public int KisiSayisi { get; set; }



    }
}
