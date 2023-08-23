using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONSTRUCTORS_ZAMAN_ORNEGİ
{
    public class Time
    {
        int _duration; //saniye cinsinden
        string _time;

        public Time(int duration)
        {
            _duration = duration;
        }
        public Time(string time)
        {
            _time = time;
        }

        public string ZamaniHesapla()
        {
            int saat, dakika, saniye, saatsaniye, dakikasaniye;
            saat = _duration / 3600;
            saatsaniye = saat * 3600;
            dakika = (_duration - saatsaniye) / 60;
            if (dakika >= 60)
                dakika = (_duration - saatsaniye) % 60;
            dakikasaniye = dakika * 60;
            saniye = _duration - saatsaniye - dakikasaniye;
            return saat.ToString().PadLeft(2, '0') + ":" + dakika.ToString().PadLeft(2, '0') + ":" + saniye.ToString().PadLeft(2, '0');
        }
        public int SureyiHesapla()
        {
            int saatler = Convert.ToInt32(_time.Split(':')[0]);
            int dakikalar = Convert.ToInt32(_time.Split(':')[1]);
            int saniyeler = Convert.ToInt32(_time.Split(':')[2]);
            return saatler * (int)Math.Pow(60, 2) + dakikalar * 60 + saniyeler;
        }
    }
}








