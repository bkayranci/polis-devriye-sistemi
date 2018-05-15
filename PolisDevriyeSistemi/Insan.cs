using System;
using System.Collections.Generic;
using System.Text;

namespace PolisDevriyeSistemi
{
    public abstract class Insan
    {
        string _ad;
        string _soyad;
        IKonum _konum;
        int _beklemeSuresi;

        public string Ad => _ad;
        public string Soyad => _soyad;
        public IKonum Konum => _konum;
        public int BeklemeSuresi => _beklemeSuresi;

        public Insan(string ad, string soyad, IKonum konum, int beklemeSuresi = 2)
        {
            _ad = ad;
            _soyad = soyad;
            _konum = konum;
            _beklemeSuresi = beklemeSuresi * 1000;
        }
    }
}
