namespace PolisDevriyeSistemi
{
    internal class Konum : IKonum
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Konum(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
}