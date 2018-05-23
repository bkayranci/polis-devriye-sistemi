using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolisDevriyeSistemiFormApp
{
    abstract class Merkez : IMerkez
    {
        Queue<ISikayet> _sikayetler;

        public Queue<ISikayet> Sikayetler => _sikayetler;

        public Konum Konum;

        public Merkez(int x, int y)
        {
            Konum = new Konum(x, y);
            _sikayetler = new Queue<ISikayet>();
        }

        public void SikayetKaydi(ISikayet sikayet)
        {
            // sistemin calismasi buna bagli bunun sirasinin degismesi durumunda ornegin, sikayeti eklemeden once haberver cagirilirsa hataya dusecek. bu yuzden template uygulayip bu siranin bozulmamasini sagliyoruz.
            SikayetEkle(sikayet);

            // rapora ekle
            RaporaEkle(sikayet);

            // sikayet alindiginda kesin haber verilecek ama polis merkezi olursa polislere haber verilecek, ambulans merkezi olursa saglikcilara haber verilecek
            HaberVer();
        }

        private void SikayetEkle(ISikayet sikayet)
        {
            _sikayetler.Enqueue(sikayet);
        }

        public abstract void RaporaEkle(ISikayet sikayet);

        public abstract void HaberVer();
    }
}
