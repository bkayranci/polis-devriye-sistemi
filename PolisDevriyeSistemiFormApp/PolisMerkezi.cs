using System;
using System.Collections.Generic;
using System.Threading;

namespace PolisDevriyeSistemiFormApp
{
    internal class PolisMerkezi : IMerkez
    {
        static PolisMerkezi uniqueInstance;
        static readonly Object lockObject = new object();
        public Konum Konum;

        List<IPolis> _polisler;
        Queue<ISikayet> _sikayetler;

        public List<IPolis> Polisler => _polisler;
        public Queue<ISikayet> Sikayetler => _sikayetler;

        private PolisMerkezi(int x, int y)
        {
            Konum = new Konum(x, y);
            _polisler = new List<IPolis>();
            _sikayetler = new Queue<ISikayet>();

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

        public void HaberVer()
        {
            IPolis musaitPolis = _polisler.Find(m => !m.MesgulMu);

            if (musaitPolis != null && _sikayetler.Count > 0)
            {
                musaitPolis.Guncelle(_sikayetler.Dequeue());
            }

        }

        public void SikayetKaydi(ISikayet sikayet)
        {
            _sikayetler.Enqueue(sikayet);
            Form1.RaporEkle(string.Format("[{0}] [{1},{2}] sikayeti alindi", sikayet.GetType().Name, sikayet.Konum.X, sikayet.Konum.Y));
            HaberVer();
        }

    }
}