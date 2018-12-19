
using BirthDayApp_webApiOrnegi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BirthDayApp_webApiOrnegi.Controllers
{
    public class DavetiyeController : ApiController
    {
        //BU METOT BİZE GET İLE WHERE ŞARTINI SAĞLAYAN VERİLERİ GETİRECEKTİR.
        //[HttpGet] // normalde api yapısı id/controller olduğundan hangi metodu alacağını bilmez. Bit buraya httpGet demekle get olarak çağrıldığında bu metot çalısın demiş oluruz
        public IEnumerable<DavetiyeModel> GetKatilanlar() //[HttpGet] kullanılmadan da metodun önünde Get kullanılır
        {
            //burada xml json gibi veri tipleri gidebilir. // view gondermiyoruz
            return Veritabani.Liste.Where(i => i.KatilmaDurumu == true);
         }

        public IEnumerable<DavetiyeModel> GetKatilmayanlar() //bu durumda iki tane get olduğundan WebApiConfig de çağrılam ayaralrına {action} ekledik, action ile çağıracağız
        {
            //burada xml json gibi veri tipleri gidebilir. // view gondermiyoruz
            return Veritabani.Liste.Where(i => i.KatilmaDurumu == false);
        }

        //[HttpPost] // demekle de api post yaptığında buraya gelsin demiş oluruz
        public string Ekle( DavetiyeModel model) //[HttpPost] kullanılmadan da metodun önünde Post kullanılır
        {
            if (ModelState.IsValid) // atribute ile verilen değerler sağlanmış ise
            {
                Veritabani.Add(model);
                return "OK";

            }
            return "ERR";
        }
    }
}
