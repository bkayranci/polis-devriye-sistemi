namespace PolisDevriyeSistemiFormApp
{
    public class Yaralama : ISikayet
    {
        public Konum Konum { get; set; }

        public Yaralama(Konum konum)
        {
            this.Konum = konum;
        }

        public Yaralama(int x, int y)
        {
            Konum = new Konum(x, y);
        }
    }
}