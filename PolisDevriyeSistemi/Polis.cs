using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace PolisDevriyeSistemi
{
    class Polis : Insan, IPolis
    {
        public bool MesgulMu { get; set; }

        public Polis(string ad, string soyad, IKonum konum) : base(ad, soyad, konum)
        {
        }

        public void Guncelle(ISikayet sikayet)
        {
            Thread thread = new Thread(() => Git(sikayet.Konum));
            // Git(sikayet.Konum);
            thread.Start();
        }

        public void Git(IKonum konum)
        {
            Console.Clear();
            Console.WriteLine("[{0},{1}] gidilecek", konum.X,konum.Y);
            while (!((Konum.X == konum.X) && (Konum.Y == konum.Y)))
            {
                Console.WriteLine("Polis olay yerine gidiyor. [X:{0} Y: {1}]", Konum.X, Konum.Y);
                Thread.Sleep(BeklemeSuresi);

                if (Konum.X > konum.X)
                {
                    Konum.X--;
                }
                else if(Konum.Y < konum.Y)
                {
                    Konum.X++;
                }
                else
                {

                }

                if (Konum.Y > konum.Y)
                {
                    Konum.Y--;
                }
                else if (Konum.Y < konum.Y)
                {
                    Konum.Y++;
                }
                else
                {

                }
            }

            Console.WriteLine("Polis olay yerine geldi ve sorunu cozdu. [X:{0} Y: {1}]", Konum.X, Konum.Y);
        }
    }
}
