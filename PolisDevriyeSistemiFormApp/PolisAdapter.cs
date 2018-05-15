using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PolisDevriyeSistemiFormApp
{
    public class PolisAdapter : Polis
    {
        AtanamayanOgretmen ogretmenPolis;

        public PolisAdapter(AtanamayanOgretmen atanamayanOgretmen) : base(atanamayanOgretmen.Ad, atanamayanOgretmen.Soyad, atanamayanOgretmen.Konum)
        {
            ogretmenPolis = atanamayanOgretmen;
        }
    }
}
