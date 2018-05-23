using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PolisDevriyeSistemiFormApp
{
    public partial class Form1 : Form
    {
        public List<Insan> Vatandaslar = new List<Insan>();
        PolisMerkeziFacade polisMerkeziFacade;

        public Form1()
        {
            InitializeComponent();
            PolislerListeGuncelle();
            VatandaslarListeGuncelle();
            polisMerkeziFacade = new PolisMerkeziFacade();
        }

        private void btnVatandasEkle_Click(object sender, EventArgs e)
        {
            if (tboxVatandasAdi.TextLength < 1 || tboxVatandasSoyadi.TextLength < 1 || vatandasKonumX.Value < 0 || vatandasKonumY.Value < 0)
            {
                MessageBox.Show(null, "tum alanlar dolu ve konum degerleri 0 dan buyuk olmali!", "hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                VatandasEkle(new Vatandas(tboxVatandasAdi.Text, tboxVatandasSoyadi.Text, new Konum(vatandasKonumX.Value, vatandasKonumY.Value)));
            }
        }

        private void VatandasEkle(Vatandas vatandas)
        {
            Vatandaslar.Add(vatandas);
            raporListBox.Items.Add(string.Format("[vatandas] - {0} {1} eklendi", vatandas.Ad, vatandas.Soyad));
            VatandaslarListeGuncelle();
            tboxVatandasAdi.Clear();
            tboxVatandasSoyadi.Clear();
            vatandasKonumX.Value = 0;
            vatandasKonumY.Value = 0;
        }

        private void VatandaslarListeGuncelle()
        {
            vatandaslarListBox.Items.Clear();

            for (int i = 0; i < Vatandaslar.Count; i++)
            {
                vatandaslarListBox.Items.Add(String.Format("[{0}][{1}] | {2} {3}", Vatandaslar[i].Konum.X, Vatandaslar[i].Konum.Y, Vatandaslar[i].Ad, Vatandaslar[i].Soyad));
                vatandaslarListBox.SelectedItem = vatandaslarListBox.Items[i];
            }
        }

        private void btnPolisEkle_Click(object sender, EventArgs e)
        {
            if (tboxPolisAdi.TextLength < 1 || tboxPolisSoyadi.TextLength < 1 || polisKonumX.Value < 0 || polisKonumY.Value < 0)
            {
                MessageBox.Show(null, "tum alanlar dolu ve konum degerleri 0 dan buyuk olmali!", "hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                PolisEkle(new Polis(tboxPolisAdi.Text, tboxPolisSoyadi.Text, new Konum(polisKonumX.Value, polisKonumY.Value)));
            }
        }

        private void PolisEkle(Polis polis)
        {
            PolisMerkezi.GetInstance().Polisler.Add(polis);
            raporListBox.Items.Add(string.Format("[polis] - {0} {1} eklendi", polis.Ad, polis.Soyad));
            PolislerListeGuncelle();
            tboxPolisAdi.Clear();
            tboxPolisSoyadi.Clear();
            polisKonumX.Value = 0;
            polisKonumY.Value = 0;
        }

        private void PolislerListeGuncelle()
        {
            polislerListBox.Items.Clear();

            for (int i = 0; i < PolisMerkezi.GetInstance().Polisler.Count; i++)
            {
                Polis p = (Polis)PolisMerkezi.GetInstance().Polisler[i];
                polislerListBox.Items.Add(String.Format("{4} [{0}][{1}] | {2} {3}", p.Konum.X, p.Konum.Y, p.Ad, p.Soyad, p.MesgulMu));
            }
        }

        private void SikayetKuyruguGuncelle()
        {
            sikayetKuyruguListBox.Items.Clear();

            List<ISikayet> tempSikayetler = PolisMerkezi.GetInstance().Sikayetler.ToList<ISikayet>();

            for (int i = 0; i < tempSikayetler.Count; i++)
            {
                sikayetKuyruguListBox.Items.Add(String.Format("[{0}] [{1}] {2}", tempSikayetler[i].Konum.X, tempSikayetler[i].Konum.Y, tempSikayetler[i].GetType().Name));
            }
        }

        private void btnKazaBildir_Click(object sender, EventArgs e)
        {
            Vatandas seciliVatandas = (Vatandas)Vatandaslar[vatandaslarListBox.SelectedIndex];

            Konum konum = new Konum(0, 0);

            Form kForm = new KonumAl(konum);
            kForm.StartPosition = FormStartPosition.CenterScreen;
            kForm.ShowDialog();

            raporListBox.Items.Add(string.Format("[kaza] - [{0},{1}] | {2} {3} tarafindan eklendi", konum.X, konum.Y, seciliVatandas.Ad, seciliVatandas.Soyad));
            polisMerkeziFacade.SikayetEt(new Kaza(konum));

            SikayetKuyruguGuncelle();
            PolislerListeGuncelle();
        }

        public static void RaporEkle(string rapor)
        {
            raporListBox.Items.Add(rapor);
        }

        private void vatandaslarListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            sikayetlerGroup.Visible = true;
        }

        private void polis_giderken(object sender, EventArgs e)
        {
            PolislerListeGuncelle();
        }

        private void hayat_Tick(object sender, EventArgs e)
        {
            PolislerListeGuncelle();
            SikayetKuyruguGuncelle();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            hayat.Start();
        }

        private void btnYaralamaBildir_Click(object sender, EventArgs e)
        {
            Vatandas seciliVatandas = (Vatandas)Vatandaslar[vatandaslarListBox.SelectedIndex];

            Konum konum = new Konum(0, 0);

            Form kForm = new KonumAl(konum);
            kForm.StartPosition = FormStartPosition.CenterScreen;
            kForm.ShowDialog();

            raporListBox.Items.Add(string.Format("[yaralama] - [{0},{1}] | {2} {3} tarafindan eklendi", konum.X, konum.Y, seciliVatandas.Ad, seciliVatandas.Soyad));
            polisMerkeziFacade.SikayetEt(new Yaralama(konum));

            SikayetKuyruguGuncelle();
            PolislerListeGuncelle();
        }
    }
}
