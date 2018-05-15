using System;
using System.Collections.Generic;
using System.Text;

namespace PolisDevriyeSistemi
{
    class KazaIhbarSecenegi : Secenek
    {
        public KazaIhbarSecenegi(Vatandas vatandas, string isim = "kaza ihbari yap") : base(vatandas, isim)
        {
        }

        override public void Yap()
        {
            vInsan.SikayetEt(new Kaza(Arayuz.KonumSor()));
        }
    }
}
