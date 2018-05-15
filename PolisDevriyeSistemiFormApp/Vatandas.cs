using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PolisDevriyeSistemiFormApp
{
    internal class Vatandas : Insan
    {
        private IMerkez merkez;

        public Vatandas(string tboxVatandasAdi, string tboxVatandasSoyadi, Konum konum) 
            : base (tboxVatandasAdi, tboxVatandasSoyadi, konum) 
        {
            merkez = PolisMerkezi.GetInstance();
        }

        public void SetMerkez(IMerkez tMerkez)
        {
            merkez = tMerkez;
        }

        public void SikayetEt(ISikayet sikayet)
        {
            merkez.SikayetKaydi(sikayet);
        }
    }
}