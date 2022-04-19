using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication3.DataAccess;
using WebApplication3.Models;
using System;
using System.Collections.Generic;
using System.Text;



namespace WebApplication3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RezController : ControllerBase
    {
        List<Rezervasyon> rezs = new List<Rezervasyon>();

        [HttpPost]
        [Route("Post")]
        public  object Post(int trenId, int vagonId, int kisi)
        {
            var rez = DataAccess.VagonData.vagon.Where(x => x.TrenId == trenId && x.Id == vagonId).FirstOrDefault();
            var kapasite = rez.VagonKisiSayisi * 0.7;
            if (kapasite > kisi)
            {
                Rezervasyon rezervasyon = new Rezervasyon();
                rezervasyon.TrenId = trenId;
                rezervasyon.VagonId = vagonId;
                rezervasyon.KisiSayisi = kisi;
                rezervasyon.RezervasyonYapilabilir = true;
                rezs.Add(rezervasyon);
                
            }
            return new { V=$"Rezervasyon Yapılabilir{true}: yerleşim ayrıntı:vagon adı:{vagonId},kisisayisi:{kisi}" };
            if (kapasite<kisi)
            {

            }
            return new {X=$"Rezervasyon yapılamaz{false}: yerlesim ayrıntı: {null}"};
        }

       
    }
}
