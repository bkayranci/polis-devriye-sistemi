using System.Windows.Forms;

namespace PolisDevriyeSistemiFormApp
{
    public class Konum
    {
        public decimal X { get; set; }
        public decimal Y { get; set; }

        public Konum(decimal x, decimal y)
        {
            X = x;
            Y = y;
        }
    }
}