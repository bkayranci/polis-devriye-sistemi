using System;
using System.Threading;

namespace PolisDevriyeSistemi
{
    public class YaralamaIhbarSecenegi : Secenek
    {
        public YaralamaIhbarSecenegi(Vatandas vatandas, string isim = "yaralama ihbari yap") : base(vatandas, isim)
        {
        }

        public override void Yap()
        {
            Thread sikayet = new Thread(() => { vInsan.SikayetEt(new Yaralama(Arayuz.KonumSor())); });
            sikayet.Start();
        }
    }
}