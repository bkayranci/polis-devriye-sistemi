using System;
using System.Collections.Generic;
using System.Text;

namespace PolisDevriyeSistemi
{
    public abstract class Secenek : ISecenek
    {
        public string SecenekAdi { get; set; }

        public Vatandas vInsan;

        public Secenek(Vatandas vatandas, string isim = "secenek adi tanimlanmadi")
        {
            SecenekAdi = isim;
            vInsan = vatandas;
        }

        virtual public void Yap()
        {
            Console.WriteLine("bu islem icin yapilacak bir islem tanimlanmadi");
        }
    }
}
