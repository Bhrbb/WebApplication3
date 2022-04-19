using WebApplication3.Models;
namespace WebApplication3.DataAccess
{
    public class VagonData
    {
        public static List<Vagon> vagon = new List<Vagon>()
       {
           new Vagon(){Id=1,TrenId=1,VagonAdi="1.vagon",VagonKisiSayisi=10 },
           new Vagon(){Id=2,TrenId=1,VagonAdi="2.vagon",VagonKisiSayisi=25 },
           new Vagon(){Id=3,TrenId=1,VagonAdi="3.vagon",VagonKisiSayisi=50 },
           new Vagon(){Id=4,TrenId=2,VagonAdi="1.vagon",VagonKisiSayisi=17 },
           new Vagon(){Id=5,TrenId=2,VagonAdi="2.vagon",VagonKisiSayisi=15 },
           new Vagon(){Id=6,TrenId=3,VagonAdi="1.vagon",VagonKisiSayisi=50 },
           new Vagon(){Id=7,TrenId=3,VagonAdi="2.vagon",VagonKisiSayisi=35 },
           new Vagon(){Id=8,TrenId=3,VagonAdi="3.vagon",VagonKisiSayisi=20 },
           new Vagon(){Id=9,TrenId=3,VagonAdi="4.vagon",VagonKisiSayisi=50 },
           new Vagon(){Id=10,TrenId=3,VagonAdi="5.vagon",VagonKisiSayisi=30 },

       };
    }
}
