using WebApplication3.Models;

namespace WebApplication3.DataAccess
{
    public class TrenData
    {
        public static List<Tren> trens = new List<Tren>()
       {
          new Tren(){Id = 1,Name="Basket Express",VagonSayisi=3},
          new Tren(){Id = 2,Name="Doğu Express",VagonSayisi=2},
          new Tren(){Id = 3,Name="GuneyDoğu Express",VagonSayisi=5}

       };


    }
}
