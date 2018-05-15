namespace PolisDevriyeSistemiFormApp
{
    public class Kaza : ISikayet
    {
        public Konum Konum { get; set; }

        public Kaza(int x, int y)
        {
            Konum = new Konum(x, y);
        }

        public Kaza(Konum konum)
        {
            Konum = new Konum(konum.X, konum.Y);
        }
    }
}