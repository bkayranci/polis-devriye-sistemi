using System;
using System.Threading;

namespace PolisDevriyeSistemiFormApp
{
    public class Polis : Insan, IPolis
    {
        public bool MesgulMu { get; set; }

        public Thread olayYerineGit;
        public Thread devriyeGez;

        public Polis(string ad, string soyad, Konum konum) : base(ad, soyad, konum)
        {
            olayYerineGit = new Thread(() => { });
            devriyeGez = new Thread(() => { });
            DevriyeGez();
            Form1.RaporEkle(string.Format("[polis] [eklendi]| {0} {1}", Ad, Soyad));
        }

        // observer metodudur sikayet geldiginde calisir
        public void Guncelle(ISikayet sikayet)
        {
            // polis asenkron olarak gezdigi icin ilk once polisin devriyesini durdurur sonra olay yerine gider
            devriyeGez.Suspend();

            SetOlayYerineGit(sikayet);
            olayYerineGit.Start();

            Form1.RaporEkle(string.Format("[polis] [ihbar alindi] [{0},{1}] -> [{2},{3}] | {4} {5}", Konum.X, Konum.Y, sikayet.Konum.X, sikayet.Konum.Y, Ad, Soyad));
        }

        // asenkron olarak gidilecek konumu ayarlar
        void SetOlayYerineGit(ISikayet sikayet)
        {
            MesgulMu = true;
            olayYerineGit = new Thread(() =>
            {
                Git(sikayet.Konum);
                MesgulMu = false;
                Form1.RaporEkle(string.Format("[{2}] - [{0},{1}] sorun cozuldu", sikayet.Konum.X, sikayet.Konum.Y, sikayet.GetType().Name));
                DevriyeGez();
                PolisMerkezi.GetInstance().HaberVer();
            });
        }

        // asenkron sekilde 0-100 arasinda devriye gezer 
        void DevriyeGez()
        {
            Form1.RaporEkle(string.Format("devriye geziliyor"));
            devriyeGez = new Thread(() =>
            {
                Random rnd = new Random();
                Git(rnd.Next(0, 100), rnd.Next(0, 100));
                DevriyeGez();
            });
            devriyeGez.Start();
        }

        // verilen koordinat ile konuma gider
        public void Git(decimal x, decimal y)
        {
            Git(new Konum(x, y));
        }


        // verilen konuma gider
        public void Git(Konum konum)
        {
            while (!((Konum.X == konum.X) && (Konum.Y == konum.Y)))
            {
                Thread.Sleep(BeklemeSuresi);

                if (Konum.X > konum.X)
                {
                    this.Konum.X--;
                }
                else if (Konum.X < konum.X)
                {
                    this.Konum.X++;
                }
                else
                {

                }

                if (Konum.Y > konum.Y)
                {
                    this.Konum.Y--;
                }
                else if (Konum.Y < konum.Y)
                {
                    this.Konum.Y++;
                }
                else
                {

                }
            }
        }
    }
}