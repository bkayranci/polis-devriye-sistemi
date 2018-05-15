using System.Collections.Generic;

namespace PolisDevriyeSistemi
{
    public interface IMenu
    {
        List<ISecenek> Secenekler { get; set; }
        void Baslat();
    }
}