using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolisDevriyeSistemiFormApp
{
    class PolisMerkeziFacade
    {
        PolisMerkezi polisMerkezi = PolisMerkezi.GetInstance();

        // polis merkezi singleton mu degil mi bu tür alt sistemleri dusunmeye ihtiyac kalmiyor.
        public void SikayetEt(ISikayet sikayet)
        {
            polisMerkezi.SikayetKaydi(sikayet);
        }
    }
}
