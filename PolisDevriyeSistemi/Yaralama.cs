namespace PolisDevriyeSistemi
{
    public class Yaralama : ISikayet
    {
        public Yaralama(IKonum konum)
        {
            Konum = konum;
        }

        public Yaralama(int x, int y)
        {
            Konum = new Konum(x, y);
        }

        public IKonum Konum { get; set; }
    }
}