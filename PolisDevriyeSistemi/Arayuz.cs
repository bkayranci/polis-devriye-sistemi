using System;
using System.Collections.Generic;
using System.Threading;

namespace PolisDevriyeSistemi
{
    public class Arayuz
    {
        List<Vatandas> vatandaslar;

        public Arayuz()
        {
            vatandaslar = new List<Vatandas>()
            {
                new Vatandas("ayse", "duzgiden", new Konum(5, 5)),
                new Vatandas("fatma", "duzgitmis", new Konum(9, 9)),
                new Vatandas("hayriye", "duzgidecek", new Konum(13, 13))
            };
        }

        public void Baslat()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("===== VATANDASLAR =====");
                for (int i = 0; i < vatandaslar.Count; i++)
                {
                    Console.WriteLine("[{0}] -> {1} {2}", i, vatandaslar[i].Ad, vatandaslar[i].Soyad);
                }

                int tempVatandasIndex = Arayuz.GetInt("Index: ");
                try
                {
                    IMenu anaMenu = new AnaMenu(vatandaslar[tempVatandasIndex]);
                    anaMenu.Baslat();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Console.WriteLine("boyle bi vatandas yok yeniden dene!");
                    Thread.Sleep(2000);
                }
            }
        }

        public static int GetInt(string solKisim = "")
        {
            Console.Write(solKisim);
            ConsoleKeyInfo key = Console.ReadKey();

            switch (key.Key)
            {
                case ConsoleKey.NumPad0:
                    return 0;
                case ConsoleKey.D0:
                    return 0;
                case ConsoleKey.NumPad1:
                    return 1;
                case ConsoleKey.D1:
                    return 1;
                case ConsoleKey.NumPad2:
                    return 2;
                case ConsoleKey.D2:
                    return 2;
                case ConsoleKey.NumPad3:
                    return 3;
                case ConsoleKey.D3:
                    return 3;
                case ConsoleKey.NumPad4:
                    return 4;
                case ConsoleKey.D4:
                    return 4;
                case ConsoleKey.NumPad5:
                    return 5;
                case ConsoleKey.D5:
                    return 5;
                case ConsoleKey.NumPad6:
                    return 6;
                case ConsoleKey.D6:
                    return 6;
                case ConsoleKey.NumPad7:
                    return 7;
                case ConsoleKey.D7:
                    return 7;
                case ConsoleKey.NumPad8:
                    return 8;
                case ConsoleKey.D8:
                    return 8;
                case ConsoleKey.NumPad9:
                    return 9;
                case ConsoleKey.D9:
                    return 9;
                default:
                    Console.WriteLine("integer girmedin");
                    return -1;
            }
        }

        internal static IKonum KonumSor()
        {
            Console.WriteLine("konum girin");
            int tempX = Arayuz.GetInt("X: ");
            int tempY = Arayuz.GetInt("Y: ");

            return new Konum(tempX, tempY);
        }

        public static string GetString(string solKisim)
        {
            Console.Write(solKisim);
            return Console.ReadLine();
        }
    }
}