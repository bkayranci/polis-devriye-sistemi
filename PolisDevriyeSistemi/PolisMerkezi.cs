using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace PolisDevriyeSistemi
{
    class PolisMerkezi : IMerkez
    {
        static PolisMerkezi uniqueInstance;
        static readonly Object lockObject = new object();
        int _polisSayisi = 50;
        IKonum Konum;

        List<IPolis> _polisler;
        Queue<ISikayet> _sikayetler;

        private PolisMerkezi(int x, int y)
        {
            Konum = new Konum(x, y);
            _polisler = new List<IPolis>();
            _sikayetler = new Queue<ISikayet>();

            for (int i = 0; i < _polisSayisi; i++)
            {
                _polisler.Add(new Polis("lorem"+i, "ipsum"+i, Konum));
            }
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
                Console.WriteLine("Polis yonlendirildi. [{0} {1}]", ((Insan)musaitPolis).Ad, ((Insan)musaitPolis).Soyad);
                musaitPolis.Guncelle(_sikayetler.Dequeue());
            }
            else
            {
                while (_polisler.Find(m => !m.MesgulMu) == null)
                {
                    Console.WriteLine("Musait polis bekleniyor");
                    Thread.Sleep(1000);
                }
            }
            
        }


        public void SikayetKaydi(ISikayet sikayet)
        {
            _sikayetler.Enqueue(sikayet);
            Console.WriteLine("Sikayet kaydi alindi. [{0}]", sikayet.GetType().Name);
            HaberVer();
        }
    }
}
