using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolisDevriyeSistemiFormApp
{
    public class AtanamayanOgretmen : Insan
    {
        public AtanamayanOgretmen(string ad, string soyad, Konum konum, int beklemeSuresi = 2) : base(ad, soyad, konum, beklemeSuresi)
        {
        }
    }
}
