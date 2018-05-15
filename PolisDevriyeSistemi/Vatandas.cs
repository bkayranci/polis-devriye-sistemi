using System;
using System.Collections.Generic;
using System.Text;

namespace PolisDevriyeSistemi
{
    public class Vatandas : Insan
    {
        IMerkez _merkez;

        private IMerkez Merkez => _merkez;

        public Vatandas(string ad, string soyad, IKonum konum):base(ad, soyad, konum)
        {
            _merkez = PolisMerkezi.GetInstance();
        }

        public void SetMerkez(IMerkez merkez)
        {
            _merkez = merkez;
        }

        public void SikayetEt(ISikayet sikayet)
        {
            Console.WriteLine("Sikayet edildi. [{0}]", sikayet.GetType().Name);
            Merkez.SikayetKaydi(sikayet);
        }
    }
}
