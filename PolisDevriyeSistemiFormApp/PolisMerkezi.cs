using System;
using System.Collections.Generic;
using System.Threading;

namespace PolisDevriyeSistemiFormApp
{
    internal class PolisMerkezi : Merkez
    {
        static PolisMerkezi uniqueInstance;
        static readonly Object lockObject = new object();
        
        List<IPolis> _polisler;
        public List<IPolis> Polisler => _polisler;

        private PolisMerkezi(int x, int y) : base(x, y)
        {
            _polisler = new List<IPolis>();

            _polisler.Add(new Polis("turkalp burak", "kayrancioglu", new Konum(x, y)));
            _polisler.Add(new Polis("ali", "duzgitmis", new Konum(x, y)));
            _polisler.Add(new Polis("hasan", "duzgidecekmisti", new Konum(x, y)));
            _polisler.Add(new Polis("kemal", "duzgitmeliymis", new Konum(x, y)));
            _polisler.Add(new Polis("salah", "duzgidebilir", new Konum(x, y)));

            AtanamayanOgretmen atanamayanOgretmen = new AtanamayanOgretmen("ismail", "gitmis", new Konum(x, y));
            _polisler.Add(new PolisAdapter(atanamayanOgretmen));
        }

        public static PolisMerkezi GetInstance(int x = 0, int y = 0)
        {
            lock (lockObject)
            {
                if (uniqueInstance == null)
                {
                    uniqueInstance = new PolisMerkezi(x, y);
                }
            }

            return uniqueInstance;
        }

        public void ObserverEkle(IObserver polis)
        {
            _polisler.Add((IPolis)polis);
        }

        public override void HaberVer()
        {
            IPolis musaitPolis = _polisler.Find(m => !m.MesgulMu);

            if (musaitPolis != null && Sikayetler.Count > 0)
            {
                musaitPolis.Guncelle(Sikayetler.Dequeue());
            }
        }

        public override void RaporaEkle(ISikayet sikayet)
        {
            // polis raporuna ekler
            Form1.RaporEkle(string.Format("[{0}] [{1},{2}] sikayeti alindi", sikayet.GetType().Name, sikayet.Konum.X, sikayet.Konum.Y));
        }

    }
}