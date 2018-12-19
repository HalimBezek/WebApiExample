using BirthDayApp_webApiOrnegi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BirthDayApp_webApiOrnegi.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult DavetiyeFormu()
        {
            return View();

        }

        [HttpPost]
        public ActionResult DavetiyeFormu(DavetiyeModel model)
        {
            if (ModelState.IsValid)//ayni attribute ile özel bir durum verilmiş mi (örn:ad için girilmrsi zorunlu drumu=[Required])
            {
                Veritabani.Add(model);

                return View("Thanks", model);
                    
            }
            return View(model);

        }

        [ChildActionOnly] // sadece formdan çağrıldığında gözüksün
        public ActionResult Katilanlar()
        {
            var katilanlar = Veritabani.Liste.Where(i => i.KatilmaDurumu == true);

            return PartialView(katilanlar);

        }
    }
    
}