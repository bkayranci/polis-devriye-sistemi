using System;
using System.Collections.Generic;

namespace PolisDevriyeSistemi
{
    class Program
    {
        static void Main(string[] args)
        {
            PolisMerkezi polisMerkezi = PolisMerkezi.GetInstance();
            Arayuz arayuz = new Arayuz();
            arayuz.Baslat();
        }
    }
}
