using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BirthDayApp_webApiOrnegi.Models
{
    public static class Veritabani
    {
        private static Dictionary<string, DavetiyeModel> _liste;

        static Veritabani()
        {
            _liste = new Dictionary<string, DavetiyeModel>();
            _liste.Add("Hasan", new DavetiyeModel
            {
                Ad = "Hasan",
                Eposta = "hasan@gmail.com",
                KatilmaDurumu = true
            });

            _liste.Add("Hakan", new DavetiyeModel
            {
                Ad = "Hakan",
                Eposta = "hakan@gmail.com",
                KatilmaDurumu = true
            });

            _liste.Add("Aycan", new DavetiyeModel
            {
                Ad = "Aycan",
                Eposta = "aycan@gmail.com",
                KatilmaDurumu = false
            });
        }

        public static void Add(DavetiyeModel model)
        {
            string key = model.Ad.ToLower();
            if (_liste.ContainsKey(key))
            {
                _liste[key] = model;
            }
            else
            {
                _liste.Add(key, model);
            }
        }

        public static IEnumerable<DavetiyeModel> Liste
        {
            get { return _liste.Values; }
        }
    }
}