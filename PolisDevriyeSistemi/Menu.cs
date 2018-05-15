
using System;
using System.Collections.Generic;
using System.Text;

namespace PolisDevriyeSistemi
{
    class AnaMenu : IMenu
    {
        public List<ISecenek> Secenekler { get; set; }
        public Vatandas insan;

        public AnaMenu(Vatandas vatandas)
        {
            Secenekler = new List<ISecenek>()
            {
                new KazaIhbarSecenegi(vatandas),
                new YaralamaIhbarSecenegi(vatandas)
            };

            insan = vatandas;
        }

        public void Baslat()
        {
            while (true)
            {
                Console.Clear();
                for (int i = 0; i < Secenekler.Count; i++)
                {
                    Console.WriteLine("{0} -> {1}", i, Secenekler[i].SecenekAdi);
                }

                int tIndex = Arayuz.GetInt("Index: ");

                try
                {
                    Secenekler[tIndex].Yap();
                }
                catch (Exception)
                {
                    Console.WriteLine("boyle bir secenek yok");
                }
            }
        }
    }
}
