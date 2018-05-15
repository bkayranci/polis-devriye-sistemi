namespace PolisDevriyeSistemi
{
    public class Kaza : ISikayet
    {
        public IKonum Konum { get; set; }

        public Kaza(int x, int y)
        {
            Konum = new Konum(x, y);
        }

        public Kaza(IKonum konum)
        {
            Konum = new Konum(konum.X, konum.Y);
        }
    }
}